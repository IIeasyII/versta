using System;

namespace versta.Models
{
    /// <summary>
    /// Модель заказа
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Идентификатор заказа
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Город отправителя
        /// </summary>
        public string SenderCity { get; set; }

        /// <summary>
        /// Адрес отправителя
        /// </summary>
        public string SenderAddress { get; set; }

        /// <summary>
        /// Город получателя
        /// </summary>
        public string RecipientCity { get; set; }

        /// <summary>
        /// Адресс получателя
        /// </summary>
        public string RecipientAddress { get; set; }

        /// <summary>
        /// Вес заказа
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Дата забора заказа
        /// </summary>
        public DateTime Date { get; set; }

        #region Инициализация
        public Order()
        {
            Id = Guid.NewGuid().ToString();
        }
        #endregion
    }
}
