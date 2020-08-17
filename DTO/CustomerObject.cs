using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerObject
    {
        private string makh, tenkh, nskh, gtkh, scmtkh, dckh, sdtkh;

        public CustomerObject()
        {
        }

        public CustomerObject(string makh, string tenkh, string nskh, string gtkh, string scmtkh, string dckh, string sdtkh)
        {
            this.Makh = makh;
            this.Tenkh = tenkh;
            this.Nskh = nskh;
            this.Gtkh = gtkh;
            this.Scmtkh = scmtkh;
            this.Dckh = dckh;
            this.Sdtkh = sdtkh;
        }

        public string Makh { get => makh; set => makh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Nskh { get => nskh; set => nskh = value; }
        public string Gtkh { get => gtkh; set => gtkh = value; }
        public string Scmtkh { get => scmtkh; set => scmtkh = value; }
        public string Dckh { get => dckh; set => dckh = value; }
        public string Sdtkh { get => sdtkh; set => sdtkh = value; }
    }
}
