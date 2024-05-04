using Dataaccess.Entites;
using Dataaccess.Reprositiry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess
{
    public interface IUnitOfWork
    {
        public void save();

        public MenuRepo MenuRepo { get; }

        public SubMenuRepo SubMenuRepo { get; }
    }
}
