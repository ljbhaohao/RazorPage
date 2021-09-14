using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model.Entities;
using Service;

namespace WebApplication1.Pages.Xueshen
{
    public class DetailModel : PageModel
    {
        private readonly IStudentRepository studentRepository;

        public DetailModel(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        public Student Student { get; set; }
        public IActionResult OnGet(int id)
        {
            Student = studentRepository.GetById(id);
            if (Student==null)
            {
               return RedirectToPage("/NotFound");
            }
            return Page();
        }
    }
}
