
namespace LabSoft.Data.Repositorio
{
    public class UserRespository : IUserRepository
    {
        private readonly MyDbContext _context;

        public UserRespository(MyDbContext context)
        {
            _context = context;
        }
        

        public void AddUser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser? GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ApplicationUser> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}