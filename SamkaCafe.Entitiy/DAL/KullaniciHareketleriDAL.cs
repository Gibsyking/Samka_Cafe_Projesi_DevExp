using SamkaCafe.Entitiy.Interfaces;
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
    public class KullaniciHareketleriDAL : EntityRepostoryBase<CafeContext, KullaniciHareketleri, KullaniciHareketleriValidator>
    {
        // public static int kulllaniciId { get; set; }
        public void KullaniciHareketleriEKLE(CafeContext context, KullaniciHareketleri kullaniciHareketleri, string aciklama)
        {
            KullaniciHareketleriDAL kullaniciHareketleriDAL = new KullaniciHareketleriDAL();
            kullaniciHareketleri.Tarih = DateTime.Now;
            kullaniciHareketleri.Aciklama = aciklama;
            if (kullaniciHareketleriDAL.AddOrUpdate(context, kullaniciHareketleri))
            {
                kullaniciHareketleriDAL.Save(context);
            }
        }
    }

}
