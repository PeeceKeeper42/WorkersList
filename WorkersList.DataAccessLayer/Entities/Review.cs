namespace WorkersList.DataAccessLayer.Entities
{
    public class Review
    {
        public Review()
        {
            Comments = new HashSet<Comment>();
            Workers = new HashSet<Worker>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Liked { get; set; }
        public int Disliked { get; set; }
        public DateTimeOffset LastModifyInfoDate { get; set; }

        //One to many Department - Reviews
        public Department Department { get; set; }
        public int DepartmentId { get; set; }

        //Many to many Worker - Reviews
        public ICollection<Worker> Workers { get; set; }

        //One to Many Review - Comments
        public ICollection<Comment> Comments { get; set; }
    }
}
