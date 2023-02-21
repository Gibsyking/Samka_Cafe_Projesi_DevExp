using FluentValidation;
using SamkaCafe.Entitiy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamkaCafe.Entitiy.Validations
{
    public class MenuValidator : AbstractValidator<Menu>
    {
        public MenuValidator()
        {
            RuleFor(p => p.MenuAdi).NotEmpty().WithMessage("Menu Adı Boş geçilemez.");
            RuleFor(p => p.MenuAdi).MinimumLength(3).WithMessage("Menu Adı Alanı En Az 3 Karakterden Oluştur.");
            RuleFor(p => p.MenuAdi).MaximumLength(12).WithMessage("Menu Adı Alanı En Fazla 12 Karakterden Oluştur.");
        }
    }
}
