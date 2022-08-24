using FlutterBackend.Business.Abstract;
using FlutterBackend.Business.Concrete;
using FlutterBackend.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FlutterBackend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IK_MobilController : Controller
    {
        private IIKMobilService _mobilService;

        public IK_MobilController()
        {
            _mobilService = new IK_MobilManager();
        }

        [HttpGet]
        public List<IK_Mobil> Get()
        {
            return _mobilService.GetAll();
        }
        [HttpPost]
        public IK_Mobil Post([FromBody]IK_Mobil ik_mobil)
        {   
            

            return _mobilService.Create(ik_mobil);

        }
    
    }
}
