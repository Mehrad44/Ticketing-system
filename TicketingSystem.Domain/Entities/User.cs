using System;
using System.Collections.Generic;
using System.Text;
using TicketingSystem.Domain.Common;

namespace TicketingSystem.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }
        public bool IsAdmin { get; private set; }

        private User() { }

        public User(string fullName, string email, string passwordHash, bool isAdmin = false)
        {
            FullName = fullName;
            Email = email;
            PasswordHash = passwordHash;
            IsAdmin = isAdmin;
        }
    }
}
