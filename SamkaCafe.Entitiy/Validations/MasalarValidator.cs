using FluentValidation;
using SamkaCafe.Entitiy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamkaCafe.Entitiy.Validations
{
    public class MasalarValidator : AbstractValidator<Masalar>
    {
        public MasalarValidator()
        {
            RuleFor(p => p.MasaAdi).NotEmpty().WithMessage("Masa Adı Boş geçilemez.");
          //  RuleFor(p => p.).NotEmpty().WithMessage("Miktar Boş geçilemez.");
        }
    }
}
