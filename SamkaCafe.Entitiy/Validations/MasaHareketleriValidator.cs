using FluentValidation;
using SamkaCafe.Entitiy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamkaCafe.Entitiy.Validations
{
    public class MasaHareketleriValidator:AbstractValidator<MasaHareketleri>
    {
        public MasaHareketleriValidator()
        {
            RuleFor(p => p.SatisKodu).NotEmpty().WithMessage("Satış Kodu Alanı Boş Geçilemez.");
            RuleFor(p => p.SatisKodu).Length(15).WithMessage("Maximum 15 Karakter Kullanılabilir");
            RuleFor(p => p.Miktari).NotEmpty().WithMessage("Miktar Boş geçilemez.");
            RuleFor(p => p.Miktari).GreaterThan(0).WithMessage("Miktar  Boş geçilemez.");
            RuleFor(p => p.BirimFiyatı).NotEmpty().WithMessage("Birim Fiyatı Boş geçilemez.");
            RuleFor(p => p.BirimFiyatı).LessThanOrEqualTo(150).WithMessage("Birim Fiyatı En fazla 150 dir.");

        }
    }
}
