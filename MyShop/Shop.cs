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
        /// <summary>
        /// Текущее время
        /// </summary>
        public DateTime Time;

        /// <summary>
        /// Коеффициент с которым меняется время работы магазина по отношению к реальному времени
        /// </summary>
        public int TimeStep;

        /// <summary>
        /// Вырука магазина
        /// </summary>
        public decimal Receipts;

        /// <summary>
        /// Кассы в магазине
        /// </summary>
        public List<Cash> Cashs;

        /// <summary>Интенсивность прихода покупателей утром </summary>
        public int ByersInMorning;
        /// <summary>Интенсивность прихода покупателей днем </summary>
        public int ByersInDay;
        /// <summary>Интенсивность прихода покупателей вечером </summary>
        public int ByersInEvening;

        /// <summary>Количество необслуженных покупателей</summary>
        public int UnservicedByersCount;

        /// <summary>
        /// Инициализация магазина
        /// </summary>
        public Shop()
        {
            DateTime now = DateTime.Now;
            TimeStep = 1;
            Time = new DateTime(now.Year, now.Month, now.Day, 8, 0, 0);
            Receipts = 0;
            ByersInMorning = 2;
            ByersInDay = 5;
            ByersInEvening = 2;
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
            Random rnd = new Random();

            //Создание дополнительных покупателей
            int intensity=0;

            if (Time.Hour >= 8 && Time.Hour < 12)
                intensity = ByersInMorning;
            else if (Time.Hour >= 12 && Time.Hour < 18)
                intensity = ByersInDay;
            else if (Time.Hour >= 6 && Time.Hour < 23)
                intensity = ByersInEvening;

            if(rnd.Next(60)<intensity)
            {
                //Находим работающую кассу с минимальной очередью
                Cash cash = Cashs.FirstOrDefault(c => c.QueryLength == Cashs.Where(s => s.StateId == 1).Min(s => s.QueryLength) && c.StateId == 1);
                cash.Byers.Add(new Byer(Time));
            }

            foreach (var cash in Cashs)
            {
                cash.Update(Time);
            }

            Time = Time.AddSeconds(TimeStep);
            
        }
    }
}
