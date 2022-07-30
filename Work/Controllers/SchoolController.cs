using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Work.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : Controller
    {
        private ISchoolService _schoolService;
        public SchoolController()
        {
            _schoolService = new SchoolManager();
        }
        [HttpGet]
        public List<School> Get()
        {
            return _schoolService.GetAllSchool();
        }
        [HttpGet("{id}")]
        public School Get(int id)
        {
            return _schoolService.GetSchoolById(id);
        }
        [HttpPost]
        public School Post([FromBody] School p)
        {
            return _schoolService.CreateSchool(p);
        }
        [HttpPut]
        public School Put([FromBody] School p)
        {
            return _schoolService.UpdateSchool(p);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            _schoolService.DeleteSchool(id);
        }

       /* public IActionResult Index()
        {
            return View();
        }*/
    }
}
