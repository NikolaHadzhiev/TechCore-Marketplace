using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechCore.DataAccess.Repository.CategoryRepo;

namespace TechCore.DataAccess.Repository
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }

        void Save();
    }
}
