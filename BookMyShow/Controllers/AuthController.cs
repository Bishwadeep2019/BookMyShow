
using BookMyShow.DataModels;
using Microsoft.AspNetCore.Mvc;
using BookMyShow.Models.CoreModels;
using System.Security.Cryptography;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static UserDetail user  = new UserDetail();
        private readonly IConfiguration _configuration;
        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDetail>> Register(UserDto request)
        {
            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            var userDetail = databaseContent.FirstOrDefault<UserDetail>("SELECT * FROM UserDetails WHERE email = @0", request.Email);
            if(userDetail == null)
            {
                CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

                user.Name = request.UserName;
                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
                user.Email = request.Email;

                databaseContent.Insert(user);

                return Ok(user);
            }
            else
            {
                return BadRequest();
            }
            
        }

        
        [HttpPost("login")]
        
        public async Task<ActionResult<string>> Login(LoginDTO request)
        {
            var email = request.Email;
            
            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            var userDetail = databaseContent.FirstOrDefault<UserDetail>("SELECT * FROM UserDetails WHERE email = @0", email);
            if(userDetail == null)
            {
                return BadRequest("no data found");
            }
            Console.Write("OK2"+userDetail.Email);
            Console.Write("Ok1"+email);
            if (email !=userDetail.Email )
            {
                Console.WriteLine("OK"+request.Email);
                return BadRequest("User not found");
            }

            if (!VerifyPassowrdHash(request.Password, userDetail.PasswordHash, userDetail.PasswordSalt))
            {
                return BadRequest("wrong password");
            }

            string token = CreateToken(userDetail);
            return Ok(new { Token = token });
        }

        private string CreateToken(UserDetail user)
        {
            List<Claim> claims = new List<Claim>
             {
                 new Claim(ClaimTypes.Name, user.Name)
             };

            var key =  new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token  = new JwtSecurityToken(
                claims:claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials:cred);
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using(var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPassowrdHash(string password,  byte[] passwordHash,  byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }
    }
}
