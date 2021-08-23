using System.Collections.Generic;

namespace versta.Models
{
    /// <summary>
    /// Общая модель для отображения основной страницы
    /// </summary>
    public class IndexViewModel
    {
        /// <summary>
        /// Список всех заказов
        /// </summary>
        public IEnumerable<Order> Orders { get; set; }

        /// <summary>
        /// Информация о странице
        /// </summary>
        public PageInfo PageInfo { get; set; }
    }
}
