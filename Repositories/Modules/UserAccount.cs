﻿using System;
using System.Collections.Generic;

namespace Repositories.Modules;

public partial class UserAccount
{
    public int UserId { get; set; }

    public string? Name { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
