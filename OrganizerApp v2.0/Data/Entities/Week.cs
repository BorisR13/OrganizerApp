using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Week
    {
        [Key]
        public int ID { get; set; }

        public int WeekNumber { get; set; }

        public static List<Day> WeekDays { get; set; }
    }
}
