using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class TypeBUS
    {
        public static List<TypeObject> getTypes()
        {
            DBDataContext data = new DBDataContext();
            List<TypeObject> lst = null;
            lst = (from type in data.tbltype8s
                     select new TypeObject
                     {
                         Type_id = type.type_id,
                         Type_name = type.type_name,
                     }).ToList();
            return lst;
        }

        public static bool createType(TypeObject similar)
        {
            try
            {
                DBDataContext data = new DBDataContext();
                tbltype8 type = new tbltype8();
                type.type_id = similar.Type_id;
                type.type_name = similar.Type_name;
                data.tbltype8s.InsertOnSubmit(type);
                data.SubmitChanges();

                return true;
            }catch(Exception ex) {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static bool updateType(TypeObject similar)
        {
            try
            {
                DBDataContext data = new DBDataContext();
                var type = data.tbltype8s.Single(pr => pr.type_id == similar.Type_id);
                type.type_name = similar.Type_name;
                data.SubmitChanges();
                return true;
            } catch
            {
                return false;
            }
        }

        public static bool deleteType(TypeObject similar)
        {
            try
            {
                DBDataContext data = new DBDataContext();
                var delete = from type in data.tbltype8s
                             where type.type_id == similar.Type_id
                             select type;
                foreach(var i in delete)
                {
                    data.tbltype8s.DeleteOnSubmit(i);
                    data.SubmitChanges();
                }
                return true;
            } catch
            {
                return false;
            }
        }

        public static List<TypeObject> searchType(String conds)
        {
            DBDataContext data = new DBDataContext();
            List<TypeObject> lst = null;
            lst = (from type in data.tbltype8s
                   where type.type_id.Contains(conds)
                   select new TypeObject
                   {
                       Type_id = type.type_id,
                       Type_name = type.type_name,
                   }).ToList();
            return lst;
        }
    }
}
