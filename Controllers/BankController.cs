using BankPractice.Context;
using BankPractice.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankPractice.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private object dbContext;

        public BankController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        [HttpPost]
        public object Create([FromBody]Bank bank)
        {
           _dbContext.BankDetails.Add(bank);
            _dbContext.SaveChanges();
            return Ok();
        }


        [HttpGet]
        [Route("Details")]
        public ActionResult Get()
        {
            var BankUserDetails = _dbContext.BankDetails.ToList();
            return Ok(BankUserDetails);
        }

        [HttpGet]
        public ActionResult Get(int Id)
        {
            if(Id == 0)
            {
                return NotFound();
            }
            var BankDetails = _dbContext.BankDetails.FirstOrDefault(x => x.Id == Id);
            return Ok();
        }


        [HttpPut]
        public ActionResult Update([FromBody]Bank bank)
        {
             _dbContext.BankDetails.Update(bank);
            _dbContext.SaveChanges();
            return Ok();
        }




        [HttpDelete]

        public ActionResult Delete(int Id)
        {
            if(Id == 0)
            {
                return NotFound();
            }
            var BankDetails = _dbContext.BankDetails.FirstOrDefault(x => x.Id == Id);
            if(BankDetails == null)
            {
                return NotFound();
            }
            _dbContext.BankDetails.Remove(BankDetails);
            _dbContext.SaveChanges();
            return Ok();
        }









    }
}