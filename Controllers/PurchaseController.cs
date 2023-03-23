using Dapper;
using Flint.Properties;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Flint.Properties;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Flint.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PurchaseController : Controller
    {
        [HttpPost]
        public void CreatePurchase([FromBody] Purchase purchases)
        {
            var db = new ApplicationContext();
            var newPurchase = new Purchase()
            {
                DateOfPurchase = purchases.DateOfPurchase,
                Sum = purchases.Sum,
                ChipsId = purchases.ChipsId,
                CustomerId = purchases.CustomerId


            };
            db.Purchases.Add(newPurchase);
            db.SaveChanges();
        }


        [HttpGet]
        public Purchase Get([FromQuery] Guid id)
        {
            var db = new ApplicationContext();
            var entity = db.Purchases
                .Include(x => x.Chips)
                .Include(x => x.Customer)
                .FirstOrDefault(c => c.Id == id);
            return entity;
        }


        [HttpPut]
        public void Update([FromBody] Purchase questionsi)
        {
            var db = new ApplicationContext();
            var entity = db.Purchases.FirstOrDefault(c => c.Id == questionsi.Id);
                
            entity.DateOfPurchase = questionsi.DateOfPurchase;
            entity.Sum = questionsi.Sum;
            db.Update(entity);
            db.SaveChanges();
        }

        [HttpDelete]
        public void Delete([FromQuery] Guid id)
        {
            var db = new ApplicationContext();
            var entity = db.Purchases.FirstOrDefault(c => c.Id == id);
            db.Purchases.Remove(entity);
            db.SaveChanges();
        }




    }
}
