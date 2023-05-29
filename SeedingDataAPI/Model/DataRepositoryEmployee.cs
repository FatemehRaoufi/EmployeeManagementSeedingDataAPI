namespace SeedingDataAPI.Model
{
    public class DataRepositoryEmployee : IDataRepositoryEmployee
    {

        private readonly EmployeeDbContext db;

        public DataRepositoryEmployee(EmployeeDbContext db)
        {
            this.db = db;
        }

        public List<Employee> GetEmployees() => db.Employee.ToList();

        public Employee PutEmployee(Employee employee)
        {
            db.Employee.Update(employee);
            db.SaveChanges();
            return db.Employee.Where(x => x.EmployeeId == employee.EmployeeId).FirstOrDefault();
        }

        public List<Employee> AddEmployee(Employee employee)
        {
            db.Employee.Add(employee);
            db.SaveChanges();
            return db.Employee.ToList();
        }

        public Employee GetEmployeeById(string Id)
        {
            return db.Employee.Where(x => x.EmployeeId ==Convert.ToInt32(Id)).FirstOrDefault();
        }

        //public Employee GetEmployeeById(string id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
