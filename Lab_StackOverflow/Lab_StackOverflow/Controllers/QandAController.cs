using Lab_StackOverflow.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_StackOverflow.Controllers
{
    public class QandAController : Controller
    {
        /*
        *      Question Routes
        *      
        *      /QandA  -- list all the questions (calls Index view
        *      /QandA/question?cat=SOFTWARE  -- list all questions in a category
        *      /QandA/ListAnswers?ques=1 -- list details for question by ID
        *      /admin/addQform -- preset the user with a form to add a question
        *      /admin/addques -- create a new question
        *      /admin/editQform?quesid=2 -- preset the user with a form to edit a question
        *      /admin/saveques -- save edited question
        * */

        // Question Section
        public IActionResult Index()
        {
            // Here's a page you want to make available to only logged-in users,
            // you could do something like this in the controller:
            if (DAL.CurrentUser == null)
            {
                return Redirect("/");
            }
            List<Question> quess= DAL.GetAllQuestions();
            return View(quess);
        }

        public IActionResult question(int ques)
        {
            Question theques = DAL.GetQuestion(ques);
            return View(theques);
        }

        public IActionResult delete(int id)
        {
            DAL.DeleteQuestion(id);
            return Redirect("/Qand/");
        }

        public IActionResult addQform()
        {
            return View();
        }

        public IActionResult addques(Question ques)
        {
            DAL.InsertQuestion(ques);
            return Redirect("/QandA/");
        }

        public IActionResult editQform(int quesid)
        {
            Question ques = DAL.GetQuestion(quesid);
            return View(ques);
        }

        public IActionResult saveques(Question ques)
        {
            DAL.UpdateQuestion(ques);
            return Redirect($"/QandA/question?ques={ques.id}");
        }

        /*
        *      Answer Routes
        *      
        *      /QandA  -- list all the answers (calls Index view
        *      /QandA/answer?cat=SOFTWARE  -- list all questions in a category
        *      /QandA/answer?ques=1 -- list details for question by ID
        *      /admin/addAform -- preset the user with a form to add an product
        *      /admin/addansw -- create a new answer
        *      /admin/editAform?answid=2 -- preset the user with a form to edit an answer
        *      /admin/saveansw -- save edited answer
        * */

        // Answer section
        public IActionResult ListAnswers(int quesid)
        {
            QuestionAnswers answs = DAL.GetAllAnswers(quesid);
            return View(answs);
        }

        public IActionResult answer(int answ)
        {
            EditQuestionAnswer theansw = DAL.GetAnswer(answ);
            return View(theansw);
        }

        public IActionResult deleteAnswer(int questionId, int answid)
        {
            DAL.DeleteAnswer(answid);
            return Redirect($"/QandA/ListAnswers?quesid={questionId}");
        }

        public IActionResult addAform()
        {
            return View();
        }

        public IActionResult addansw(Answer answ)
        {
            DAL.InsertAnswer(answ);
            return Redirect("/QandA/");
        }

        public IActionResult editAform(int answid)
        {
            EditQuestionAnswer answ = DAL.GetAnswer(answid);
            return View(answ);
        }

        public IActionResult saveansw(Answer answ)
        {
            DAL.UpdateAnswer(answ);
            return Redirect($"/QandA/answer?answ={answ.id}");
        }
    }
}
