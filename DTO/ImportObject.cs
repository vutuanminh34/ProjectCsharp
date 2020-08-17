using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ImportObject
    {
        private string mapn, ngaylappn, manvpn, manccpn;

        public ImportObject() { }
        public ImportObject(string mapn, string ngaylappn, string manvpn, string manccpn)
        {
            this.Mapn = mapn;
            this.Ngaylappn = ngaylappn;
            this.Manvpn = manvpn;
            this.Manccpn = manccpn;
        }

        public string Mapn { get => mapn; set => mapn = value; }
        public string Ngaylappn { get => ngaylappn; set => ngaylappn = value; }
        public string Manvpn { get => manvpn; set => manvpn = value; }
        public string Manccpn { get => manccpn; set => manccpn = value; }
    }
}
