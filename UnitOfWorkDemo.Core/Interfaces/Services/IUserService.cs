using Models.Entities;
using Models.InputDtos;

namespace Abstractions.Interfaces.Services
{
    public interface IUserService
    {
        Task<bool> Create(CreateUserDto dto);

        Task<IEnumerable<User>> GetAll();
    }
}
