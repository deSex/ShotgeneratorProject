using BusinessLayer.Handlers;
using Contracts;
using Contracts.Models.User;
using DataLayer;
using ShotGeneratorProject.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShotGeneratorProject.Api.Controllers
{
    //[Route("api/values")]
    public class ValuesController : ApiController
    {
        private IUnitOfWork _iUnitOfWork;

        public ValuesController(IUnitOfWork unitOfWork)
        {
            this._iUnitOfWork = unitOfWork;
        }
        public ValuesController()
        {
            this._iUnitOfWork = new UserRepository(new DataContext());
        }


        public void Post([FromBody]string value)
        {
        }
        [HttpGet]
        [Route("api/values/users/{id:int}")]
        public IHttpActionResult GetUserId(int id)
        {

            return Ok(_iUnitOfWork.GetUserById(id));
        }

        [HttpPost]
        [Route("api/values/users/save/{id:int}")]
        public IHttpActionResult SaveTemporaryUser(int id)
        {
            return Ok(_iUnitOfWork.GetUserById(id));
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
