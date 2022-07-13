
using WorkersList.CommonLayer.Enumerators;
using WorkersList.DataAccessLayer.Contexts;

namespace WorkersList.BusinessLogicLayer.Services
{
    public class CheckService
    {
        private readonly MainContext _mainContext;
        public CheckService(MainContext mainContext)
        {
            _mainContext = mainContext;
        }

        public async Task<bool> FirstNameCheck(Field field, string fieldValue)
        {
            switch(field)
            {
                case Field.FirstName:
                    {
                        
                        break;
                    }
            }
        }
    }
}
