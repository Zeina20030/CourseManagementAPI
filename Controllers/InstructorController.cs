using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CourseManagementAPI.Services;
using CourseManagementAPI.Data;
using CourseManagementAPI.Models;

namespace CourseManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class InstructorController : ControllerBase
    {
        private readonly InstructorService _service;
        private readonly AppDbContext _context;

        public InstructorController(InstructorService service, AppDbContext context)
        {
            _service = service;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetAllAsync());
        }

        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] string name)
        {
            var instructor = new Instructor
            {
                Name = name
            };

            _context.Instructors.Add(instructor);
            await _context.SaveChangesAsync();

            return Ok(instructor);
        }
    }
}