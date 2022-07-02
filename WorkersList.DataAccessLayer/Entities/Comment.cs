namespace WorkersList.DataAccessLayer.Entities
{
    public class Comment
    {
        public Comment()
        {
            Comments = new HashSet<Comment>();
        }
        public int Id { get; set; }
        public string Text { get; set; }
        public byte Rate { get; set; }

        //One to Many Worker - Comments
        public Worker Worker { get; set; }
        public int WorkerId { get; set; }

        //One to Many Review - Comments
        public Review Review { get; set; }
        public int? ReviewId { get; set; }

        //One to Many Comment - Comments
        public ICollection<Comment> Comments { get; set; }
    }
}
