using KutuphaneDataAccess.Context;
using KutuphaneDataAccess.DatabaseIslemleri.Abstract;
using KutuphaneDataAccess.Model;
using KutuphaneDataAccess.Model.Response;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KutuphaneDataAccess.DatabaseIslemleri.Concreate
{
    public class KitapManager : IKitap
    {
        private KutuphaneContext kutuphaneContext;
        public KitapManager()
        {
            kutuphaneContext = new KutuphaneContext();
        }
        public Kitap Duzenle(Kitap kitap)
        {

            var result= kutuphaneContext.Set<Kitap>().Update(kitap).Entity;
            kutuphaneContext.SaveChanges();
            return result;

        }

        public Kitap Ekle(Kitap kitap)
        {
            var result =kutuphaneContext.Set<Kitap>().Add(kitap).Entity;
            kutuphaneContext.SaveChanges();
            return result;
        }

        public IQueryable<KitapResponse> GetKitaps()
        {

            var result = from kitap in kutuphaneContext.Set<Kitap>()
                         join yazar in kutuphaneContext.Set<Yazar>()
                             on kitap.yazar_id equals yazar.Id
                         
                         select new KitapResponse
                         {
                             Id =kitap.Id,
                             kitap_adi=kitap.kitap_adi,
                             sayfaSayisi =kitap.sayfaSayisi,
                             yazar = yazar.yazar_Ad_Soyad
                         };
            return result;

            //return kutuphaneContext.Set<Kitap>().Include(x => x.yazar);
        }

        public bool Sil(Kitap kitap)
        {
            try
            {
                kutuphaneContext.Set<Kitap>().Remove(kitap);
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
