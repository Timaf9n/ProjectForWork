using DocumentFormat.OpenXml.EMMA;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectForWork.Models
{
    public class Brand
    {
        public int id { get; set; }
        [Column("Brand")]
        public string Name { get; set; }


        public List<Model> Models { get; set; }
        //public List<ModelCar> ModelCars { get; set; } = new List<ModelCar>();

    }
}
