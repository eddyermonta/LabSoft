
namespace LabSoft.Data.Negocio.Servicios
{
    public interface IUserService
    {
        List<ApplicationUser> GetUsers();
        ApplicationUser? GetUserById(int id);
        void AddUser(ApplicationUser user);
    }
}