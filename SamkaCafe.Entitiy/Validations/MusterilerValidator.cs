using FluentValidation;
using SamkaCafe.Entitiy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamkaCafe.Entitiy.Validations
{
    public class MusterilerValidator: AbstractValidator<Musteriler>
    {
        public MusterilerValidator()
        {
            RuleFor(p => p.AdiSoyadi).NotEmpty().WithMessage("Ad Soyad Alanı Boş Geçilemez.");
            RuleFor(p => p.Telefon).NotEmpty().WithMessage("Telefon Alanı Boş Geçilemez.");


        }
    }
}
