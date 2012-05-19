using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MyShop
{
    /// <summary>
    /// Класс касса
    /// </summary>
    public class Cash
    {
        [DisplayName("Активна")]
        public bool IsActive { get; set; }
        [DisplayName("Длина очереди")]
        public int QueryLength { get { return Byers.Count; } }
        /// <summary>Выручка кассы</summary>
        [DisplayName("Выручка кассы")]
        public decimal Receipts { get; set; }

        /// <summary>
        /// Покупатели на кассе
        /// </summary>
        public List<Byer> Byers;

        public Cash()
        {
            Byers=new List<Byer>();
        }

        /// <summary>
        /// Основной метод релизации логики работы кассы
        /// </summary>
        public void Update()
        {

        }
    }
}
