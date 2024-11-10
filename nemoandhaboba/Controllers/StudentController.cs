using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using nemoandhaboba.Dto;
using nemoandhaboba.models;
using nemoandhaboba.Repo;

namespace nemoandhaboba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class StudentController : ControllerBase
    {
        private readonly  Istudentrepo _userrepo;
        public StudentController(Istudentrepo repo)
        {
            
                 _userrepo= repo;
        }
        [HttpGet("{id}")]
        public IActionResult get(int id)
        { 
           var student = _userrepo.Getuserbyid(id);
            if(student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
        [HttpPost]
        public IActionResult post(StudentDto dto)
        {
            _userrepo.Addstudent(dto);
            return Ok();

        }
        [HttpPut]
        public IActionResult put(StudentDto dto,int id)
        {
           
                
                _userrepo.Updatestudent(dto,id);
                return Ok(dto);

        
        }
        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        { 
            _userrepo.Deletestudent(id);
            return Ok();

        }
    }
}
