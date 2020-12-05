using KutuphaneDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KutuphaneDataAccess.DatabaseIslemleri.Abstract
{
    public interface IYazar
    {
        Yazar Ekle(Yazar yazar);
        IQueryable<Yazar> GetYazars();
        Yazar Duzenle(Yazar yazar);
    }
}
