﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TB.AspNetCore.Domain.Entitys
{
    public partial class SystemRoles
    {
        public SystemRoles()
        {
            BackstageUser = new HashSet<BackstageUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public virtual List<string> Menus { get; set; }
        public ICollection<BackstageUser> BackstageUser { get; set; }
    }
}
