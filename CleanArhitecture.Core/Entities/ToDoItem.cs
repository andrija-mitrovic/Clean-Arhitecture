using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArhitecture.Core.Entities
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }
}
