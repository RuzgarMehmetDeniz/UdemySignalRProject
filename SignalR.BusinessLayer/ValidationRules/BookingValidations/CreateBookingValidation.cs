using FluentValidation;
using SignalR.DtoLayer.BookingDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.ValidationRules.BookingValidations
{
    public class CreateBookingValidation : AbstractValidator<CreateBookingDto>
    {
        public CreateBookingValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez!");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon Boş Geçilemez!");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez!");
            RuleFor(x => x.PersonCount).NotEmpty().WithMessage("Kişi Alanı Boş Geçilemez!");
            RuleFor(x => x.Date).NotEmpty().WithMessage("Tarih Alanı Boş Geçilemez Lütfen Tarih Alanı Seçiniz!");

            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Lütfen İsim Alanını en az 5 karakter veri girişi yapınız!");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Lütfen İsim Alanını en fazla 50 karakter veri girşi yapınız!");
            RuleFor(x => x.Description).MaximumLength(500).WithMessage("Lütfen Açıklama Alanına En Fazla 500 Karakter Girişi Yapınız");

            RuleFor(x => x.Mail).EmailAddress().WithMessage("Lütfen Geçerli Bir Email Adresi Giriniz");
        }
    }
}
