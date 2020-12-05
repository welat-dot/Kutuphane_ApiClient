using KutuphaneDataAccess.DatabaseIslemleri.Abstract;
using KutuphaneDataAccess.Model;
using KutuphaneDataAccess.Context;
using System.Linq;

namespace KutuphaneDataAccess.DatabaseIslemleri.Concreate
{
    public class YazarManager : IYazar
    {
        private KutuphaneContext kutuphaneContext;
        public YazarManager()
        {
            kutuphaneContext = new KutuphaneContext();
        }
        public Yazar Duzenle(Yazar yazar)
        {
            var result = kutuphaneContext.Set<Yazar>().Update(yazar);
            kutuphaneContext.SaveChanges();
            return result.Entity;
           

        }

        public Yazar Ekle(Yazar yazar)
        {
            
            var result = kutuphaneContext.Set<Yazar>().Add(yazar);
            kutuphaneContext.SaveChanges();           
            return result.Entity;
            
        }

        public IQueryable<Yazar> GetYazars()
        {
            return kutuphaneContext.Set<Yazar>();
            
        }
    }
}
