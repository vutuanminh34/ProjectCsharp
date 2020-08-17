using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExportDetailObject : ProductObject
    {
        private string export_detail_export_id;
        private string export_detail_product_id;
        private int? export_detail_amount;

        public ExportDetailObject() : base()
        {
            
        }

        public ExportDetailObject(string export_detail_export_id, string export_detail_product_id, int? export_detail_amount)
        {
            this.Export_detail_export_id = export_detail_export_id;
            this.Export_detail_product_id = export_detail_product_id;
            this.Export_detail_amount = export_detail_amount;
        }

        public string Export_detail_export_id { get => export_detail_export_id; set => export_detail_export_id = value; }
        public string Export_detail_product_id { get => export_detail_product_id; set => export_detail_product_id = value; }
        public int? Export_detail_amount { get => export_detail_amount; set => export_detail_amount = value; }
    }
}
