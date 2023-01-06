using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Enum
{
    internal interface IListe<T>
    {
        void Ekle(T model);
        List<T> Liste();
    }
}
