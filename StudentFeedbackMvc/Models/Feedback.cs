using System;
using System.ComponentModel.DataAnnotations;

namespace StudentFeedbackMvc.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Enrollment Number is required")]
        [Display(Name = "Enrollment No")]
        public string EnrollmentNo { get; set; }

        [Required(ErrorMessage = "Student Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Student Name must be between 3 and 100 characters")]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Subject is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Subject must be between 3 and 100 characters")]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        [Display(Name = "Rating (1-5)")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Comments are required")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Comments must be between 10 and 500 characters")]
        [Display(Name = "Comments")]
        public string Comments { get; set; }

        [Display(Name = "Submission Date")]
        public DateTime SubmissionDate { get; set; }
    }
}using System;
using System.ComponentModel.DataAnnotations;

namespace StudentFeedbackMvc.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Enrollment Number is required")]
        [Display(Name = "Enrollment No")]
        public string EnrollmentNo { get; set; }

        [Required(ErrorMessage = "Student Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Student Name must be between 3 and 100 characters")]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Subject is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Subject must be between 3 and 100 characters")]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        [Display(Name = "Rating (1-5)")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Comments are required")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Comments must be between 10 and 500 characters")]
        [Display(Name = "Comments")]
        public string Comments { get; set; }

        [Display(Name = "Submission Date")]
        public DateTime SubmissionDate { get; set; }
    }
}