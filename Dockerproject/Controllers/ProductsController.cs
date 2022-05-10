using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dockerproject.Models;

namespace Dockerproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public IActionResult Get()
        {
            List<Product> prdList = new List<Product>() 
            {
                new Product(){ProductId=1022, ProductName="Printer", UnitPrice=2400,Quantity=5},
                new Product(){ProductId=1023, ProductName="XRAY", UnitPrice=2400,Quantity=3},
                new Product(){ProductId=1024,ProductName="MACHINE",UnitPrice=2400,Quantity=4},
                new Product(){ProductId=1026,ProductName="BOAT",UnitPrice=2400,Quantity=6},
                new Product(){ProductId=1027,ProductName="KEYBOARD",UnitPrice=2400,Quantity=2}
            };
            return Ok(prdList);
            
        
        }
    }
}

