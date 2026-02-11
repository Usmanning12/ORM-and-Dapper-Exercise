using System.Data;
using Dapper;

namespace ORM_Dapper
{
    public class DapperDepartmentRepository: IDepartmentRepository
    {
        private readonly IDbConnection _connection;
    
        public DapperDepartmentRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("select * from Department");
        }

        public void InsertDepartment(string newDepartmentName)
        {
            _connection.Execute("INSERT INTO Departments (Name) VALUES (@departmentName);",  
            new {newDepartmentName = newDepartmentName});
        }

    }
}

