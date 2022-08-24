using FlutterBackend.Business.Abstract;
using FlutterBackend.Business.Concrete;
using FlutterBackend.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlutterBackend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneController : ControllerBase
    {
        private IPhoneService _phoneService;

        public PhoneController()
        {
            _phoneService = new PhoneManager();
        }

        [HttpGet]
        public List<Phone> Get()
        {
            return _phoneService.GetAllPhones();
        }
        [HttpGet("{id}")]
        public Phone Get(int id)
        {
           
            return _phoneService.GetPhoneById(id);


        }

        //[HttpPost]
        //public Phone Post(String Sifre) {  
        
        //    var message = Request.CreateResponse(HttpStatusCode.Created, employee);  
        //}
    }
}