using System.IO;
using System.Xml.Serialization;
using VehicleCatalogApp.Models;

namespace VehicleCatalogApp.Data
{
    public static class DataLoader
    {
        public static VehicleCatalog LoadData(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(VehicleCatalog));
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                return (VehicleCatalog)serializer.Deserialize(fs);
            }
        }
    }
}