using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.OpenData.Paris.Data
{
    public class Fields : IFields
    {
        public string type_arr { get; set; }
        public double shape_area { get; set; }
        public int? arrdt { get; set; }
        public string reglement { get; set; }
        public int objectid { get; set; }
        public string date_arr { get; set; }
        public List<double> geo_point_2d { get; set; }
        public double shape_len { get; set; }
        public int stv { get; set; }
        public string nom_zca { get; set; }
        public GeoShape geo_shape { get; set; }
        public string type_de_poste_public { get; set; }
        public List<double> position { get; set; }
    }
}
