using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
// using Item;

using Catalog.Entities;
namespace Catalog.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemControllers : ControllerBase
    {
        private readonly InMemItemsRepository repository;

        public ItemControllers(){
            repository = new InMemItemsRepository();
        }

        [HttpGet]

        public IEnumerable<Item> GetItems(){
            var items = repository.GetItems();
            return items;
        }
        
    }
}