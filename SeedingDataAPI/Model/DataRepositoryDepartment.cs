namespace SeedingDataAPI.Model
{
    public class DataRepositoryDepartment : IDataRepositoryDepartment
    {

        private readonly EmployeeDbContext db;

        public DataRepositoryDepartment(EmployeeDbContext db)
        {
            this.db = db;
        }

        public List<Department> GetDepartments() => db.Department.ToList();

        public Department PutDepartment(Department Department)
        {
            db.Department.Update(Department);
            db.SaveChanges();
            return db.Department.Where(x => x.DepartmentId == Department.DepartmentId).FirstOrDefault();
        }

        public List<Department> AddDepartment(Department Department)
        {
            db.Department.Add(Department);
            db.SaveChanges();
            return db.Department.ToList();
        }

        public Department GetDepartmentById(int Id)
        {
            return db.Department.Where(x => x.DepartmentId == Id).FirstOrDefault();
        }

        public Department GetDepartmentById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
