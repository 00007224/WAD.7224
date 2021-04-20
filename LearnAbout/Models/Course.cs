using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearnAbout.Models
{
    public class Course
    {
        public int? ID { get; set; }

        public string Name { get; set; }

        

        public string Description { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Please, choose any of the variant!")]
        
        public int? LearningCenter { get; set; }
        [DisplayName("LearningCenter")]
        public CourseLearningCenter CourseLearningCenter { get; set; }

        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Please, choose any of the variant!")]
        
        public int? BackgroundLevel { get; set; }
        [DisplayName("Background Level")]
        public CourseBackgroundLevel CourseBackgroundLevel { get; set; }

    }
}
