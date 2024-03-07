using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Angular_Project_Server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UsersController : ControllerBase
  {
    public static List<User> users { get; set; } = new List<User>()
    {
          new User{id=1,name="Miri",adress="Uziel 35",email="Miri@gmail.com",password="1234" },
          new User{id=2,name="Tzivi",adress="Uziel 35",email="Tzivi@gmail.com",password="5678" },
          new User{id=3,name="Lali",adress="Uziel 35",email="Lali@gmail.com",password="9012" },
          new User{id=4,name="Ayala",adress="Uziel 35",email="Ayala@gmail.com",password="3456" }
    };
    // GET: api/<UsersController>
    [HttpGet]
    public IEnumerable<User> Get()
    {
      return users;
    }
    // GET api/<UsersController>/5
    [HttpGet("{id}")]
    public User Get(int id)
    {
      return users.Find(x => x.id == id);
    }

    // POST api/<UsersController>
    [HttpPost]
    public void Post([FromBody] User user)
    {
      users.Add(user);
    }

    // PUT api/<UsersController>/5
    //[HttpPut("{id}")]
    //public void Put(int id, [FromBody] User user)
    //{

    //}

    // DELETE api/<UsersController>/5
    //[HttpDelete("{id}")]
    //public void Delete(int id)
    //{
    //}
  }
}
