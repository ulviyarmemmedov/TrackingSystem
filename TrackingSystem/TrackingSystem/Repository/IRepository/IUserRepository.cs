using TrackingSystem.DTO;

namespace TrackingSystem.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task LogIn(LogInRequestDto logInRequestDTO);
        Task Register(RegistrationRequestDTO logInRequestDTO);
    }
}
