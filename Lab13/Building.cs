using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Building
    {
        string adress;
        int dlina;
        int shirina;
        int visota;

        string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                adress = value;
            }
        }
        int Dlina
        {
            get
            {
                return dlina;
            }  
            set
            {
                if (value < 1)
                    dlina = 1;
                else
                    dlina = value;
            }
        }

        int Shirina
        {
            get
            {
                return shirina;
            }
            set
            {
                if (value < 1)
                    shirina = 1;
                else
                    shirina = value;
            }
        }
        int Visota
        {
            get
            {
                return visota;
            }
            set
            {
                if (value < 1)
                    visota = 1;
                else
                    visota = value;
            }
        }
        public Building (string adress, int dlina, int shirina, int visota)
        {
            this.Adress = adress;
            this.Dlina = dlina;
            this.Shirina = shirina;
            this.Visota = visota;
        }

        public string Print()
        {
            return $"Здание по адресу:" +
                $" {adress} имеет параметры:\nдлина - {dlina}, ширина - {shirina}, высота - {visota}";
        }
    }
}
