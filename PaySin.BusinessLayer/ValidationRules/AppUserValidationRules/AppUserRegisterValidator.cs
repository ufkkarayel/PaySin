using FluentValidation;
using PaySin.DtoLayer.Dtos.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySin.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithErrorCode("İsim alanı boş bırakılamaz!");
            RuleFor(x => x.Surname).NotEmpty().WithErrorCode("Soyisim alanı boş bırakılamaz!");
            RuleFor(x => x.Username).NotEmpty().WithErrorCode("Kullanıcı adı boş bırakılamaz!");
            RuleFor(x => x.Email).NotEmpty().WithErrorCode("Mail alanı boş bırakılamaz!");
            RuleFor(x => x.Password).NotEmpty().WithErrorCode("Parola boş bırakılamaz!");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithErrorCode("Parola tekrarı boş bırakılamaz!");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter giriniz.");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen en az 2 karakter giriniz.");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Parolalarınız eşleşmemektedir.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz.");

        }
    }
}
