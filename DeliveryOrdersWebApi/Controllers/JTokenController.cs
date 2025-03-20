using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace DeliveryOrdersWebApi.Controllers
{
    [Route("api/V1/[controller]")]
    [Route("api/V2/[controller]")]
    [ApiController]
    public class JTokenController : Controller
    {
        private IConfiguration _config;
        public JTokenController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost]
        public IActionResult TokenRequest()
        {
            //your logic for login process
            //If login usrename and password are correct then proceed to generate token


            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var Sectoken = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              null,
              expires: DateTime.Now.AddMinutes(60),
              signingCredentials: credentials);

            var token = new JwtSecurityTokenHandler().WriteToken(Sectoken);

            return Ok(token);
        }
    }
}

