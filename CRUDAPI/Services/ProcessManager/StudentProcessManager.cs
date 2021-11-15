using CRUDAPI.Models;
using CRUDAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CRUDAPI.Services.ProcessManager
{
    public class StudentProcessManager : ControllerBase
    {
        private readonly IStudent _student;
        public StudentProcessManager(IStudent student){
            _student = student; 
        }
        public async Task AddStudent(Student student)
        {
            await _student.AddStudent(student);
        }
        public async Task<Student> GetStudent(string ID)
        {
            return await _student.GetStudent(ID);
        }
        public async Task<Student> UpdateStudent(Student student)
        {
            if (await _student.GetStudent(student.Id.ToString()) != null) {
                await _student.UpdateStudent(student);
                return student;
            }
            return null;
            
        }
        public async Task DeleteStudent(string ID)
        {
            await _student.DeleteStudent(await GetStudent(ID));
        }
        public void resetAI(int number)
        {
            
        }
        
    }
}
