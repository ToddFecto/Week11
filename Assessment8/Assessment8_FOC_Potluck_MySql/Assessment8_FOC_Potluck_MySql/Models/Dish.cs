using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Assessment8_FOC_Potluck_MySql.Models
{
    [Table("Dish")]
    public class Dish
    {
        [Key]
        public int id { get; set; }
        public string TMName { get; set; }
        public string PhoneNumber { get; set; }
        public string DishName { get; set; }
        public string DishDescription { get; set; }
        public string Category { get; set; }
    }
}
