using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyShop
{
    /// <summary>
    /// Класс покупателя
    /// </summary>
    public class Byer
    {
        /// <summary>Время в которое покупатель прибыл в магазин</summary>
        public DateTime TimeArrived;
        /// <summary>Время необходимое на обслуживание покупателя</summary>
        public TimeSpan HandlingTime;
        /// <summary>Время которое покупатель готов стоять в очереди</summary>
        public TimeSpan PatienceTime;
        /// <summary>Сумма вырученная на кассе после обслуживания покупателя</summary>
        public decimal Money;

        public Byer(Shop shop)
        {
            Random rnd = new Random(Environment.TickCount);
            
            TimeArrived = shop.Time;
            HandlingTime = new TimeSpan(0, 0, rnd.Next(shop.HandlingTimeFrom, shop.HandlingTimeTo));
            PatienceTime = new TimeSpan(0, 0, rnd.Next(shop.PatienceTimeFrom, shop.PatienceTimeTo));
            Money = rnd.Next(shop.ByerReceiptsFrom, shop.ByerReceiptsTo);
        }
    }
}
