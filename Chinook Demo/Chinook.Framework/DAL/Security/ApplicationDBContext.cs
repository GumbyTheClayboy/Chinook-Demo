using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Chinook.Framework.Entities.Security;

namespace Chinook.Framework.DAL.Security
{
    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDBContext()
            : base("DefaultConnection")
        {
        }
    }
}
