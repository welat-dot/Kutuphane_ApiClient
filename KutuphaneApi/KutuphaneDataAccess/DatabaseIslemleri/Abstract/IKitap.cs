using KutuphaneDataAccess.Model;
using KutuphaneDataAccess.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KutuphaneDataAccess.DatabaseIslemleri.Abstract
{
    public interface IKitap
    {
        Kitap Ekle(Kitap kitap);
        bool Sil(Kitap kitap);
        Kitap Duzenle(Kitap kitap);
        IQueryable<KitapResponse> GetKitaps();
    }
}
