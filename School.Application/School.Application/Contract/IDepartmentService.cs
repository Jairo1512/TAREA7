namespace School.Application.Contract
{
    public interface IDepartmentService
    {
        void AddDepartment(string name);
        string GetDepartmentById(int id);
    }
}

