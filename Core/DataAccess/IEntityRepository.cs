using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
    
        //T ile çalışılacak tip belirlenir.
        //Filtre vermek için linq ile yapılabilecek ortam : expression
        //Filter=null -> Filtre vermeyebilirsin demek.
        //T'yi kısıtlamak isteriz.Bizim istediğimiz türde parametre yollansın.
        //T bize veri tabanı nesnelerinden gelir.
        //Generic Constraint : Generic Kısıtlama 
        //where T: Class(Referans Tip demek) , Ya IEntity yada ondan implemente olabilir, Newlenebilir.
        //Newlenebilir dediğimiz için IEntity'i alamaz sadece implementelerini alır.


        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter); //Tek bir data detayına gitmek için
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        
    }
}
