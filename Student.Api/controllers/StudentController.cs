using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Student.Api.data;

namespace Student.Api {
    public class StudentController : ControllerBase
    {
        private readonly DataContext _dataContext; 

        public StudentController(DataContext dataContext){  // Constructor injection 
            _dataContext = dataContext;   // Injecting the data context 
        }

        [HttpGet("GetStudentList")]
        public IActionResult GetStudentList() // IActionResult is a return type 
        {
            var studentList = _dataContext.Students.ToList();
            return Ok(studentList); // Returns a 200 status code with the student list
        }


        [HttpPost("CreateStudent")]
        public IActionResult CreateStudent(Student student){
            _dataContext.Add(student);
            _dataContext.SaveChanges();
            return Ok(student);
        }
    }
}