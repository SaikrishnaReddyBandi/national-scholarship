using nsp_project_api.Repository;
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
    public class InstituteStateMinistryLoginController : ControllerBase
    {
        dbNSPContext db = new dbNSPContext();

        [HttpGet]
        [Route("InstStatMini")]
        public IActionResult GetInstStatMini()
        {
            var data = from InstStatMini in db.InstituteStateMinistryLogin select InstStatMini;
            return Ok(data);
        }
        [HttpGet]
        [Route("InstStatMini/{Userid}")]
        public IActionResult GetInstStatMini(int? Userid)
        {
            if (Userid == null)
            {
                return BadRequest("Userid cannot be null,Try again");
            }

            var data = db.InstituteStateMinistryLogin.Find(Userid);


            if (data == null)
            {
                return NotFound($"Userid {Userid} Not Found");
            }
            return Ok(data);
        }

        [HttpPost]
        [Route("AddInstStatMini")]
        public IActionResult PostInstStatMini([FromBody] InstituteStateMinistryLogin inststatmini)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.InstituteStateMinistryLogin.Add(inststatmini);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    return BadRequest("Something went wrong while saving Record");
                }
            }
            return Created("Record Successfully Added", inststatmini);
        }
        [HttpPut]
        [Route("EditInstStatMini/{Userid}")]
        public IActionResult Putinststatmini(int Userid, [FromBody] InstituteStateMinistryLogin inststatmini)
        {
            if (ModelState.IsValid)
            {
                InstituteStateMinistryLogin oism = db.InstituteStateMinistryLogin.Find(inststatmini);
                oism.Userid = inststatmini.Userid;
                db.SaveChanges();
                return Ok(inststatmini);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("DeleteInstStatMini/{Userid}")]
        public IActionResult DeleteInstsStatMini(int? Userid)
        {
            if (Userid == null) return BadRequest("Userid cannot be null");
            var data = db.InstituteStateMinistryLogin.Find(Userid);
            if (data == null) return NotFound("Invalid  Userid");
            db.InstituteStateMinistryLogin.Remove(data);
            db.SaveChanges();
            return Ok("Record Successfully Deleted!!!");
        }
    }
}

