using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneClient.ClientIslemleri
{
    public class Result<T>
    {
        public string  Mesage { get; set; }
        public T Data { get; set; }
    }
}
