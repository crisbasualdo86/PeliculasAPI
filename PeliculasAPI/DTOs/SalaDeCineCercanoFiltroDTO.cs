using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.DTOs
{
    public class SalaDeCineCercanoFiltroDTO
    {
        private int distanciaEnKms = 10;
        private int distanciaMaximaKms = 50;

        [Range(-90, 90)]
        public double Latitud { get; set; }
        [Range(-180, 180)]
        public double Longitud { get; set; }  
        public int DistanciaEnKms
        {
            get
            {
                return distanciaEnKms;
            }
            set
            {
                distanciaEnKms = (value > distanciaMaximaKms) ? distanciaMaximaKms : value;
            }
        }
    }
}
