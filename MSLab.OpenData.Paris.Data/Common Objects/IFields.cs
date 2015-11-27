using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.OpenData.Paris.Data
{
    public interface IFields
    {
        string type_arr { get; set; }
        double shape_area { get; set; }
        int? arrdt { get; set; }
        string reglement { get; set; }
        int objectid { get; set; }
        string date_arr { get; set; }
        List<double> geo_point_2d { get; set; }
        double shape_len { get; set; }
        int stv { get; set; }
        string nom_zca { get; set; }
        GeoShape geo_shape { get; set; }
        string type_de_poste_public { get; set; }
        List<double> position { get; set; }

    }
}
