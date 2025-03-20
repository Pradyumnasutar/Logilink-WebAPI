using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eSupplier_Lib.Models;

public partial class Sm_Quotationdetail_Vendor
{
    [Key]
    public int QuotationDetailId { get; set; }  // QUOTATIONDETAILID
    public int? QuotationId { get; set; }       // QUOTATIONID
    public int? ItemStatus { get; set; }        // ITEMSTATUS
    public int? ItemNo { get; set; }            // ITEMNO
    public string? Vendor_ItemNo { get; set; }   // VENDOR_ITEMNO
    public double? Qty_Req { get; set; }        // QTY_REQ
    public double? Qty_Quoted { get; set; }     // QTY_QUOTED
    public double? Qty_Ord { get; set; }        // QTY_ORD
    public double? Quoted_Price { get; set; }   // QUOTED_PRICE
    public double? Quote_ExchRate { get; set; } // QUOTE_EXCHRATE
    public double? Discount { get; set; }       // DISCOUNT
    public int? DeliveryTime { get; set; }      // DELIVERYTIME
    public string? PartName { get; set; }        // PARTNAME
    public string? DrawingNo { get; set; }       // DRAWINGNO
    public string? PosNo { get; set; }           // POSNO
    public string? RefNo { get; set; }           // REFNO
    public string? Unit_Code { get; set; }       // UNIT_CODE
    public string? Equip_Name { get; set; }      // EQUIP_NAME
    public string? Equip_Maker { get; set; }     // EQUIP_MAKER
    public string? Equip_Type { get; set; }      // EQUIP_TYPE
    public string? Equip_SerNo { get; set; }     // EQUIP_SERNO
    public string? Equip_Remarks { get; set; }   // EQUIP_REMARKS
    public string? QuoteItem_Remark { get; set; } // QUOTEITEM_REMARK
    public string? Item_Remark { get; set; }     // ITEM_REMARK
    public DateTime? Update_Date { get; set; }  // UPDATE_DATE
    public DateTime? Created_Date { get; set; } // CREATED_DATE
    public int? Changed_By_Vendor { get; set; } // CHANGED_BY_VENDOR
    public int? SiteId { get; set; }            // SITEID
    public string? DocItemId { get; set; }       // DOCITEMID
    public string? Quote_File { get; set; }      // QUOTE_FILE
    public string? Vendor_RefNo { get; set; }    // VENDOR_REFNO
    public string? OriginatingSystemRef { get; set; } // ORIGINATINGSYSTEMREF
    public string? Item_Marked_Remark { get; set; } // ITEM_MARKED_REMARK
    public int? Sys_ItemNo { get; set; }        // SYS_ITEMNO
    public string? Buyer_Unit_Code { get; set; } // BUYER_UNIT_CODE
    public string? Item_Type { get; set; }       // ITEM_TYPE
    public int? Link_Record_Id { get; set; }    // LINK_RECORD_ID
    public string? Udf1 { get; set; }            // UDF1
    public string? Udf2 { get; set; }            // UDF2
    public string? Udf3 { get; set; }            // UDF3
    public string? SupplierOrgRef { get; set; }  // SupplierORGRef
    public string? Vendor_ItemName { get; set; } // VENDOR_ITEMNAME
    public string? BuyerOrgRef { get; set; }     // BuyerORGRef
    public string? Reference_No { get; set; }    // REFERENCE_NO
    public string? ExternalItemNumber { get; set; } // ExternalItemNumber
    public string? Impa { get; set; }            // IMPA
    public string? Issa { get; set; }            // ISSA
    public string? Item_Packet_Size { get; set; } // ITEM_PACKET_SIZE
    public string? Department { get; set; }      // DEPARTMENT
    public double? Tax_Amount { get; set; }     // TAX_AMOUNT
    public string? Byr_OriginatingSystemRef { get; set; } // BYR_ORIGINATINGSYSTEMREF
    public double? Buyer_Price { get; set; }    // Buyer_Price
    public string? Quality_Level { get; set; }   // QUALITY_LEVEL
}
