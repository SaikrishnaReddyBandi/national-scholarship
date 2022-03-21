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
    public class ScholarshipAppFormController : ControllerBase
    {
        dbNSPContext db = new dbNSPContext();

        [HttpGet]
        [Route("scholarapp")]
        public IActionResult Getscholarapp()
        {
            var data = from scholarshipapp in db.ScholarshipApplicationForms select scholarshipapp;
            return Ok(data);
        }
        [HttpGet]
        [Route("scholarapp/{Appid}")]
        public IActionResult Getscholarapp(int? Appid)
        {
            if (Appid == null)
            {
                return BadRequest("ApplicationId cannot be null,Try again");
            }

            var data = db.ScholarshipApplicationForms.Find(Appid);


            if (data == null)
            {
                return NotFound($"ApplicationId {Appid} Not Found");
            }
            return Ok(data);
        }

        [HttpPost]
        [Route("Addscholarapp")]
        public IActionResult Postscholarapp([FromBody] ScholarshipApplicationForm scholarapp)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.ScholarshipApplicationForms.Add(scholarapp);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    return BadRequest("Something went wrong while saving Record");
                }
            }
            return Created("Record Successfully Added", scholarapp);
        }
        [HttpPut]
        [Route("Editscholarapp/{Appid}")]
        public IActionResult Putscholarapp(int Appid, [FromBody] ScholarshipApplicationForm scholarapp)
        {
            if (ModelState.IsValid)
            {
                ScholarshipApplicationForm oscholarapp = db.ScholarshipApplicationForms.Find(Appid);
                oscholarapp.FamilyIncome = scholarapp.FamilyIncome;
                oscholarapp.UniversityName = scholarapp.UniversityName;
                oscholarapp.TutionFee = scholarapp.TutionFee;

                db.SaveChanges();
                return Ok(scholarapp);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("Deletescholarapp/{Appid}")]
        public IActionResult Deletescholarapp(int? Appid)
        {
            if (Appid == null) return BadRequest("Applicationid cannot be null");
            var data = db.ScholarshipApplicationForms.Find(Appid);
            if (data == null) return NotFound("Invalid Applicationid");
            db.ScholarshipApplicationForms.Remove(data);
            db.SaveChanges();
            return Ok("Record Successfully Deleted!!!");
        }
    }
}
