using AutoMapper;
using TrackingSystem.Repository.IRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TrackingSystem.DAL;
using Microsoft.AspNetCore.Identity.Data;
using TrackingSystem.DTO;

namespace TrackingSystem.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly TrackingSystemDbContext _trackingSystemDbContext;
        
        // after identity         
        private readonly IMapper _mapper;
        public UserRepository(TrackingSystemDbContext trackingSystemDbContext, IMapper mapper)
        {
            _trackingSystemDbContext = trackingSystemDbContext;
            _mapper = mapper;
        }

        public bool IsUniqueUser(string username)
        {
            throw new NotImplementedException();
        }

        public Task LogIn(LogInRequestDto logInRequestDTO)
        {
            throw new NotImplementedException();
        }

        public Task Register(RegistrationRequestDTO logInRequestDTO)
        {
            throw new NotImplementedException();
        }
    }
}