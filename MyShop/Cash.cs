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
        /// <summary>Состояние кассы (неактивна, активна, инкассация)</summary>
        public int StateId;
        public string StateName
        {
            get
            {
                switch(StateId)
                {
                    case 0:
                        return "Не работает";
                    case 1:
                        return "Работает";
                    case 2:
                        return "Инкассация";
                    default:
                        return "Неизвестное состояние";
                }
            }
        }

        /// <summary>Длина очереди</summary>
        public int QueryLength { get { return Byers.Count; } }

        /// <summary>Выручка кассы</summary>
        public decimal Receipts { get; set; }

        /// <summary>Магазин, которому пренадлежит касса</summary>
        public Shop Shop;

        /// <summary>Покупатель, обслуживающийся в данный момент</summary>
        public Byer CurrentByer;

        /// <summary>Время в которое произошла инкассация</summary>
        public DateTime EncashmentTime;
        /// <summary>продолжительность инкассацииинкассация</summary>
        public TimeSpan EncashmenLength;

        /// <summary>Время начала обслуживания очередного покупателя</summary>
        public DateTime HandlingStartTime;

        /// <summary>Покупатели на кассе</summary>
        public List<Byer> Byers;

        public Cash()
        {
            Byers=new List<Byer>();
            CurrentByer = null;
        }

        /// <summary>
        /// Основной метод релизации логики работы кассы
        /// </summary>
        public void Update(DateTime time)
        {
            //Обслуживание покупателей
            Handling(time);

            //Поиск необслуженных покупателей
            FindUnservicedByers(time);

            //Если выручка на кассе больше чем 10000
            if(StateId==1 && Receipts>=10000)
            {
                //Инкассация
                Encashment(time);
            }

            //Если прошло время необходимое на инкассацию
            if(StateId == 2 && EncashmentTime+EncashmenLength <=time)
            {
                StateId = 1;
                //Перенос денег из кассы в магазин
                Shop.Receipts += Receipts;
                Receipts = 0;
            }
        }

        /// <summary>
        /// Обслуживание покупателей
        /// </summary>
        /// <param name="time">Текущее время</param>
        private void Handling(DateTime time)
        {
            //Если обслуживать некого, то возврат из функции
            if (Byers.Count == 0)
                return;

            //Если никто не обслуживается
            if(CurrentByer==null)
            {
                //Поиск покупателя в очереди прибывшего раньше всего
                Byer firstByer = Byers.FirstOrDefault(b => b.TimeArrived == Byers.Min(s => s.TimeArrived));
                CurrentByer = firstByer;
                HandlingStartTime = time;
            }
            else
            {
                //Если прошло время, необходимое на обслуживание покупателя
                if (HandlingStartTime + CurrentByer.HandlingTime <= time)
                {
                    //Удаляем его из очереди
                    Byers.Remove(CurrentByer);

                    //Выручку в кассу
                    Receipts += CurrentByer.Money;

                    //Обслуживание нового покупателя
                    Byer firstByer = Byers.FirstOrDefault(b => b.TimeArrived == Byers.Min(s => s.TimeArrived));
                    CurrentByer = firstByer;
                    HandlingStartTime = time;
                }
            }
        }

        /// <summary>
        /// Поиск необслуженных покупателей
        /// </summary>
        /// <param name="time">Текущее время<</param>
        private void FindUnservicedByers(DateTime time)
        {
            for (int i = Byers.Count - 1; i >= 0; i--)
            {
                Byer byer = Byers[i];
                //Если покупатель не может больше ждать
                if (byer.TimeArrived + byer.PatienceTime <= time)
                {
                    //Он ухождит из магазина
                    Byers.Remove(byer);
                    Shop.UnservicedByersCount++;
                }
            }
        }

        /// <summary>
        /// Инкассация
        /// </summary>
        /// <param name="time">Текущее время</param>
        private void Encashment(DateTime time)
        {
            Random rnd = new Random();

            StateId = 2;
            EncashmentTime = time;
            EncashmenLength = new TimeSpan(0, rnd.Next(10, 20), 0);

            //Покупатели в очереди распределяются по другим кассам
            int cashIndex = 0;
            List<Cash> activeCashs = Shop.Cashs.Where(s => s.StateId == 1).ToList();
            for (int byerIndex = Byers.Count - 1; byerIndex >= 0; byerIndex--)
            {
                Byer byer = Byers[byerIndex];
                Byers.Remove(byer);
                activeCashs[cashIndex].Byers.Add(byer);
                cashIndex++;
                if (cashIndex >= activeCashs.Count)
                    cashIndex = 0;
            }
        }
    }
}
