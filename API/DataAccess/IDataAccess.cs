using API.Models;

namespace API.DataAccess
{
    public interface IDataAccess
    {
        int CreateUser(User user);
        bool IsEmailAvailable(string email);

        //Function
    }
}
