using CourseManagementAPI.Data;
using CourseManagementAPI.DTOs;
using CourseManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseManagementAPI.Services
{
    public class CourseService
    {
        private readonly AppDbContext _context;

        public CourseService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<CourseReadDto>> GetAllAsync()
        {
            return await _context.Courses
                .Include(c => c.Instructor)
                .AsNoTracking()
                .Select(c => new CourseReadDto
                {
                    Id = c.Id,
                    Title = c.Title,
                    InstructorName = c.Instructor.Name
                })
                .ToListAsync();
        }

        public async Task CreateAsync(CourseCreateDto dto)
        {
            var course = new Course
            {
                Title = dto.Title,
                InstructorId = dto.InstructorId
            };

            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, CourseUpdateDto dto)
        {
            var course = await _context.Courses.FindAsync(id);

            if (course == null)
                throw new Exception("Not found");

            course.Title = dto.Title;
            await _context.SaveChangesAsync();
        }
    }
}