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
        public int HeadOfDepartmentId { get; set; }
        public string ResponsibilityArea { get; set; }
        public DateTimeOffset LastModifyInfoDate { get; set; }

        //One to many Department - Workers
        public ICollection<Worker> Workers { get; set; }

        //One to many Department - Reviews
        public ICollection<Review> Reviews { get; set; }
    }
}
