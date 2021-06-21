using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace inOutProject.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Item Name")]
        public string ExpenseName { get; set; }

        [DisplayName("Money")]
        public int Money { get; set; }
    }
}
