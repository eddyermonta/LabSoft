
namespace LabSoft.Data.Repositorio
{
    public interface IUserRepository
    {
        List<ApplicationUser> GetUsers();
        ApplicationUser? GetUserById(int id);
        void AddUser(ApplicationUser user);
    }
}