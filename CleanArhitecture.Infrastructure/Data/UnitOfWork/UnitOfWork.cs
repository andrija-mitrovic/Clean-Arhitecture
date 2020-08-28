using CleanArhitecture.Core.Interfaces;
using CleanArhitecture.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArhitecture.Infrastructure.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IToDoItemRepository _toDoItems;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IToDoItemRepository ToDoItems
            => _toDoItems = _toDoItems ?? new ToDoItemRepository(_context);

        public async Task<bool> SaveAsync()
            => await _context.SaveChangesAsync() > 0;

        public void Dispose()
            => _context.Dispose();
    }
}
