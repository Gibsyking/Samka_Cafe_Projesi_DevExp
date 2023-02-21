using FluentValidation;
using SamkaCafe.Entitiy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamkaCafe.Entitiy.Validations
{
    public class SatislarValidator:AbstractValidator<Satislar>
    {
        public SatislarValidator()
        {
            RuleFor(p => p.SatisKodu).NotEmpty().WithMessage("Satis Kodu Boş geçilemez.");
        }
    }
}
