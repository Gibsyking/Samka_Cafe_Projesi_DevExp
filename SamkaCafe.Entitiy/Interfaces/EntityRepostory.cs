using System;
using System.Collections.Generic;
using System.Data.Entity; // ENTİTİY KÜTÜPHANESİ İÇİN KULLANILIR.
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions; // LİNQ KÜTÜPHANESİ İÇİN KULLANILIR


namespace SamkaCafe.Entitiy.Interfaces
{
    public  interface EntityRepostory<TContex, TEntity>
        where TContex : DbContext, new()
        where TEntity : class,IEntity, new()
    {
        List<TEntity> GetAll(TContex contex, Expression<Func<TEntity, bool>> filter = null); // BU FONSİYON LİSTELEME İÇİN KULLANILIR. VE FİLTREME YAPAR BAŞLANGIÇ OLARAK NULL DEĞERİ ATANMIŞTIR.
        TEntity GetbyFilter(TContex contex, Expression<Func<TEntity, bool>> filter); // ENTİTY FİLTRELEMELERİ İÇİN KULLANILAN PARAMETRE.
        bool AddOrUpdate(TContex contex, TEntity entity); // EKLEME VE GÜNCELLEME İÇİN KULLANILAN PARAMETRE.
        void Delete(TContex contex, Expression<Func<TEntity, bool>> filter); // SİLME İÇİN KULLANILAN PARAMETRE
        void Save(TContex contex); // KAYDET İÇİN KULLANILAN PARAMETRE.
    }
}
