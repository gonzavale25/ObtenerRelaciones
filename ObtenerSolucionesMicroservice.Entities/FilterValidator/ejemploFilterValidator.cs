using FluentValidation;
using ObtenerSolucionesMicroservice.Entities.Filter;
using ObtenerSolucionesMicroservice.Entities.Model;

namespace ObtenerSolucionesMicroservice.Entities.FilterValidator
{
    public class ejemploUpdateDtoValidator : AbstractValidator<ejemploEntity>
    {
        public ejemploUpdateDtoValidator()
        {
            //  RuleFor(x => x.ID)
            //.Must(id => int.TryParse(id.ToString(), out _))
            //.WithMessage("El campo ID debe ser un número.");
            //  RuleFor(x => x.Email)
            //   .NotEmpty().WithMessage("El campo no puede ser vacío")
            //   .EmailAddress().WithMessage("Formato de correo electrónico inválido");
            //  RuleFor(x => x.Edad)
            //.GreaterThan(0).WithMessage("La edad debe ser mayor que cero");
        }
    }
    public class ejemploCreateDtoValidator : AbstractValidator<ejemploCreateDto>
    {
        public ejemploCreateDtoValidator()
        {
            RuleFor(x => x.Email)
             .NotEmpty().WithMessage("El campo no puede ser vacío")
             .EmailAddress().WithMessage("Formato de correo electrónico inválido");
            RuleFor(x => x.Edad)
            .GreaterThan(0).WithMessage("La edad debe ser mayor que cero");
            RuleFor(x => x.Nombre)
                  .NotEmpty().WithMessage("El campo no puede ser vacío");
        }
    }
}
