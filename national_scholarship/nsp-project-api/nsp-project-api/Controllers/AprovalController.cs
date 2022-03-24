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
    public class AprovalController : ControllerBase
    {
        dbNSPContext db = new dbNSPContext();

        [HttpGet]
        [Route("aproval")]
        public IActionResult Getaproval()
        {
            var data = from aproval in db.Aproval select aproval;
            return Ok(data);
        }
        [HttpGet]
        [Route("aproval/{Appid}")]
        public IActionResult Getaproval(int? Appid)
        {
            if (Appid == null)
            {
                return BadRequest("AppId cannot be null,Try again");
            }

            var data = db.Aproval.Find(Appid);


            if (data == null)
            {
                return NotFound($"AppId {Appid} Not Found");
            }
            return Ok(data);
        }

        [HttpPost]
        [Route("Addaproval")]
        public IActionResult Postaproval([FromBody] Aproval aprov)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Aproval.Add(aprov);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    return BadRequest("Something went wrong while saving Record");
                }
            }
            return Created("Record Successfully Added", aprov);
        }
        [HttpPut]
        [Route("Editaproval/{Appid}")]
        public IActionResult Putaproval(int Appid, [FromBody] Aproval aprov)
        {
            if (ModelState.IsValid)
            {
                Aproval oaproval = db.Aproval.Find(Appid);
                oaproval.Appid = aprov.Appid;
                oaproval.InstituteCode = aprov.InstituteCode;
                db.SaveChanges();
                return Ok(aprov);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("Deleteaproval/{Appid}")]
        public IActionResult Deleteaproval(int? Appid)
        {
            if (Appid == null) return BadRequest("Applicationid cannot be null");
            var data = db.Aproval.Find(Appid);
            if (data == null) return NotFound("Invalid Applicationid");
            db.Aproval.Remove(data);
            db.SaveChanges();
            return Ok("Record Successfully Deleted!!!");
        }
    }
}

