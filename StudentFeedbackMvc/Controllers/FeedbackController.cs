using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using StudentFeedbackMvc.Models;

namespace StudentFeedbackMvc.Controllers
{
    public class FeedbackController : Controller
    {
        private static List<Feedback> feedbackList = new List<Feedback>();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View(new Feedback());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedback.SubmissionDate = DateTime.Now;
                feedbackList.Add(feedback);
                TempData["SuccessMessage"] = "Feedback submitted successfully!";
                return RedirectToAction("Index");
            }

            return View(feedback);
        }

        public ActionResult List()
        {
            return View(feedbackList.OrderByDescending(f => f.SubmissionDate).ToList());
        }
    }

    public class Feedback
    {
        public string EnrollmentNo { get; set; }
        public string StudentName { get; set; }
        public string Subject { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }
        public DateTime SubmissionDate { get; set; }
    }
}