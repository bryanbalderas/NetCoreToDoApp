using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace toDoApp.Models
{
    public class TodoList
    {
        public int Id { get; set; }
        [Required]
        public String Content { get; set; }
    }
}
