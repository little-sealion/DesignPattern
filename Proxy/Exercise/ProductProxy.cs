using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Proxy.Exercise
{
    public class ProductProxy : Product
    {
        private DbContext _dbContext;
        public ProductProxy(int id, DbContext dbContext) : base(id)
        {
            _dbContext = dbContext;
        }

        public override void SetName(string name)
        {
            Name = name;
            _dbContext.MarkAsChanged(this);
        }
    }
}