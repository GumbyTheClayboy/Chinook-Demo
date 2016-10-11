﻿using Chinook.Framework.DAL.Security;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RoleManager : RoleManager<IdentityRole>
{
    public RoleManager()
        : base(new RoleStore<IdentityRole>(new ApplicationDBContext()))
    {
    }
}
