using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArhitecture.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArhitecture.WebAPI.Controllers
{
    public class ToDoItemController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public ToDoItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllToDoItems()
        {
            var items = await _unitOfWork.ToDoItems.GetAllAsync();

            return Ok(items);
        }
    }
}
