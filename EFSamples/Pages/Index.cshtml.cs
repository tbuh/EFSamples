using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFSamples.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace EFSamples.Pages
{
    public class IndexModel : PageModel
    {
        private EntityContext entityContext;
        public IndexModel(EntityContext entityContext)
        {
            this.entityContext = entityContext;
        }
        public List<User> Users { get; set; }

        public void OnGet()
        {
            Users = entityContext.Users.FromSql("select * from users").Include(u => u.Organization).ToList();
        }
    }
}
