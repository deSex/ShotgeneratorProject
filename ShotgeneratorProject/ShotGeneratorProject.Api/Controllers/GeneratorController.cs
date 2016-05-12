using AutoMapper;
using BusinessLayer.Handlers;
using Contacts.Models.Viewmodels;
using Contracts;
using Contracts.Models.User;
using Contracts.Models.UserSettings;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ShotGeneratorProject.Api.Controllers
{
    //[Route("api/values")]
    public class GeneratorController : ApiController
    {
        private IUnitOfWork _iUnitOfWork;

        public GeneratorController(IUnitOfWork unitOfWork)
        {
            this._iUnitOfWork = unitOfWork;
        }
        Product[] products = new Product[]
       {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
       };
        [HttpPost]
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        [HttpPost]
        [Route("api/generator/usersettings/")]
        public IHttpActionResult Post(UserViewModel userSettingsList)
        {
                     
            if (userSettingsList == null)
            {
                return BadRequest("Generator is null");
            }
            var user = Helper.GeneratorHelper.doStuff(userSettingsList);
            _iUnitOfWork.SaveUser(user);
          
            return Ok(userSettingsList);

        }      
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }


}
