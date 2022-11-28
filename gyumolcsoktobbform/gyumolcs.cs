using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyumolcsoktobbform
{
    internal class gyumolcs
    {
        int id;
        string name;
        double egysegAr;
        double mennyiseg;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double EgysegAr { get => egysegAr; set => egysegAr = value; }
        public double Mennyiseg { get => mennyiseg; set => mennyiseg = value; }

        public gyumolcs(int id, string name, double egysegAr, double mennyiseg)
        {
            Id = id;
            Name = name;
            EgysegAr = egysegAr;
            Mennyiseg = mennyiseg;
        }

        public override string ToString()
        {
            return name + " " + mennyiseg + " " + egysegAr;
        }
    }
}
