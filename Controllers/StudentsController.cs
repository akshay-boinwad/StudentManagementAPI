using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagementAPI.Data;
using StudentManagementAPI.Models;

namespace StudentManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public StudentsController(ApplicationDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
   {
       return await _context.Students.ToListAsync();
   }
   [HttpPost]
public async Task<ActionResult<Student>> CreateStudent(Student student)
{
    _context.Students.Add(student);
    await _context.SaveChangesAsync();

    return CreatedAtAction(nameof(GetStudents), new { id = student.Id }, student);
}
[HttpPut("{id}")]
public async Task<IActionResult> UpdateStudent(int id, Student student)
{
    if (id != student.Id)
        return BadRequest();

    _context.Entry(student).State = EntityState.Modified;

    await _context.SaveChangesAsync();

    return NoContent();
}
[HttpDelete("{id}")]
public async Task<IActionResult> DeleteStudent(int id)
{
    var student = await _context.Students.FindAsync(id);

    if (student == null)
        return NotFound();

    _context.Students.Remove(student);
    await _context.SaveChangesAsync();

    return NoContent();
}
 }
}