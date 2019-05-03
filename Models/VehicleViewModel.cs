using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace AspNetCoreDemos.Reporting.Vehicle {
    public static class VehicleDataContextExtensions {
        public static IList<VehicleViewModel> Get(this VehicleDataContext dataContext) {
            return dataContext.Models
                .Join(
                        dataContext.Trademarks,
                        m => m.TrademarkID,
                        t => t.ID,
                        (m, t) => new VehicleViewModel {
                            ID = m.ID,
                            Name = m.Name,
                            Modification = m.Modification,
                            MPGCity = m.MPGCity,
                            MPGHighway = m.MPGHighway,
                            Doors = m.Doors,
                            Cylinders = m.Cylinders,
                            Horsepower = m.Horsepower,
                            Torque = m.Torque,
                            TransmissionSpeeds = m.TransmissionSpeeds,
                            TransmissionType = m.TransmissionType,
                            Description = m.Description,
                            Photo = m.Photo,
                            Trademark = t.ID,
                            TrademarkName = t.Name
                        }
                )
                .ToList();
        }
    }

    public class VehicleViewModel {
        public int ID { get; set; }
        public int Trademark { get; set; }
        public string Name { get; set; }
        public string Modification { get; set; }
        [DisplayName("MPG @ City")]
        public int? MPGCity { get; set; }
        [DisplayName("MPG @ Highway")]
        public int? MPGHighway { get; set; }
        public int Doors { get; set; }
        public int Cylinders { get; set; }
        public string Horsepower { get; set; }
        public string Torque { get; set; }
        [DisplayName("Transmission Speeds")]
        public int TransmissionSpeeds { get; set; }
        [DisplayName("Transmission Type")]
        public int TransmissionType { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
        [DisplayName("Trademark Name")]
        public string TrademarkName { get; set; }
    }
}
