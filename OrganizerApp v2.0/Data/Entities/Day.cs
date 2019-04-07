using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Day
    {
        [Key]
        public int ID { get; set; }

        public string DayName { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        [ForeignKey("week")]
        public int weekID { get; set; }
        public Week week { get; set; }

        [ForeignKey("month")]
        public int MonthID { get; set; }
        public Month Month { get; set; }

        public string TaskName { get; set; }
        public string TaskKeyWords { get; set; }
        public string TaskDescription { get; set; }

    }
}
