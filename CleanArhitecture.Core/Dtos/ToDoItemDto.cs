using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArhitecture.Core.Dtos
{
    public class ToDoItemDto
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }

}
