using Dataaccess.Entites;
using Dataaccess.Reprositiry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LimoDbContext db;
        public UnitOfWork(LimoDbContext context)
        {
            db = context;

            MenuRepo = new MenuRepo(db);
            SubMenuRepo = new SubMenuRepo(db);
        }
        public MenuRepo MenuRepo { get; private set; } 
        public SubMenuRepo SubMenuRepo { get; private set; }
        public void save()
        {
            db.SaveChanges();
        }
    }
}
