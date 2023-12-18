using System;

namespace HomeApi.Contracts.Models.Devices
{
    /// <summary>
    /// Удаляет устройство
    /// </summary>
    public class DeleteDeviceRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set;}
    }
}