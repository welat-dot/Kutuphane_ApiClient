using KutuphaneDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KutuphaneDataAccess.DatabaseIslemleri.Abstract
{
    public interface IUye
    {
        Uye Ekle(Uye uye);
        bool Sil(Uye uye);
        Uye Duzenle(Uye uye);
        IQueryable<Uye> GetUyes();
    }
}
