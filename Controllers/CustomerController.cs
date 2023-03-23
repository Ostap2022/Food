using Dapper;
using Flint.Properties;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Flint.Properties;
using Microsoft.AspNetCore.Mvc;

namespace Flint.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CustomerController : Controller
    {
        [HttpPost]
        public void CreateCustomer([FromBody] Customer customers)
        {
            var db = new ApplicationContext();
            var newCustomer = new Customer()
            {
                Name = customers.Name
            };
            db.Customers.Add(newCustomer);
            db.SaveChanges();


        }

        [HttpGet]
        public Customer Get([FromQuery] Guid id)
        {
            var db = new ApplicationContext();
            var entity = db.Customers.FirstOrDefault(c => c.Id == id);
            return entity;
        }


        [HttpPut]
        public void Update([FromBody] Customer questions)
        {
            var db = new ApplicationContext();
            var entity = db.Customers.FirstOrDefault(c => c.Id == questions.Id);
            entity.Name = questions.Name;
            db.Update(entity);
            db.SaveChanges();
        }


        [HttpDelete]
        public void Delete([FromQuery] Guid id)
        {
            var db = new ApplicationContext();
            var entity = db.Customers.FirstOrDefault(c => c.Id == id);
            db.Customers.Remove(entity);
            db.SaveChanges();
        }



    }
}
