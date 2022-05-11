using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetrolStationDB.Database.Base;

namespace PetrolStationDB.Database.Models
{
    [Table("petrol_station")]
    public class PetrolStation: BaseEntity
    {
        [Column("number_station", Order = 1)]
        public int NumberStation { get; set; }

        [Column("location", Order = 2)]
        public string Location { get; set; }

        [Column("petrol_station_type_id", Order = 3)]
        public Guid PetrolStationTypeId { get; set; }
        public PetrolStationType PetrolStationType { get; set; }
    }
}
