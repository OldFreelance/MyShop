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
        public int HandlingTimeFrom=30;
        /// <summary>Верхняя граница времени обслуживания покупателя</summary>
        public int HandlingTimeTo=90;
        /// <summary>Нижняя граница времени ожидания покупателя</summary>
        public int PatienceTimeFrom=300;
        /// <summary>Верхняя граница времени ожидания покупателя</summary>
        public int PatienceTimeTo=600;
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
                Cashs.Add(new Cash {StateId = i > 3 ? 0 : 1, Shop = this});
        }

        /// <summary>
        /// Основной метод релизации логики работы магазина, вызывается раз в 1 секунду
        /// </summary>
        public void Update()
        {
            GenerateByers();

            //Если во всех работающих кассах длина очереди больше 10 человек
            if(Cashs.Where(s=>s.StateId==1).Min(s=>s.QueryLength)==10)
            {
                //Активируем новую кассу
                Cash cash = Cashs.FirstOrDefault(s => s.StateId == 0);
                if (cash != null)
                    cash.StateId = 1;
            }

            //Логика работы касс
            foreach (var cash in Cashs)
            {
                cash.Update(Time);
            }

            //Увеличиваем время
            Time = Time.AddSeconds(1);
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
            else if (Time.Hour >= 12 && Time.Hour < 18)
                intensity = ByersInDay;
            else if (Time.Hour >= 6 && Time.Hour < 23)
                intensity = ByersInEvening;

            //Есди день скидок, то генерируем покупателей не раз в 60 сек, а раз в 40 (40=60/1.5)
            int timeInterval = DiscountDay ? 40 : 60;

            if (rnd.Next(timeInterval) < intensity)
            {
                List<Cash> activeCashs = Cashs.Where(s => s.StateId == 1).ToList();

                //Находим работающую кассу с минимальной очередью
                Cash cash = activeCashs.FirstOrDefault(c => c.QueryLength == activeCashs.Min(s => s.QueryLength));
                cash.Byers.Add(new Byer(this));
            }
        }
    }
}
