using System;
using System.ComponentModel.DataAnnotations;

namespace versta.Models
{
    /// <summary>
    /// Модель заказа для отображения на странице
    /// </summary>
    public class OrderViewModel
    {
        /// <summary>
        /// Город отправителя
        /// </summary>
        [Required(ErrorMessage = "Укажите город отправителя")]
        [Display(Name = "Город отправителя")]
        public string SenderCity { get; set; }

        /// <summary>
        /// Адрес отправителя
        /// </summary>
        [Required(ErrorMessage = "Укажите адрес отправителя")]
        [Display(Name = "Адрес отправителя")]
        public string SenderAddress { get; set; }

        /// <summary>
        /// Город получателя
        /// </summary>
        [Required(ErrorMessage = "Укажите город получателя")]
        [Display(Name = "Город получателя")]
        public string RecipientCity { get; set; }

        /// <summary>
        /// Адрес получателя
        /// </summary>
        [Required(ErrorMessage = "Укажите адрес получателя")]
        [Display(Name = "Адрес получателя")]
        public string RecipientAddress { get; set; }

        /// <summary>
        /// Вес заказа
        /// </summary>
        [Required(ErrorMessage = "Укажите вес заказа")]
        [Display(Name = "Вес заказа(г)")]
        [Range(0, 100000, ErrorMessage = "Не верно указан вес груза")]
        public double Weight { get; set; }

        /// <summary>
        /// Дата забора заказа
        /// </summary>
        [Required(ErrorMessage = "Укажите дату забора заказа")]
        [Display(Name = "Дата забора заказа")]
        public DateTime Date { get; set; }
    }
}
