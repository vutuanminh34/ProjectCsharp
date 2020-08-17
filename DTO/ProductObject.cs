using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductObject
    {
        protected String product_id;
        protected String product_name;
        protected String product_brand;
        protected String product_image;
        protected String product_specification;
        protected String product_feature;
        protected double? product_exprice;
        protected double? product_imprice;
        protected int? product_amount;
        protected String product_type_id;

        public ProductObject()
        {

        }

        public ProductObject(string product_id, string product_name, string product_brand, string product_image, string product_specification, string product_feature, float product_exprice, float product_imprice, int product_amount, string product_type_id)
        {
            this.Product_id = product_id;
            this.Product_name = product_name;
            this.Product_brand = product_brand;
            this.Product_image = product_image;
            this.Product_specification = product_specification;
            this.Product_feature = product_feature;
            this.Product_exprice = product_exprice;
            this.Product_imprice = product_imprice;
            this.Product_amount = product_amount;
            this.Product_type_id = product_type_id;
        }

        public string Product_id { get => product_id; set => product_id = value; }
        public string Product_name { get => product_name; set => product_name = value; }
        public string Product_brand { get => product_brand; set => product_brand = value; }
        public string Product_image { get => product_image; set => product_image = value; }
        public string Product_specification { get => product_specification; set => product_specification = value; }
        public string Product_feature { get => product_feature; set => product_feature = value; }
        public double? Product_exprice { get => product_exprice; set => product_exprice = value; }
        public double? Product_imprice { get => product_imprice; set => product_imprice = value; }
        public int? Product_amount { get => product_amount; set => product_amount = value; }
        public string Product_type_id { get => product_type_id; set => product_type_id = value; }
    }
}
