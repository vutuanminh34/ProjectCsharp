using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DegreeObject
    {
        private string maTD, tenTD;

        public DegreeObject() { }
        public DegreeObject(string maTD, string tenTD)
        {
            MaTD = maTD;
            TenTD = tenTD;
        }

        public string MaTD { get => maTD; set => maTD = value; }
        public string TenTD { get => tenTD; set => tenTD = value; }
    }
}
