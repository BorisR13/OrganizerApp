using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ToDoActivity
    {

        [Key]
        public int ID { get; set; }

        public string Activity { get; set; }
    }
}
