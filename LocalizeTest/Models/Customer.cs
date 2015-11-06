using System;
using System.ComponentModel.DataAnnotations;

namespace LocalizeTest.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true,DataFormatString = "{0:d}")]
        public DateTime Birthday { get; set; }

        public decimal Salary { get; set; }
    }
}