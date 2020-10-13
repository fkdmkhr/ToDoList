using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using ToDoList.Data;
using ToDoList.Models;
using Microsoft.EntityFrameworkCore;

namespace ToDoList.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ToDoListContext _context;

        public IndexModel(ToDoListContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get; set; }

        public async Task OnGetAsync()
        {
            Person = await _context.Person.ToListAsync();
        }

        //public string Message = "no message";

        //[DataType(DataType.Text)]
        //public string Name { get; set; }

        //[DataType(DataType.Text)]
        //public string Password { get; set; }

        //[DataType(DataType.Text)]
        //public string Mail { get; set; }

        //[DataType(DataType.Text)]
        //public string Tel { get; set; }

        //public void OnGet()
        //{
        //    Message = "入力してください。";
        //}

        //public void OnPost(string name, string password, string mail, string tel)
        //{
        //    Message = "[Name: " + name + ", password ( " + password.Length + " chars), mail" + mail + " <" + tel + ">]";
        //}
    }
}
