namespace WorkersList.DataAccessLayer.Entities
{
    public class WorkerPassword
    {
        public int Id { get; set; }
        public string HashedPassword { get; set; }
        public byte[] Salt { get; set; }


        //One to one Worker - Password
        public Worker Worker { get; set; }
        public int WorkerId { get; set; }
    }
}
