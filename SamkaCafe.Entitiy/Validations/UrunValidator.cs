using FluentValidation;
using SamkaCafe.Entitiy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamkaCafe.Entitiy.Validations
{
    public class UrunValidator:AbstractValidator<Urun>
    {
        public UrunValidator()
        {
            RuleFor(p => p.UrunKodu).NotEmpty().WithMessage("Ürün Kodu Alanı Boş Geçilemez.");
            RuleFor(p => p.UrunAdi).NotEmpty().WithMessage("Ürün Adı Alanı Boş Geçilemez.");
            RuleFor(p => p.BirimFiyati1).GreaterThan(0).WithMessage("BirimFiyatı1 Boş geçilemez.");
            RuleFor(p => p.BirimFiyati2).GreaterThan(0).WithMessage("BirimFiyatı2  Boş geçilemez.");
            RuleFor(p => p.BirimFiyati3).GreaterThan(0).WithMessage("BirimFiyatı3  Boş geçilemez.");

        }
    }
}
