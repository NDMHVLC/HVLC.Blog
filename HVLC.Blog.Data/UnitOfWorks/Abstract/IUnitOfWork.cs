using HVLC.Blog.Core.Entities;
using HVLC.Blog.Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HVLC.Blog.Data.UnitOfWorks.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class, IEntity, new();

        Task<int> SaveAsync();

        int Save();
    }
}
