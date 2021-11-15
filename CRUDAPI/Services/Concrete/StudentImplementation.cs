using CRUDAPI.Models;
using CRUDAPI.Services.Interface;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace CRUDAPI.Services.Concrete
{
    public class StudentImplementation : IStudent
    {
        private readonly CrudContext _context;

        public StudentImplementation(CrudContext context)
        {
            _context = context;
        }
        public async Task AddStudent(Student student)
        {
            await _context.Students.AddAsync(student);
            _context.SaveChanges();
        }

        public async Task DeleteStudent(Student student)
        {
            await Task.Run(()=> _context.Students.Remove(student));
            _context.SaveChanges();
        }

        public async Task<Student> GetStudent(string Id)
        {
          return  await Task.Run(() => _context.Students.Where(student => student.Id == Int32.Parse(Id)).SingleOrDefault());
        }

        public async Task UpdateStudent(Student student)
        {
            await Task.Run(() => _context.Students.Update(student));
            _context.SaveChanges();
        }
    }
}
