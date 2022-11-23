using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungBanHang.Web.Models
{
    /// <summary>
    /// thông tin thực thể ShoppingCart Item
    /// </summary>
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public int Amount { get; set; }

        public string ShoppingCartId { get; set; }
    }
}
