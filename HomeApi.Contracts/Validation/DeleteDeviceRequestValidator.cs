using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using HomeApi.Contracts.Models.Devices;

namespace HomeApi.Contracts.Validation
{
    /// <summary>
    /// Класс-валидатор запросов удаления устройства
    /// </summary>
    public class DeleteDeviceRequestValidator : AbstractValidator<DeleteDeviceRequest>
    {
        /// <summary>
        /// Метод, конструктор, устанавливающий правила
        /// </summary>
        public DeleteDeviceRequestValidator() 
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}