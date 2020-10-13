using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Pages
{
    public class FindModel : PageModel
    {
        private readonly ToDoListContext _context;

        public IList<Person> People { get; set; }


        public void OnGet()
        {
        }
    }
}
