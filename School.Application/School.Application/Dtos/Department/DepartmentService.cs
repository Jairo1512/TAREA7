using School.Application.Contract;
using School.Application.Dtos.Department;
using School.Application.Core;

namespace School.Application.Services
{
    public class DepartmentService : BaseService, IDepartmentService
    {
        private readonly List<DepartmentDto> departments = new();

        public void AddDepartment(string name)
        {
            if (!ValidateInput(name))
            {
                throw new ArgumentException("Invalid department name.");
            }

            var newDepartment = new DepartmentDto
            {
                Id = departments.Count + 1,
                Name = name,
                CreatedDate = DateTime.Now
            };
            departments.Add(newDepartment);
        }

        public string GetDepartmentById(int id)
        {
            var department = departments.FirstOrDefault(d => d.Id == id);
            return department?.Name ?? "Department not found.";
        }
    }
}

