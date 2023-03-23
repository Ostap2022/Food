using Dapper;
using Flint.Properties;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;


namespace Flint.Controllers
{
    public class Purchase
    {
      
    public Guid Id { get; set; }
    public string DateOfPurchase { get; set; }
    public int Sum { get; set; }
    public Guid ChipsId { get; set; }
        public Chips? Chips { get; set; }// щоб витягнути звязані дані по чіпс айді
        public Customer? Customer { get; set; }
        public Guid CustomerId { get; set; }      
      
    }
}
