using WorkersList.DataAccessLayer.Contexts;
using WorkersList.DataAccessLayer.Entities;

namespace WorkersList.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MainContext())
            {
                var worker = new Worker()
                {
                    Name = "Name1",
                    Surname = "Surname1",
                    Email = "Email1",
                    PhoneNumber = "+1",
                    JobPosition = "Senior"
                };
                var workerPassword = new WorkerPassword()
                {
                    HashedPassword = "stringpass1",
                    Salt = new byte[10]
                };
                worker.WorkerPassword = workerPassword;
                db.Workers.Add(worker);
                db.WorkerPasswords.Add(workerPassword);
                db.SaveChanges();
            }
        }
    }
}