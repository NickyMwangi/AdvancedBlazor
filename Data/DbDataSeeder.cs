using Newtonsoft.Json;
using Data.Models;

namespace Data
{
    public class DbDataSeeder
    {
        private readonly WebContext _db;
        public DbDataSeeder(WebContext db)
        {
            _db = db;
        }

        public void Seed ()
        {
            SeedMerchants();
        }

        public void SeedMerchants()
        {
            if (!_db.Merchants.Any())
            {
                var merchants = new List<Merchant>();
                using(StreamReader rdr = new StreamReader("./Data/json/_Merchant.json"))
                {
                    string jsn = rdr.ReadToEnd();
                    merchants =  JsonConvert.DeserializeObject<List<Merchant>>(jsn);
                }
                if (merchants != null && merchants.Count > 0)
                {
                    _db.Merchants.AddRange(merchants);
                    _db.SaveChanges();
                }
            }
        }
    }
}


