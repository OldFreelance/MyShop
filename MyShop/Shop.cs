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

        /// <summary>
        /// Инициализация магазина
        /// </summary>
        public Shop()
        {
            DateTime now = DateTime.Now;
            TimeStep = 1;
            Time = new DateTime(now.Year, now.Month, now.Day, 8, 0, 0);
            Receipts = 0;
            Cashs = new List<Cash>();
            for(int i=0;i<4;i++)
                Cashs.Add(new Cash());
        }

        /// <summary>
        /// Основной метод релизации логики работы магазина, вызывается раз в 1 секунду
        /// </summary>
        public void Update()
        {
            foreach (var cash in Cashs)
            {
                cash.Update();
            }

            Time = Time.AddSeconds(TimeStep);
        }
    }
}
