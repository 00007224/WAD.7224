using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnAbout.Models
{
    public class CourseLearningCenter
    {
        public int ID { get; set; }

        public enum LearningCenter {
            Coursera,
            GeekBrains,
            Skillbox,
            OTUS
        }
    }
}
