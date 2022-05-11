using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetrolStationDB.Database;
using PetrolStationDB.Database.Models;
using PetrolStationDB.Services;
using Microsoft.EntityFrameworkCore;

namespace PetrolStationDB.Controllers
{
    public class PetrolStationController
    {
        public List<PetrolStationType> GetAllTypes(string search = "")
        {
            using (_ContextDb db = new _ContextDb())
            {
                if(search == "")
                {
                    return db.PetrolStationTypes.ToList();
                }
                else
                {
                    return db.PetrolStationTypes.Where(t => t.TypeName.ToLower().Contains(search.ToLower())).ToList();
                }
            }
        }

        public int GetMaxNumberStation()
        {
            int maxNumberStation = 0;

            using(_ContextDb db = new _ContextDb())
            {
                if(db.PetrolStations.ToList().Count > 0)
                {
                    maxNumberStation = db.PetrolStations.Max(p => p.NumberStation);
                }
            }

            return maxNumberStation;
        }

        public bool AddNewPetrolStation(
            string _num,
            Guid _guidType,
            string _location,
            string _user
        )
        {
            bool result = false;

            using (_ContextDb db = new _ContextDb())
            {
                PetrolStation ps = new PetrolStation
                {
                    Id = Guid.NewGuid(),
                    NumberStation = Convert.ToInt32(_num),
                    Location = _location,
                    PetrolStationTypeId = _guidType,
                    CreatedBy = _user,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = _user,
                    UpdatedDate = DateTime.Now
                };

                db.PetrolStations.Add(ps);
                db.SaveChanges();
                result = true;
            }
            return result;
        }
    }
}
