﻿
using UsedCars.Entities;

namespace UsedCars.Models
{
    public class VehicleEquipmentDto
    {
        public Guid VehicleId { get; set; }
        public Guid AdditionalEquipmentId { get; set; }

        //public AdditionalEquipment AdditionalEquipment { get; set; }

        //public Vehicle Vehicle { get; set; }

    }
}
