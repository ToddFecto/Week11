using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment8_FOC_Potluck_MySql.Models
{
    public class TeamMemberDishes
    {
        public TeamMember tm { get; set; }
        public List<Dish> dishes { get; set; }
    }
}
