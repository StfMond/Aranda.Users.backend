﻿using System.Collections.Generic;

namespace Aranda.Users.BackEnd.Models
{
    public partial class Role
    {
        public Role()
        {
            RolePermission = new HashSet<RolePermission>();
            User = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RolePermission> RolePermission { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
