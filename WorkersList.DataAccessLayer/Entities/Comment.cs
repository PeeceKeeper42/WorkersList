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
        public int Liked { get; set; }
        public int Disliked { get; set; }
        public DateTimeOffset LastModifyInfoDate { get; set; }

        //One to Many Worker - Comments
        public Worker Worker { get; set; }
        public int WorkerId { get; set; }

        //One to Many Review - Comments
        public Review Review { get; set; }
        public int? ReviewId { get; set; }

        //One to Many Comment - Comments
        public ICollection<Comment> Comments { get; set; }
        public int? ParentCommentId { get; set; }
        public Comment ParentComment { get; set; }
    }
}
