using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepository
{
    public interface IMerchantRepository
    {
        public Merchant create(Merchant obj);
        public Merchant update(Merchant obj);
        public bool Delete(Guid id);
        public List<Merchant> GetAll();
        public Merchant Get(Guid id);
    }
}
