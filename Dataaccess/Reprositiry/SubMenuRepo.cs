using Dataaccess.Entites;
using Dataaccess.IReprositiry;
using Dataaccess.Reprository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess.Reprositiry
{
    public class SubMenuRepo : Reprository<SubMenu>, ISubMenu
    {
        private readonly LimoDbContext db;
        public SubMenuRepo(LimoDbContext context) : base(context)
        {
            db = context;
        }
    }
}
