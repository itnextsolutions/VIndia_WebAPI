using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Web.Http;
using System.Web.Http.Cors;
using VastraIndiaDAL;
using VastraIndiaWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VastraIndiaWebAPI.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class LoginController : ApiController
    {

        DataTable dt = new DataTable();
        LoginDAL objLogin = new LoginDAL();

        // GET: api/<LoginController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LoginController>/5
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoginController>
        [Route("api/Login/login")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] LoginModel login)
        {
            //login.username = "admin";
            //login.password = "kiran11";
            dt = objLogin.GetLoginDetail(login.username);

            if (dt.Rows.Count != 0)
            {
                var hashCode = dt.Rows[0]["Vcode"];
                //Password Hasing Process Call LoginHelper Class Method    
                var encodingPasswordString = LoginHelper.EncodePassword(login.password, Convert.ToString(hashCode));

                dt = objLogin.Login(login.username, encodingPasswordString);

                if (dt.Rows.Count != 0)
                {
                    //var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                    //var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                    //var tokeOptions = new JwtSecurityToken(
                    //    issuer: "*",
                    //    audience: "*",
                    //    claims: new List<Claim>(),
                    //    expires: DateTime.Now.AddMinutes(5),
                    //    signingCredentials: signinCredentials
                    //);
                    //var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                    //return Ok(new AuthenticatedResponse { Token = tokenString });
                    return  Json("Success");
                }

                return Json("Invalid Password");
            }

            return  Json("Invalid UserName & Password");

            //return Unauthorized("Invalid Password");
        }
        // PUT api/<LoginController>/5
        [HttpPut]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginController>/5
        [HttpDelete]
        public void Delete(int id)
        {
        }

    }
}