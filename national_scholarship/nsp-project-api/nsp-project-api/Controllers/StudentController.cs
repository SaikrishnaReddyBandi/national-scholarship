using nsp_project_api.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nsp_project_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        dbNSPContext db = new dbNSPContext();

        [HttpGet]
        [Route("Studlist")]
        public IActionResult GetStudlist()
        {
            var data = from stud in db.Student select stud;
            return Ok(data);
        }
        [HttpGet]
        [Route("Studlist/{RollNumber}")]
        public IActionResult GetStudReglist(int? RollNumber)
        {
            if (RollNumber == null)
            {
                return BadRequest("RollNumber cannot be null,Try again");
            }

            var data = db.Student.Find(RollNumber);


            if (data == null)
            {
                return NotFound($"RollNumber {RollNumber} Not Found");
            }
            return Ok(data);
        }

        [HttpPost]
        [Route("AddStud")]
        public IActionResult PostStud([FromBody] Student Stud)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    db.Student.Add(Stud);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    return BadRequest("Something went wrong while saving Record");
                }
            }
            return Created("Record Successfully Added", Stud);
        }
        [HttpPut]
        [Route("EditStud/{RollNumber}")]
        public IActionResult PutStud(int RollNumber, [FromBody] Student Stud)
        {
            if (ModelState.IsValid)
            {
                Student ostud = db.Student.Find(RollNumber);
                ostud.EmailId = Stud.EmailId;
                ostud.House = Stud.House;
                ostud.Pincode = Stud.Pincode;


                db.SaveChanges();
                return Ok(ostud);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("DeleteStud/{RollNumber}")]
        public IActionResult DeleteStud(int? RollNumber)
        {
            if (RollNumber == null) return BadRequest("RollNumber cannot be null");
            var data = db.Student.Find(RollNumber);
            if (data == null) return NotFound("Invalid RollNumber");
            db.Student.Remove(data);
            db.SaveChanges();
            return Ok("Record Successfully Deleted!!!");
        }
    }
}