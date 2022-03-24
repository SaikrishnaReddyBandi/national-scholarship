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
    public class StudentLoginController : ControllerBase
    {
        dbNSPContext db = new dbNSPContext();

        [HttpGet]
        [Route("Studloginlist")]
        public IActionResult GetStudloginlist()
        {
            var data = from login in db.StudentLogin select login;
            return Ok(data);
        }
        [HttpGet]
        [Route("Studloginlist/{Regid}")]
        public IActionResult Studloginlist(int? Regid)
        {
            if (Regid == null)
            {
                return BadRequest("RegistrationId cannot be null,Try again");
            }

            var data = db.StudentLogin.Find(Regid);


            if (data == null)
            {
                return NotFound($"Dept {Regid} Not Found");
            }
            return Ok(data);
        }

        [HttpPost]
        [Route("AddStudlogin")]
        public IActionResult PostStudlogin([FromBody] StudentLogin Stud)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.StudentLogin.Add(Stud);
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
        [Route("EditStudlogin/{Regid}")]
        public IActionResult PutStudlogin(int Regid, [FromBody] StudentLogin Stud)
        {
            if (ModelState.IsValid)
            {
                StudentLogin ostud = db.StudentLogin.Find(Regid);
                ostud.Password = Stud.Password;

                db.SaveChanges();
                return Ok(Stud);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("DeleteStudlogin/{Regid}")]
        public IActionResult DeleteStudlogin(int? Regid)
        {
            if (Regid == null) return BadRequest("Registrationid cannot be null");
            var data = db.StudentLogin.Find(Regid);
            if (data == null) return NotFound("Invalid Registrationid");
            db.StudentLogin.Remove(data);
            db.SaveChanges();
            return Ok("Record Successfully Deleted!!!");
        }
    }
}