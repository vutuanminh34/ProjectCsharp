using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StaffObject
    {
        private string manv, tennv,ngaysinhnv, gioitinhnv, socmtnv, diachinv, sdtnv, trinhdonv;
        

        public StaffObject() { }
        public StaffObject(string diachinv, string gioitinhnv, string manv, string ngaysinhnv, string sdtnv, string socmtnv, string tennv, string trinhdonv)
        {
            Diachinv = diachinv;
            Gioitinhnv = gioitinhnv;
            Manv = manv;
            Ngaysinhnv = ngaysinhnv;
            Sdtnv = sdtnv;
            Socmtnv = socmtnv;
            Tennv = tennv;
            Trinhdonv = trinhdonv;
        }

        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Ngaysinhnv { get => ngaysinhnv; set => ngaysinhnv = value; }
        public string Gioitinhnv { get => gioitinhnv; set => gioitinhnv = value; }
        public string Socmtnv { get => socmtnv; set => socmtnv = value; }
        public string Diachinv { get => diachinv; set => diachinv = value; }
        public string Sdtnv { get => sdtnv; set => sdtnv = value; }
        public string Trinhdonv { get => trinhdonv; set => trinhdonv = value; }
    }
}
