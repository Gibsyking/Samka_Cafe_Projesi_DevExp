using FluentValidation;
using SamkaCafe.Entitiy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamkaCafe.Entitiy.Validations
{
    public class KullanicilarValidator : AbstractValidator<Kullanicilar>
    {
        public KullanicilarValidator()
        {
            RuleFor(p => p.AdSoyad).NotEmpty().WithMessage("Ad Soyad Alanı Boş Geçilemez.");
            RuleFor(p => p.KullaniciAdi).NotEmpty().WithMessage("Kullanıcı Adı Boş geçilemez.");
            RuleFor(p => p.KullaniciAdi).MinimumLength(1).WithMessage("Kullanıcı Adı en az '1' karakterden oluşmalıdır.");
            RuleFor(p => p.KullaniciAdi).MaximumLength(20).WithMessage("Kullanıcı Adı en fazla '20' karakterden oluşmalıdır.");
            RuleFor(p => p.Parola).NotEmpty().WithMessage("Parola Boş geçilemez.");
            RuleFor(p => p.Parola).MinimumLength(1).WithMessage("Parolanız en az '1' karakterden oluşmalıdır.");
            RuleFor(p => p.Parola).MaximumLength(20).WithMessage("Parolanız en fazla '20' karakterden oluşmalıdır.");
            RuleFor(p => p.Telefon1).NotEmpty().WithMessage("Telefon Boş geçilemez.");
            RuleFor(p => p.Email).NotEmpty().WithMessage("E mail Boş geçilemez.");
            RuleFor(p => p.Email).EmailAddress().WithMessage("E mail Formatı Yanlış Lütfen Düzeltin.");

        }
    }
}
