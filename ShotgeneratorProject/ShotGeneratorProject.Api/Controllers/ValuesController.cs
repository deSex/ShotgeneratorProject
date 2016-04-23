using BusinessLayer.Handlers;
using Contracts;
using ShotGeneratorProject.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShotGeneratorProject.Api.Controllers
{
    [Route("api/generator")]
    public class ValuesController : ApiController
    {
        private readonly UserHandler _userHandler;
        // GET api/values

        public ValuesController()
        {

        }
        public ValuesController(IUnitOfWork unitOfWork)
        {
            _userHandler = new UserHandler(unitOfWork);
        }

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }
        [Route("getuserid/{userId:int}")]
        public IEnumerable<string> GetUserId(int id)
        {
            return new string[] { "value1", "value2" };
            //var userId = _userHandler.GetUserById(id);
            //return Ok();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }


        public void SaveTemporaryUser(string userName, string password)
        {


        }
        public void GetTemporaryUser(string userName, string password)
        {

            CheckIfUserHasPremission(userName, password);

            if (true)
            {

            }

        }

        private bool CheckIfUserHasPremission(string userName, string password)
        {
            return true;
        }
    }


}
