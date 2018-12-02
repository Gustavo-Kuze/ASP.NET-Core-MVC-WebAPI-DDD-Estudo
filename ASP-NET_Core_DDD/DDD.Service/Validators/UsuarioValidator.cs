using DDD.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Service.Validators
{
    public class UsuarioValidator : AbstractValidator<User>
    {
        public UsuarioValidator()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("O objeto não pode ser encontrado");
                    });

            RuleFor(c => c.Cpf)
                .NotEmpty().WithMessage("É necessário informar o CPF.")
                .NotNull().WithMessage("É necessário informar o CPF.");

            RuleFor(c => c.BirthDate)
                .NotEmpty().WithMessage("É necessário informar a Data de nascimento.")
                .NotNull().WithMessage("É necessário informar a Data de nascimento.");

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("É necessário informar o nome.")
                .NotNull().WithMessage("É necessário informar o nome.");
        }
    }
}
