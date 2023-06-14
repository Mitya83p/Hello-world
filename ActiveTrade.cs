using System;

namespace PrismaBoy
{
    enum Direction
    {
        Buy,
        Sell
    }

    [Serializable]

    class ActiveTrade
    {
        public long ProfitOrderTransactionId { get; set; }
        public long ProfitOrderId { get; set; }

        public long StopLossOrderTransactionId { get; set; }
        public long StopLossOrderId { get; set; }

        public bool IsStopOrderPlaced;


        public long Id;
        public string Security;
        public Direction Direction;
        public decimal Price;
        public decimal Volume;
        public DateTime Time;
        public decimal StopPrice;

        /// <summary>
        /// Имя заявки которая привела к трейду
        /// </summary>
        public string OrderName;

        /// <summary>
        /// Конструктор класса ActiveTrade
        /// </summary>
        public ActiveTrade(long id, string security, Direction direction, decimal price, decimal volume, DateTime time, decimal stopPrice, string orderName)
        {
            Id = id;
            Security = security;
            Direction = direction;
            Price = price;
            Volume = volume;
            Time = time;
            IsStopOrderPlaced = false;
            StopPrice = stopPrice;
            OrderName = orderName;
        }
    }
}
