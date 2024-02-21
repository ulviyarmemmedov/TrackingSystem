using AutoMapper;
using TrackingSystem.Repository.IRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TrackingSystem.DAL;

namespace TrackingSystem.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly TrackingSystemDbContext _trackingSystemDbContext;
        

        // after identity         
        private readonly IMapper _mapper;
        

        
    }
}