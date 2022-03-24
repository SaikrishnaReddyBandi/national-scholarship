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
    public class _12thClassController : ControllerBase
    {
        dbNSPContext db = new dbNSPContext();

        [HttpGet]
        [Route("twelfthclass")]
        public IActionResult Gettwelfthclass()
        {
            var data = from Twelfthclass in db._12thclass select Twelfthclass;
            return Ok(data);
        }
        [HttpGet]
        [Route("twelfthclass/{Rnumber}")]
        public IActionResult Gettwelfthclass(int? Rnumber)
        {
            if (Rnumber == null)
            {
                return BadRequest("RollNumber cannot be null,Try again");
            }

            var data = db._12thclass.Find(Rnumber);


            if (data == null)
            {
                return NotFound($"RollNumber {Rnumber} Not Found");
            }
            return Ok(data);
        }

        [HttpPost]
        [Route("Addtwelfthclass")]
        public IActionResult Posttwelfthclass([FromBody] _12thclass Twelfth)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db._12thclass.Add(Twelfth);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    return BadRequest("Something went wrong while saving Record");
                }
            }
            return Created("Record Successfully Added", Twelfth);
        }
        [HttpPut]
        [Route("Edittwelfthclass/{Rnumber}")]
        public IActionResult Puttwelfthclass(int Rnumber, [FromBody] _12thclass Twelfth)
        {
            if (ModelState.IsValid)
            {
                _12thclass otwelfth = db._12thclass.Find(Rnumber);
                otwelfth.BoardName = Twelfth.BoardName;
                otwelfth.Percentage = Twelfth.Percentage;
                otwelfth.PassingYear = Twelfth.PassingYear;

                db.SaveChanges();
                return Ok(Twelfth);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("Deletetwelfthclass/{Rnumber}")]
        public IActionResult Deletetwelfthclass(int? Rnumber)
        {
            if (Rnumber == null) return BadRequest("RollNumber cannot be null");
            var data = db._12thclass.Find(Rnumber);
            if (data == null) return NotFound("Invalid RollNumber");
            db._12thclass.Remove(data);
            db.SaveChanges();
            return Ok("Record Successfully Deleted!!!");
        }
    }
}
