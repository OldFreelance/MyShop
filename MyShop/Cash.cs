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
        Random rnd = new Random(Environment.TickCount);

        /// <summary>Всевозможные причины обслуживания кассы</summary>
        public static string[] StateDiscriptions = { "Кончилась бумага", "Аннуляция", "Кассир отошел" };

        /// <summary>Имя кассы</summary>
        public string Name { get; set; }

        /// <summary>Состояние кассы (0 - неактивна, 1 - активна, 2 - инкассация, 3 - обслуживание)</summary>
        public int StateId { get; set; }
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
                    case 3:
                        return StateDiscription;
                    default:
                        return "Неизвестное состояние";
                }
            }
        }

        /// <summary>Описание состояние обслуживания</summary>
        public string StateDiscription;

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

        /// <summary>Время начала обслуживания</summary>
        public DateTime MaintenanceTime;
        /// <summary>Продолжительность обслуживания</summary>
        public TimeSpan MaintenanceLength;

        /// <summary>Покупатели на кассе</summary>
        public List<Byer> Byers;

        public Cash(Shop shop)
        {
            Shop = shop;
            StateId = 0;
            Byers=new List<Byer>();
            CurrentByer = null;
        }

        /// <summary>Для удобного просмотра касс в окне отладчика</summary>
        /// <returns>Строка состояния кассы</returns>
        public override string ToString()
        {
            return string.Format("{0} ({1}, {2} покупателей, выручка {3})", Name, StateName, QueryLength, Receipts);
            //return Name + " ("+StateName+", "+QueryLength +" покупателей, выручка "+Receipts+")";
        }

        /// <summary>
        /// Основной метод релизации логики работы кассы
        /// </summary>
        public void Update()
        {
            //Обслуживание покупателей
            Handling();

            //Поиск необслуженных покупателей
            FindUnservicedByers();

            //Обслуживание
            Maintenance();

            //Если выручка на кассе больше чем 10000
            if(/*StateId==1 &&*/ Receipts>=10000)
            {
                //Если на инкассации стоит меньше 2х касс
                if (Shop.Cashs.Where(s => s.StateId == 2).Count(s=>true) < 2)
                {
                    //Инкассация
                    Encashment();
                }
                else
                {
                    //Если сумма на кассе превышает 15000
                    if (Receipts > 15000)
                    {
                        //Закрываем кассу
                        StateId = 0;
                        DistributeByers();
                    }
                    //Иначе касса работает дальше
                }
            }

            //Если прошло время необходимое на инкассацию
            if (StateId == 2 && EncashmentTime + EncashmenLength <= Shop.Time)
            {
                //Если инкассация закончилась днем 
                if (Shop.Time.Hour >= 8 && Shop.Time.Hour < 22)
                    StateId = 1;//то открываем кассу
                else
                    StateId = 0;//иначе закрываем кассу

                //Перенос денег из кассы в магазин
                Shop.Receipts += Receipts;
                Receipts = 0;
            }
        }

        /// <summary>
        /// Установка и снятие кассы с обслуживания
        /// </summary>
        private void Maintenance()
        {
            //Random rnd = new Random(Environment.TickCount);

            switch(StateId)
            {
                case 1:
                    //Примерно одна поломка в час
                    if (rnd.Next(3600) == 1)
                    {
                        StateDiscription = StateDiscriptions[rnd.Next(StateDiscriptions.Length)];
                        StateId = 3;
                        //DistributeByers();
                        MaintenanceTime = Shop.Time;
                        MaintenanceLength = new TimeSpan(0, rnd.Next(5), 0);
                    }
                    break;
                case 3:
                    if(MaintenanceTime+MaintenanceLength<=Shop.Time)
                    {
                        StateId = 1;
                    }
                    break;
            }

        }

        /// <summary>
        /// Обслуживание покупателей
        /// </summary>
        private void Handling()
        {
            //Если обслуживать некого, то возврат из функции
            if (Byers.Count == 0 || StateId != 1)
                return;

            //Если никто не обслуживается
            if(CurrentByer==null)
            {
                //Поиск покупателя в очереди прибывшего раньше всего
                Byer firstByer = Byers.FirstOrDefault(b => b.TimeArrived == Byers.Min(s => s.TimeArrived));
                CurrentByer = firstByer;
                HandlingStartTime = Shop.Time;
            }
            else
            {
                //Если прошло время, необходимое на обслуживание покупателя
                if (HandlingStartTime + CurrentByer.HandlingTime <= Shop.Time)
                {
                    //Удаляем его из очереди
                    Byers.Remove(CurrentByer);

                    //Выручку в кассу
                    Receipts += CurrentByer.Money;

                    //Обслуживание нового покупателя
                    Byer firstByer = Byers.FirstOrDefault(b => b.TimeArrived == Byers.Min(s => s.TimeArrived));
                    CurrentByer = firstByer;
                    HandlingStartTime = Shop.Time;
                }
            }
        }

        /// <summary>
        /// Поиск необслуженных покупателей
        /// </summary>
        private void FindUnservicedByers()
        {
            for (int i = Byers.Count - 1; i >= 0; i--)
            {
                Byer byer = Byers[i];
                //Если покупатель не может больше ждать
                if (byer.TimeArrived + byer.PatienceTime <= Shop.Time)
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
        public void Encashment()
        {
            //Random rnd = new Random(Environment.TickCount);

            StateId = 2;
            EncashmentTime = Shop.Time;
            EncashmenLength = new TimeSpan(0, rnd.Next(10, 20), 0);

            //Покупатели в очереди распределяются по другим кассам
            if(QueryLength!=0)
                DistributeByers();
        }

        /// <summary>
        /// Распределить покупателей по другим очередям
        /// </summary>
        public void DistributeByers()
        {
            //Если нет открытых касс
            if (Shop.ActiveCashs.Count == 0)
            {
                //Создание новой и перевод всей очереди туда
                Cash cash = Shop.Cashs.FirstOrDefault(s => s.StateId == 0 && s.Receipts < 10000);
                //Если нет кассы которую можно открыть
                if (cash == null)
                    //Выгоняем покупателей
                    KickAwayByers();
                else
                {
                    //Открываем кассу
                    cash.StateId = 1;
                    //Переводим туда очередь
                    cash.Byers.AddRange(Byers);
                    Byers.Clear();
                }
            }
            else
            {
                int cashIndex = 0;
                //List<Cash> activeCashs = Shop.Cashs.Where(s => s.StateId == 1).ToList();
                for (int byerIndex = Byers.Count - 1; byerIndex >= 0; byerIndex--)
                {
                    Byer byer = Byers[byerIndex];
                    Byers.Remove(byer);
                    Shop.ActiveCashs[cashIndex].Byers.Add(byer);
                    cashIndex++;
                    if (cashIndex >= Shop.ActiveCashs.Count)
                        cashIndex = 0;
                }
            }
        }

        /// <summary>
        /// Прогнать всех покупателей
        /// </summary>
        public void KickAwayByers()
        {
            Shop.UnservicedByersCount += QueryLength;
            Byers.Clear();
        }
    }
}
