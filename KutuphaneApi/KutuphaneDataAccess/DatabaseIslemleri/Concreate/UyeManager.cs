using KutuphaneDataAccess.Context;
using KutuphaneDataAccess.DatabaseIslemleri.Abstract;
using KutuphaneDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KutuphaneDataAccess.DatabaseIslemleri.Concreate
{
    public class UyeManager : IUye
    {
        private KutuphaneContext kutuphaneContext;
        public UyeManager()
        {
            kutuphaneContext = new KutuphaneContext();
        }
        public Uye Duzenle(Uye uye)
        {
            var result= kutuphaneContext.Set<Uye>().Update(uye).Entity;
            kutuphaneContext.SaveChanges();
            return result;
        }

        public Uye Ekle(Uye uye)
        {
            var result= kutuphaneContext.Set<Uye>().Add(uye).Entity;
            kutuphaneContext.SaveChanges();
            return result;
        }

        public IQueryable<Uye> GetUyes()
        {
            return kutuphaneContext.Set<Uye>();
        }

        public bool Sil(Uye uye)
        {
            try
            {
                kutuphaneContext.Set<Uye>().Remove(uye);
                kutuphaneContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
