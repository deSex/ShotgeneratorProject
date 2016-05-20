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
using System.Web.Mvc;
using System.Web.Security;

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

        [System.Web.Http.HttpPost]
        [System.Web.Mvc.AllowAnonymous]
        [ValidateAntiForgeryToken]
        [System.Web.Http.Route("api/generator/usersettings/")]
        public IHttpActionResult Post(UserViewModel userSettingsList)
        {

            if (!ModelState.IsValid || userSettingsList == null)
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
