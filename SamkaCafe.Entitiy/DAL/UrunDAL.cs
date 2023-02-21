using SamkaCafe.Entitiy.Models;
using SamkaCafe.Entitiy.Repository;
using SamkaCafe.Entitiy.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamkaCafe.Entitiy.DAL
{
    public class UrunDAL : EntityRepostoryBase<CafeContext, Urun, UrunValidator>
    {
        public object Urunlistele(CafeContext context)
        {
            var liste = (from c in context.Urun select new
            {
                c.Id,
                c.MenuId,
                c.UrunKodu,
                c.UrunAdi,
                c.BirimFiyati1,
                c.BirimFiyati2, 
                c.BirimFiyati3,
                c.Aciklama,
                c.Tarih,
                c.Resim,
                Menu=c.Menu.MenuAdi
                
            }).ToList();
            return liste;
            
    
        }


    }
}
