using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.DAL
{
    public interface IRepository<TEntity> where TEntity : class {AccountManager. }
    {
        public void Add(TEntity pEntity);
        public void Remove(TEntity pEntity);
        public TEntity Get(int pId);
        public IEnumerable<TEntity> GetAll();
            
       
}
