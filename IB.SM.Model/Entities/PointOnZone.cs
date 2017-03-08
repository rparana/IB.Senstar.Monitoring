using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB.SM.Model.Entities
{
    public class PointOnZone
    {
        private double _y2, _dy, _dx, _fe, _dxp, _dyp;
        public PointOnZone()
        { }

        public int zoneID { get; set; }
        public double dist { get; set; }
        public double ini { get; set; }
        public double fim { get; set; }
        public float x1 { get; set; }
        public float x2 { get; set; }
        public float y1 { get; set; }
        public float y2 { get; set; }

        private double dx
        {
            get
            {
                _dx = x2 - x1;
                return _dx;
            }
        }

        private double dy
        {
            get
            {
                _dy = y2 - y1;
                return _dy;
            }
        }

        private double fe
        {
            get
            {
                _fe = (dist - ini) / (fim - ini);
                return _fe;
            }
        }

        private double dxp
        {
            get
            {
                _dxp = fe * dx;
                return _dxp;
            }

        }
        private double dyp
        {
            get
            {
                _dyp = fe * dy;
                return _dyp;
            }

        }

        public float xp
        {
            get
            {
                return float.Parse((x1 + dxp).ToString());
            }
        }

        public float yp
        {
            get
            {
                return float.Parse((y1 + dyp).ToString());
            }
        }
    }
}
