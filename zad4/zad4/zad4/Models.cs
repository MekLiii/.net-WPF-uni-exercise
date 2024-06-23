using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace VehicleCatalogApp.Models
{
    [XmlRoot("VehicleCatalog")]
    public class VehicleCatalog
    {
        [XmlArray("Categories")]
        [XmlArrayItem("Category")]
        public List<Category> Categories { get; set; } = new List<Category>();
    }

    public class Category
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        public string Description { get; set; }

        [XmlArray("Subcategories")]
        [XmlArrayItem("Subcategory")]
        public List<Subcategory> Subcategories { get; set; } = new List<Subcategory>();
    }

    public class Subcategory
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        public string Description { get; set; }
        public string ParentCompany { get; set; }
        public int Founded { get; set; }
        public string CountriesOfProduction { get; set; }

        [XmlArray("Models")]
        [XmlArrayItem("Model")]
        public List<Model> Models { get; set; } = new List<Model>();
    }

    public class Model
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Year")]
        public int Year { get; set; }

        [XmlAttribute("EngineCapacity")]
        public string EngineCapacity { get; set; }

        [XmlAttribute("DriveType")]
        public string DriveType { get; set; }
    }
}