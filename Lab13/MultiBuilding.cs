using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    sealed class MultiBuilding:Building
    {
        int floor;

        int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                floor = value;
            }
        }
        public MultiBuilding(string adress, int dlina, int shirina, int visota, int floor) : base(adress, dlina, shirina, visota)
        {
            this.Floor = floor;
        }

        public string Print()
        {
            string rez = base.Print();
            rez += $", этажность - {floor}";
            return rez;
        }
    }
}
