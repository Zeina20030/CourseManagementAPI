using CourseManagementAPI.Data;
using CourseManagementAPI.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CourseManagementAPI.Services
{
    public class InstructorService
    {
        private readonly AppDbContext _context;

        public InstructorService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<InstructorReadDto>> GetAllAsync()
        {
            return await _context.Instructors
                .AsNoTracking()
                .Select(i => new InstructorReadDto
                {
                    Id = i.Id,
                    Name = i.Name
                })
                .ToListAsync();
        }
    }
}