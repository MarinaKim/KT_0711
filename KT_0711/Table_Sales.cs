namespace KT_0711
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_Sales
    {
        [Key]
        public int SalesId { get; set; }

        public int SalesGroupId { get; set; }

        public int BUKRS { get; set; }

        public string WERKS { get; set; }

        public string LGORT { get; set; }

        public string SALES_CHANEL { get; set; }

        public string SALES_CHANEL_TXT { get; set; }

        public string KUNNR { get; set; }

        public string KUNNR_TXT { get; set; }

        public string KUNNR_BIN { get; set; }

        public string KUNNR_ADR_UR { get; set; }

        public string KUNNR_ADR_DOST { get; set; }

        public string ID_OUT_DELIVERY { get; set; }

        public DateTime ID_OUT_DELIVERY_DATA { get; set; }

        public string MTART { get; set; }

        public string MTART_TXT { get; set; }

        public string MTART_EAN { get; set; }

        public string MTART_EINE { get; set; }

        public string MTART_PROIZVOD_COUNTRY { get; set; }

        public string MTART_PROIZVOD_ID { get; set; }

        public string MTART_PROIZVOD_TXT { get; set; }

        public double BSTART { get; set; }

        public double SUMM { get; set; }

        public string VALUTA { get; set; }

        public string PART_NUM { get; set; }

        public string USER_CREATE_OUT_DELIVERY { get; set; }

        public string Tender { get; set; }

        public string USER_CREATE_OUT_DELIVERY_NAME { get; set; }

        public DateTime? PART_GODN { get; set; }

        public string PART_SER_NUM { get; set; }

        public DateTime? PART_DATE_MANUFACTURE { get; set; }

        public string INVOCE_TYPE_TRANFERT { get; set; }

        public int? WerksSpot { get; set; }

        public DateTime? RequestDate { get; set; }
    }
}
