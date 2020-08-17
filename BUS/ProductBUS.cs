using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class ProductBUS
    {
  
        public static List<ProductObject> getProducts()
        {
            DBDataContext data = new DBDataContext();
            List<ProductObject> lst = null;
            lst = (from product in data.tblproduct8s
                     select new ProductObject
                     {
                         Product_id = product.product_id,
                         Product_name = product.product_name,
                         Product_brand = product.product_brand,
                         Product_image = product.product_image,
                         Product_specification = product.product_specification,
                         Product_feature = product.product_feature,
                         Product_exprice = product.product_exprice,
                         Product_imprice = product.product_imprice,
                         Product_amount = product.product_amount,
                         Product_type_id = product.product_type_id
                     }).ToList();
            return lst;
        }

        public static bool createProduct(ProductObject similar)
        {
            DBDataContext data = new DBDataContext();
            try
            {
                tblproduct8 product = new tblproduct8();
                product.product_id = similar.Product_id;
                product.product_name = similar.Product_name;
                product.product_brand = similar.Product_brand;
                product.product_image = similar.Product_image;
                product.product_specification = similar.Product_specification;
                product.product_feature = similar.Product_feature;
                product.product_exprice = similar.Product_exprice;
                product.product_imprice = similar.Product_imprice;
                product.product_amount = similar.Product_amount;
                product.product_type_id = similar.Product_type_id;
                data.tblproduct8s.InsertOnSubmit(product);
                data.SubmitChanges();
                return true;
            }catch {
                return false;
            }
        }

        public static bool updateProduct(ProductObject similar)
        {
            DBDataContext data = new DBDataContext();
            try
            {
                var product = data.tblproduct8s.Single(pr => pr.product_id == similar.Product_id);
                product.product_name = similar.Product_name;
                product.product_brand = similar.Product_brand;
                product.product_image = similar.Product_image;
                product.product_specification = similar.Product_specification;
                product.product_feature = similar.Product_feature;
                product.product_exprice = similar.Product_exprice;
                product.product_imprice = similar.Product_imprice;
                product.product_amount = similar.Product_amount;
                product.product_type_id = similar.Product_type_id;
                data.SubmitChanges();
                return true;
            } catch
            {
                return false;
            }
        }

        public static bool deleteProduct(ProductObject similar)
        {
            DBDataContext data = new DBDataContext();
            try
            {
                var delete = from product in data.tblproduct8s
                             where product.product_id == similar.Product_id
                             select product;
                foreach(var i in delete)
                {
                    data.tblproduct8s.DeleteOnSubmit(i);
                    data.SubmitChanges();
                }
                return true;
            } catch
            {
                return false;
            }
        }

        public static List<ProductObject> searchProduct(String conds)
        {
            DBDataContext data = new DBDataContext();
            List<ProductObject> lst = null;
            lst = (from product in data.tblproduct8s
                   where product.product_id.Contains(conds)
                   select new ProductObject
                   {
                       Product_id = product.product_id,
                       Product_name = product.product_name,
                       Product_brand = product.product_brand,
                       Product_image = product.product_image,
                       Product_specification = product.product_specification,
                       Product_feature = product.product_feature,
                       Product_exprice = product.product_exprice,
                       Product_imprice = product.product_imprice,
                       Product_amount = product.product_amount,
                       Product_type_id = product.product_type_id
                   }).ToList();
            return lst;
        }

        public static bool updateProductAmount(String id ,String amount)
        {
            DBDataContext data = new DBDataContext();
            try
            {
                var product = data.tblproduct8s.Single(pr => pr.product_id == id);
                product.product_amount = Int32.Parse(amount);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
