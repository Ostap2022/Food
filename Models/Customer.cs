using Dapper;
using Flint.Properties;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;



namespace Flint.Controllers
{
    public class Customer
    {
     public Guid Id { get; set; }
        
     public string Name { get; set; }
    
    }
}
