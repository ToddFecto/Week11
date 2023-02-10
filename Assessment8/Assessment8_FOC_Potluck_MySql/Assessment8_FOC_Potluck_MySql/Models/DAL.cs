using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;
using MySql.Data.MySqlClient;

namespace Assessment8_FOC_Potluck_MySql.Models
{
    public class DAL
    {
        // Database connection
        public static MySqlConnection DB;

        // TeamMember/RSVP Table

        // "R" Read all, read one
        public static List<TeamMember> GetAllTeamMembers()
        {
            return DB.GetAll<TeamMember>().ToList();
        }

        public static TeamMember GetTeammember(int id)
        {
            return DB.Get<TeamMember>(id);
        }

        // "C" Create (Insert) into TeamMember table

        public static void InsertTeammember(TeamMember tm)
        {
            DB.Insert(tm);
        }

        // "U" Update in TeamMember Table 
        public static void UpdateTeammember(TeamMember tm)
        {
            DB.Update(tm);
        }

        // DELETE TM Form (RSVP - CRUD "D")
        public static void DeleteTM(int id)
        {
            TeamMember tm = new TeamMember() { id = id };
            DB.Delete(tm);
        }

        // Dish Table

        // "R" Read all, read one
        public static List<Dish> GetAllDishes()
        {
            return DB.GetAll<Dish>().ToList();
        }

        public static Dish GetDish(int id)
        {
            return DB.Get<Dish>(id);
        }

        // "C" Create (Insert) into Dish table

        public static void InsertDish(Dish dish)
        {
            DB.Insert(dish);
        }

        // "U" Update in Dish Table 
        public static void UpdateDish(Dish dish)
        {
            DB.Update(dish);
        }

        // DELETE Dish Form (Dish - CRUD "D")
        public static void DeleteDish(int id)
        {
            Dish dish = new Dish() { id = id };
            DB.Delete(dish);
        }
    }
}
