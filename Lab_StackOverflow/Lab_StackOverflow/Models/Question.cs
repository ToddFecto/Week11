﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Lab_StackOverflow.Models
{
    [Table("question")]
    public class Question
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string title { get; set; }
        public string detail { get; set; }
        public DateTime posted { get; set; }
        public string category { get; set; }
        public string tags { get; set; }
        public int status { get; set; }
    }
}
