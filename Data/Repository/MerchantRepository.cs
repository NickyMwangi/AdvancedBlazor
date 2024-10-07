using Data.IRepository;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class MerchantRepository : IMerchantRepository
    {
        private readonly WebContext _db;
        public MerchantRepository(WebContext db)
        {
            _db = db; 
        }
        public Merchant create(Merchant obj)
        {
            _db.Add(obj);
            _db.SaveChanges();
            return obj;
        }

        public bool Delete(Guid id)
        {
            var obj = _db.Merchants.First(n => n.Id == id);
            if (obj == null) {
                _db.Merchants.Remove(obj);
                return _db.SaveChanges() > 0;
            }
            return false;
        }

        public Merchant Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Merchant> GetAll()
        {
            return _db.Merchants.ToList();   
        }

        public Merchant update(Merchant obj)
        {
            throw new NotImplementedException();
        }
    }
}
