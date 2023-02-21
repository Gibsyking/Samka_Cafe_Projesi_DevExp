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
    public class MasalarDAL: EntityRepostoryBase<CafeContext,Masalar,MasalarValidator>
    {
        public object MasalariListele(CafeContext context)
        {
            /// İNNER JOİN İLE KULLANICI İLE MASALARI BİRBİRİNE BAĞLAMA VE MASALARA EKLEME İŞLEMİ YAPMA.
           
            var model = (from masa in context.Masalar join k in context.Kullanicilar on masa.KullaniciId equals k.Id into kullanici from kullanicimasa in kullanici.DefaultIfEmpty()  select new
            {
                masa.Aciklama,
                masa.Durumu,
                masa.EklenmeTarihi,
                masa.Id,
                masa.Islem,
                masa.MasaAdi,
                masa.RezerveMi,
                masa.SonIslemTarihi,
               Kullanici=kullanicimasa.KullaniciAdi // GİRDCONTROL ÜZERİNDEKİ DİZAYNA EKLENECEK. CAPTİON ALTINA. BU YENİ İSİM FİELD NAME İÇERİSİNE
            }).ToList();
            return model;
        }
    }
}
