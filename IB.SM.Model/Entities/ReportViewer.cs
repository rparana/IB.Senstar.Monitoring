using System;

namespace IB.SM.Model.Entities
{
    public class ReportViewer
    {
        public string TipoRel { get; set; }
        public string Dt_Inicio { get; set; }
        public string Dt_Fim { get; set; }
        public DateTime Data_Hora { get; set; }
        public string Central { get; set; }
        public string Lado { get; set; }
        public string Zona { get; set; }
        public string Distancia { get; set; }
        public string Nota { get; set; }

        public ReportViewer()
        {
        }
    }
}
