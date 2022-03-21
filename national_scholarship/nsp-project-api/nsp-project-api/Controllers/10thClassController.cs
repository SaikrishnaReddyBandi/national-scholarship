using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using nsp_project_api.Repository;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace nsp_project_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class _10thClassController : ControllerBase
    {
        dbNSPContext db = new dbNSPContext();

        [HttpGet]
        [Route("tenthclass")]
        public IActionResult Gettenthclass()
        {
            var data = from Tenthclass in db._10thclasses select Tenthclass;
            return Ok(data);
        }
        [HttpGet]
        [Route("tenthclass/{RollNumber}")]
        public IActionResult Gettenthclass(int? RollNumber)
        {
            if (RollNumber == null)
            {
                return BadRequest("RollNumber cannot be null,Try again");
            }

            var data = db._10thclasses.Find(RollNumber);


            if (data == null)
            {
                return NotFound($"RollNumber {RollNumber} Not Found");
            }
            return Ok(data);
        }

        [HttpPost]
        [Route("Addtenthclass")]
        public IActionResult Posttenthclass([FromBody] _10thclass Tenth)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db._10thclasses.Add(Tenth);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    return BadRequest("Something went wrong while saving Record");
                }
            }
            return Created("Record Successfully Added", Tenth);
        }
        [HttpPut]
        [Route("Edittenthclass/{RollNumber}")]
        public IActionResult Puttenthclass(int RollNumber, [FromBody] _10thclass Tenth)
        {
            if (ModelState.IsValid)
            {
                _10thclass otenth = db._10thclasses.Find(RollNumber);
                otenth.BoardName = Tenth.BoardName;
                otenth.Percentage = Tenth.Percentage;
                otenth.PassingYear = Tenth.PassingYear;

                db.SaveChanges();
                return Ok(Tenth);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("Deletetenthclass/{RollNumber}")]
        public IActionResult Deletetenthclass(int? RollNumber)
        {
            if (RollNumber == null) return BadRequest("Registrationid cannot be null");
            var data = db._10thclasses.Find(RollNumber);
            if (data == null) return NotFound("Invalid Registrationid");
            db._10thclasses.Remove(data);
            db.SaveChanges();
            return Ok("Record Successfully Deleted!!!");
        }
    }
}
