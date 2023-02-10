using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Lab_StackOverflow.Models
{
    public class EditQuestionAnswer
    {
        public Question ques { get; set; }
        public Answer answ { get; set; }
    }
}
