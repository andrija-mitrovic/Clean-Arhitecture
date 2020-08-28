using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArhitecture.Core.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IToDoItemRepository ToDoItems { get; }
        Task<bool> SaveAsync();
    }
}
