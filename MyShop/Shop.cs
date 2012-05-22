using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyShop
{
    /// <summary>
    /// Класс магазин
    /// </summary>
    public class Shop
    {
        /// <summary>Текущее время</summary>
        public DateTime Time;

        /// <summary>Выручка магазина</summary>
        public decimal Receipts;

        /// <summary>Кассы в магазине</summary>
        public List<Cash> Cashs;
        /// <summary>Активные кассы</summary>
        public List<Cash> ActiveCashs { get { return Cashs.Where(s => s.StateId == 1).ToList(); } }

        /// <summary>Количество необслуженных покупателей</summary>
        public int UnservicedByersCount;

        #region Настройки программы
        /// <summary>Коеффициент с которым меняется время работы магазина по отношению к реальному времени</summary>
        public int TimeStep;
        /// <summary>День скидок</summary>
        public bool DiscountDay;

        /// <summary>Интенсивность прихода покупателей утром </summary>
        public int ByersInMorning=3;
        /// <summary>Интенсивность прихода покупателей днем </summary>
        public int ByersInDay=5;
        /// <summary>Интенсивность прихода покупателей вечером </summary>
        public int ByersInEvening=3;

        /// <summary>Нижняя граница времени обслуживания покупателя</summary>
        public int HandlingTimeFrom=60;
        /// <summary>Верхняя граница времени обслуживания покупателя</summary>
        public int HandlingTimeTo=120;
        /// <summary>Нижняя граница времени ожидания покупателя</summary>
        public int PatienceTimeFrom=300;
        /// <summary>Верхняя граница времени ожидания покупателя</summary>
        public int PatienceTimeTo=600;

        /// <summary>Нижняя граница выручки от покупателя</summary>
        public int ByerReceiptsFrom=1;
        /// <summary>Верхняя граница выручки от покупателя</summary>
        public int ByerReceiptsTo = 100;

        /// <summary>Минимальное число покупателей в очереди, после которого касса закрывается</summary>
        public int MinQueryLength = 3;
        /// <summary>Максимальное число покупателей в очереди, после которого открывается новая касса</summary>
        public int MaxQueryLength = 10;
        #endregion

        /// <summary>
        /// Инициализация магазина
        /// </summary>
        public Shop()
        {
            DateTime now = DateTime.Now;
            TimeStep = 1;
            Time = new DateTime(now.Year, now.Month, now.Day, 8, 0, 0);
            Receipts = 0;
            DiscountDay = false;
            UnservicedByersCount = 0;
            Cashs = new List<Cash>();
            for (int i = 0; i < 10; i++)
                Cashs.Add(new Cash {StateId = 0, Shop = this});
        }

        /// <summary>
        /// Основной метод релизации логики работы магазина, вызывается раз в 1 секунду
        /// </summary>
        public void Update()
        {
            //Создание новых покупателей
            GenerateByers();

            //Открытие новых касс по необходимости
            OpenNewCash();

            //Закрытие малоиспользующихсф касс касс по необходимости
            CloseUnisedCash();

            //Логика работы касс
            foreach (var cash in Cashs)
            {
                cash.Update();
            }

            //Увеличиваем время
            Time = Time.AddSeconds(1);
        }

        /// <summary>
        /// Открытие по необходимости новых касс
        /// </summary>
        private void OpenNewCash()
        {
            //Если во всех работающих кассах длина очереди больше MaxQueryLength человек
            if(ActiveCashs.Count!=0)
            {
                if (ActiveCashs.Min(s => s.QueryLength) >= MaxQueryLength)
                {
                    //Активируем новую кассу
                    Cash cash = Cashs.FirstOrDefault(s => s.StateId == 0);
                    if (cash != null)
                        cash.StateId = 1;
                }
            }
            else
            {
                //Если произошло открытие магазина
                if(Time.Hour==8 && Time.Minute==0)
                {
                    //Активируем новую кассу
                    Cash cash = Cashs.FirstOrDefault(s => s.StateId == 0);
                    if (cash != null)
                        cash.StateId = 1;
                }
            }
        }

        /// <summary>
        /// Закрытие по необходимости новых касс
        /// </summary>
        private void CloseUnisedCash()
        {
            //Если открыто более одной кассы
            if (ActiveCashs.Count > 1)
            {
                //И на всех открытых кассах длина очереди меньше или равна MinQueryLength
                if (ActiveCashs.Max(s => s.QueryLength) <= MinQueryLength)
                {
                    //Нахождение и закрытие последней кассы с минимальной длиной очереди
                    Cash cash = ActiveCashs.LastOrDefault(s => s.QueryLength <= MinQueryLength);
                    cash.StateId = 0;
                    cash.DistributeByers();
                }
            }
        }

        /// <summary>
        /// Создание дополнительных покупателей
        /// </summary>
        private void GenerateByers()
        {
            Random rnd = new Random();
            int intensity=0;

            //Определение интенсивности по времени дня
            if (Time.Hour >= 8 && Time.Hour < 12)
                intensity = ByersInMorning;
            else if (Time.Hour >= 12 && Time.Hour < 17)
                intensity = ByersInDay;
            else if (Time.Hour >= 17 && Time.Hour < 22)
                intensity = ByersInEvening;

            //Если магазин закрывается (22:00)
            if(Time.Hour==22 && Time.Minute==0)
            {
                //Инкассация на всех кассах
                foreach (Cash cash in Cashs.Where(s=>s.Receipts!=0))
                {
                    cash.KickAwayByers();
                    cash.Encashment();
                }
            }

            //Есди день скидок, то генерируем покупателей не раз в 60 сек, а раз в 40 (40=60/1.5)
            int timeInterval = DiscountDay ? 40 : 60;

            if (rnd.Next(timeInterval) < intensity)
            {
                //Находим работающую кассу с минимальной очередью
                Cash cash = ActiveCashs.FirstOrDefault(c => c.QueryLength == ActiveCashs.Min(s => s.QueryLength));
                if (cash == null)
                    //Нет работающей кассы для покупателя. Он уходит необслуженным.
                    UnservicedByersCount++;
                else
                    //Покупатель становится в очередь в кассу
                    cash.Byers.Add(new Byer(this));
            }
        }
    }
}
