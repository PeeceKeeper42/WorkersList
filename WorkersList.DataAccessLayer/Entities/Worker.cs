namespace WorkersList.DataAccessLayer.Entities
{
    public class Worker
    {
        public Worker()
        {
            Reviews = new HashSet<Review>();
            Comments = new HashSet<Comment>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string JobPosition { get; set; }
        public DateTimeOffset DateOfEmployment { get; set; }
        public DateTimeOffset LastModifyInfoDate { get; set; }

        //One to many Department - Workers
        public Department Department { get; set; }
        public int? DepartmentId { get; set; }

        //One to one Worker - Password
        public WorkerPassword WorkerPassword { get; set; }

        //Many to many Worker - Reviews
        public ICollection<Review> Reviews { get; set; }

        //One to Many Worker - Comments
        public ICollection<Comment> Comments { get; set; }
    }
}
