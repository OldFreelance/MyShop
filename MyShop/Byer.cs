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


        public Byer(DateTime time)
        {
            Random rnd = new Random();

            TimeArrived = time;
            HandlingTime = new TimeSpan(0, 0, rnd.Next(30)+30);
            PatienceTime = new TimeSpan(0, rnd.Next(5) + 1, 0);
            Money = rnd.Next(100);
        }
    }
}
