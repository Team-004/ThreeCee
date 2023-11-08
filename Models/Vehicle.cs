using System;
using System.Collections.Generic;

namespace ThreeCee.Models
{
    internal class Vehicle
    {
        public enum EFuelType
        {
            Gasoline, // Benzin
            Diesel,
            Electric
        }

        public string FuelTypeString() => FuelType switch {
            EFuelType.Gasoline => "Benzin", 
            EFuelType.Diesel => "Diesel",
            EFuelType.Electric => "Elektrisch",
            _ => throw new ArgumentOutOfRangeException(nameof(FuelType), FuelType, null)
        };

        public string StatusString() => Status switch {
            EStatus.Bought => "gekauft",
            EStatus.Leased => "geleast",
            _ => throw new ArgumentOutOfRangeException(nameof(Status), Status, null)
        };

        public enum EStatus
        {
            Bought, // gekauft
            Leased, // geleast
        }

        public string Model;
        public string Name;
        public EStatus Status;
        public EFuelType FuelType;
        public string Function;
        public float FuelConsumptionLPerKm;
        public float KilometersDriven;

        // Bsp.: Volkswagen T6 Transporter, Diesel, geleast von [Leasing-Unternehmen], Lieferung
        public Vehicle(
            string model,
            string name,
            EStatus status,
            EFuelType fuelType,
            string function,
            float fuelConsumptionLPerKm,
            float kilometersDriven
        )
        {
            Model = model;
            Name = name;
            Status = status;
            FuelType = fuelType;
            Function = function;
            FuelConsumptionLPerKm = fuelConsumptionLPerKm;
            KilometersDriven = kilometersDriven;
        }

        public static List<Vehicle> GetDummyVehicles() =>
            new List<Vehicle>
            {
                new Vehicle(
                    model: "VW T6 Transporter",
                    name: "Lieferwagen 1",
                    status: EStatus.Bought,
                    function: "Lieferung",
                    fuelType: EFuelType.Gasoline,
                    fuelConsumptionLPerKm: 0.07f,
                    kilometersDriven: 86000f
                ),
                new Vehicle(
                    model: "VW T6 Transporter",
                    name: "Lieferwagen 2",
                    status: EStatus.Leased,
                    function: "Lieferung",
                    fuelType: EFuelType.Gasoline,
                    fuelConsumptionLPerKm: 0.07f,
                    kilometersDriven: 55000f
                )
            };
    }
}
