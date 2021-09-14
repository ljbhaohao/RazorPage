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
    public class IndexModel : PageModel
    {
        private readonly IStudentRepository studentRepository;

        public IndexModel(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        public IEnumerable<Student> Students { get; set; }
        public void OnGet()
        {
            Students = studentRepository.GetAllStudens();

        }
    }
}
