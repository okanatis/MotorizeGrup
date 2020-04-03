using System;
using System.Collections.Generic;
using System.Text;

namespace Motorize_Business.Repository.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;
        int SaveChanges();
    }
}
