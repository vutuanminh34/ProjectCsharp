using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ImportdetailObject
    {
        private string mapn, masp;
        private int slnhap;

        public ImportdetailObject()
        {
        }

        public ImportdetailObject(string mapn, string masp, int slnhap)
        {
            this.Mapn = mapn;
            this.Masp = masp;
            this.Slnhap = slnhap;
        }

        public string Mapn { get => mapn; set => mapn = value; }
        public string Masp { get => masp; set => masp = value; }
        public int Slnhap { get => slnhap; set => slnhap = value; }
    }
}
