using nsp_project_api.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace nsp_project_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstituteRegistrationController : ControllerBase
    {
        dbNSPContext db = new dbNSPContext();

        [HttpGet]
        [Route("Instlist")]
        public IActionResult GetInstitute()
        {
            var data = from registration in db.InstituteRegistrationForms select registration;
            return Ok(data);
        }

        [HttpGet]
        [Route("Instlist/{institutecode}")]
        public IActionResult Institute(int? Institutecode)
        {
            if (Institutecode == null)
            {
                return BadRequest("Institutecode cannot be null,Try again");
            }

            var data = db.InstituteRegistrationForms.Find(Institutecode);

            if (data == null)
            {
                return NotFound($"Dept {Institutecode} Not Found");
            }
            return Ok(data);
        }

        [HttpPost]
        [Route("AddInst")]
        public IActionResult PostInst([FromBody] InstituteRegistrationForm Inst)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    db.InstituteRegistrationForms.Add(Inst);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    return BadRequest("Something went wrong while saving Record");
                }
            }
            return Created("Record Successfully Added", Inst);
        }
        [HttpPut]
        [Route("EditInst/{institutecode}")]
        public IActionResult PutInst(int InstituteCode, [FromBody] InstituteRegistrationForm inst)
        {
            if (ModelState.IsValid)
            {
                InstituteRegistrationForm oinst = db.InstituteRegistrationForms.Find(InstituteCode);
                oinst.InstituteName = inst.InstituteName;
                oinst.Location = inst.Location;
                oinst.InstituteCategory = inst.InstituteCategory;

                db.SaveChanges();
                return Ok(oinst);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("DeleteInst/{institutecode}")]
        public IActionResult DeleteInst(int? InstituteCode)
        {
            if (InstituteCode == null) return BadRequest("Id cannot be null");
            var data = db.InstituteRegistrationForms.Find(InstituteCode);
            if (data == null) return NotFound("Invalid Id");
            db.InstituteRegistrationForms.Remove(data);
            db.SaveChanges();
            return Ok("Record Successfully Deleted!!!");
        }
    }
}

