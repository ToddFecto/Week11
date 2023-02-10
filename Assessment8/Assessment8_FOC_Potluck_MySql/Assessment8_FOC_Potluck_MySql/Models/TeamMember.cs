using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Assessment8_FOC_Potluck_MySql.Models
{
    [Table("TeamMember")]
    public class TeamMember
    {
        [Key]
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string AttendanceDate { get; set; }
        public string GuestName { get; set; }
    }
}
