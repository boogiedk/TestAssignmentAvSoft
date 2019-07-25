using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TestAssignmentAvSoft.Models
{
    public class CounterModel
    {
        [Key]
        public Guid Guid { get; set; }
        public int Id { get; set; }
        public int Value { get; set; }
    }
}
