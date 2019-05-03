using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreDemos.Reporting.Vehicle {
    public class VehicleDataContext : DbContext {
        public VehicleDataContext(DbContextOptions<VehicleDataContext> options)
            :base(options) {
        }

        public DbSet<Model> Models { get; set; }
        public DbSet<Trademark> Trademarks { get; set; }
    }

    [Table("Model")]
    public class Model {
        public int ID { get; set; }
        public int TrademarkID { get; set; }
        public string Name { get; set; }
        public string Modification { get; set; }
        [Column("MPG City")]
        public int? MPGCity { get; set; }
        [Column("MPG Highway")]
        public int? MPGHighway { get; set; }
        public int Doors { get; set; }
        public int Cylinders { get; set; }
        public string Horsepower { get; set; }
        public string Torque { get; set; }
        [Column("Transmission Speeds")]
        public int TransmissionSpeeds { get; set; }
        [Column("Transmission Type")]
        public int TransmissionType { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
    }

    [Table("Trademark")]
    public class Trademark {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
