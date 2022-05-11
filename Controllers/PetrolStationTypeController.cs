﻿using System;
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
    public class PetrolStationTypeController
    {
        public List<PetrolStationType> GetAllTypes(string search = "", string field = "")
        {
            List<PetrolStationType> result = null;

            using (_ContextDb db = new _ContextDb())
            {
                if(search == "")
                {
                    result = db.PetrolStationTypes.ToList();
                }
                else
                {
                    switch (field)
                    {
                        case "common":
                            result = db.PetrolStationTypes
                                .Where(
                                    psType => psType.TypeName.ToLower().Contains(search.ToLower()) 
                                    || psType.CreatedBy.ToLower().Contains(search.ToLower())
                                    || psType.UpdatedBy.ToLower().Contains(search.ToLower())
                                    || psType.CreatedDate.ToString().ToLower().Contains(search.ToLower())
                                    || psType.UpdatedDate.ToString().ToLower().Contains(search.ToLower())
                                ).ToList();
                            break;

                        case "typename":
                            result = db.PetrolStationTypes.Where(psType => psType.TypeName.ToLower().Contains(search.ToLower())).ToList();
                            break;

                        case "userBy":
                            result = db.PetrolStationTypes
                                .Where(psType => psType.CreatedBy.ToLower().Contains(search.ToLower()) || psType.UpdatedBy.ToLower().Contains(search.ToLower())).ToList();
                            break;

                        case "date":
                            result = db.PetrolStationTypes
                                .Where(psType => psType.CreatedDate.ToString().ToLower().Contains(search.ToLower()) || psType.UpdatedDate.ToString().ToLower().Contains(search.ToLower())).ToList();
                            break;

                        default:
                            result = db.PetrolStationTypes.ToList();
                            break;
                    }
                }
            }
            return result;
        }

        public bool SaveChangesSingleType(Guid _id, string _typeName, string _user)
        {
            bool result = false;
            PetrolStationType psType = null;

            using (_ContextDb db = new _ContextDb())
            {
                psType = db.PetrolStationTypes.FirstOrDefault(ps => ps.Id == _id);
                if(psType != null)
                {
                    psType.TypeName = _typeName;
                    psType.UpdatedBy = _user;
                    psType.UpdatedDate = DateTime.Now;
                    db.PetrolStationTypes.Update(psType);
                    db.SaveChanges();

                    result = true;
                }
            }
            return result;
        }

        public bool DeleteSingleType(Guid _id)
        {
            bool result = false;
            PetrolStationType psType = null;

            using(_ContextDb db = new _ContextDb())
            {
                psType = db.PetrolStationTypes.FirstOrDefault(ps => ps.Id == _id);
                if( psType != null)
                {
                    db.PetrolStationTypes.Remove(psType);
                    db.SaveChanges();
                    result = true;
                }
            }
            return result;
        }

        public bool AddSingleType(string _typename, string _user)
        {
            bool isAdd = false;
            Guid guid;

            using (_ContextDb db = new _ContextDb())
            {
                PetrolStationType psType = new PetrolStationType
                {
                    Id = Guid.NewGuid(),
                    TypeName = _typename,
                    CreatedBy = _user,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = _user,
                    UpdatedDate = DateTime.Now
                };

                guid = psType.Id;

                db.PetrolStationTypes.Add(psType);
                db.SaveChanges();
            }

            using (var db = new _ContextDb())
            {
                if(db.PetrolStationTypes.Any(ps => ps.Id == guid)) { isAdd = true; }
            }

            return isAdd;
        }
    }
}
