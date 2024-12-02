using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Student.Api {
    public class StudentController : ControllerBase
    {
        private readonly string[] studentList = new[] { "Student1", "Student2", "Student3" };

        [HttpGet("GetStudentList")]
        public IActionResult GetStudentList() // IActionResult is a return type 
        {
            return Ok(studentList); // Returns a 200 status code with the student list
        }


        [HttpPost("CreateStudent")]
        public IActionResult CreateStudent(Student student){
            return Ok(student);
        }
    }
}