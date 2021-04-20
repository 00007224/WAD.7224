using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnAbout.Models
{
    public class CourseBackgroundLevel
    {
        public int ID { get; set; }

        public enum BackgroundLevel
        {
            Begginer,
            Intermediate,
            Advanced
        }
    }
}
