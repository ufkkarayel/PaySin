using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySin.BusinessLayer.Abstract
{
    public interface IGenericServices<T> where T : class
    {
        void TInsert(T t);
        void TUpdate(T t);
        void TDelete(T t);
        T TGetByID(int id);
        List<T> TGetAll();
    }
}
