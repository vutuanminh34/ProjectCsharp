using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class DistributorBUS
    {
        public static List<DistributorObject> getDistributors()
        {
            DBDataContext data = new DBDataContext();
            List<DistributorObject> lst = null;
            lst = (from dis in data.tbldistributor8s
                   select new DistributorObject
                   {
                       Distributor_id = dis.distributor_id,
                       Distributor_name = dis.distributor_name,
                       Distributor_address = dis.distributor_address,
                       Distributor_email = dis.distributor_email,
                       Distributor_phone = dis.distributor_phone,
                   }).ToList();
            return lst;
        }
        public static List<DistributorObject> findDistributor(DistributorObject obj)
        {
            DBDataContext data = new DBDataContext();
            List<DistributorObject> lst = null;
            lst = (from dis in data.tbldistributor8s
                   where dis.distributor_id == obj.Distributor_id
                   select new DistributorObject
                   {
                       Distributor_id = dis.distributor_id,
                       Distributor_name = dis.distributor_name,
                       Distributor_address = dis.distributor_address,
                       Distributor_email = dis.distributor_email,
                       Distributor_phone = dis.distributor_phone,
                   }).ToList();
            return lst;
        }
        public static bool isExistingname(DistributorObject dobj)
        {
            DBDataContext data = new DBDataContext();
            List < DistributorObject > lst = null;
            lst = (from dis in data.tbldistributor8s
                   where dis.distributor_name == dobj.Distributor_name
                   select new DistributorObject{
                       Distributor_id = dis.distributor_id,
                       Distributor_name = dis.distributor_name,
                       Distributor_address = dis.distributor_address,
                       Distributor_phone = dis.distributor_phone,
                       Distributor_email = dis.distributor_email,
                   }).ToList();
            if(lst.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool createDistributor(DistributorObject dobj)
        {
            try
            {
                if (isExistingname(dobj))
                {
                    DBDataContext data = new DBDataContext();
                    tbldistributor8 dis = new tbldistributor8();
                    dis.distributor_id = dobj.Distributor_id;
                    dis.distributor_name = dobj.Distributor_name;
                    dis.distributor_address = dobj.Distributor_address;
                    dis.distributor_phone = dobj.Distributor_phone;
                    dis.distributor_email = dobj.Distributor_email;
                    data.tbldistributor8s.InsertOnSubmit(dis);
                    data.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public static bool updateDistributor(DistributorObject dobj)
        {
            try
            {
                DBDataContext data = new DBDataContext();
                var dis = data.tbldistributor8s.Single(pr => pr.distributor_id == dobj.Distributor_id);
                dis.distributor_name = dobj.Distributor_name;
                dis.distributor_address = dobj.Distributor_address;
                dis.distributor_phone = dobj.Distributor_phone;
                dis.distributor_email = dobj.Distributor_email;
                data.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool removeDistributor(DistributorObject dobj)
        {
            try
            {
                DBDataContext data = new DBDataContext();
                var del = data.tbldistributor8s.Single(cond => cond.distributor_id == dobj.Distributor_id || cond.distributor_name == dobj.Distributor_name);
                data.tbldistributor8s.DeleteOnSubmit(del);
                data.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
