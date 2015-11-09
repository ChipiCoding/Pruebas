using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Class
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [RegularExpression("([1-9][0-9]*)")]
        public string document { get; set; }

        public string name { get; set; }

        public DateTime date { get; set; }
    }
}
