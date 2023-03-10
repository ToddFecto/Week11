using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace DepInjDemo.Models
{
    [Table("category")]
    public class Category
    {
        [Key]
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string username { get; set; }

        public override string ToString()
        {
            return $"{id} {name} {description} {username}";
        }
    }
}
