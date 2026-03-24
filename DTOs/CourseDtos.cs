using System.ComponentModel.DataAnnotations;

namespace CourseManagementAPI.DTOs
{
    public class CourseCreateDto
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Range(1, int.MaxValue)]
        public int InstructorId { get; set; }
    }

    public class CourseUpdateDto
    {
        [Required]
        public string Title { get; set; }
    }

    public class CourseReadDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string InstructorName { get; set; }
    }
}