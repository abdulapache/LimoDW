using Dataaccess.Entites;
using Dataaccess.IReprositiry;
using Dataaccess.Reprository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess.Reprositiry
{
    public class MenuRepo : Reprository<Menu>, IMenu
    {
        private readonly LimoDbContext db;
        public MenuRepo(LimoDbContext context) : base(context)
        {
            db = context;
        }
    }
}
