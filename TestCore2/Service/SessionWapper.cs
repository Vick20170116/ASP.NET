using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using TestCore2.Models;

namespace TestCore2.Service
{
    public class ISessionWapper
    {
        public UserModel User { get; set; }
    }
    public class SessionWapper : ISessionWapper
    {
        private static readonly string _userKey = "session.user";
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SessionWapper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        private ISession Session => _httpContextAccessor.HttpContext.Session;

        public UserModel User
        {
            get => Session.GetObject<UserModel>(_userKey);
            set => Session.SetObject(_userKey, value);
        }
    }
}
