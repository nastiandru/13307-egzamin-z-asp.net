using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace _13307_egzamin.Models
{
    public class ToDoModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Podaj Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Podaj Description")]
  
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? DueDate { get; set; }
        public bool IsDone { get; set; }
    }
}
