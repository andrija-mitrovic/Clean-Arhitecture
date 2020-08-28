using CleanArhitecture.Core.Entities;
using CleanArhitecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArhitecture.Infrastructure.Data.Repositories
{
    public class ToDoItemRepository: GenericRepository<ToDoItem>, IToDoItemRepository    
    {
        public ToDoItemRepository(ApplicationDbContext context) : base(context) { }
    }
}
