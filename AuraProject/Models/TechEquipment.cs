using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuraProject.Models
{
    public class TechEquipment
    {
        public string Name { get; set; }

        public static IEnumerable<TechEquipment> GetElement()
        {
            return new List<TechEquipment>
            {
                new TechEquipment {Name = "Rekawiczki" },
                new TechEquipment {Name = "Kask" },
                new TechEquipment {Name = "Okulary" },
                new TechEquipment {Name = "Buty" },
                new TechEquipment {Name = "Woda" }
            };
        }
    }
}