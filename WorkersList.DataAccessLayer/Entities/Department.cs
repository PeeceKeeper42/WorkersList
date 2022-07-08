namespace WorkersList.DataAccessLayer.Entities
{
    public class Department
    {
        public Department()
        {
            Workers = new HashSet<Worker>();
            Reviews = new HashSet<Review>();
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string HeadOfDepartmentId { get; set; }
        public string ResponsibilityArea { get; set; }
        public DateTimeOffset LastModifyInfoDate { get; set; }

        //Many to many Workers - Departments
        public ICollection<Worker> Workers { get; set; }

        //One to many Department - Reviews
        public ICollection<Review> Reviews { get; set; }
    }
}
