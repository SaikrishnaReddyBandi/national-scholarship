using nsp_project_api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace nsp_project_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentRegistrationController : ControllerBase
    {
        dbNSPContext db = new dbNSPContext();

        [HttpGet]
        [Route("Studlist")]
        public IActionResult GetStudReglist()
        {
            var data = from registration in db.StudentRegistrationForms select registration;
            return Ok(data);
        }
        [HttpGet]
        [Route("Studlist/{Regid}")]
        public IActionResult GetStudReglist(int? Regid)
        {
            if (Regid == null)
            {
                return BadRequest("RegistrationId cannot be null,Try again");
            }

            var data = db.StudentRegistrationForms.Find(Regid);


            if (data == null)
            {
                return NotFound($"RegistrationId {Regid} Not Found");
            }
            return Ok(data);
        }

        [HttpPost]
        [Route("AddStud")]
        public IActionResult PostStudReg([FromBody] StudentRegistrationForm Stud)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    db.StudentRegistrationForms.Add(Stud);
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
        [Route("EditStud/{Regid}")]
        public IActionResult PutStudReg(int Regid, [FromBody] StudentRegistrationForm Stud)
        {
            if (ModelState.IsValid)
            {
                StudentRegistrationForm ostud = db.StudentRegistrationForms.Find(Regid);
                ostud._10thRollno = Stud._10thRollno;
                ostud._12thRollno = Stud._12thRollno;
                ostud.BankName = Stud.BankName;
                ostud.BankAccountNo = Stud.BankAccountNo;
                ostud.BankIfsccode = Stud.BankIfsccode;
                ostud.State = Stud.State;
                ostud.District = Stud.District;
                ostud.Setpassword = Stud.Setpassword;
                ostud.AdharCard = Stud.AdharCard;


                db.SaveChanges();
                return Ok(ostud);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("DeleteStud/{Regid}")]
        public IActionResult DeleteStudReg(int? Regid)
        {
            if (Regid == null) return BadRequest("RegistrationId cannot be null");
            var data = db.StudentRegistrationForms.Find(Regid);
            if (data == null) return NotFound("Invalid RegistrationId");
            db.StudentRegistrationForms.Remove(data);
            db.SaveChanges();
            return Ok("Record Successfully Deleted!!!");
        }
    }
}

