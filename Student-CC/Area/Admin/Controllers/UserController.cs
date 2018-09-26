using ManpowerManagement.Data.Model;
using ManpowerManagement.Service.Helper;
using ManpowerManagement.Service.UnitOfWork;
using ManpowerManagement.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using static Student_CC.Controllers.SampleDataController;

namespace ManpowerManagement.Area.Admin.Controllers
{
    [Area("Admin")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unit;

        public UserController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = ""
            });
        }

        [HttpGet("GetRole")]
        public IActionResult GetRole()
        {
            dynamic Response = new ExpandoObject();
            Response.Status = true;
            Response.data = GetRoleList();
            return Ok(Response);
        }

        [HttpGet("GetUsers")]
        public IActionResult GetUsers()
        {
            var users = _unit.User.GetAll();
            dynamic Response = new ExpandoObject();
            Response.status = true;
            Response.data = users;
            return Ok(Response);
        }

        [HttpPost("CreateUser")]
        public IActionResult CreateUser(UserViweModel model)
        {
            if (!ModelState.IsValid)
            {
                return Ok(Helper.ModelStateError(ModelState));
            }

            User user = JsonConvert.DeserializeObject<User>(JsonConvert.SerializeObject(model));
            user.UserName = user.Email;
            _unit.User.Add(user);
            _unit.SaveChanges();
            dynamic Response = new ExpandoObject();
            Response.Status = true;
            Response.Message = "User Created Successfully";
            return Ok(Response);
        }

        public List<SelectListItem> GetRoleList()
        {
            List<SelectListItem> list = Enum.GetValues(typeof(Enums.Role)).Cast<Enums.Role>().Where(x=> ((int)x)!=1).Select(x => new SelectListItem()
            {
                Text = Enums.GetDescription(x),
                Value = ((int)x).ToString()
            }).ToList();
            return list;
        }

    }
}
