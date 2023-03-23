using Dapper;
using Flint.Properties;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Flint.Properties;


namespace Flint.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ChipsController : Controller
    {
        [HttpPost]
        public void CreateChips([FromBody] Chips chipsies)
        {
            var db = new ApplicationContext();
            var newChips = new Chips()
            {
                Name = chipsies.Name,
                Vaga = chipsies.Vaga,
                Price = chipsies.Price


            };
            db.Chipses.Add(newChips);
            db.SaveChanges();
        }

        [HttpGet]
        public Chips Get ([FromQuery] Guid id)
        {
            var db = new ApplicationContext();
            var entity = db.Chipses .FirstOrDefault(c => c.Id == id);
            return entity;
        }

        [HttpPut]
        public void Update([FromBody] Chips question)
        {
            var db = new ApplicationContext();
            var entity = db.Chipses.FirstOrDefault(c => c.Id == question.Id);
            entity.Name = question.Name;
            entity.Vaga = question.Vaga;
            entity.Price = question.Price;
            db.Update(entity);
            db.SaveChanges();
        }


        [HttpDelete]
        public void Delete([FromQuery] Guid id)
        {
            var db = new ApplicationContext();
            var entity = db.Chipses.FirstOrDefault(c => c.Id == id);
            db.Chipses.Remove(entity);
            db.SaveChanges();
        }





    }
}
