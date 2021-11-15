using CRUDAPI.Models;
using System.Threading.Tasks;

namespace CRUDAPI.Services.Interface
{
    public interface IStudent
    {
        public Task AddStudent(Student student);
        public Task<Student> GetStudent(string Id);
        public Task UpdateStudent(Student student);
        public Task DeleteStudent(Student student);
    }
}
