using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestAssignmentAvSoft.Models
{
    public class CounterSpecialModel
    {
        [Key]
        public Guid Guid { get; set; }

        public int Id { get; set; }

        public int Count { get; set; }

        public int CountMoreThenOne { get; set; }
    }
}
