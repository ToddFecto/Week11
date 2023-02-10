using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Lab_StackOverflow.Models
{
    public class DAL
    {
        public static string CurrentUser = null;

        // Database connection
        public static MySqlConnection DB = new MySqlConnection("Server=localhost;Database=stackoverflow;Uid=root;Password=abc123");

        // question Table

        // "R" Read all, read one
        public static List<Question> GetAllQuestions()
        {
            return DB.GetAll<Question>().ToList();
        }

        public static Question GetQuestion(int id)
        {
            return DB.Get<Question>(id);
        }


        // "C" Create (Insert) into question table

        public static void InsertQuestion(Question ques)
        {
            ques.username = DAL.CurrentUser;
            DB.Insert(ques);
        }

        // "U" Update in question table
        // Do we even need this one? Yeah probably
        public static void UpdateQuestion(Question ques)
        {
            // 
            // Question { id = "COFF", description = "New decription" }
            //
            //
            ques.username = DAL.CurrentUser;
            DB.Update(ques);
        }

        // "D" Delete from question table
        public static void DeleteQuestion(int id)
        {
            Question ques = new Question() { id = id };
            DB.Delete(ques);
        }

        // answer Table

        // "R" Read all, read one
        public static QuestionAnswers GetAllAnswers(int theQuesId)
        {
            // We're going to build an SQL query that looks like this:
            // select * from product where categoryId = 'COFF' (for example)
            // Need a key - value pair of some name, we'll say catId
            // and its value will be the category such as COFF.
            //      e.g.  catId = "COFF"
            // Then we'll let dapper build our query SQL for us,
            // replacing our key with the value e.g.:
            //      select * from product where categoryId = @catId
            // And what will happen is the @catId will get replaced with COFF

            // Let's make our "key value pair list" first. We'll use
            // an anonymous object.

            var keyvalues = new { quesId = theQuesId };
            string sql = "select * from answer where questionId = @quesId";   // Code in another language, stored in a string!
            // Dapper will replace @catId with the value in our keyvalues object
            // e.g.     select * from product where categoryId = 'COFF'
            // it will handle the single quotes for us so we don't have to.
            // We hand over to dapper our starter SQL string and or keyvalue list.

            QuestionAnswers qa = new QuestionAnswers();
            qa.answs = DB.Query<Answer>(sql, keyvalues).ToList();
            qa.ques = DAL.GetQuestion(theQuesId);
            return qa;
        }

        public static EditQuestionAnswer GetAnswer(int theAnswId)
        {
            var keyvalues = new { answId = theAnswId };
            string sql = "select * from answer where questionId = @answId";
            EditQuestionAnswer Edqa = new EditQuestionAnswer();
            Edqa.answ = (Answer)DB.Query<Answer>(sql, keyvalues);
            Edqa.ques = DAL.GetQuestion(theAnswId);
            return Edqa;
            //return DB.Get<Answer>(id);
        }


        // "C" Create (Insert) into answer table

        public static void InsertAnswer(Answer answ)
        {
            answ.username = DAL.CurrentUser;
            DB.Insert(answ);
        }

        // "U" Update in answer table
        // Do we even need this one? Yeah probably
        public static void UpdateAnswer(Answer answ)
        {
            // 
            // Answer { id = "COFF", description = "New decription" }
            //
            //
            answ.username = DAL.CurrentUser;
            DB.Update(answ);
        }

        // "D" Delete from answer table
        public static void DeleteAnswer(int id)
        {
            var myparams = new { id = id };
            Answer answ = new Answer() { id = id };
            DB.Delete(answ);
        }
    }
}
