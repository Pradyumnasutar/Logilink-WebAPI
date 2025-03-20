using System;
using System.Collections.Generic;
using eSupplier_Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace eSupplier_Lib.Data;

public partial class ESupplierConlashContext : DbContext
{
    public ESupplierConlashContext()
    {
    }

    public ESupplierConlashContext(DbContextOptions<ESupplierConlashContext> options)
        : base(options)
    {

    }

    public virtual DbSet<Sm_Quotationdetail_Vendor> Sm_Quotationdetail_Vendor { get; set; }

    public virtual DbSet<SmQuotationsVendor> Sm_Quotations_Vendor { get; set; }

    public virtual DbSet<SmQuotationsVendorAdditionalDetail> Sm_Quotations_Vendor_Additional_Details { get; set; }

    public virtual DbSet<SmQuotationsVendorAddress> Sm_Quotations_Vendor_Address { get; set; }

    //public virtual DbSet<CaTemp1> CaTemp1s { get; set; }

    //public virtual DbSet<ELitePwd> ELitePwds { get; set; }

    //public virtual DbSet<LeSReportRequest> LeSReportRequests { get; set; }

    //public virtual DbSet<LeSThomeAddress> LeSThomeAddresses { get; set; }

    //public virtual DbSet<LeSVesselMaster> LeSVesselMasters { get; set; }

    //public virtual DbSet<LeSVesseltype> LeSVesseltypes { get; set; }

    //public virtual DbSet<LesBranch> LesBranches { get; set; }

    //public virtual DbSet<LesBrokerCustomerLink> LesBrokerCustomerLinks { get; set; }

    //public virtual DbSet<LesBrokerUserLink> LesBrokerUserLinks { get; set; }

    //public virtual DbSet<LesBuyer> LesBuyers { get; set; }

    //public virtual DbSet<LesBuyerSupplierFormat> LesBuyerSupplierFormats { get; set; }

    //public virtual DbSet<LesCategory> LesCategories { get; set; }

    //public virtual DbSet<LesClientConnectLog> LesClientConnectLogs { get; set; }

    //public virtual DbSet<LesClientSystemInfo> LesClientSystemInfos { get; set; }

    //public virtual DbSet<LesCustomer> LesCustomers { get; set; }

    //public virtual DbSet<LesCustomerAccount> LesCustomerAccounts { get; set; }

    //public virtual DbSet<LesEntityMapping> LesEntityMappings { get; set; }

    //public virtual DbSet<LesIfsTransaction> LesIfsTransactions { get; set; }

    //public virtual DbSet<LesInventory> LesInventories { get; set; }

    //public virtual DbSet<LesInventoryHistory> LesInventoryHistories { get; set; }

    //public virtual DbSet<LesInventorySupplierLink> LesInventorySupplierLinks { get; set; }

    //public virtual DbSet<LesInventorylocation> LesInventorylocations { get; set; }

    //public virtual DbSet<LesInvoice> LesInvoices { get; set; }

    //public virtual DbSet<LesInvoiceaging> LesInvoiceagings { get; set; }

    //public virtual DbSet<LesInvoicedetail> LesInvoicedetails { get; set; }

    //public virtual DbSet<LesKpi> LesKpis { get; set; }

    //public virtual DbSet<LesKpiQuery> LesKpiQueries { get; set; }

    //public virtual DbSet<LesKpiResult> LesKpiResults { get; set; }

    //public virtual DbSet<LesLocation> LesLocations { get; set; }

    //public virtual DbSet<LesLoginHistory> LesLoginHistories { get; set; }

    //public virtual DbSet<LesModule> LesModules { get; set; }

    //public virtual DbSet<LesModuleAction> LesModuleActions { get; set; }

    //public virtual DbSet<LesMonitorLoginHistory> LesMonitorLoginHistories { get; set; }

    //public virtual DbSet<LesNearmissCode> LesNearmissCodes { get; set; }

    //public virtual DbSet<LesOrder> LesOrders { get; set; }

    //public virtual DbSet<LesOrderCreditnoteLink> LesOrderCreditnoteLinks { get; set; }

    //public virtual DbSet<LesOrderInvoiceLink> LesOrderInvoiceLinks { get; set; }

    //public virtual DbSet<LesPartcategory> LesPartcategories { get; set; }

    //public virtual DbSet<LesParttype> LesParttypes { get; set; }

    //public virtual DbSet<LesQuoteEnvelopeDetail> LesQuoteEnvelopeDetails { get; set; }

    //public virtual DbSet<LesResendDocNotify> LesResendDocNotifies { get; set; }

    //public virtual DbSet<LesSalesorder> LesSalesorders { get; set; }

    //public virtual DbSet<LesSalesorderDetail> LesSalesorderDetails { get; set; }

    //public virtual DbSet<LesShipmentDelivery> LesShipmentDeliveries { get; set; }

    //public virtual DbSet<LesStagingDefaultSummary> LesStagingDefaultSummaries { get; set; }

    //public virtual DbSet<LesStagingGroup> LesStagingGroups { get; set; }

    //public virtual DbSet<LesStagingGroupSummary> LesStagingGroupSummaries { get; set; }

    //public virtual DbSet<LesStagingQuotationVendor> LesStagingQuotationVendors { get; set; }

    //public virtual DbSet<LesStatementofaccount> LesStatementofaccounts { get; set; }

    //public virtual DbSet<LesSupportTicket> LesSupportTickets { get; set; }

    //public virtual DbSet<LesSupportTicketsLink> LesSupportTicketsLinks { get; set; }

    //public virtual DbSet<LesTransaction> LesTransactions { get; set; }

    //public virtual DbSet<LesTransactionsCount> LesTransactionsCounts { get; set; }

    //public virtual DbSet<LesUserCustomerLink> LesUserCustomerLinks { get; set; }

    //public virtual DbSet<LesUsertype> LesUsertypes { get; set; }

    //public virtual DbSet<LesUsertypeModuleAccess> LesUsertypeModuleAccesses { get; set; }

    //public virtual DbSet<LesVBrokerCustomerLink> LesVBrokerCustomerLinks { get; set; }

    //public virtual DbSet<LesVUserCustomerLink> LesVUserCustomerLinks { get; set; }

    //public virtual DbSet<LesvCustomer> LesvCustomers { get; set; }

    //public virtual DbSet<LesvDashboardAddress> LesvDashboardAddresses { get; set; }

    //public virtual DbSet<LesvDashboardUser> LesvDashboardUsers { get; set; }

    //public virtual DbSet<MastCompany> MastCompanies { get; set; }

    //public virtual DbSet<MtmlDeliveryTerm> MtmlDeliveryTerms { get; set; }

    //public virtual DbSet<MtmlDocAmount> MtmlDocAmounts { get; set; }

    //public virtual DbSet<MtmlDocComment> MtmlDocComments { get; set; }

    //public virtual DbSet<MtmlDocDatetime> MtmlDocDatetimes { get; set; }

    //public virtual DbSet<MtmlDocHeader> MtmlDocHeaders { get; set; }

    //public virtual DbSet<MtmlDocItem> MtmlDocItems { get; set; }

    //public virtual DbSet<MtmlDocItemEquipment> MtmlDocItemEquipments { get; set; }

    //public virtual DbSet<MtmlDocParty> MtmlDocParties { get; set; }

    //public virtual DbSet<MtmlDocReference> MtmlDocReferences { get; set; }

    //public virtual DbSet<MtmlTransactionHeader> MtmlTransactionHeaders { get; set; }

    //public virtual DbSet<MtmlTransportMode> MtmlTransportModes { get; set; }

    //public virtual DbSet<MxmlAddress> MxmlAddresses { get; set; }

    //public virtual DbSet<MxmlDocHeader> MxmlDocHeaders { get; set; }

    //public virtual DbSet<MxmlDocItem> MxmlDocItems { get; set; }

    //public virtual DbSet<MxmlTransactionHeader> MxmlTransactionHeaders { get; set; }

    //public virtual DbSet<SmAddress> SmAddresses { get; set; }

    //public virtual DbSet<SmAddressConfig> SmAddressConfigs { get; set; }

    //public virtual DbSet<SmAttachment> SmAttachments { get; set; }

    //public virtual DbSet<SmAuditlog> SmAuditlogs { get; set; }

    //public virtual DbSet<SmBuyerSupplierGroup> SmBuyerSupplierGroups { get; set; }

    //public virtual DbSet<SmBuyerSupplierGroupFlow> SmBuyerSupplierGroupFlows { get; set; }

    //public virtual DbSet<SmBuyerSupplierItemRef> SmBuyerSupplierItemRefs { get; set; }

    //public virtual DbSet<SmBuyerSupplierItemRefTemp> SmBuyerSupplierItemRefTemps { get; set; }

    //public virtual DbSet<SmBuyerSupplierLink> SmBuyerSupplierLinks { get; set; }

    //public virtual DbSet<SmBuyerSupplierLinkRule> SmBuyerSupplierLinkRules { get; set; }

    //public virtual DbSet<SmBuyerSupplierLinkRuleVoucher> SmBuyerSupplierLinkRuleVouchers { get; set; }

    //public virtual DbSet<SmBuyerSupplierRule> SmBuyerSupplierRules { get; set; }

    //public virtual DbSet<SmByrSuppMailConfig> SmByrSuppMailConfigs { get; set; }

    //public virtual DbSet<SmCompanyGroupCode> SmCompanyGroupCodes { get; set; }

    //public virtual DbSet<SmCountryCode> SmCountryCodes { get; set; }

    //public virtual DbSet<SmCurrency> SmCurrencies { get; set; }

    //public virtual DbSet<SmCurrencyMapped> SmCurrencyMappeds { get; set; }

    //public virtual DbSet<SmCurrencylog> SmCurrencylogs { get; set; }

    //public virtual DbSet<SmDefaultRule> SmDefaultRules { get; set; }

    //public virtual DbSet<SmDocEquipment> SmDocEquipments { get; set; }

    //public virtual DbSet<SmDocumentFormat> SmDocumentFormats { get; set; }

    //public virtual DbSet<SmDocumentformatRule> SmDocumentformatRules { get; set; }

    //public virtual DbSet<SmErrorDetail> SmErrorDetails { get; set; }

    //public virtual DbSet<SmErrorLog> SmErrorLogs { get; set; }

    //public virtual DbSet<SmEsupplierRule> SmEsupplierRules { get; set; }

    //public virtual DbSet<SmExportedQuotation> SmExportedQuotations { get; set; }

    //public virtual DbSet<SmExportedQuoteItem> SmExportedQuoteItems { get; set; }

    //public virtual DbSet<SmExternalUser> SmExternalUsers { get; set; }

    //public virtual DbSet<SmFileAudit> SmFileAudits { get; set; }

    //public virtual DbSet<SmInvoiceAddrlink> SmInvoiceAddrlinks { get; set; }

    //public virtual DbSet<SmInvoiceFormat> SmInvoiceFormats { get; set; }

    //public virtual DbSet<SmItemUomMapping> SmItemUomMappings { get; set; }

    //public virtual DbSet<SmMailDownloadLog> SmMailDownloadLogs { get; set; }

    //public virtual DbSet<SmMailTransactionLog> SmMailTransactionLogs { get; set; }

    //public virtual DbSet<SmPartunit> SmPartunits { get; set; }

    //public virtual DbSet<SmPdfBuyerLink> SmPdfBuyerLinks { get; set; }

    //public virtual DbSet<SmPdfItemMapping> SmPdfItemMappings { get; set; }

    //public virtual DbSet<SmPdfMapping> SmPdfMappings { get; set; }



    //public virtual DbSet<SmReqnInvoice> SmReqnInvoices { get; set; }

    //public virtual DbSet<SmReqnInvoiceItem> SmReqnInvoiceItems { get; set; }

    //public virtual DbSet<SmSendMailAudit> SmSendMailAudits { get; set; }

    //public virtual DbSet<SmSendMailQueue> SmSendMailQueues { get; set; }

    //public virtual DbSet<SmSendMailQueueTemp> SmSendMailQueueTemps { get; set; }

    //public virtual DbSet<SmServerSync> SmServerSyncs { get; set; }

    //public virtual DbSet<SmShipmentDocument> SmShipmentDocuments { get; set; }

    //public virtual DbSet<SmShipmentItem> SmShipmentItems { get; set; }

    //public virtual DbSet<SmXlsBuyerFixedMapping> SmXlsBuyerFixedMappings { get; set; }

    //public virtual DbSet<SmXlsBuyerLink> SmXlsBuyerLinks { get; set; }

    //public virtual DbSet<SmXlsBuyerMapping> SmXlsBuyerMappings { get; set; }

    //public virtual DbSet<SmXlsGroupMapping> SmXlsGroupMappings { get; set; }

    //public virtual DbSet<SmXlsSection> SmXlsSections { get; set; }

    //public virtual DbSet<SmvAuditLog> SmvAuditLogs { get; set; }

    //public virtual DbSet<SmvBuyerSupplierDefaultRule> SmvBuyerSupplierDefaultRules { get; set; }

    //public virtual DbSet<SmvBuyerSupplierDefaultRulesUnique> SmvBuyerSupplierDefaultRulesUniques { get; set; }

    //public virtual DbSet<SmvBuyerSupplierExcelGroup> SmvBuyerSupplierExcelGroups { get; set; }

    //public virtual DbSet<SmvBuyerSupplierGroupFlow> SmvBuyerSupplierGroupFlows { get; set; }

    //public virtual DbSet<SmvBuyerSupplierLink> SmvBuyerSupplierLinks { get; set; }

    //public virtual DbSet<SmvBuyerSupplierLinkDetail> SmvBuyerSupplierLinkDetails { get; set; }

    //public virtual DbSet<SmvBuyerSupplierLinkInvoice> SmvBuyerSupplierLinkInvoices { get; set; }

    //public virtual DbSet<SmvBuyerSupplierLinkRule> SmvBuyerSupplierLinkRules { get; set; }

    //public virtual DbSet<SmvBuyerSupplierLinkRuleVoucher> SmvBuyerSupplierLinkRuleVouchers { get; set; }

    //public virtual DbSet<SmvBuyerSupplierPdfGroup> SmvBuyerSupplierPdfGroups { get; set; }

    //public virtual DbSet<SmvBuyerSupplierVoucherGroup> SmvBuyerSupplierVoucherGroups { get; set; }

    //public virtual DbSet<SmvByrSuppQuote> SmvByrSuppQuotes { get; set; }

    //public virtual DbSet<SmvCompanyGroup> SmvCompanyGroups { get; set; }

    //public virtual DbSet<SmvDistinctBuyerSupplierDefaultRule> SmvDistinctBuyerSupplierDefaultRules { get; set; }

    //public virtual DbSet<SmvDocumentformatRule> SmvDocumentformatRules { get; set; }

    //public virtual DbSet<SmvEpbPushdataFinalQuote> SmvEpbPushdataFinalQuotes { get; set; }

    //public virtual DbSet<SmvEpbPushdataPo> SmvEpbPushdataPos { get; set; }

    //public virtual DbSet<SmvEpbPushdataRfq> SmvEpbPushdataRfqs { get; set; }

    //public virtual DbSet<SmvErrorLog> SmvErrorLogs { get; set; }

    //public virtual DbSet<SmvEsupplierRulesVoucher> SmvEsupplierRulesVouchers { get; set; }

    //public virtual DbSet<SmvExcelRfqMappingDetail> SmvExcelRfqMappingDetails { get; set; }

    //public virtual DbSet<SmvExportAceShipQuote> SmvExportAceShipQuotes { get; set; }

    //public virtual DbSet<SmvExportAmos2ExcelPo> SmvExportAmos2ExcelPos { get; set; }

    //public virtual DbSet<SmvExportAmos2ExcelRfq> SmvExportAmos2ExcelRfqs { get; set; }

    //public virtual DbSet<SmvExportAmos2MtmlPoc> SmvExportAmos2MtmlPocs { get; set; }

    //public virtual DbSet<SmvExportAmos2MtmlPocLe> SmvExportAmos2MtmlPocLes { get; set; }

    //public virtual DbSet<SmvExportAmos2MtmlQuote> SmvExportAmos2MtmlQuotes { get; set; }

    //public virtual DbSet<SmvExportAmos2MtmlQuoteLe> SmvExportAmos2MtmlQuoteLes { get; set; }

    //public virtual DbSet<SmvExportAmos2MtmlRfq> SmvExportAmos2MtmlRfqs { get; set; }

    //public virtual DbSet<SmvExportEdiMtmlPo> SmvExportEdiMtmlPos { get; set; }

    //public virtual DbSet<SmvExportEdiMtmlRfq> SmvExportEdiMtmlRfqs { get; set; }

    //public virtual DbSet<SmvExportEdiQuotePoc> SmvExportEdiQuotePocs { get; set; }

    //public virtual DbSet<SmvExportEmsMtmlPo> SmvExportEmsMtmlPos { get; set; }

    //public virtual DbSet<SmvExportEmsMtmlRfq> SmvExportEmsMtmlRfqs { get; set; }

    //public virtual DbSet<SmvExportEsupplierInternalQuotePoc> SmvExportEsupplierInternalQuotePocs { get; set; }

    //public virtual DbSet<SmvExportEsupplierInternalRfqPo> SmvExportEsupplierInternalRfqPos { get; set; }

    //public virtual DbSet<SmvExportEsupplierLiteRfqPo> SmvExportEsupplierLiteRfqPos { get; set; }

    //public virtual DbSet<SmvExportExcelDocumentPo> SmvExportExcelDocumentPos { get; set; }

    //public virtual DbSet<SmvExportExcelDocumentPoc> SmvExportExcelDocumentPocs { get; set; }

    //public virtual DbSet<SmvExportExcelDocumentQuote> SmvExportExcelDocumentQuotes { get; set; }

    //public virtual DbSet<SmvExportExcelDocumentRfq> SmvExportExcelDocumentRfqs { get; set; }

    //public virtual DbSet<SmvExportExcelQuote> SmvExportExcelQuotes { get; set; }

    //public virtual DbSet<SmvExportExcelQuoteLe> SmvExportExcelQuoteLes { get; set; }

    //public virtual DbSet<SmvExportGoodwoodPoc> SmvExportGoodwoodPocs { get; set; }

    //public virtual DbSet<SmvExportGoodwoodQuote> SmvExportGoodwoodQuotes { get; set; }

    //public virtual DbSet<SmvExportHtmlQuote> SmvExportHtmlQuotes { get; set; }

    //public virtual DbSet<SmvExportMarineLinkPo> SmvExportMarineLinkPos { get; set; }

    //public virtual DbSet<SmvExportMarineLinkRfq> SmvExportMarineLinkRfqs { get; set; }

    //public virtual DbSet<SmvExportMespasQuote> SmvExportMespasQuotes { get; set; }

    //public virtual DbSet<SmvExportMtmlV2Po> SmvExportMtmlV2Pos { get; set; }

    //public virtual DbSet<SmvExportMtmlV2QuotePoc> SmvExportMtmlV2QuotePocs { get; set; }

    //public virtual DbSet<SmvExportMtmlV2Rfq> SmvExportMtmlV2Rfqs { get; set; }

    //public virtual DbSet<SmvExportPoAckDoc> SmvExportPoAckDocs { get; set; }

    //public virtual DbSet<SmvExportPoAckMarineLink> SmvExportPoAckMarineLinks { get; set; }

    //public virtual DbSet<SmvExportPocDoc> SmvExportPocDocs { get; set; }

    //public virtual DbSet<SmvExportPocMarineLink> SmvExportPocMarineLinks { get; set; }

    //public virtual DbSet<SmvExportQuoteDoc> SmvExportQuoteDocs { get; set; }

    //public virtual DbSet<SmvExportQuoteMarineLink> SmvExportQuoteMarineLinks { get; set; }

    //public virtual DbSet<SmvExportRealMarinePoc> SmvExportRealMarinePocs { get; set; }

    //public virtual DbSet<SmvExportRealMarineQuote> SmvExportRealMarineQuotes { get; set; }

    //public virtual DbSet<SmvExportRealMarineQuoteLe> SmvExportRealMarineQuoteLes { get; set; }

    //public virtual DbSet<SmvExportRfqAckDoc> SmvExportRfqAckDocs { get; set; }

    //public virtual DbSet<SmvExportRfqAckMarineLink> SmvExportRfqAckMarineLinks { get; set; }

    //public virtual DbSet<SmvExportRickmersQuote> SmvExportRickmersQuotes { get; set; }

    //public virtual DbSet<SmvExportRmsExcelDocumentPo> SmvExportRmsExcelDocumentPos { get; set; }

    //public virtual DbSet<SmvExportRmsExcelDocumentRfq> SmvExportRmsExcelDocumentRfqs { get; set; }

    //public virtual DbSet<SmvExportSeaProcQuotePoc> SmvExportSeaProcQuotePocs { get; set; }

    //public virtual DbSet<SmvExportShipSmartQuote> SmvExportShipSmartQuotes { get; set; }

    //public virtual DbSet<SmvExportShipmentDoc> SmvExportShipmentDocs { get; set; }

    //public virtual DbSet<SmvExportShipnetQuote> SmvExportShipnetQuotes { get; set; }

    //public virtual DbSet<SmvExportShipservQuotePoc> SmvExportShipservQuotePocs { get; set; }

    //public virtual DbSet<SmvExportShipservQuotePocThomeUat> SmvExportShipservQuotePocThomeUats { get; set; }

    //public virtual DbSet<SmvExportSinwaRfq> SmvExportSinwaRfqs { get; set; }

    //public virtual DbSet<SmvExportStamcoExcelQuote> SmvExportStamcoExcelQuotes { get; set; }

    //public virtual DbSet<SmvExportVshipsQuote> SmvExportVshipsQuotes { get; set; }

    //public virtual DbSet<SmvExportedQuoteAmountVendor> SmvExportedQuoteAmountVendors { get; set; }

    //public virtual DbSet<SmvFileAudit> SmvFileAudits { get; set; }

    //public virtual DbSet<SmvFileAuditNew> SmvFileAuditNews { get; set; }

    //public virtual DbSet<SmvGetLeSconnectClient> SmvGetLeSconnectClients { get; set; }

    //public virtual DbSet<SmvGetSendMailQueue> SmvGetSendMailQueues { get; set; }

    //public virtual DbSet<SmvGetSendMailQueueSendgrid> SmvGetSendMailQueueSendgrids { get; set; }

    //public virtual DbSet<SmvImportAceWebRfq> SmvImportAceWebRfqs { get; set; }

    //public virtual DbSet<SmvImportAmos2ExcelQuote> SmvImportAmos2ExcelQuotes { get; set; }

    //public virtual DbSet<SmvImportAmos2ExcelQuoteLe> SmvImportAmos2ExcelQuoteLes { get; set; }

    //public virtual DbSet<SmvImportAmos2MtmlDoc> SmvImportAmos2MtmlDocs { get; set; }

    //public virtual DbSet<SmvImportAmos2MtmlDocsLe> SmvImportAmos2MtmlDocsLes { get; set; }

    //public virtual DbSet<SmvImportAnobelPdf> SmvImportAnobelPdfs { get; set; }

    //public virtual DbSet<SmvImportCbedPdf> SmvImportCbedPdfs { get; set; }

    //public virtual DbSet<SmvImportEdiByrDoc> SmvImportEdiByrDocs { get; set; }

    //public virtual DbSet<SmvImportEdiSuppDoc> SmvImportEdiSuppDocs { get; set; }

    //public virtual DbSet<SmvImportEmsSuppDoc> SmvImportEmsSuppDocs { get; set; }

    //public virtual DbSet<SmvImportExcelDocsByr> SmvImportExcelDocsByrs { get; set; }

    //public virtual DbSet<SmvImportExcelDocsSupp> SmvImportExcelDocsSupps { get; set; }

    //public virtual DbSet<SmvImportExcelRfq> SmvImportExcelRfqs { get; set; }

    //public virtual DbSet<SmvImportExcelRfqsLe> SmvImportExcelRfqsLes { get; set; }

    //public virtual DbSet<SmvImportGoodwoodRfq> SmvImportGoodwoodRfqs { get; set; }

    //public virtual DbSet<SmvImportHidroviaPdf> SmvImportHidroviaPdfs { get; set; }

    //public virtual DbSet<SmvImportJandenulPdf> SmvImportJandenulPdfs { get; set; }

    //public virtual DbSet<SmvImportManPdf> SmvImportManPdfs { get; set; }

    //public virtual DbSet<SmvImportMarineExcelRfq> SmvImportMarineExcelRfqs { get; set; }

    //public virtual DbSet<SmvImportMarineLinkDoc> SmvImportMarineLinkDocs { get; set; }

    //public virtual DbSet<SmvImportMarineLinkSuppDoc> SmvImportMarineLinkSuppDocs { get; set; }

    //public virtual DbSet<SmvImportMtmPoPdf> SmvImportMtmPoPdfs { get; set; }

    //public virtual DbSet<SmvImportMtmlV2ByrDoc> SmvImportMtmlV2ByrDocs { get; set; }

    //public virtual DbSet<SmvImportMtmlV2SuppDoc> SmvImportMtmlV2SuppDocs { get; set; }

    //public virtual DbSet<SmvImportMtmshipRfq> SmvImportMtmshipRfqs { get; set; }

    //public virtual DbSet<SmvImportPaccSdsHub> SmvImportPaccSdsHubs { get; set; }

    //public virtual DbSet<SmvImportPdfDoc> SmvImportPdfDocs { get; set; }

    //public virtual DbSet<SmvImportPdfFile> SmvImportPdfFiles { get; set; }

    //public virtual DbSet<SmvImportPdfMaritec> SmvImportPdfMaritecs { get; set; }

    //public virtual DbSet<SmvImportPolskaPdf> SmvImportPolskaPdfs { get; set; }

    //public virtual DbSet<SmvImportRealMarineDoc> SmvImportRealMarineDocs { get; set; }

    //public virtual DbSet<SmvImportRealMarineDocsLe> SmvImportRealMarineDocsLes { get; set; }

    //public virtual DbSet<SmvImportRmsExcelDocsSupp> SmvImportRmsExcelDocsSupps { get; set; }

    //public virtual DbSet<SmvImportScannedPdfDoc> SmvImportScannedPdfDocs { get; set; }

    //public virtual DbSet<SmvImportSeaProcByrDoc> SmvImportSeaProcByrDocs { get; set; }

    //public virtual DbSet<SmvImportShipServByrDoc> SmvImportShipServByrDocs { get; set; }

    //public virtual DbSet<SmvImportShipServByrDocsThomeUat> SmvImportShipServByrDocsThomeUats { get; set; }

    //public virtual DbSet<SmvImportShipnetRfq> SmvImportShipnetRfqs { get; set; }

    //public virtual DbSet<SmvImportShipsmartRfq> SmvImportShipsmartRfqs { get; set; }

    //public virtual DbSet<SmvImportSilverseaPdf> SmvImportSilverseaPdfs { get; set; }

    //public virtual DbSet<SmvImportSincereindPdf> SmvImportSincereindPdfs { get; set; }

    //public virtual DbSet<SmvImportSinwaQuote> SmvImportSinwaQuotes { get; set; }

    //public virtual DbSet<SmvImportSinwaQuoteLe> SmvImportSinwaQuoteLes { get; set; }

    //public virtual DbSet<SmvImportSpPdfFile> SmvImportSpPdfFiles { get; set; }

    //public virtual DbSet<SmvImportStamcoExcelRfq> SmvImportStamcoExcelRfqs { get; set; }

    //public virtual DbSet<SmvImportSwirePo> SmvImportSwirePos { get; set; }

    //public virtual DbSet<SmvImportUnionmarinePdf> SmvImportUnionmarinePdfs { get; set; }

    //public virtual DbSet<SmvImportVshipPdf> SmvImportVshipPdfs { get; set; }

    //public virtual DbSet<SmvImportVshipsDoc> SmvImportVshipsDocs { get; set; }

    //public virtual DbSet<SmvInvoiceAddrlink> SmvInvoiceAddrlinks { get; set; }

    //public virtual DbSet<SmvInvoiceDetailsPortal> SmvInvoiceDetailsPortals { get; set; }

    //public virtual DbSet<SmvInvoiceItemdetailsPortal> SmvInvoiceItemdetailsPortals { get; set; }

    //public virtual DbSet<SmvLesClientsLog> SmvLesClientsLogs { get; set; }

    //public virtual DbSet<SmvLogin> SmvLogins { get; set; }

    //public virtual DbSet<SmvMailLog> SmvMailLogs { get; set; }

    //public virtual DbSet<SmvPdfBuyerLink> SmvPdfBuyerLinks { get; set; }

    //public virtual DbSet<SmvPdfBuyerLinkNew> SmvPdfBuyerLinkNews { get; set; }

    //public virtual DbSet<SmvQuotationsActiveItem> SmvQuotationsActiveItems { get; set; }

    //public virtual DbSet<SmvQuotationsItem> SmvQuotationsItems { get; set; }

    //public virtual DbSet<SmvQuotationsVendor> SmvQuotationsVendors { get; set; }

    //public virtual DbSet<SmvQuotationsVendorAddress> SmvQuotationsVendorAddresses { get; set; }

    //public virtual DbSet<SmvQuotationsVendorInvoice> SmvQuotationsVendorInvoices { get; set; }

    //public virtual DbSet<SmvQuoteAmountBuyerItem> SmvQuoteAmountBuyerItems { get; set; }

    //public virtual DbSet<SmvQuoteAmountVendor> SmvQuoteAmountVendors { get; set; }

    //public virtual DbSet<SmvQuoteAmountVendorNoAdditionalItem> SmvQuoteAmountVendorNoAdditionalItems { get; set; }

    //public virtual DbSet<SmvQuoteHeader> SmvQuoteHeaders { get; set; }

    //public virtual DbSet<SmvQuoteHeaderAmount> SmvQuoteHeaderAmounts { get; set; }

    //public virtual DbSet<SmvQuoteHeaderMtml> SmvQuoteHeaderMtmls { get; set; }

    //public virtual DbSet<SmvSmMailDownloadLog> SmvSmMailDownloadLogs { get; set; }

    //public virtual DbSet<SmvTransactionsCreditnote> SmvTransactionsCreditnotes { get; set; }

    //public virtual DbSet<SmvTransactionsInvoice> SmvTransactionsInvoices { get; set; }

    //public virtual DbSet<SmvUsertypeModuleAccess> SmvUsertypeModuleAccesses { get; set; }

    //public virtual DbSet<SmvVoucherBuyerSupplierGroup> SmvVoucherBuyerSupplierGroups { get; set; }

    //public virtual DbSet<SmvXlsMapping> SmvXlsMappings { get; set; }

    //public virtual DbSet<SmvXlsMappingNew> SmvXlsMappingNews { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<CaTemp1>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToTable("CA_Temp1");

    //        entity.Property(e => e.Date)
    //            .HasColumnType("datetime")
    //            .HasColumnName("DATE");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.QuoteAmount).HasColumnName("QUOTE_AMOUNT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<ELitePwd>(entity =>
    //    {
    //        entity.HasKey(e => e.PkId);

    //        entity.ToTable("eLitePWDs");

    //        entity.Property(e => e.PkId).HasColumnName("PK_ID");
    //        entity.Property(e => e.LesCode)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("LES_CODE");
    //        entity.Property(e => e.LesPwd)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("LES_PWD");
    //        entity.Property(e => e.MailBcc)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_BCC");
    //        entity.Property(e => e.MailBody)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_BODY");
    //        entity.Property(e => e.MailFrom)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_FROM");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(500)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.MailTo)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_TO");
    //        entity.Property(e => e.NotToSent).HasColumnName("NOT_TO_SENT");
    //        entity.Property(e => e.RefKey)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("ref_key");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false);
    //    });

    //    modelBuilder.Entity<LeSReportRequest>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToTable("LeS_ReportRequests");

    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("createdDate");
    //        entity.Property(e => e.RepRequestId)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("repRequestId");
    //        entity.Property(e => e.ReportFileName)
    //            .IsUnicode(false)
    //            .HasColumnName("reportFileName");
    //        entity.Property(e => e.ReportInputFile)
    //            .IsUnicode(false)
    //            .HasColumnName("reportInputFile");
    //        entity.Property(e => e.ReportStatus).HasColumnName("reportStatus");
    //        entity.Property(e => e.RequestId)
    //            .IsUnicode(false)
    //            .HasColumnName("requestID");
    //        entity.Property(e => e.ServerName)
    //            .IsUnicode(false)
    //            .HasColumnName("serverName");
    //        entity.Property(e => e.UpdatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("updatedDate");
    //        entity.Property(e => e.UserId)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("userId");
    //    });

    //    modelBuilder.Entity<LeSThomeAddress>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToTable("LeS_Thome_Address");

    //        entity.Property(e => e.AddrName)
    //            .HasMaxLength(200)
    //            .HasColumnName("ADDR_NAME");
    //        entity.Property(e => e.Addressid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("ADDRESSID");
    //        entity.Property(e => e.EmailId).HasColumnName("EMAIL_ID");
    //        entity.Property(e => e.LesCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("LES_CODE");
    //        entity.Property(e => e.LesPwd)
    //            .HasMaxLength(50)
    //            .HasColumnName("LES_PWD");
    //        entity.Property(e => e.PwdText)
    //            .HasMaxLength(50)
    //            .HasColumnName("PWD_TEXT");
    //        entity.Property(e => e.ThomeCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("THOME_CODE");
    //        entity.Property(e => e.Udf1)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF1");
    //        entity.Property(e => e.Udf2)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF2");
    //        entity.Property(e => e.UpdateDate)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<LeSVesselMaster>(entity =>
    //    {
    //        entity.HasKey(e => e.Vesselid).HasName("PK__LeS_VESS__7E4804AA11C3C001");

    //        entity.ToTable("LeS_VESSEL_MASTER");

    //        entity.Property(e => e.Vesselid).HasColumnName("VESSELID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.DeadWeightTonnage)
    //            .HasMaxLength(20)
    //            .HasColumnName("DEAD_WEIGHT_TONNAGE");
    //        entity.Property(e => e.GrossTonnage)
    //            .HasMaxLength(20)
    //            .HasColumnName("GROSS_TONNAGE");
    //        entity.Property(e => e.ImoNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("IMO_NO");
    //        entity.Property(e => e.UpdatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATED_DATE");
    //        entity.Property(e => e.VesselBuilt)
    //            .HasMaxLength(10)
    //            .HasColumnName("VESSEL_BUILT");
    //        entity.Property(e => e.VesselCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("VESSEL_CODE");
    //        entity.Property(e => e.VesselEntity)
    //            .HasMaxLength(200)
    //            .HasColumnName("VESSEL_ENTITY");
    //        entity.Property(e => e.VesselFlag)
    //            .HasMaxLength(300)
    //            .HasColumnName("VESSEL_FLAG");
    //        entity.Property(e => e.VesselFlagCountry).HasColumnName("VESSEL_FLAG_COUNTRY");
    //        entity.Property(e => e.VesselLength)
    //            .HasMaxLength(20)
    //            .HasColumnName("VESSEL_LENGTH");
    //        entity.Property(e => e.VesselName)
    //            .HasMaxLength(200)
    //            .HasColumnName("VESSEL_NAME");
    //        entity.Property(e => e.VesselOwner)
    //            .HasMaxLength(100)
    //            .HasColumnName("VESSEL_OWNER");
    //        entity.Property(e => e.VesselTag).HasColumnName("VESSEL_TAG");
    //        entity.Property(e => e.VesselType)
    //            .HasMaxLength(100)
    //            .HasColumnName("VESSEL_TYPE");
    //    });

    //    modelBuilder.Entity<LeSVesseltype>(entity =>
    //    {
    //        entity.HasKey(e => e.Vesseltypeid).HasName("PK__LeS_VESS__42EF975F7694C445");

    //        entity.ToTable("LeS_VESSELTYPE");

    //        entity.Property(e => e.Vesseltypeid).HasColumnName("VESSELTYPEID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.UpdatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATED_DATE");
    //        entity.Property(e => e.VesseltypeCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("VESSELTYPE_CODE");
    //        entity.Property(e => e.VesseltypeName)
    //            .HasMaxLength(200)
    //            .HasColumnName("VESSELTYPE_NAME");
    //    });

    //    modelBuilder.Entity<LesBranch>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToTable("LES_BRANCH");

    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.BranchAddressid).HasColumnName("BRANCH_ADDRESSID");
    //        entity.Property(e => e.BranchCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BRANCH_CODE");
    //        entity.Property(e => e.BranchName)
    //            .HasMaxLength(100)
    //            .HasColumnName("BRANCH_NAME");
    //        entity.Property(e => e.Branchid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("BRANCHID");

    //        entity.HasOne(d => d.Address).WithMany()
    //            .HasForeignKey(d => d.Addressid)
    //            .HasConstraintName("FK__LES_BRANC__ADDRE__29ADC38E");
    //    });

    //    modelBuilder.Entity<LesBrokerCustomerLink>(entity =>
    //    {
    //        entity.HasKey(e => e.Brokercustlinkid);

    //        entity.ToTable("LES_BROKER_CUSTOMER_LINK");

    //        entity.Property(e => e.Brokercustlinkid).HasColumnName("BROKERCUSTLINKID");
    //        entity.Property(e => e.Brokerid).HasColumnName("BROKERID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");
    //        entity.Property(e => e.IsConnected).HasColumnName("IS_CONNECTED");
    //        entity.Property(e => e.UpdatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATED_DATE");
    //    });

    //    modelBuilder.Entity<LesBrokerUserLink>(entity =>
    //    {
    //        entity.HasKey(e => e.Brokercustlinkid);

    //        entity.ToTable("LES_BROKER_USER_LINK");

    //        entity.Property(e => e.Brokercustlinkid).HasColumnName("BROKERCUSTLINKID");
    //        entity.Property(e => e.Brokerid).HasColumnName("BROKERID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");
    //        entity.Property(e => e.IsConnected).HasColumnName("IS_CONNECTED");
    //        entity.Property(e => e.UpdatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATED_DATE");
    //        entity.Property(e => e.Userid).HasColumnName("USERID");
    //    });

    //    modelBuilder.Entity<LesBuyer>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToTable("LES_BUYERS");

    //        entity.Property(e => e.Code)
    //            .HasMaxLength(50)
    //            .HasColumnName("CODE");
    //        entity.Property(e => e.Format)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("FORMAT");
    //        entity.Property(e => e.Name)
    //            .HasMaxLength(500)
    //            .IsUnicode(false)
    //            .HasColumnName("NAME");
    //        entity.Property(e => e.No).HasColumnName("NO");
    //        entity.Property(e => e.UpdateDate)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<LesBuyerSupplierFormat>(entity =>
    //    {
    //        entity.HasKey(e => e.Formatid);

    //        entity.ToTable("LES_BUYER_SUPPLIER_FORMATS");

    //        entity.Property(e => e.Formatid).HasColumnName("FORMATID");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.AllowedFormats).HasColumnName("ALLOWED_FORMATS");
    //        entity.Property(e => e.UpdateDate)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");

    //        entity.HasOne(d => d.Address).WithMany(p => p.LesBuyerSupplierFormats)
    //            .HasForeignKey(d => d.Addressid)
    //            .HasConstraintName("FK_LES_BUYER_SUPPLIER_FORMATS_SM_ADDRESS");
    //    });

    //    modelBuilder.Entity<LesCategory>(entity =>
    //    {
    //        entity.HasKey(e => e.CategoryId).HasName("PK__LES_CATE__E7DA297CF19A69EA");

    //        entity.ToTable("LES_CATEGORY");

    //        entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");
    //        entity.Property(e => e.Code)
    //            .HasMaxLength(10)
    //            .HasColumnName("CODE");
    //        entity.Property(e => e.Description)
    //            .HasMaxLength(250)
    //            .HasColumnName("DESCRIPTION");
    //    });

    //    modelBuilder.Entity<LesClientConnectLog>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToTable("LES_CLIENT_CONNECT_LOG");

    //        entity.Property(e => e.Clientid).HasColumnName("CLIENTID");
    //        entity.Property(e => e.Connectid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("CONNECTID");
    //        entity.Property(e => e.LastConnect)
    //            .HasColumnType("datetime")
    //            .HasColumnName("LAST_CONNECT");
    //        entity.Property(e => e.LastConnect1)
    //            .HasColumnType("datetime")
    //            .HasColumnName("LAST_CONNECT1");
    //        entity.Property(e => e.LisenceKey)
    //            .HasMaxLength(50)
    //            .HasColumnName("LISENCE_KEY");
    //        entity.Property(e => e.NotifyCnt).HasColumnName("NOTIFY_CNT");
    //    });

    //    modelBuilder.Entity<LesClientSystemInfo>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToTable("LES_CLIENT_SYSTEM_INFO");

    //        entity.Property(e => e.Client).HasMaxLength(100);
    //        entity.Property(e => e.ExeDate).HasMaxLength(100);
    //        entity.Property(e => e.ExeName).HasMaxLength(100);
    //        entity.Property(e => e.ExeVersion).HasMaxLength(100);
    //        entity.Property(e => e.LastUpdated).HasColumnType("datetime");
    //        entity.Property(e => e.Pcname)
    //            .HasMaxLength(100)
    //            .HasColumnName("PCName");
    //        entity.Property(e => e.Serverip).HasMaxLength(100);
    //        entity.Property(e => e.Serverpath).HasMaxLength(100);
    //        entity.Property(e => e.SysInfoId).ValueGeneratedOnAdd();
    //        entity.Property(e => e.SysUpdateDate)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime");
    //    });

    //    modelBuilder.Entity<LesCustomer>(entity =>
    //    {
    //        entity.HasKey(e => e.Customerid);

    //        entity.ToTable("LES_CUSTOMERS");

    //        entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");
    //        entity.Property(e => e.AddrCity)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDR_CITY");
    //        entity.Property(e => e.AddrCountry)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDR_COUNTRY");
    //        entity.Property(e => e.AddrState)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDR_STATE");
    //        entity.Property(e => e.Address1)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDRESS1");
    //        entity.Property(e => e.Address2)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDRESS2");
    //        entity.Property(e => e.Address3)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDRESS3");
    //        entity.Property(e => e.Address4)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDRESS4");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.BalanceLcy).HasColumnName("balance_lcy");
    //        entity.Property(e => e.Brokerid).HasColumnName("BROKERID");
    //        entity.Property(e => e.CompanyName)
    //            .HasMaxLength(50)
    //            .HasColumnName("COMPANY_NAME");
    //        entity.Property(e => e.Companyid).HasColumnName("COMPANYID");
    //        entity.Property(e => e.ContactPersonName)
    //            .HasMaxLength(50)
    //            .HasColumnName("CONTACT_PERSON_NAME");
    //        entity.Property(e => e.ContactPersonid).HasColumnName("CONTACT_PERSONID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("created_date");
    //        entity.Property(e => e.CreditLimit).HasColumnName("CREDIT_LIMIT");
    //        entity.Property(e => e.CreditlimitUsage).HasColumnName("CREDITLIMIT_USAGE");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(10)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.Currencyid).HasColumnName("CURRENCYID");
    //        entity.Property(e => e.CustCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("CUST_CODE");
    //        entity.Property(e => e.CustName)
    //            .HasMaxLength(200)
    //            .HasColumnName("CUST_NAME");
    //        entity.Property(e => e.CustType)
    //            .HasMaxLength(50)
    //            .HasColumnName("CUST_TYPE");
    //        entity.Property(e => e.Emailid)
    //            .HasMaxLength(50)
    //            .HasColumnName("EMAILID");
    //        entity.Property(e => e.Fax)
    //            .HasMaxLength(50)
    //            .HasColumnName("FAX");
    //        entity.Property(e => e.Homepage).HasColumnName("HOMEPAGE");
    //        entity.Property(e => e.Parentid).HasColumnName("PARENTID");
    //        entity.Property(e => e.PaymentTerms)
    //            .HasMaxLength(50)
    //            .HasColumnName("PAYMENT_TERMS");
    //        entity.Property(e => e.Paytermsid).HasColumnName("PAYTERMSID");
    //        entity.Property(e => e.Phone)
    //            .HasMaxLength(50)
    //            .HasColumnName("PHONE");
    //        entity.Property(e => e.UpdatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("updated_date");
    //        entity.Property(e => e.Zipcode)
    //            .HasMaxLength(50)
    //            .HasColumnName("ZIPCODE");
    //    });

    //    modelBuilder.Entity<LesCustomerAccount>(entity =>
    //    {
    //        entity.HasKey(e => e.Custaccountid);

    //        entity.ToTable("LES_CUSTOMER_ACCOUNT");

    //        entity.Property(e => e.Custaccountid).HasColumnName("CUSTACCOUNTID");
    //        entity.Property(e => e.Companyid).HasColumnName("companyid");
    //        entity.Property(e => e.CreditLimit).HasColumnName("CREDIT_LIMIT");
    //        entity.Property(e => e.CreditlimitUsage).HasColumnName("CREDITLIMIT_USAGE");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(10)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");
    //        entity.Property(e => e.PaymentTerms)
    //            .HasMaxLength(50)
    //            .HasColumnName("PAYMENT_TERMS");
    //        entity.Property(e => e.Paytermsid).HasColumnName("PAYTERMSID");

    //        entity.HasOne(d => d.Customer).WithMany(p => p.LesCustomerAccounts)
    //            .HasForeignKey(d => d.Customerid)
    //            .HasConstraintName("FK_LES_CUSTOMER_ACCOUNT_LES_CUSTOMERS1");
    //    });

    //    modelBuilder.Entity<LesEntityMapping>(entity =>
    //    {
    //        entity.HasKey(e => e.Entitymappingid);

    //        entity.ToTable("LES_ENTITY_MAPPINGS");

    //        entity.Property(e => e.Entitymappingid).HasColumnName("ENTITYMAPPINGID");
    //        entity.Property(e => e.ClassName)
    //            .HasMaxLength(50)
    //            .HasColumnName("CLASS_NAME");
    //        entity.Property(e => e.DbFieldName)
    //            .HasMaxLength(50)
    //            .HasColumnName("DB_FIELD_NAME");
    //        entity.Property(e => e.DefaultValue)
    //            .HasMaxLength(50)
    //            .HasColumnName("DEFAULT_VALUE");
    //        entity.Property(e => e.JsonFieldName)
    //            .HasMaxLength(50)
    //            .HasColumnName("JSON_FIELD_NAME");
    //        entity.Property(e => e.ModuleName)
    //            .HasMaxLength(50)
    //            .HasColumnName("MODULE_NAME");
    //        entity.Property(e => e.TableName)
    //            .HasMaxLength(50)
    //            .HasColumnName("TABLE_NAME");
    //    });

    //    modelBuilder.Entity<LesIfsTransaction>(entity =>
    //    {
    //        entity.HasKey(e => e.Transactionid).HasName("PK__LES_IFS___356DA90E15C2BC96");

    //        entity.ToTable("LES_IFS_TRANSACTIONS");

    //        entity.Property(e => e.Transactionid).HasColumnName("TRANSACTIONID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(10)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Exported).HasColumnName("EXPORTED");
    //        entity.Property(e => e.IfsRequestno)
    //            .HasMaxLength(50)
    //            .HasColumnName("IFS_REQUESTNO");
    //        entity.Property(e => e.IfsRevisionNo).HasColumnName("IFS_REVISION_NO");
    //        entity.Property(e => e.IfsVendorno)
    //            .HasMaxLength(50)
    //            .HasColumnName("IFS_VENDORNO");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Released).HasColumnName("RELEASED");
    //        entity.Property(e => e.UpdatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATED_DATE");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(100)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<LesInventory>(entity =>
    //    {
    //        entity.HasKey(e => e.Inventoryid);

    //        entity.ToTable("LES_INVENTORY");

    //        entity.Property(e => e.Inventoryid).HasColumnName("INVENTORYID");
    //        entity.Property(e => e.AvailStock).HasColumnName("AVAIL_STOCK");
    //        entity.Property(e => e.AvgPrice).HasColumnName("AVG_PRICE");
    //        entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Drawingno)
    //            .HasMaxLength(40)
    //            .HasColumnName("DRAWINGNO");
    //        entity.Property(e => e.Inventoryno)
    //            .HasMaxLength(20)
    //            .HasColumnName("INVENTORYNO");
    //        entity.Property(e => e.Invname)
    //            .HasMaxLength(45)
    //            .HasColumnName("INVNAME");
    //        entity.Property(e => e.Lastsuppllier).HasColumnName("LASTSUPPLLIER");
    //        entity.Property(e => e.MakerAddressid).HasColumnName("MAKER_ADDRESSID");
    //        entity.Property(e => e.Makerref)
    //            .HasMaxLength(50)
    //            .HasColumnName("MAKERREF");
    //        entity.Property(e => e.Maxlvl).HasColumnName("MAXLVL");
    //        entity.Property(e => e.Minlvl).HasColumnName("MINLVL");
    //        entity.Property(e => e.PackQty).HasColumnName("PACK_QTY");
    //        entity.Property(e => e.PartPriceDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PART_PRICE_DATE");
    //        entity.Property(e => e.PartsText1)
    //            .HasMaxLength(50)
    //            .HasColumnName("Parts_Text1");
    //        entity.Property(e => e.PartsText2)
    //            .HasMaxLength(50)
    //            .HasColumnName("Parts_Text2");
    //        entity.Property(e => e.PartsText3)
    //            .HasMaxLength(50)
    //            .HasColumnName("Parts_Text3");
    //        entity.Property(e => e.PartsText4)
    //            .HasMaxLength(50)
    //            .HasColumnName("Parts_Text4");
    //        entity.Property(e => e.Parttypeid).HasColumnName("PARTTYPEID");
    //        entity.Property(e => e.Partunitid).HasColumnName("PARTUNITID");
    //        entity.Property(e => e.PckUnitid).HasColumnName("PCK_UNITID");
    //        entity.Property(e => e.Posno)
    //            .HasMaxLength(10)
    //            .HasColumnName("POSNO");
    //        entity.Property(e => e.Remark)
    //            .HasColumnType("ntext")
    //            .HasColumnName("REMARK");
    //        entity.Property(e => e.ReservedStock).HasColumnName("RESERVED_STOCK");
    //        entity.Property(e => e.Stockable).HasColumnName("STOCKABLE");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
    //    });

    //    modelBuilder.Entity<LesInventoryHistory>(entity =>
    //    {
    //        entity.HasKey(e => e.Invhistoryid);

    //        entity.ToTable("LES_INVENTORY_HISTORY");

    //        entity.Property(e => e.Invhistoryid).HasColumnName("INVHISTORYID");
    //        entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Currencyid).HasColumnName("CURRENCYID");
    //        entity.Property(e => e.HistoryType).HasColumnName("HISTORY_TYPE");
    //        entity.Property(e => e.Inventoryid).HasColumnName("INVENTORYID");
    //        entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.Supunitid).HasColumnName("SUPUNITID");
    //        entity.Property(e => e.UnitPrice).HasColumnName("UNIT_PRICE");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
    //        entity.Property(e => e.Used).HasColumnName("USED");
    //    });

    //    modelBuilder.Entity<LesInventorySupplierLink>(entity =>
    //    {
    //        entity.HasKey(e => e.Invsupid);

    //        entity.ToTable("LES_INVENTORY_SUPPLIER_LINK");

    //        entity.Property(e => e.Invsupid).HasColumnName("INVSUPID");
    //        entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Inventoryid).HasColumnName("INVENTORYID");
    //        entity.Property(e => e.Ispreferred).HasColumnName("ISPREFERRED");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
    //    });

    //    modelBuilder.Entity<LesInventorylocation>(entity =>
    //    {
    //        entity.HasKey(e => e.Inventorylocationid);

    //        entity.ToTable("LES_INVENTORYLOCATION");

    //        entity.Property(e => e.Inventorylocationid).HasColumnName("INVENTORYLOCATIONID");
    //        entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Inventoryid).HasColumnName("INVENTORYID");
    //        entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");
    //        entity.Property(e => e.Stock).HasColumnName("STOCK");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
    //    });

    //    modelBuilder.Entity<LesInvoice>(entity =>
    //    {
    //        entity.HasKey(e => e.InvoiceId).HasName("PK__LES_INVO__0CE91F0804C5EE81");

    //        entity.ToTable("LES_INVOICE");

    //        entity.Property(e => e.InvoiceId)
    //            .ValueGeneratedNever()
    //            .HasColumnName("INVOICE_ID");
    //        entity.Property(e => e.AccName)
    //            .HasMaxLength(50)
    //            .HasColumnName("ACC_NAME");
    //        entity.Property(e => e.AccountNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("ACCOUNT_NO");
    //        entity.Property(e => e.Attachment)
    //            .HasMaxLength(50)
    //            .HasColumnName("ATTACHMENT");
    //        entity.Property(e => e.BankName)
    //            .HasMaxLength(50)
    //            .HasColumnName("BANK_NAME");
    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.BuyerOrgNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_ORG_NO");
    //        entity.Property(e => e.BuyerPoDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("BUYER_PO_DATE");
    //        entity.Property(e => e.BuyerVatNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_VAT_NO");
    //        entity.Property(e => e.ChamberOfCommerce)
    //            .HasMaxLength(50)
    //            .HasColumnName("CHAMBER_OF_COMMERCE");
    //        entity.Property(e => e.Conveyance).HasColumnName("CONVEYANCE");
    //        entity.Property(e => e.CourierAmt).HasColumnName("COURIER_AMT");
    //        entity.Property(e => e.CourierName).HasColumnName("COURIER_NAME");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.CreditToInvoiceNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("CREDIT_TO_INVOICE_NO");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(10)
    //            .IsFixedLength()
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.CustomerNo).HasColumnName("CUSTOMER_NO");
    //        entity.Property(e => e.DateOfDelivery)
    //            .HasColumnType("datetime")
    //            .HasColumnName("DATE_OF_DELIVERY");
    //        entity.Property(e => e.DeliveryNoteNo).HasColumnName("DELIVERY_NOTE_NO");
    //        entity.Property(e => e.DeliveryPortName).HasColumnName("DELIVERY_PORT_NAME");
    //        entity.Property(e => e.DeliveryTerms).HasColumnName("DELIVERY_TERMS");
    //        entity.Property(e => e.Discount).HasColumnName("DISCOUNT");
    //        entity.Property(e => e.DiscountPercent).HasColumnName("DISCOUNT_PERCENT");
    //        entity.Property(e => e.DispatchDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("DISPATCH_DATE");
    //        entity.Property(e => e.DueDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("DUE_DATE");
    //        entity.Property(e => e.FcaAmt).HasColumnName("FCA_AMT");
    //        entity.Property(e => e.ForwarderDispatchNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("FORWARDER_DISPATCH_NO");
    //        entity.Property(e => e.Freightamt).HasColumnName("FREIGHTAMT");
    //        entity.Property(e => e.GrnFileRef)
    //            .HasMaxLength(50)
    //            .HasColumnName("GRN_FILE_REF");
    //        entity.Property(e => e.GrnNumber)
    //            .HasMaxLength(50)
    //            .HasColumnName("GRN_NUMBER");
    //        entity.Property(e => e.GrnToVoucherFlag).HasColumnName("GRN_TO_VOUCHER_FLAG");
    //        entity.Property(e => e.IbanNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("IBAN_NO");
    //        entity.Property(e => e.ImoNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("IMO_NO");
    //        entity.Property(e => e.InsuranceAmt).HasColumnName("INSURANCE_AMT");
    //        entity.Property(e => e.Invlinkid).HasColumnName("INVLINKID");
    //        entity.Property(e => e.InvoiceAmount).HasColumnName("INVOICE_AMOUNT");
    //        entity.Property(e => e.InvoiceDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("INVOICE_DATE");
    //        entity.Property(e => e.InvoiceRecvDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("INVOICE_RECV_DATE");
    //        entity.Property(e => e.Invoiceno)
    //            .HasMaxLength(50)
    //            .HasColumnName("INVOICENO");
    //        entity.Property(e => e.Invoicetype)
    //            .HasMaxLength(50)
    //            .HasColumnName("INVOICETYPE");
    //        entity.Property(e => e.IpAddress)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("IP_ADDRESS");
    //        entity.Property(e => e.ItemsCount).HasColumnName("ITEMS_COUNT");
    //        entity.Property(e => e.Linkid)
    //            .HasMaxLength(50)
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
    //        entity.Property(e => e.Othercosts).HasColumnName("OTHERCOSTS");
    //        entity.Property(e => e.PackingHandlingAmt).HasColumnName("PACKING_HANDLING_AMT");
    //        entity.Property(e => e.PaymentRef)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("PAYMENT_REF");
    //        entity.Property(e => e.PaymentTerms)
    //            .IsUnicode(false)
    //            .HasColumnName("PAYMENT_TERMS");
    //        entity.Property(e => e.PoAmount).HasColumnName("PO_AMOUNT");
    //        entity.Property(e => e.PoDepartment)
    //            .HasMaxLength(200)
    //            .HasColumnName("PO_DEPARTMENT");
    //        entity.Property(e => e.PoNo)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("PO_NO");
    //        entity.Property(e => e.PoRefNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("PO_REF_NO");
    //        entity.Property(e => e.Portalstatus).HasColumnName("PORTALSTATUS");
    //        entity.Property(e => e.Remarks).HasColumnName("REMARKS");
    //        entity.Property(e => e.SAccountNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("sACCOUNT_NO");
    //        entity.Property(e => e.SIbanNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("sIBAN_NO");
    //        entity.Property(e => e.SKvKNo).HasColumnName("sKvK_NO");
    //        entity.Property(e => e.SSwiftNo).HasColumnName("sSWIFT_NO");
    //        entity.Property(e => e.Sflag).HasColumnName("SFLAG");
    //        entity.Property(e => e.ShippingMarks).HasColumnName("SHIPPING_MARKS");
    //        entity.Property(e => e.SortCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("SORT_CODE");
    //        entity.Property(e => e.SubmitedXmlFile).HasColumnName("SUBMITED_XML_FILE");
    //        entity.Property(e => e.SubmittedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("SUBMITTED_DATE");
    //        entity.Property(e => e.SupplierAddressid).HasColumnName("SUPPLIER_ADDRESSID");
    //        entity.Property(e => e.SupplierDispatchNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_DISPATCH_NO");
    //        entity.Property(e => e.SupplierOrgNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_ORG_NO");
    //        entity.Property(e => e.SupplierVatNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_VAT_NO");
    //        entity.Property(e => e.SwiftNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("SWIFT_NO");
    //        entity.Property(e => e.TotalItemsAmt).HasColumnName("TOTAL_ITEMS_AMT");
    //        entity.Property(e => e.TransactionAmt).HasColumnName("TRANSACTION_AMT");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.Username)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("USERNAME");
    //        entity.Property(e => e.VatAmt).HasColumnName("VAT_AMT");
    //        entity.Property(e => e.VesselCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("VESSEL_CODE");
    //        entity.Property(e => e.VesselName)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("VESSEL_NAME");
    //    });

    //    modelBuilder.Entity<LesInvoiceaging>(entity =>
    //    {
    //        entity.HasKey(e => e.Invageid);

    //        entity.ToTable("LES_INVOICEAGING");

    //        entity.Property(e => e.Invageid).HasColumnName("INVAGEID");
    //        entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");
    //        entity.Property(e => e.Grt90days)
    //            .HasMaxLength(50)
    //            .HasColumnName("GRT90DAYS");
    //        entity.Property(e => e.Inv31to60days)
    //            .HasMaxLength(50)
    //            .HasColumnName("INV_31TO60DAYS");
    //        entity.Property(e => e.Inv61to90days)
    //            .HasMaxLength(50)
    //            .HasColumnName("INV_61TO90DAYS");
    //        entity.Property(e => e.Invoiceid).HasColumnName("INVOICEID");
    //        entity.Property(e => e.Oneto30days)
    //            .HasMaxLength(50)
    //            .HasColumnName("ONETO30DAYS");
    //        entity.Property(e => e.TotalPayables)
    //            .HasColumnType("decimal(18, 2)")
    //            .HasColumnName("TOTAL_PAYABLES");
    //        entity.Property(e => e.Zeroday)
    //            .HasMaxLength(50)
    //            .HasColumnName("ZERODAY");
    //    });

    //    modelBuilder.Entity<LesInvoicedetail>(entity =>
    //    {
    //        entity.HasKey(e => e.Invoiceid);

    //        entity.ToTable("LES_INVOICEDETAILS");

    //        entity.Property(e => e.Invoiceid).HasColumnName("INVOICEID");
    //        entity.Property(e => e.Age).HasColumnName("age");
    //        entity.Property(e => e.Attachment).HasColumnName("ATTACHMENT");
    //        entity.Property(e => e.BalanceAmount)
    //            .HasColumnType("decimal(18, 2)")
    //            .HasColumnName("BALANCE_AMOUNT");
    //        entity.Property(e => e.BillingParty).HasColumnName("BILLING_PARTY");
    //        entity.Property(e => e.BillingPartyid).HasColumnName("BILLING_PARTYID");
    //        entity.Property(e => e.Brokerid).HasColumnName("BROKERID");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(10)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.CustomerName)
    //            .HasMaxLength(50)
    //            .HasColumnName("CUSTOMER_NAME");
    //        entity.Property(e => e.CustomerReference)
    //            .HasMaxLength(50)
    //            .HasColumnName("CUSTOMER_REFERENCE");
    //        entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");
    //        entity.Property(e => e.DeptCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("DEPT_CODE");
    //        entity.Property(e => e.DueDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("DUE_DATE");
    //        entity.Property(e => e.Forwarderid).HasColumnName("FORWARDERID");
    //        entity.Property(e => e.InvoiceAmount)
    //            .HasColumnType("decimal(18, 2)")
    //            .HasColumnName("INVOICE_AMOUNT");
    //        entity.Property(e => e.InvoiceDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("INVOICE_DATE");
    //        entity.Property(e => e.InvoiceRemarks)
    //            .HasMaxLength(200)
    //            .HasColumnName("invoice_remarks");
    //        entity.Property(e => e.InvoiceStatusText)
    //            .HasMaxLength(50)
    //            .HasColumnName("INVOICE_STATUS_TEXT");
    //        entity.Property(e => e.Invoiceno)
    //            .HasMaxLength(50)
    //            .HasColumnName("INVOICENO");
    //        entity.Property(e => e.Invoicestatusid).HasColumnName("INVOICESTATUSID");
    //        entity.Property(e => e.JobOrderno)
    //            .HasMaxLength(50)
    //            .HasColumnName("JOB_ORDERNO");
    //        entity.Property(e => e.OrNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("OR_NO");
    //        entity.Property(e => e.OtherCharges)
    //            .HasColumnType("decimal(18, 2)")
    //            .HasColumnName("OTHER_CHARGES");
    //        entity.Property(e => e.PaidAmount)
    //            .HasColumnType("decimal(18, 2)")
    //            .HasColumnName("PAID_AMOUNT");
    //        entity.Property(e => e.PaidDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PAID_DATE");
    //        entity.Property(e => e.PaymentStatus)
    //            .HasMaxLength(50)
    //            .HasColumnName("PAYMENT_STATUS");
    //        entity.Property(e => e.TotalLineamount)
    //            .HasColumnType("decimal(18, 2)")
    //            .HasColumnName("TOTAL_LINEAMOUNT");
    //        entity.Property(e => e.VatAmount)
    //            .HasColumnType("decimal(18, 2)")
    //            .HasColumnName("VAT_AMOUNT");
    //        entity.Property(e => e.VesselName)
    //            .HasMaxLength(50)
    //            .HasColumnName("VESSEL_NAME");
    //        entity.Property(e => e.Vesselno)
    //            .HasMaxLength(20)
    //            .HasColumnName("VESSELNO");
    //    });

    //    modelBuilder.Entity<LesKpi>(entity =>
    //    {
    //        entity.HasKey(e => e.KpiId).HasName("PK__LES_KPI__CEC470B826415ED4");

    //        entity.ToTable("LES_KPI");

    //        entity.Property(e => e.KpiId)
    //            .ValueGeneratedNever()
    //            .HasColumnName("KPI_ID");
    //        entity.Property(e => e.Description)
    //            .HasMaxLength(100)
    //            .HasColumnName("DESCRIPTION");
    //    });

    //    modelBuilder.Entity<LesKpiQuery>(entity =>
    //    {
    //        entity.HasKey(e => e.Id).HasName("PK__LES_KPI___3214EC270DAFBDE5");

    //        entity.ToTable("LES_KPI_QUERIES");

    //        entity.Property(e => e.Id).HasColumnName("ID");
    //        entity.Property(e => e.AddrType)
    //            .HasMaxLength(20)
    //            .HasColumnName("ADDR_TYPE");
    //        entity.Property(e => e.KpiId).HasColumnName("KPI_ID");
    //        entity.Property(e => e.QueryType)
    //            .HasMaxLength(20)
    //            .HasColumnName("QUERY_TYPE");
    //        entity.Property(e => e.SqlQuery).HasColumnName("SQL_QUERY");

    //        entity.HasOne(d => d.Kpi).WithMany(p => p.LesKpiQueries)
    //            .HasForeignKey(d => d.KpiId)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK__LES_KPI_Q__KPI_I__4E7533E9");
    //    });

    //    modelBuilder.Entity<LesKpiResult>(entity =>
    //    {
    //        entity.HasKey(e => e.Id).HasName("PK__LES_KPI___3214EC2787C231C6");

    //        entity.ToTable("LES_KPI_RESULT");

    //        entity.Property(e => e.Id).HasColumnName("ID");
    //        entity.Property(e => e.Branchid).HasColumnName("BRANCHID");
    //        entity.Property(e => e.DateInt).HasColumnName("DATE_INT");
    //        entity.Property(e => e.KpiId).HasColumnName("KPI_ID");
    //        entity.Property(e => e.Result).HasColumnName("RESULT");

    //        entity.HasOne(d => d.Kpi).WithMany(p => p.LesKpiResults)
    //            .HasForeignKey(d => d.KpiId)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK__LES_KPI_R__KPI_I__4B98C73E");
    //    });

    //    modelBuilder.Entity<LesLocation>(entity =>
    //    {
    //        entity.HasKey(e => e.Locationid).HasName("PK_LES_QUOTATIONS_VENDOR_DETAIL");

    //        entity.ToTable("LES_LOCATIONS");

    //        entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.LocDescription)
    //            .HasMaxLength(50)
    //            .HasColumnName("LOC_DESCRIPTION");
    //        entity.Property(e => e.Loccode)
    //            .HasMaxLength(10)
    //            .HasColumnName("LOCCODE");
    //        entity.Property(e => e.MappedEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAPPED_EMAIL");
    //        entity.Property(e => e.UpdateDate).HasColumnType("datetime");
    //    });

    //    modelBuilder.Entity<LesLoginHistory>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("LES_LOGIN_HISTORY");

    //        entity.Property(e => e.ClientServerIp)
    //            .HasMaxLength(50)
    //            .HasColumnName("CLIENT_SERVER_IP");
    //        entity.Property(e => e.ExUsercode)
    //            .HasMaxLength(10)
    //            .IsFixedLength()
    //            .HasColumnName("EX_USERCODE");
    //        entity.Property(e => e.LoggedIn)
    //            .HasMaxLength(10)
    //            .IsUnicode(false)
    //            .HasColumnName("LOGGED_IN");
    //        entity.Property(e => e.LoggedInRemarks).HasColumnName("LOGGED_IN_REMARKS");
    //        entity.Property(e => e.LoggedOut)
    //            .HasMaxLength(10)
    //            .IsUnicode(false)
    //            .HasColumnName("LOGGED_OUT");
    //        entity.Property(e => e.LoggedOutRemarks).HasColumnName("LOGGED_OUT_REMARKS");
    //        entity.Property(e => e.LoginTrackId)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LOGIN_TRACK_ID");
    //        entity.Property(e => e.Sessionid)
    //            .HasMaxLength(250)
    //            .HasColumnName("SESSIONID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.Userid).HasColumnName("USERID");
    //    });

    //    modelBuilder.Entity<LesModule>(entity =>
    //    {
    //        entity.HasKey(e => e.Moduleid).HasName("PK__LES_MODU__73B63DA9A69474E3");

    //        entity.ToTable("LES_MODULES");

    //        entity.Property(e => e.Moduleid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("MODULEID");
    //        entity.Property(e => e.Module)
    //            .HasMaxLength(50)
    //            .HasColumnName("MODULE");
    //    });

    //    modelBuilder.Entity<LesModuleAction>(entity =>
    //    {
    //        entity.HasKey(e => e.Moduleactionid).HasName("PK_SM_MODULE_ACTIONS");

    //        entity.ToTable("LES_MODULE_ACTIONS");

    //        entity.Property(e => e.Moduleactionid).HasColumnName("MODULEACTIONID");
    //        entity.Property(e => e.ActionName)
    //            .HasMaxLength(50)
    //            .HasColumnName("ACTION_NAME");
    //        entity.Property(e => e.Moduleid).HasColumnName("MODULEID");
    //    });

    //    modelBuilder.Entity<LesMonitorLoginHistory>(entity =>
    //    {
    //        entity.HasKey(e => e.LoginTrackId).HasName("PK__LES_MONITOR_LOGI__756E3A22");

    //        entity.ToTable("LES_MONITOR_LOGIN_HISTORY");

    //        entity.Property(e => e.LoginTrackId).HasColumnName("LOGIN_TRACK_ID");
    //        entity.Property(e => e.ClientServerIp)
    //            .HasMaxLength(50)
    //            .HasColumnName("CLIENT_SERVER_IP");
    //        entity.Property(e => e.LoggedIn)
    //            .HasColumnType("datetime")
    //            .HasColumnName("LOGGED_IN");
    //        entity.Property(e => e.LoggedInRemarks).HasColumnName("LOGGED_IN_REMARKS");
    //        entity.Property(e => e.LoggedOut)
    //            .HasColumnType("datetime")
    //            .HasColumnName("LOGGED_OUT");
    //        entity.Property(e => e.LoggedOutRemarks).HasColumnName("LOGGED_OUT_REMARKS");
    //        entity.Property(e => e.Sessionid)
    //            .HasMaxLength(250)
    //            .HasColumnName("SESSIONID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.Userid).HasColumnName("USERID");
    //    });

    //    modelBuilder.Entity<LesNearmissCode>(entity =>
    //    {
    //        entity.HasKey(e => e.Nmid).HasName("PK__LES_NEAR__E32F4C813F346C5E");

    //        entity.ToTable("LES_NEARMISS_CODES");

    //        entity.Property(e => e.Nmid).HasColumnName("NMID");
    //        entity.Property(e => e.CancelledByUser)
    //            .HasMaxLength(50)
    //            .HasColumnName("CANCELLED_BY_USER");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Exported).HasColumnName("EXPORTED");
    //        entity.Property(e => e.IsCancelled).HasColumnName("IS_CANCELLED");
    //        entity.Property(e => e.Nearmissid)
    //            .HasMaxLength(20)
    //            .HasColumnName("NEARMISSID");
    //        entity.Property(e => e.NmCode)
    //            .HasMaxLength(30)
    //            .HasColumnName("NM_CODE");
    //        entity.Property(e => e.Nmappid)
    //            .HasMaxLength(40)
    //            .HasColumnName("NMAPPID");
    //        entity.Property(e => e.Reportdate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("REPORTDATE");
    //    });

    //    modelBuilder.Entity<LesOrder>(entity =>
    //    {
    //        entity.HasKey(e => e.Orderid);

    //        entity.ToTable("LES_ORDERS");

    //        entity.Property(e => e.Orderid).HasColumnName("ORDERID");
    //        entity.Property(e => e.Attachment).HasColumnName("ATTACHMENT");
    //        entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");
    //        entity.Property(e => e.CustomerReference)
    //            .HasMaxLength(50)
    //            .HasColumnName("CUSTOMER_REFERENCE");
    //        entity.Property(e => e.DocumentNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOCUMENT_NO");
    //        entity.Property(e => e.EtaDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("ETA_DATE");
    //        entity.Property(e => e.OrderAmount)
    //            .HasColumnType("decimal(18, 2)")
    //            .HasColumnName("ORDER_AMOUNT");
    //        entity.Property(e => e.OrderAmountText)
    //            .HasMaxLength(50)
    //            .HasColumnName("ORDER_AMOUNT_TEXT");
    //        entity.Property(e => e.OrderDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("ORDER_DATE");
    //        entity.Property(e => e.OrderNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("ORDER_NO");
    //        entity.Property(e => e.StatusText)
    //            .HasMaxLength(50)
    //            .HasColumnName("STATUS_TEXT");
    //        entity.Property(e => e.Statusid).HasColumnName("STATUSID");
    //        entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
    //        entity.Property(e => e.UpdatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATED_DATE");
    //        entity.Property(e => e.VesselName)
    //            .HasMaxLength(50)
    //            .HasColumnName("VESSEL_NAME");
    //        entity.Property(e => e.Vesselno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VESSELNO");
    //    });

    //    modelBuilder.Entity<LesOrderCreditnoteLink>(entity =>
    //    {
    //        entity.HasKey(e => e.Keyid);

    //        entity.ToTable("LES_ORDER_CREDITNOTE_LINK");

    //        entity.Property(e => e.Keyid).HasColumnName("KEYID");
    //        entity.Property(e => e.GrnStatus).HasColumnName("GRN_STATUS");
    //        entity.Property(e => e.Invoiceid).HasColumnName("INVOICEID");
    //        entity.Property(e => e.Invoiceno)
    //            .HasMaxLength(50)
    //            .HasColumnName("INVOICENO");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");

    //        entity.HasOne(d => d.Quotation).WithMany(p => p.LesOrderCreditnoteLinks)
    //            .HasForeignKey(d => d.Quotationid)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_LES_ORDER_CREDITNOTE_LINK_QUOTATION");
    //    });

    //    modelBuilder.Entity<LesOrderInvoiceLink>(entity =>
    //    {
    //        entity.HasKey(e => e.Keyid);

    //        entity.ToTable("LES_ORDER_INVOICE_LINK");

    //        entity.Property(e => e.Keyid).HasColumnName("KEYID");
    //        entity.Property(e => e.GrnStatus).HasColumnName("GRN_STATUS");
    //        entity.Property(e => e.Invoiceid).HasColumnName("INVOICEID");
    //        entity.Property(e => e.Invoiceno)
    //            .HasMaxLength(50)
    //            .HasColumnName("INVOICENO");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");

    //        entity.HasOne(d => d.Quotation).WithMany(p => p.LesOrderInvoiceLinks)
    //            .HasForeignKey(d => d.Quotationid)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_LES_ORDER_INVOICE_LINK_QUOTATION");
    //    });

    //    modelBuilder.Entity<LesPartcategory>(entity =>
    //    {
    //        entity.HasKey(e => e.Categoryid);

    //        entity.ToTable("LES_PARTCATEGORY");

    //        entity.Property(e => e.Categoryid).HasColumnName("CATEGORYID");
    //        entity.Property(e => e.CategoryCode)
    //            .HasMaxLength(10)
    //            .HasColumnName("CATEGORY_CODE");
    //        entity.Property(e => e.Description)
    //            .HasMaxLength(50)
    //            .HasColumnName("DESCRIPTION");
    //    });

    //    modelBuilder.Entity<LesParttype>(entity =>
    //    {
    //        entity.HasKey(e => e.Parttypeid);

    //        entity.ToTable("LES_PARTTYPE");

    //        entity.Property(e => e.Parttypeid).HasColumnName("PARTTYPEID");
    //        entity.Property(e => e.Categoryid).HasColumnName("CATEGORYID");
    //        entity.Property(e => e.Description)
    //            .HasMaxLength(50)
    //            .HasColumnName("DESCRIPTION");
    //        entity.Property(e => e.ParttypeCode)
    //            .HasMaxLength(10)
    //            .HasColumnName("PARTTYPE_CODE");
    //    });

    //    modelBuilder.Entity<LesQuoteEnvelopeDetail>(entity =>
    //    {
    //        entity.HasKey(e => e.QuoteEnvelopeId);

    //        entity.ToTable("LES_QUOTE_ENVELOPE_DETAILS");

    //        entity.Property(e => e.QuoteEnvelopeId).HasColumnName("QUOTE_ENVELOPE_ID");
    //        entity.Property(e => e.CaseId)
    //            .HasMaxLength(250)
    //            .HasColumnName("CASE_ID");
    //        entity.Property(e => e.CaseNumber)
    //            .HasMaxLength(250)
    //            .HasColumnName("CASE_NUMBER");
    //        entity.Property(e => e.CaseThreadId)
    //            .HasMaxLength(250)
    //            .HasColumnName("CASE_THREAD_ID");
    //        entity.Property(e => e.DepartmentMail)
    //            .HasMaxLength(250)
    //            .HasColumnName("DEPARTMENT_MAIL");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.Location)
    //            .HasMaxLength(100)
    //            .HasColumnName("LOCATION");
    //        entity.Property(e => e.MailBcc)
    //            .HasMaxLength(250)
    //            .HasColumnName("MAIL_BCC");
    //        entity.Property(e => e.MailCc)
    //            .HasMaxLength(250)
    //            .HasColumnName("MAIL_CC");
    //        entity.Property(e => e.MailFrom)
    //            .HasMaxLength(250)
    //            .HasColumnName("MAIL_FROM");
    //        entity.Property(e => e.MailReply)
    //            .HasMaxLength(250)
    //            .HasColumnName("MAIL_REPLY");
    //        entity.Property(e => e.MailTo)
    //            .HasMaxLength(250)
    //            .HasColumnName("MAIL_TO");
    //        entity.Property(e => e.MappedMail)
    //            .HasMaxLength(250)
    //            .HasColumnName("MAPPED_MAIL");
    //        entity.Property(e => e.MessageId)
    //            .HasMaxLength(250)
    //            .HasColumnName("MESSAGE_ID");
    //        entity.Property(e => e.MessageNumber)
    //            .HasMaxLength(250)
    //            .HasColumnName("MESSAGE_NUMBER");
    //        entity.Property(e => e.MsgFullpath)
    //            .HasMaxLength(250)
    //            .HasColumnName("MSG_FULLPATH");
    //        entity.Property(e => e.MsgName)
    //            .HasMaxLength(100)
    //            .HasColumnName("MSG_NAME");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Udf1)
    //            .HasMaxLength(200)
    //            .HasColumnName("UDF1");
    //        entity.Property(e => e.Udf2)
    //            .HasMaxLength(200)
    //            .HasColumnName("UDF2");
    //        entity.Property(e => e.Udf3)
    //            .HasMaxLength(200)
    //            .HasColumnName("UDF3");

    //        entity.HasOne(d => d.Quotation).WithMany(p => p.LesQuoteEnvelopeDetails)
    //            .HasForeignKey(d => d.Quotationid)
    //            .HasConstraintName("FK_LES_QUOTE_ENVELOPE_DETAILS_SM_QUOTATIONS_VENDOR");
    //    });

    //    modelBuilder.Entity<LesResendDocNotify>(entity =>
    //    {
    //        entity.HasKey(e => e.ResendId);

    //        entity.ToTable("LES_RESEND_DOC_NOTIFY");

    //        entity.Property(e => e.ResendId).HasColumnName("RESEND_ID");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.QuotationId).HasColumnName("QUOTATION_ID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<LesSalesorder>(entity =>
    //    {
    //        entity.HasKey(e => e.Salesorderid);

    //        entity.ToTable("LES_SALESORDER");

    //        entity.Property(e => e.Salesorderid).HasColumnName("SALESORDERID");
    //        entity.Property(e => e.Amount).HasColumnName("AMOUNT");
    //        entity.Property(e => e.Buyerref)
    //            .HasMaxLength(30)
    //            .HasColumnName("BUYERREF");
    //        entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Currencyid).HasColumnName("CURRENCYID");
    //        entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");
    //        entity.Property(e => e.DeliveryDays).HasColumnName("DELIVERY_DAYS");
    //        entity.Property(e => e.Discount).HasColumnName("DISCOUNT");
    //        entity.Property(e => e.Freightamt).HasColumnName("FREIGHTAMT");
    //        entity.Property(e => e.GeneralTerms)
    //            .HasColumnType("ntext")
    //            .HasColumnName("GENERAL_TERMS");
    //        entity.Property(e => e.Othercosts).HasColumnName("OTHERCOSTS");
    //        entity.Property(e => e.PayTerms)
    //            .HasColumnType("ntext")
    //            .HasColumnName("PAY_TERMS");
    //        entity.Property(e => e.Profitmargin).HasColumnName("PROFITMARGIN");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteReference)
    //            .HasMaxLength(30)
    //            .HasColumnName("QUOTE_REFERENCE");
    //        entity.Property(e => e.QuoteSubject)
    //            .HasMaxLength(100)
    //            .HasColumnName("QUOTE_SUBJECT");
    //        entity.Property(e => e.QuoteValidity)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_VALIDITY");
    //        entity.Property(e => e.RfqDelDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_DEL_DATE");
    //        entity.Property(e => e.Salesorderno)
    //            .HasMaxLength(50)
    //            .HasColumnName("SALESORDERNO");
    //        entity.Property(e => e.Shipname)
    //            .HasMaxLength(50)
    //            .HasColumnName("SHIPNAME");
    //        entity.Property(e => e.Status).HasColumnName("STATUS");
    //        entity.Property(e => e.SupplierRemarks)
    //            .HasColumnType("ntext")
    //            .HasColumnName("SUPPLIER_REMARKS");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
    //        entity.Property(e => e.VesselEta)
    //            .HasColumnType("datetime")
    //            .HasColumnName("VESSEL_ETA");
    //    });

    //    modelBuilder.Entity<LesSalesorderDetail>(entity =>
    //    {
    //        entity.HasKey(e => e.Salesorderdetailid);

    //        entity.ToTable("LES_SALESORDER_DETAILS");

    //        entity.Property(e => e.Salesorderdetailid).HasColumnName("SALESORDERDETAILID");
    //        entity.Property(e => e.BuyerUnitprice).HasColumnName("BUYER_UNITPRICE");
    //        entity.Property(e => e.Buyerunitid).HasColumnName("BUYERUNITID");
    //        entity.Property(e => e.ConversionFactor).HasColumnName("CONVERSION_FACTOR");
    //        entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.DeliveryDays).HasColumnName("DELIVERY_DAYS");
    //        entity.Property(e => e.Discount).HasColumnName("DISCOUNT");
    //        entity.Property(e => e.Drawingno)
    //            .HasMaxLength(200)
    //            .HasColumnName("DRAWINGNO");
    //        entity.Property(e => e.Inventoryid).HasColumnName("INVENTORYID");
    //        entity.Property(e => e.ItemRemarks)
    //            .HasColumnType("ntext")
    //            .HasColumnName("ITEM_REMARKS");
    //        entity.Property(e => e.Itemno).HasColumnName("ITEMNO");
    //        entity.Property(e => e.Makerref)
    //            .HasMaxLength(50)
    //            .HasColumnName("MAKERREF");
    //        entity.Property(e => e.OrderedQty).HasColumnName("ORDERED_QTY");
    //        entity.Property(e => e.PackQty).HasColumnName("PACK_QTY");
    //        entity.Property(e => e.Partname)
    //            .HasMaxLength(1000)
    //            .HasColumnName("PARTNAME");
    //        entity.Property(e => e.PckUnitid).HasColumnName("PCK_UNITID");
    //        entity.Property(e => e.Posno)
    //            .HasMaxLength(200)
    //            .HasColumnName("POSNO");
    //        entity.Property(e => e.Profitmargin).HasColumnName("PROFITMARGIN");
    //        entity.Property(e => e.Qty).HasColumnName("QTY");
    //        entity.Property(e => e.Quotationdetailid).HasColumnName("QUOTATIONDETAILID");
    //        entity.Property(e => e.Refno)
    //            .HasMaxLength(200)
    //            .HasColumnName("REFNO");
    //        entity.Property(e => e.Salesorderid).HasColumnName("SALESORDERID");
    //        entity.Property(e => e.Stockable).HasColumnName("STOCKABLE");
    //        entity.Property(e => e.Stockinhand).HasColumnName("STOCKINHAND");
    //        entity.Property(e => e.Supplierunitid).HasColumnName("SUPPLIERUNITID");
    //        entity.Property(e => e.Tosplit).HasColumnName("TOSPLIT");
    //        entity.Property(e => e.Udf1)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF1");
    //        entity.Property(e => e.Udf2)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF2");
    //        entity.Property(e => e.Udf3)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF3");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
    //        entity.Property(e => e.VendorUnitprice).HasColumnName("VENDOR_UNITPRICE");
    //    });

    //    modelBuilder.Entity<LesShipmentDelivery>(entity =>
    //    {
    //        entity.HasKey(e => e.Shipmentid);

    //        entity.ToTable("LES_SHIPMENT_DELIVERIES");

    //        entity.Property(e => e.Shipmentid).HasColumnName("SHIPMENTID");
    //        entity.Property(e => e.AwbNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("AWB_NO");
    //        entity.Property(e => e.CoName)
    //            .HasMaxLength(50)
    //            .HasColumnName("CO_NAME");
    //        entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");
    //        entity.Property(e => e.DeliveredBy).HasColumnName("DELIVERED_BY");
    //        entity.Property(e => e.DeliveredByText)
    //            .HasMaxLength(50)
    //            .HasColumnName("DELIVERED_BY_TEXT");
    //        entity.Property(e => e.DocumentNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOCUMENT_NO");
    //        entity.Property(e => e.EtaDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("ETA_DATE");
    //        entity.Property(e => e.FromPort)
    //            .HasMaxLength(50)
    //            .HasColumnName("FROM_PORT");
    //        entity.Property(e => e.OrderDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("ORDER_DATE");
    //        entity.Property(e => e.OrderNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("ORDER_NO");
    //        entity.Property(e => e.OrderType)
    //            .HasMaxLength(20)
    //            .HasColumnName("ORDER_TYPE");
    //        entity.Property(e => e.Orderid).HasColumnName("ORDERID");
    //        entity.Property(e => e.Ordertypeid).HasColumnName("ORDERTYPEID");
    //        entity.Property(e => e.QtyPac).HasColumnName("QTY_PAC");
    //        entity.Property(e => e.ShipmentDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("SHIPMENT_DATE");
    //        entity.Property(e => e.ShipmentQty)
    //            .HasColumnType("decimal(18, 2)")
    //            .HasColumnName("SHIPMENT_QTY");
    //        entity.Property(e => e.Shipper)
    //            .HasMaxLength(50)
    //            .HasColumnName("SHIPPER");
    //        entity.Property(e => e.StatusText)
    //            .HasMaxLength(50)
    //            .HasColumnName("STATUS_TEXT");
    //        entity.Property(e => e.Statusid)
    //            .HasMaxLength(10)
    //            .IsFixedLength()
    //            .HasColumnName("STATUSID");
    //        entity.Property(e => e.ToPort)
    //            .HasMaxLength(50)
    //            .HasColumnName("TO_PORT");
    //        entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
    //        entity.Property(e => e.UpdatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATED_DATE");
    //        entity.Property(e => e.VesselName)
    //            .HasMaxLength(50)
    //            .HasColumnName("vessel_name");
    //        entity.Property(e => e.Vesselno)
    //            .HasMaxLength(20)
    //            .HasColumnName("VESSELNO");
    //        entity.Property(e => e.Weight).HasMaxLength(50);

    //        entity.HasOne(d => d.Order).WithMany(p => p.LesShipmentDeliveries)
    //            .HasForeignKey(d => d.Orderid)
    //            .HasConstraintName("FK__LES_SHIPM__ORDER__02E8FC28");
    //    });

    //    modelBuilder.Entity<LesStagingDefaultSummary>(entity =>
    //    {
    //        entity.HasKey(e => e.DefaultSummaryid);

    //        entity.ToTable("LES_STAGING_DEFAULT_SUMMARY");

    //        entity.Property(e => e.DefaultSummaryid).HasColumnName("DEFAULT_SUMMARYID");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.DateFromInt).HasColumnName("DATE_FROM_INT");
    //        entity.Property(e => e.DateToInt).HasColumnName("DATE_TO_INT");
    //        entity.Property(e => e.KpiId).HasColumnName("KPI_ID");
    //        entity.Property(e => e.TransactionResult)
    //            .HasColumnType("ntext")
    //            .HasColumnName("TRANSACTION_RESULT");
    //    });

    //    modelBuilder.Entity<LesStagingGroup>(entity =>
    //    {
    //        entity.HasKey(e => e.StagingGroupid);

    //        entity.ToTable("LES_STAGING_GROUPS");

    //        entity.Property(e => e.StagingGroupid).HasColumnName("STAGING_GROUPID");
    //        entity.Property(e => e.Brokerid).HasColumnName("BROKERID");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Category)
    //            .HasMaxLength(50)
    //            .HasColumnName("CATEGORY");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(10)
    //            .IsFixedLength()
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VesselName)
    //            .HasMaxLength(50)
    //            .HasColumnName("VESSEL_NAME");
    //    });

    //    modelBuilder.Entity<LesStagingGroupSummary>(entity =>
    //    {
    //        entity.HasKey(e => e.StagingGroupSummaryid);

    //        entity.ToTable("LES_STAGING_GROUP_SUMMARY");

    //        entity.Property(e => e.StagingGroupSummaryid).HasColumnName("STAGING_GROUP_SUMMARYID");
    //        entity.Property(e => e.DateInt).HasColumnName("DATE_INT");
    //        entity.Property(e => e.KpiId).HasColumnName("KPI_ID");
    //        entity.Property(e => e.StagingGroupid).HasColumnName("STAGING_GROUPID");
    //        entity.Property(e => e.TransactionResult)
    //            .HasColumnType("ntext")
    //            .HasColumnName("TRANSACTION_RESULT");
    //    });

    //    modelBuilder.Entity<LesStagingQuotationVendor>(entity =>
    //    {
    //        entity.HasKey(e => e.Quotationid);

    //        entity.ToTable("LES_STAGING_QUOTATION_VENDOR");

    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.ByrSuppLinkid).HasColumnName("BYR_SUPP_LINKID");
    //        entity.Property(e => e.Category)
    //            .HasMaxLength(50)
    //            .HasColumnName("CATEGORY");
    //        entity.Property(e => e.CreatedDateInt).HasColumnName("CREATED_DATE_INT");
    //        entity.Property(e => e.Currency)
    //            .HasMaxLength(50)
    //            .HasColumnName("CURRENCY");
    //        entity.Property(e => e.Deliverydays).HasColumnName("DELIVERYDAYS");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(25)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Exported).HasColumnName("EXPORTED");
    //        entity.Property(e => e.IsDeclined).HasColumnName("IS_DECLINED");
    //        entity.Property(e => e.Itemcount).HasColumnName("ITEMCOUNT");
    //        entity.Property(e => e.LinkRecordid).HasColumnName("LINK_RECORDID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.QuoteAmount).HasColumnName("QUOTE_AMOUNT");
    //        entity.Property(e => e.QuoteExchrate).HasColumnName("QUOTE_EXCHRATE");
    //        entity.Property(e => e.VendorStatus).HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.Vessel)
    //            .HasMaxLength(200)
    //            .HasColumnName("VESSEL");
    //    });

    //    modelBuilder.Entity<LesStatementofaccount>(entity =>
    //    {
    //        entity.HasKey(e => e.SoaId).HasName("PK_LeS_StatementOfAccount");

    //        entity.ToTable("LES_STATEMENTOFACCOUNT");

    //        entity.Property(e => e.SoaId).HasColumnName("SOA_ID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.CustCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("CUST_CODE");
    //        entity.Property(e => e.CustName)
    //            .HasMaxLength(200)
    //            .HasColumnName("CUST_NAME");
    //        entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(30)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Filename)
    //            .HasMaxLength(200)
    //            .HasColumnName("FILENAME");
    //        entity.Property(e => e.Month)
    //            .HasMaxLength(20)
    //            .HasColumnName("MONTH");
    //        entity.Property(e => e.SoaDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("SOA_DATE");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATED_DATE");
    //        entity.Property(e => e.Year).HasColumnName("YEAR");
    //    });

    //    modelBuilder.Entity<LesSupportTicket>(entity =>
    //    {
    //        entity.HasKey(e => e.AutoNumber);

    //        entity.ToTable("LES_SUPPORT_TICKETS", tb => tb.HasTrigger("trgAfterInsert_LES_SUPPORT_TICKETS"));

    //        entity.Property(e => e.AutoNumber).HasColumnName("AUTO_NUMBER");
    //        entity.Property(e => e.ClosedTime)
    //            .HasColumnType("datetime")
    //            .HasColumnName("closedTime");
    //        entity.Property(e => e.Comments)
    //            .HasMaxLength(1000)
    //            .HasColumnName("COMMENTS");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Description)
    //            .HasMaxLength(300)
    //            .HasColumnName("DESCRIPTION");
    //        entity.Property(e => e.Email)
    //            .HasMaxLength(300)
    //            .HasColumnName("EMAIL");
    //        entity.Property(e => e.Refkey1)
    //            .HasMaxLength(50)
    //            .HasColumnName("REFKEY1");
    //        entity.Property(e => e.Refkey2)
    //            .HasMaxLength(50)
    //            .HasColumnName("REFKEY2");
    //        entity.Property(e => e.Refkey3)
    //            .HasMaxLength(50)
    //            .HasColumnName("REFKEY3");
    //        entity.Property(e => e.Status)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("STATUS");
    //        entity.Property(e => e.Subject)
    //            .HasMaxLength(300)
    //            .HasColumnName("SUBJECT");
    //        entity.Property(e => e.TicketNo).HasColumnName("TICKET_NO");
    //        entity.Property(e => e.UpdateDate)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.ZohoId)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("ZOHO_ID");
    //        entity.Property(e => e.ZohoTeamid)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("ZOHO_TEAMID");
    //        entity.Property(e => e.ZohoThreadcount)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("ZOHO_THREADCOUNT");
    //        entity.Property(e => e.ZohoWeburl)
    //            .HasMaxLength(300)
    //            .IsUnicode(false)
    //            .HasColumnName("ZOHO_WEBURL");
    //    });

    //    modelBuilder.Entity<LesSupportTicketsLink>(entity =>
    //    {
    //        entity.HasKey(e => e.AutoNumber);

    //        entity.ToTable("LES_SUPPORT_TICKETS_LINK");

    //        entity.Property(e => e.AutoNumber).HasColumnName("AUTO_NUMBER");
    //        entity.Property(e => e.Refkey2)
    //            .HasMaxLength(50)
    //            .HasColumnName("REFKEY2");
    //        entity.Property(e => e.TicketNo).HasColumnName("TICKET_NO");
    //        entity.Property(e => e.UpdateDate).HasColumnType("datetime");
    //    });

    //    modelBuilder.Entity<LesTransaction>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("LES_TRANSACTIONS");

    //        entity.Property(e => e.AddDiscType).HasColumnName("ADD_DISC_TYPE");
    //        entity.Property(e => e.AdditionalDisc).HasColumnName("ADDITIONAL_DISC");
    //        entity.Property(e => e.Allowance).HasColumnName("ALLOWANCE");
    //        entity.Property(e => e.Attachment1)
    //            .HasMaxLength(150)
    //            .HasColumnName("ATTACHMENT1");
    //        entity.Property(e => e.Attachment2)
    //            .HasMaxLength(150)
    //            .HasColumnName("ATTACHMENT2");
    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.BuyerRemarks).HasColumnName("BUYER_REMARKS");
    //        entity.Property(e => e.BuyerVrno)
    //            .HasMaxLength(250)
    //            .HasColumnName("BUYER_VRNO");
    //        entity.Property(e => e.ByrSuppLinkid).HasColumnName("BYR_SUPP_LINKID");
    //        entity.Property(e => e.ChangedByVendor).HasColumnName("CHANGED_BY_VENDOR");
    //        entity.Property(e => e.ContractType).HasMaxLength(50);
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.CreatedDateInt).HasColumnName("CREATED_DATE_INT");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(3)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.Currencyid).HasColumnName("CURRENCYID");
    //        entity.Property(e => e.DeliveryPromised)
    //            .HasColumnType("datetime")
    //            .HasColumnName("DELIVERY_PROMISED");
    //        entity.Property(e => e.Deliverydays).HasColumnName("DELIVERYDAYS");
    //        entity.Property(e => e.Deliverytime)
    //            .HasColumnType("datetime")
    //            .HasColumnName("DELIVERYTIME");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.DocXml)
    //            .HasMaxLength(5)
    //            .HasColumnName("DOC_XML");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(256)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.Exported).HasColumnName("EXPORTED");
    //        entity.Property(e => e.FileEndState).HasColumnName("FILE_END_STATE");
    //        entity.Property(e => e.FileExport)
    //            .HasColumnType("datetime")
    //            .HasColumnName("FILE_EXPORT");
    //        entity.Property(e => e.FileImport)
    //            .HasColumnType("datetime")
    //            .HasColumnName("FILE_IMPORT");
    //        entity.Property(e => e.FileStatus).HasColumnName("FILE_STATUS");
    //        entity.Property(e => e.FileType)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("FILE_TYPE");
    //        entity.Property(e => e.FileUpload)
    //            .HasColumnType("datetime")
    //            .HasColumnName("FILE_UPLOAD");
    //        entity.Property(e => e.Freightamt).HasColumnName("FREIGHTAMT");
    //        entity.Property(e => e.GeneralTerms).HasColumnName("GENERAL_TERMS");
    //        entity.Property(e => e.HasAttachment)
    //            .HasMaxLength(1)
    //            .IsUnicode(false)
    //            .HasColumnName("HAS_ATTACHMENT");
    //        entity.Property(e => e.IsDeclined).HasColumnName("IS_DECLINED");
    //        entity.Property(e => e.ItemTotal).HasColumnName("ITEM_TOTAL");
    //        entity.Property(e => e.Latedate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("LATEDATE");
    //        entity.Property(e => e.LinkRecordid).HasColumnName("LINK_RECORDID");
    //        entity.Property(e => e.Location)
    //            .HasMaxLength(200)
    //            .HasColumnName("LOCATION");
    //        entity.Property(e => e.OrderHandling).HasMaxLength(50);
    //        entity.Property(e => e.OrderType).HasMaxLength(300);
    //        entity.Property(e => e.OrgSystemRef).HasMaxLength(100);
    //        entity.Property(e => e.OriginatingRequestNo).HasMaxLength(50);
    //        entity.Property(e => e.OtherCost2).HasColumnName("OTHER_COST2");
    //        entity.Property(e => e.OtherCost3).HasColumnName("OTHER_COST3");
    //        entity.Property(e => e.Othercosts).HasColumnName("OTHERCOSTS");
    //        entity.Property(e => e.PayTerms).HasColumnName("PAY_TERMS");
    //        entity.Property(e => e.Payloadid)
    //            .HasMaxLength(100)
    //            .HasColumnName("PAYLOADID");
    //        entity.Property(e => e.PaymentTerms).HasColumnName("PAYMENT_TERMS");
    //        entity.Property(e => e.PoAckDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PO_ACK_DATE");
    //        entity.Property(e => e.PocBy).HasColumnName("POC_BY");
    //        entity.Property(e => e.PocDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("POC_DATE");
    //        entity.Property(e => e.PocReference)
    //            .HasMaxLength(50)
    //            .HasColumnName("POC_REFERENCE");
    //        entity.Property(e => e.Podate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PODATE");
    //        entity.Property(e => e.PortCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("PORT_CODE");
    //        entity.Property(e => e.PortName)
    //            .HasMaxLength(100)
    //            .HasColumnName("PORT_NAME");
    //        entity.Property(e => e.PrintStatus).HasColumnName("PRINT_STATUS");
    //        entity.Property(e => e.Priority).HasColumnName("PRIORITY");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.QuoteAmount).HasColumnName("QUOTE_AMOUNT");
    //        entity.Property(e => e.QuoteApproveddate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_APPROVEDDATE");
    //        entity.Property(e => e.QuoteDiscount).HasColumnName("QUOTE_DISCOUNT");
    //        entity.Property(e => e.QuoteExchrate).HasColumnName("QUOTE_EXCHRATE");
    //        entity.Property(e => e.QuoteFileRef)
    //            .HasMaxLength(150)
    //            .HasColumnName("QUOTE_FILE_REF");
    //        entity.Property(e => e.QuoteFileStamp)
    //            .HasMaxLength(50)
    //            .HasColumnName("QUOTE_FILE_STAMP");
    //        entity.Property(e => e.QuoteRecvdDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_RECVD_DATE");
    //        entity.Property(e => e.QuoteReference)
    //            .HasMaxLength(50)
    //            .HasColumnName("QUOTE_REFERENCE");
    //        entity.Property(e => e.QuoteRemarks).HasColumnName("QUOTE_REMARKS");
    //        entity.Property(e => e.QuoteSubject)
    //            .HasMaxLength(1000)
    //            .HasColumnName("QUOTE_SUBJECT");
    //        entity.Property(e => e.QuoteSubmitBy).HasColumnName("QUOTE_SUBMIT_BY");
    //        entity.Property(e => e.QuoteSubmitDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_SUBMIT_DATE");
    //        entity.Property(e => e.QuoteValidity)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_VALIDITY");
    //        entity.Property(e => e.QuoteVersion).HasColumnName("QUOTE_VERSION");
    //        entity.Property(e => e.ReplyByDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("REPLY_BY_DATE");
    //        entity.Property(e => e.RevisionNumber).HasMaxLength(50);
    //        entity.Property(e => e.RfqAckDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_ACK_DATE");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //        entity.Property(e => e.RfqSentDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_SENT_DATE");
    //        entity.Property(e => e.SentBy).HasColumnName("SENT_BY");
    //        entity.Property(e => e.ShipComplete).HasMaxLength(20);
    //        entity.Property(e => e.Siteid).HasColumnName("SITEID");
    //        entity.Property(e => e.SpMasRemark)
    //            .HasMaxLength(500)
    //            .HasColumnName("SP_MAS_REMARK");
    //        entity.Property(e => e.Status)
    //            .HasMaxLength(9)
    //            .IsUnicode(false)
    //            .HasColumnName("STATUS");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.SupplierOrgref)
    //            .HasMaxLength(50)
    //            .HasColumnName("SupplierORGRef");
    //        entity.Property(e => e.SupplierVrno)
    //            .HasMaxLength(250)
    //            .HasColumnName("SUPPLIER_VRNO");
    //        entity.Property(e => e.TaxAmount).HasColumnName("TAX_AMOUNT");
    //        entity.Property(e => e.TaxPercnt).HasColumnName("TAX_PERCNT");
    //        entity.Property(e => e.TransportMode)
    //            .HasMaxLength(20)
    //            .HasColumnName("TRANSPORT_MODE");
    //        entity.Property(e => e.Udf1)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF1");
    //        entity.Property(e => e.Udf2)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF2");
    //        entity.Property(e => e.Udf3)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF3");
    //        entity.Property(e => e.UpdType).HasMaxLength(50);
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UpdateDateInt).HasColumnName("UPDATE_DATE_INT");
    //        entity.Property(e => e.VendorStatus).HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.Version).HasColumnName("VERSION");
    //        entity.Property(e => e.VesselEta)
    //            .HasColumnType("datetime")
    //            .HasColumnName("VESSEL_ETA");
    //        entity.Property(e => e.VesselEtd)
    //            .HasColumnType("datetime")
    //            .HasColumnName("VESSEL_ETD");
    //        entity.Property(e => e.VesselIdno)
    //            .HasMaxLength(100)
    //            .HasColumnName("VESSEL_IDNO");
    //        entity.Property(e => e.VesselName)
    //            .HasMaxLength(200)
    //            .HasColumnName("VESSEL_NAME");
    //        entity.Property(e => e.VesselOwner)
    //            .HasMaxLength(150)
    //            .HasColumnName("VESSEL_OWNER");
    //        entity.Property(e => e.VesselOwnerCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("VESSEL_OWNER_CODE");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(250)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<LesTransactionsCount>(entity =>
    //    {
    //        entity.HasKey(e => e.TransactionId);

    //        entity.ToTable("LES_TRANSACTIONS_COUNT");

    //        entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
    //        entity.Property(e => e.ClientCode)
    //            .HasMaxLength(50)
    //            .IsFixedLength();
    //        entity.Property(e => e.ExecutionDate).HasColumnType("datetime");
    //        entity.Property(e => e.Poccount).HasColumnName("POCCount");
    //        entity.Property(e => e.Pocount).HasColumnName("POCount");
    //        entity.Property(e => e.Rfqcount).HasColumnName("RFQCount");
    //    });

    //    modelBuilder.Entity<LesUserCustomerLink>(entity =>
    //    {
    //        entity.HasKey(e => e.Usercustomerlinkid);

    //        entity.ToTable("LES_USER_CUSTOMER_LINKS");

    //        entity.Property(e => e.Usercustomerlinkid).HasColumnName("USERCUSTOMERLINKID");
    //        entity.Property(e => e.Companyid).HasColumnName("COMPANYID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.CustomerAddressid).HasColumnName("CUSTOMER_ADDRESSID");
    //        entity.Property(e => e.IsConnected).HasColumnName("IS_CONNECTED");
    //        entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
    //        entity.Property(e => e.UpdatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATED_DATE");
    //        entity.Property(e => e.Userid).HasColumnName("USERID");
    //        entity.Property(e => e.Usertypeid).HasColumnName("USERTYPEID");
    //    });

    //    modelBuilder.Entity<LesUsertype>(entity =>
    //    {
    //        entity.HasKey(e => e.Usertypeid).IsClustered(false);

    //        entity.ToTable("LES_USERTYPE");

    //        entity.Property(e => e.Usertypeid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("USERTYPEID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UsertypeLevel).HasColumnName("USERTYPE_LEVEL");
    //        entity.Property(e => e.Usertypedescr)
    //            .HasMaxLength(50)
    //            .HasColumnName("USERTYPEDESCR");
    //    });

    //    modelBuilder.Entity<LesUsertypeModuleAccess>(entity =>
    //    {
    //        entity.HasKey(e => e.Moduleaccessid).IsClustered(false);

    //        entity.ToTable("LES_USERTYPE_MODULE_ACCESS");

    //        entity.Property(e => e.Moduleaccessid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("MODULEACCESSID");
    //        entity.Property(e => e.AccessLevel).HasColumnName("ACCESS_LEVEL");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Moduleid).HasColumnName("MODULEID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.Usertypeid).HasColumnName("USERTYPEID");

    //        entity.HasOne(d => d.Usertype).WithMany(p => p.LesUsertypeModuleAccesses)
    //            .HasForeignKey(d => d.Usertypeid)
    //            .HasConstraintName("FK_LES_USERTYPE_MODULE_ACCESS_LES_USERTYPE");
    //    });

    //    modelBuilder.Entity<LesVBrokerCustomerLink>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("LES_V_BROKER_CUSTOMER_LINK");

    //        entity.Property(e => e.AddrType)
    //            .HasMaxLength(10)
    //            .HasColumnName("ADDR_TYPE");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.BrokerName).HasColumnName("BROKER_NAME");
    //        entity.Property(e => e.Brokercustlinkid).HasColumnName("BROKERCUSTLINKID");
    //        entity.Property(e => e.Brokerid).HasColumnName("BROKERID");
    //        entity.Property(e => e.Companyid).HasColumnName("COMPANYID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.CustCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("CUST_CODE");
    //        entity.Property(e => e.CustName)
    //            .HasMaxLength(50)
    //            .HasColumnName("CUST_NAME");
    //        entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");
    //        entity.Property(e => e.IsConnected).HasColumnName("IS_CONNECTED");
    //        entity.Property(e => e.RowNum).HasColumnName("ROW_NUM");
    //        entity.Property(e => e.UpdatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATED_DATE");
    //    });

    //    modelBuilder.Entity<LesVUserCustomerLink>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("LES_V_USER_CUSTOMER_LINKS");

    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.CompanyCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("COMPANY_CODE");
    //        entity.Property(e => e.CompanyDescription)
    //            .HasMaxLength(255)
    //            .HasColumnName("COMPANY_DESCRIPTION");
    //        entity.Property(e => e.Companyid).HasColumnName("COMPANYID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.CustCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("CUST_CODE");
    //        entity.Property(e => e.CustName)
    //            .HasMaxLength(200)
    //            .HasColumnName("CUST_NAME");
    //        entity.Property(e => e.CustomerAddressid).HasColumnName("CUSTOMER_ADDRESSID");
    //        entity.Property(e => e.ExUsercode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("EX_USERCODE");
    //        entity.Property(e => e.ExUsername).HasColumnName("EX_USERNAME");
    //        entity.Property(e => e.IsConnected).HasColumnName("IS_CONNECTED");
    //        entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");
    //        entity.Property(e => e.UpdatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATED_DATE");
    //        entity.Property(e => e.Usercustomerlinkid).HasColumnName("USERCUSTOMERLINKID");
    //        entity.Property(e => e.Userid).HasColumnName("USERID");
    //        entity.Property(e => e.Usertypedescr)
    //            .HasMaxLength(50)
    //            .HasColumnName("USERTYPEDESCR");
    //        entity.Property(e => e.Usertypeid).HasColumnName("USERTYPEID");
    //    });

    //    modelBuilder.Entity<LesvCustomer>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("LESV_CUSTOMERS");

    //        entity.Property(e => e.AddrCity)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDR_CITY");
    //        entity.Property(e => e.AddrCountry)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDR_COUNTRY");
    //        entity.Property(e => e.AddrState)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDR_STATE");
    //        entity.Property(e => e.AddrType)
    //            .HasMaxLength(10)
    //            .HasColumnName("ADDR_TYPE");
    //        entity.Property(e => e.Address1)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDRESS1");
    //        entity.Property(e => e.Address2)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDRESS2");
    //        entity.Property(e => e.Address3)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDRESS3");
    //        entity.Property(e => e.Address4)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDRESS4");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.BalanceLcy).HasColumnName("BALANCE_LCY");
    //        entity.Property(e => e.BrokerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BROKER_CODE");
    //        entity.Property(e => e.BrokerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BROKER_NAME");
    //        entity.Property(e => e.Brokerid).HasColumnName("BROKERID");
    //        entity.Property(e => e.CompanyName)
    //            .HasMaxLength(50)
    //            .HasColumnName("COMPANY_NAME");
    //        entity.Property(e => e.Companyid).HasColumnName("COMPANYID");
    //        entity.Property(e => e.ContactPersonName)
    //            .HasMaxLength(50)
    //            .HasColumnName("CONTACT_PERSON_NAME");
    //        entity.Property(e => e.ContactPersonid).HasColumnName("CONTACT_PERSONID");
    //        entity.Property(e => e.CreditLimit).HasColumnName("CREDIT_LIMIT");
    //        entity.Property(e => e.CreditlimitUsage).HasColumnName("CREDITLIMIT_USAGE");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(10)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.Currencyid).HasColumnName("CURRENCYID");
    //        entity.Property(e => e.CustCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("CUST_CODE");
    //        entity.Property(e => e.CustName)
    //            .HasMaxLength(200)
    //            .HasColumnName("CUST_NAME");
    //        entity.Property(e => e.CustType)
    //            .HasMaxLength(50)
    //            .HasColumnName("CUST_TYPE");
    //        entity.Property(e => e.Customerid).HasColumnName("CUSTOMERID");
    //        entity.Property(e => e.Emailid)
    //            .HasMaxLength(50)
    //            .HasColumnName("EMAILID");
    //        entity.Property(e => e.Fax)
    //            .HasMaxLength(50)
    //            .HasColumnName("FAX");
    //        entity.Property(e => e.Homepage).HasColumnName("HOMEPAGE");
    //        entity.Property(e => e.ParentCode).HasColumnName("PARENT_CODE");
    //        entity.Property(e => e.ParentName).HasColumnName("PARENT_NAME");
    //        entity.Property(e => e.Parentid).HasColumnName("PARENTID");
    //        entity.Property(e => e.PaymentTerms)
    //            .HasMaxLength(50)
    //            .HasColumnName("PAYMENT_TERMS");
    //        entity.Property(e => e.Paytermsid).HasColumnName("PAYTERMSID");
    //        entity.Property(e => e.Phone)
    //            .HasMaxLength(50)
    //            .HasColumnName("PHONE");
    //        entity.Property(e => e.Zipcode)
    //            .HasMaxLength(50)
    //            .HasColumnName("ZIPCODE");
    //    });

    //    modelBuilder.Entity<LesvDashboardAddress>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("LESV_DASHBOARD_ADDRESS");

    //        entity.Property(e => e.AddrCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("ADDR_CODE");
    //        entity.Property(e => e.AddrName)
    //            .HasMaxLength(200)
    //            .HasColumnName("ADDR_NAME");
    //        entity.Property(e => e.AddrType)
    //            .HasMaxLength(10)
    //            .HasColumnName("ADDR_TYPE");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //    });

    //    modelBuilder.Entity<LesvDashboardUser>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("LESV_DASHBOARD_USERS");

    //        entity.Property(e => e.AddrCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("ADDR_CODE");
    //        entity.Property(e => e.AddrName)
    //            .HasMaxLength(200)
    //            .HasColumnName("ADDR_NAME");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.Companyid).HasColumnName("COMPANYID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.DashboardAccess).HasColumnName("DASHBOARD_ACCESS");
    //        entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");
    //        entity.Property(e => e.Loginid)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("LOGINID");
    //        entity.Property(e => e.Mail).HasColumnName("MAIL");
    //        entity.Property(e => e.SecCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("SEC_CODE");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UserStatus)
    //            .HasMaxLength(3)
    //            .IsUnicode(false)
    //            .HasColumnName("USER_STATUS");
    //        entity.Property(e => e.Userid).HasColumnName("USERID");
    //        entity.Property(e => e.Username).HasColumnName("USERNAME");
    //        entity.Property(e => e.Usertype).HasColumnName("USERTYPE");
    //        entity.Property(e => e.Usertypedescr)
    //            .HasMaxLength(50)
    //            .HasColumnName("USERTYPEDESCR");
    //    });

    //    modelBuilder.Entity<MastCompany>(entity =>
    //    {
    //        entity.HasKey(e => e.Companyid);

    //        entity.ToTable("MAST_COMPANY");

    //        entity.Property(e => e.Companyid).HasColumnName("COMPANYID");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.CompanyCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("COMPANY_CODE");
    //        entity.Property(e => e.CompanyDescription)
    //            .HasMaxLength(255)
    //            .HasColumnName("COMPANY_DESCRIPTION");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("date")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Logopath)
    //            .HasMaxLength(50)
    //            .HasColumnName("LOGOPATH");
    //        entity.Property(e => e.UpdatedDate)
    //            .HasColumnType("date")
    //            .HasColumnName("UPDATED_DATE");
    //    });

    //    modelBuilder.Entity<MtmlDeliveryTerm>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToTable("MTML_DELIVERY_TERMS");

    //        entity.Property(e => e.DelTermCode)
    //            .HasMaxLength(10)
    //            .HasColumnName("DEL_TERM_CODE");
    //        entity.Property(e => e.DelTermDesc)
    //            .HasMaxLength(50)
    //            .HasColumnName("DEL_TERM_DESC");
    //        entity.Property(e => e.DelTermId)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("DEL_TERM_ID");
    //    });

    //    modelBuilder.Entity<MtmlDocAmount>(entity =>
    //    {
    //        entity.HasKey(e => e.Amountid);

    //        entity.ToTable("MTML_DOC_AMOUNTS", tb => tb.HasTrigger("trgAfterInsertDOC_AMOUNTS_MTML"));

    //        entity.HasIndex(e => e.Autoid, "IX_AutoID").IsUnique();

    //        entity.HasIndex(e => e.Mtmldocid, "NonClusteredIndex-MTMLDOCID");

    //        entity.Property(e => e.Amountid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("AMOUNTID");
    //        entity.Property(e => e.AmtValue).HasColumnName("AMT_VALUE");
    //        entity.Property(e => e.Autoid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("AUTOID");
    //        entity.Property(e => e.Mtmldocid).HasColumnName("MTMLDOCID");
    //        entity.Property(e => e.Qualifier)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("QUALIFIER");
    //        entity.Property(e => e.UpdateDate)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<MtmlDocComment>(entity =>
    //    {
    //        entity.ToTable("MTML_DOC_COMMENTS", tb => tb.HasTrigger("trgAfterInsertDocCommentsMTML"));

    //        entity.HasIndex(e => e.Autoid, "IX_AutoID").IsUnique();

    //        entity.HasIndex(e => e.Qualifier, "NonClusteredIndex-20160120-161418");

    //        entity.HasIndex(e => e.Mtmldocid, "NonClusteredIndex-MTMLDOCID");

    //        entity.Property(e => e.Mtmldoccommentid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("MTMLDOCCOMMENTID");
    //        entity.Property(e => e.Autoid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("AUTOID");
    //        entity.Property(e => e.Comments)
    //            .HasMaxLength(3000)
    //            .HasColumnName("COMMENTS");
    //        entity.Property(e => e.Mtmldocid).HasColumnName("MTMLDOCID");
    //        entity.Property(e => e.Qualifier)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("QUALIFIER");
    //        entity.Property(e => e.UpdateDate)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<MtmlDocDatetime>(entity =>
    //    {
    //        entity.ToTable("MTML_DOC_DATETIME");

    //        entity.HasIndex(e => e.Autoid, "IX_AutoID").IsUnique();

    //        entity.Property(e => e.Mtmldocdatetimeid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("MTMLDOCDATETIMEID");
    //        entity.Property(e => e.Autoid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("AUTOID");
    //        entity.Property(e => e.DateValue)
    //            .HasMaxLength(20)
    //            .HasColumnName("DATE_VALUE");
    //        entity.Property(e => e.Formatqualifier)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("FORMATQUALIFIER");
    //        entity.Property(e => e.Mtmldocid).HasColumnName("MTMLDOCID");
    //        entity.Property(e => e.Qualifier)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("QUALIFIER");
    //        entity.Property(e => e.UpdateDate)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<MtmlDocHeader>(entity =>
    //    {
    //        entity.HasKey(e => e.Mtmldocheaderid).IsClustered(false);

    //        entity.ToTable("MTML_DOC_HEADER", tb =>
    //            {
    //                tb.HasTrigger("trgAfterInsertDocHeaderMTML");
    //                tb.HasTrigger("trgAfterInsertDocHeaderMTML_UPD");
    //            });

    //        entity.HasIndex(e => e.Autoid, "IX_AutoID")
    //            .IsUnique()
    //            .IsClustered();

    //        entity.HasIndex(e => e.Mtmldocid, "NonClusteredIndex-MTMLDOCID");

    //        entity.Property(e => e.Mtmldocheaderid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("MTMLDOCHEADERID");
    //        entity.Property(e => e.AdditionalDisc)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("ADDITIONAL_DISC");
    //        entity.Property(e => e.Associationassignedcode)
    //            .HasMaxLength(20)
    //            .HasColumnName("ASSOCIATIONASSIGNEDCODE");
    //        entity.Property(e => e.Autoid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("AUTOID");
    //        entity.Property(e => e.BuyerRefno)
    //            .HasMaxLength(250)
    //            .HasColumnName("BUYER_REFNO");
    //        entity.Property(e => e.ContractType).HasMaxLength(50);
    //        entity.Property(e => e.ControlReference).HasMaxLength(50);
    //        entity.Property(e => e.Controllingagency)
    //            .HasMaxLength(5)
    //            .HasColumnName("CONTROLLINGAGENCY");
    //        entity.Property(e => e.Currencycode)
    //            .HasMaxLength(5)
    //            .HasColumnName("CURRENCYCODE");
    //        entity.Property(e => e.Deliverytermscode)
    //            .HasMaxLength(50)
    //            .HasColumnName("DELIVERYTERMSCODE");
    //        entity.Property(e => e.DepartmentCode).HasMaxLength(50);
    //        entity.Property(e => e.Doctype)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOCTYPE");
    //        entity.Property(e => e.EquipDtls)
    //            .HasMaxLength(500)
    //            .HasColumnName("EQUIP_DTLS");
    //        entity.Property(e => e.EquipName)
    //            .HasMaxLength(512)
    //            .HasColumnName("EQUIP_NAME");
    //        entity.Property(e => e.EquipType)
    //            .HasMaxLength(255)
    //            .HasColumnName("EQUIP_TYPE");
    //        entity.Property(e => e.Functioncode)
    //            .HasMaxLength(20)
    //            .HasColumnName("FUNCTIONCODE");
    //        entity.Property(e => e.Linecount).HasColumnName("LINECOUNT");
    //        entity.Property(e => e.Manufacturer)
    //            .HasMaxLength(300)
    //            .HasColumnName("MANUFACTURER");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(250)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(150)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.ModelNumber).HasMaxLength(100);
    //        entity.Property(e => e.Mtmldocid).HasColumnName("MTMLDOCID");
    //        entity.Property(e => e.OrderHandling).HasMaxLength(50);
    //        entity.Property(e => e.OrderType).HasMaxLength(300);
    //        entity.Property(e => e.OriginatingRequestNo).HasMaxLength(50);
    //        entity.Property(e => e.Originatingsystemref)
    //            .HasMaxLength(100)
    //            .HasColumnName("ORIGINATINGSYSTEMREF");
    //        entity.Property(e => e.PortCode)
    //            .HasMaxLength(30)
    //            .HasColumnName("PORT_CODE");
    //        entity.Property(e => e.PortName)
    //            .HasMaxLength(150)
    //            .HasColumnName("PORT_NAME");
    //        entity.Property(e => e.Priority)
    //            .HasMaxLength(50)
    //            .HasColumnName("PRIORITY");
    //        entity.Property(e => e.Releasenumber)
    //            .HasMaxLength(50)
    //            .HasColumnName("RELEASENUMBER");
    //        entity.Property(e => e.RevisionNumber).HasMaxLength(50);
    //        entity.Property(e => e.ShipComplete).HasMaxLength(30);
    //        entity.Property(e => e.SupplierOrgref)
    //            .HasMaxLength(50)
    //            .HasColumnName("SupplierORGRef");
    //        entity.Property(e => e.Taxstatus)
    //            .HasMaxLength(50)
    //            .HasColumnName("TAXSTATUS");
    //        entity.Property(e => e.TotalAmount).HasColumnName("TOTAL_AMOUNT");
    //        entity.Property(e => e.TransportModeCode).HasMaxLength(20);
    //        entity.Property(e => e.Udf1)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF1");
    //        entity.Property(e => e.Udf2)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF2");
    //        entity.Property(e => e.Udf3)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF3");
    //        entity.Property(e => e.UpdType).HasMaxLength(50);
    //        entity.Property(e => e.UpdateDate)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.Versionnumber)
    //            .HasMaxLength(50)
    //            .HasColumnName("VERSIONNUMBER");
    //    });

    //    modelBuilder.Entity<MtmlDocItem>(entity =>
    //    {
    //        entity.HasKey(e => e.Mtmldocitemid).IsClustered(false);

    //        entity.ToTable("MTML_DOC_ITEM");

    //        entity.HasIndex(e => e.Autoid, "IX_AutoID")
    //            .IsUnique()
    //            .IsClustered();

    //        entity.HasIndex(e => e.Mtmldocid, "NonClusteredIndex-MTMLDOCID");

    //        entity.Property(e => e.Mtmldocitemid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("MTMLDOCITEMID");
    //        entity.Property(e => e.Autoid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("AUTOID");
    //        entity.Property(e => e.BuyerOrgref)
    //            .HasMaxLength(50)
    //            .HasColumnName("BuyerORGRef");
    //        entity.Property(e => e.Comments)
    //            .HasMaxLength(2048)
    //            .HasColumnName("COMMENTS");
    //        entity.Property(e => e.Discountedamount).HasColumnName("DISCOUNTEDAMOUNT");
    //        entity.Property(e => e.ExternalItemNumber).HasMaxLength(50);
    //        entity.Property(e => e.Impa)
    //            .HasMaxLength(50)
    //            .HasColumnName("IMPA");
    //        entity.Property(e => e.Issa)
    //            .HasMaxLength(50)
    //            .HasColumnName("ISSA");
    //        entity.Property(e => e.ItemDescription)
    //            .HasMaxLength(1000)
    //            .HasColumnName("ITEM_DESCRIPTION");
    //        entity.Property(e => e.ItemType).HasMaxLength(50);
    //        entity.Property(e => e.Lineitemnumber).HasColumnName("LINEITEMNUMBER");
    //        entity.Property(e => e.Listprice).HasColumnName("LISTPRICE");
    //        entity.Property(e => e.Mtmldocid).HasColumnName("MTMLDOCID");
    //        entity.Property(e => e.Originatingsystemref)
    //            .HasMaxLength(50)
    //            .HasColumnName("ORIGINATINGSYSTEMREF");
    //        entity.Property(e => e.Partcode)
    //            .HasMaxLength(10)
    //            .HasColumnName("PARTCODE");
    //        entity.Property(e => e.Partnumber)
    //            .HasMaxLength(512)
    //            .HasColumnName("PARTNUMBER");
    //        entity.Property(e => e.Partunit)
    //            .HasMaxLength(200)
    //            .HasColumnName("PARTUNIT");
    //        entity.Property(e => e.Priority)
    //            .HasMaxLength(50)
    //            .HasColumnName("PRIORITY");
    //        entity.Property(e => e.Quantity)
    //            .HasMaxLength(50)
    //            .HasColumnName("QUANTITY");
    //        entity.Property(e => e.SupplierOrgref)
    //            .HasMaxLength(50)
    //            .HasColumnName("SupplierORGRef");
    //        entity.Property(e => e.SupplierRefno)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_REFNO");
    //        entity.Property(e => e.SupplierRemarks)
    //            .HasMaxLength(500)
    //            .HasColumnName("SUPPLIER_REMARKS");
    //        entity.Property(e => e.SysItemno).HasColumnName("SYS_ITEMNO");
    //        entity.Property(e => e.Udf1)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF1");
    //        entity.Property(e => e.Udf2)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF2");
    //        entity.Property(e => e.Udf3)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF3");
    //        entity.Property(e => e.Unitprice).HasColumnName("UNITPRICE");
    //        entity.Property(e => e.UpdateDate)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.VendorItemname)
    //            .HasMaxLength(500)
    //            .HasColumnName("VENDOR_ITEMNAME");
    //        entity.Property(e => e.VendorItemno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VENDOR_ITEMNO");
    //    });

    //    modelBuilder.Entity<MtmlDocItemEquipment>(entity =>
    //    {
    //        entity.HasKey(e => e.Itemequipid);

    //        entity.ToTable("MTML_DOC_ITEM_EQUIPMENT");

    //        entity.HasIndex(e => e.Autoid, "IX_AutoID").IsUnique();

    //        entity.HasIndex(e => e.Mtmldocid, "MTMLDOCID");

    //        entity.Property(e => e.Itemequipid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("ITEMEQUIPID");
    //        entity.Property(e => e.Autoid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("AUTOID");
    //        entity.Property(e => e.Description)
    //            .HasMaxLength(512)
    //            .HasColumnName("DESCRIPTION");
    //        entity.Property(e => e.Drawingnumber)
    //            .HasMaxLength(200)
    //            .HasColumnName("DRAWINGNUMBER");
    //        entity.Property(e => e.EquipName)
    //            .HasMaxLength(512)
    //            .HasColumnName("EQUIP_NAME");
    //        entity.Property(e => e.Manufacturer)
    //            .HasMaxLength(512)
    //            .HasColumnName("MANUFACTURER");
    //        entity.Property(e => e.Modeltype)
    //            .HasMaxLength(200)
    //            .HasColumnName("MODELTYPE");
    //        entity.Property(e => e.Mtmldocid).HasColumnName("MTMLDOCID");
    //        entity.Property(e => e.Mtmlitemid).HasColumnName("MTMLITEMID");
    //        entity.Property(e => e.Serialnumber)
    //            .HasMaxLength(200)
    //            .HasColumnName("SERIALNUMBER");
    //        entity.Property(e => e.UpdateDate)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<MtmlDocParty>(entity =>
    //    {
    //        entity.HasKey(e => e.Mtmlpartyid).IsClustered(false);

    //        entity.ToTable("MTML_DOC_PARTY", tb => tb.HasTrigger("trgAfterInsertPartyAddress"));

    //        entity.HasIndex(e => e.Autoid, "IX_AutoID")
    //            .IsUnique()
    //            .IsClustered();

    //        entity.HasIndex(e => e.Qualifier, "NonClusteredIndex-20160120-161336");

    //        entity.HasIndex(e => e.Mtmldocid, "NonClusteredIndex-MTMLDOCID");

    //        entity.Property(e => e.Mtmlpartyid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("MTMLPARTYID");
    //        entity.Property(e => e.Autoid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("AUTOID");
    //        entity.Property(e => e.City)
    //            .HasMaxLength(150)
    //            .HasColumnName("CITY");
    //        entity.Property(e => e.ContactName)
    //            .HasMaxLength(100)
    //            .HasColumnName("CONTACT_NAME");
    //        entity.Property(e => e.Countrycode)
    //            .HasMaxLength(50)
    //            .HasColumnName("COUNTRYCODE");
    //        entity.Property(e => e.Email)
    //            .HasMaxLength(100)
    //            .HasColumnName("EMAIL");
    //        entity.Property(e => e.EmailBcc)
    //            .HasMaxLength(150)
    //            .HasColumnName("EMAIL_BCC");
    //        entity.Property(e => e.EmailCc)
    //            .HasMaxLength(150)
    //            .HasColumnName("EMAIL_CC");
    //        entity.Property(e => e.Fax)
    //            .HasMaxLength(50)
    //            .HasColumnName("FAX");
    //        entity.Property(e => e.Functioncode)
    //            .HasMaxLength(50)
    //            .HasColumnName("FUNCTIONCODE");
    //        entity.Property(e => e.Identification)
    //            .HasMaxLength(150)
    //            .HasColumnName("IDENTIFICATION");
    //        entity.Property(e => e.Mtmldocid).HasColumnName("MTMLDOCID");
    //        entity.Property(e => e.PartyLocation)
    //            .HasMaxLength(50)
    //            .HasColumnName("PARTY_LOCATION");
    //        entity.Property(e => e.PartyName)
    //            .HasMaxLength(512)
    //            .HasColumnName("PARTY_NAME");
    //        entity.Property(e => e.Phonenumber)
    //            .HasMaxLength(50)
    //            .HasColumnName("PHONENUMBER");
    //        entity.Property(e => e.Postcode)
    //            .HasMaxLength(50)
    //            .HasColumnName("POSTCODE");
    //        entity.Property(e => e.Qualifier)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("QUALIFIER");
    //        entity.Property(e => e.State)
    //            .HasMaxLength(50)
    //            .HasColumnName("STATE");
    //        entity.Property(e => e.Streetaddress)
    //            .HasMaxLength(1024)
    //            .HasColumnName("STREETADDRESS");
    //        entity.Property(e => e.Streetaddress2)
    //            .HasMaxLength(250)
    //            .HasColumnName("STREETADDRESS2");
    //        entity.Property(e => e.Streetaddress3)
    //            .HasMaxLength(250)
    //            .HasColumnName("STREETADDRESS3");
    //        entity.Property(e => e.UpdateDate)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<MtmlDocReference>(entity =>
    //    {
    //        entity.HasKey(e => e.Mtmlreferenceid);

    //        entity.ToTable("MTML_DOC_REFERENCE", tb => tb.HasTrigger("trgAfterInsertDocReferenceMTML"));

    //        entity.HasIndex(e => e.Autoid, "IX_AutoID").IsUnique();

    //        entity.HasIndex(e => e.Mtmldocid, "NonClusteredIndex-MTMLDOCID");

    //        entity.Property(e => e.Mtmlreferenceid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("MTMLREFERENCEID");
    //        entity.Property(e => e.Autoid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("AUTOID");
    //        entity.Property(e => e.Mtmldocid).HasColumnName("MTMLDOCID");
    //        entity.Property(e => e.Qualifier)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("QUALIFIER");
    //        entity.Property(e => e.Referencenumber)
    //            .HasMaxLength(100)
    //            .HasColumnName("REFERENCENUMBER");
    //        entity.Property(e => e.UpdateDate)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<MtmlTransactionHeader>(entity =>
    //    {
    //        entity.HasKey(e => e.Mtmldocid).IsClustered(false);

    //        entity.ToTable("MTML_TRANSACTION_HEADER", tb => tb.HasTrigger("trgAfterInsertTXHeaderMTML"));

    //        entity.HasIndex(e => e.Autoid, "IX_AutoID")
    //            .IsUnique()
    //            .IsClustered();

    //        entity.Property(e => e.Mtmldocid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("MTMLDOCID");
    //        entity.Property(e => e.Autoid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("AUTOID");
    //        entity.Property(e => e.Controlreference)
    //            .HasMaxLength(150)
    //            .HasColumnName("CONTROLREFERENCE");
    //        entity.Property(e => e.Doctype)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOCType");
    //        entity.Property(e => e.Identifier)
    //            .HasMaxLength(10)
    //            .HasColumnName("IDENTIFIER");
    //        entity.Property(e => e.Preparationdate)
    //            .HasMaxLength(20)
    //            .HasColumnName("PREPARATIONDATE");
    //        entity.Property(e => e.Preparationtime)
    //            .HasMaxLength(20)
    //            .HasColumnName("PREPARATIONTIME");
    //        entity.Property(e => e.Recipeint)
    //            .HasMaxLength(500)
    //            .HasColumnName("RECIPEINT");
    //        entity.Property(e => e.Recipientcodequalifier)
    //            .HasMaxLength(50)
    //            .HasColumnName("RECIPIENTCODEQUALIFIER");
    //        entity.Property(e => e.ReferenceNumber).HasMaxLength(250);
    //        entity.Property(e => e.Sender)
    //            .HasMaxLength(500)
    //            .HasColumnName("SENDER");
    //        entity.Property(e => e.Sendercodequalifier)
    //            .HasMaxLength(50)
    //            .HasColumnName("SENDERCODEQUALIFIER");
    //        entity.Property(e => e.UpdateDate)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.Versionnumber)
    //            .HasMaxLength(50)
    //            .HasColumnName("VERSIONNUMBER");
    //    });

    //    modelBuilder.Entity<MtmlTransportMode>(entity =>
    //    {
    //        entity.HasKey(e => e.TransportId);

    //        entity.ToTable("MTML_TRANSPORT_MODE");

    //        entity.Property(e => e.TransportId).HasColumnName("TRANSPORT_ID");
    //        entity.Property(e => e.TransportDesc)
    //            .HasMaxLength(50)
    //            .HasColumnName("TRANSPORT_DESC");
    //        entity.Property(e => e.TransportMode)
    //            .HasMaxLength(10)
    //            .HasColumnName("TRANSPORT_MODE");
    //    });

    //    modelBuilder.Entity<MxmlAddress>(entity =>
    //    {
    //        entity.ToTable("MXML_ADDRESS", tb => tb.HasTrigger("trgAfterInsertDocAddress"));

    //        entity.Property(e => e.Mxmladdressid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("MXMLADDRESSID");
    //        entity.Property(e => e.AddrCity)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("ADDR_CITY");
    //        entity.Property(e => e.AddrComments)
    //            .HasMaxLength(2048)
    //            .IsUnicode(false)
    //            .HasColumnName("ADDR_COMMENTS");
    //        entity.Property(e => e.AddrCountry)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("ADDR_COUNTRY");
    //        entity.Property(e => e.AddrEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ADDR_EMAIL");
    //        entity.Property(e => e.AddrFaxAreacode)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("ADDR_FAX_AREACODE");
    //        entity.Property(e => e.AddrFaxCountry)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("ADDR_FAX_COUNTRY");
    //        entity.Property(e => e.AddrFaxNumber)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("ADDR_FAX_NUMBER");
    //        entity.Property(e => e.AddrName)
    //            .HasMaxLength(128)
    //            .IsUnicode(false)
    //            .HasColumnName("ADDR_NAME");
    //        entity.Property(e => e.AddrPhoneAreacode)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("ADDR_PHONE_AREACODE");
    //        entity.Property(e => e.AddrPhoneCountry)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("ADDR_PHONE_COUNTRY");
    //        entity.Property(e => e.AddrPhoneNumber)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("ADDR_PHONE_NUMBER");
    //        entity.Property(e => e.AddrPostcode)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("ADDR_POSTCODE");
    //        entity.Property(e => e.AddrStreet11)
    //            .HasMaxLength(512)
    //            .IsUnicode(false)
    //            .HasColumnName("ADDR_STREET11");
    //        entity.Property(e => e.AddrStreet2)
    //            .HasMaxLength(512)
    //            .IsUnicode(false)
    //            .HasColumnName("ADDR_STREET2");
    //        entity.Property(e => e.AddrType)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("ADDR_TYPE");
    //        entity.Property(e => e.ContactPerson)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("CONTACT_PERSON");
    //        entity.Property(e => e.Mxmldocid).HasColumnName("MXMLDOCID");

    //        entity.HasOne(d => d.Mxmldoc).WithMany(p => p.MxmlAddresses)
    //            .HasForeignKey(d => d.Mxmldocid)
    //            .HasConstraintName("FK_MXML_ADDRESS_MXML_TRANSACTION_HEADER");
    //    });

    //    modelBuilder.Entity<MxmlDocHeader>(entity =>
    //    {
    //        entity.ToTable("MXML_DOC_HEADER", tb =>
    //            {
    //                tb.HasTrigger("trgAfterInsertDocHeader");
    //                tb.HasTrigger("trgAfterUpdateDocHeader");
    //            });

    //        entity.Property(e => e.Mxmldocheaderid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("MXMLDOCHEADERID");
    //        entity.Property(e => e.Arrivaldate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("ARRIVALDATE");
    //        entity.Property(e => e.DeliveryPier)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DELIVERY_PIER");
    //        entity.Property(e => e.DeliveryPort)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("DELIVERY_PORT");
    //        entity.Property(e => e.Departuredate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("DEPARTUREDATE");
    //        entity.Property(e => e.DocComments)
    //            .HasMaxLength(2048)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_COMMENTS");
    //        entity.Property(e => e.DocCurrency)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_CURRENCY");
    //        entity.Property(e => e.DocPayloadid)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_PAYLOADID");
    //        entity.Property(e => e.DocTotalAmount).HasColumnName("DOC_TOTAL_AMOUNT");
    //        entity.Property(e => e.Exported).HasColumnName("EXPORTED");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Mxmldocid).HasColumnName("MXMLDOCID");
    //        entity.Property(e => e.OrderDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("ORDER_DATE");
    //        entity.Property(e => e.Originatingsystemref)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("ORIGINATINGSYSTEMREF");
    //        entity.Property(e => e.PaymentTerms).HasMaxLength(2048);
    //        entity.Property(e => e.PoMessagenumber)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("PO_MESSAGENUMBER");
    //        entity.Property(e => e.PoPayloadid)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("PO_PAYLOADID");
    //        entity.Property(e => e.PortName)
    //            .HasMaxLength(100)
    //            .HasColumnName("PORT_NAME");
    //        entity.Property(e => e.QuoteComments)
    //            .HasMaxLength(2048)
    //            .IsUnicode(false)
    //            .HasColumnName("QUOTE_COMMENTS");
    //        entity.Property(e => e.QuoteDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_DATE");
    //        entity.Property(e => e.QuoteExpiryDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_EXPIRY_DATE");
    //        entity.Property(e => e.QuoteSubmitDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_SUBMIT_DATE");
    //        entity.Property(e => e.Quoteid)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("QUOTEID");
    //        entity.Property(e => e.ReplyByDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("REPLY_BY_DATE");
    //        entity.Property(e => e.ReqDeliveryDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("REQ_DELIVERY_DATE");
    //        entity.Property(e => e.SupplierQuoteId)
    //            .HasMaxLength(50)
    //            .HasColumnName("SupplierQuoteID");
    //        entity.Property(e => e.VesselId)
    //            .HasMaxLength(25)
    //            .IsUnicode(false)
    //            .HasColumnName("VESSEL_ID");
    //        entity.Property(e => e.VesselName)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VESSEL_NAME");
    //    });

    //    modelBuilder.Entity<MxmlDocItem>(entity =>
    //    {
    //        entity.HasKey(e => e.Mxmlitemid);

    //        entity.ToTable("MXML_DOC_ITEMS", tb =>
    //            {
    //                tb.HasTrigger("trgAfterInsertDocItems");
    //                tb.HasTrigger("trgAfterUpdateDocitems");
    //            });

    //        entity.Property(e => e.Mxmlitemid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("MXMLITEMID");
    //        entity.Property(e => e.EquipDrawingno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("EQUIP_DRAWINGNO");
    //        entity.Property(e => e.EquipManufacturer)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("EQUIP_MANUFACTURER");
    //        entity.Property(e => e.EquipModel)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("EQUIP_MODEL");
    //        entity.Property(e => e.EquipName)
    //            .HasMaxLength(128)
    //            .IsUnicode(false)
    //            .HasColumnName("EQUIP_NAME");
    //        entity.Property(e => e.EquipSerialno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("EQUIP_SERIALNO");
    //        entity.Property(e => e.EquipmentDescription)
    //            .HasMaxLength(256)
    //            .IsUnicode(false)
    //            .HasColumnName("EQUIPMENT_DESCRIPTION");
    //        entity.Property(e => e.ItemComment)
    //            .HasMaxLength(2048)
    //            .HasColumnName("ITEM_COMMENT");
    //        entity.Property(e => e.ItemDescription)
    //            .HasMaxLength(512)
    //            .IsUnicode(false)
    //            .HasColumnName("ITEM_DESCRIPTION");
    //        entity.Property(e => e.ItemDiscount).HasColumnName("ITEM_DISCOUNT");
    //        entity.Property(e => e.ItemUnit)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("ITEM_UNIT");
    //        entity.Property(e => e.Linenumber).HasColumnName("LINENUMBER");
    //        entity.Property(e => e.ListPrice).HasColumnName("LIST_PRICE");
    //        entity.Property(e => e.Mxmldocid).HasColumnName("MXMLDOCID");
    //        entity.Property(e => e.Originatingsystemref)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("ORIGINATINGSYSTEMREF");
    //        entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
    //        entity.Property(e => e.Supplierpartid)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIERPARTID");
    //        entity.Property(e => e.UnitPrice).HasColumnName("UNIT_PRICE");

    //        entity.HasOne(d => d.Mxmldoc).WithMany(p => p.MxmlDocItems)
    //            .HasForeignKey(d => d.Mxmldocid)
    //            .HasConstraintName("FK_MXML_DOC_ITEMS_MXML_TRANSACTION_HEADER");
    //    });

    //    modelBuilder.Entity<MxmlTransactionHeader>(entity =>
    //    {
    //        entity.HasKey(e => e.Mxmldocid);

    //        entity.ToTable("MXML_TRANSACTION_HEADER", tb => tb.HasTrigger("trgAfterInsertTXHeader"));

    //        entity.Property(e => e.Mxmldocid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("MXMLDOCID");
    //        entity.Property(e => e.Doctype)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("DOCTYPE");
    //        entity.Property(e => e.FromAdapteruid)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("FROM_ADAPTERUID");
    //        entity.Property(e => e.FromPartyid)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("FROM_PARTYID");
    //        entity.Property(e => e.Payloadid)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("PAYLOADID");
    //        entity.Property(e => e.ServerTimestamp)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SERVER_TIMESTAMP");
    //        entity.Property(e => e.ToPartyid)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("TO_PARTYID");
    //        entity.Property(e => e.Useragent)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("USERAGENT");
    //    });

    //    modelBuilder.Entity<SmAddress>(entity =>
    //    {
    //        entity.HasKey(e => e.Addressid).IsClustered(false);

    //        entity.ToTable("SM_ADDRESS");

    //        entity.HasIndex(e => e.Addressid, "IX_SM_ADDRESS").IsClustered();

    //        entity.HasIndex(e => e.AddrCode, "NonClusteredIndex-20180706-AddrCode");

    //        entity.Property(e => e.Addressid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("ADDRESSID");
    //        entity.Property(e => e.AddrCity)
    //            .HasMaxLength(30)
    //            .HasColumnName("ADDR_CITY");
    //        entity.Property(e => e.AddrCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("ADDR_CODE");
    //        entity.Property(e => e.AddrCountry)
    //            .HasMaxLength(20)
    //            .HasColumnName("ADDR_COUNTRY");
    //        entity.Property(e => e.AddrCountryCode2)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("ADDR_COUNTRY_CODE2");
    //        entity.Property(e => e.AddrCurrencyid).HasColumnName("ADDR_CURRENCYID");
    //        entity.Property(e => e.AddrEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("ADDR_EMAIL");
    //        entity.Property(e => e.AddrFax)
    //            .HasMaxLength(30)
    //            .HasColumnName("ADDR_FAX");
    //        entity.Property(e => e.AddrInbox)
    //            .HasMaxLength(2000)
    //            .HasColumnName("ADDR_INBOX");
    //        entity.Property(e => e.AddrMobilephone)
    //            .HasMaxLength(30)
    //            .HasColumnName("ADDR_MOBILEPHONE");
    //        entity.Property(e => e.AddrMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("ADDR_MTML_CODE");
    //        entity.Property(e => e.AddrMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("ADDR_MTS_CODE");
    //        entity.Property(e => e.AddrName)
    //            .HasMaxLength(200)
    //            .HasColumnName("ADDR_NAME");
    //        entity.Property(e => e.AddrOutbox)
    //            .HasMaxLength(2000)
    //            .HasColumnName("ADDR_OUTBOX");
    //        entity.Property(e => e.AddrPhone1)
    //            .HasMaxLength(30)
    //            .HasColumnName("ADDR_PHONE1");
    //        entity.Property(e => e.AddrPhone2)
    //            .HasMaxLength(30)
    //            .HasColumnName("ADDR_PHONE2");
    //        entity.Property(e => e.AddrTelex)
    //            .HasMaxLength(30)
    //            .HasColumnName("ADDR_TELEX");
    //        entity.Property(e => e.AddrType)
    //            .HasMaxLength(10)
    //            .HasColumnName("ADDR_TYPE");
    //        entity.Property(e => e.AddrZipcode)
    //            .HasMaxLength(12)
    //            .HasColumnName("ADDR_ZIPCODE");
    //        entity.Property(e => e.Address1).HasColumnName("ADDRESS1");
    //        entity.Property(e => e.Address2)
    //            .HasMaxLength(40)
    //            .HasColumnName("ADDRESS2");
    //        entity.Property(e => e.Address3)
    //            .HasMaxLength(40)
    //            .HasColumnName("ADDRESS3");
    //        entity.Property(e => e.Address4)
    //            .HasMaxLength(40)
    //            .HasColumnName("ADDRESS4");
    //        entity.Property(e => e.BuyerLink)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_LINK");
    //        entity.Property(e => e.CompanyGroupId).HasColumnName("COMPANY_GROUP_ID");
    //        entity.Property(e => e.ContactPerson)
    //            .HasMaxLength(100)
    //            .HasColumnName("CONTACT_PERSON");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.EBizCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("eBizCode");
    //        entity.Property(e => e.EBizConnectorId)
    //            .HasMaxLength(30)
    //            .HasColumnName("eBizConnectorID");
    //        entity.Property(e => e.EInvoice).HasColumnName("eInvoice");
    //        entity.Property(e => e.EPurchase).HasColumnName("ePurchase");
    //        entity.Property(e => e.ESupplier).HasColumnName("eSupplier");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.IsLeSconnect).HasColumnName("IsLeSConnect");
    //        entity.Property(e => e.SubBuyerAddressid).HasColumnName("SUB_BUYER_ADDRESSID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.WebLink)
    //            .HasMaxLength(500)
    //            .HasColumnName("WEB_LINK");
    //        entity.Property(e => e.XmlAddrNo).HasColumnName("XML_ADDR_NO");
    //    });

    //    modelBuilder.Entity<SmAddressConfig>(entity =>
    //    {
    //        entity.HasKey(e => e.Addrconfigid);

    //        entity.ToTable("SM_ADDRESS_CONFIG");

    //        entity.Property(e => e.Addrconfigid).HasColumnName("ADDRCONFIGID");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.DefaultFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("DEFAULT_FORMAT");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPo).HasColumnName("EXPORT_PO");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.IdentificationCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("IDENTIFICATION_CODE");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportPoc).HasColumnName("IMPORT_POC");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.MailNotify).HasColumnName("MAIL_NOTIFY");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.PartyMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("PARTY_MAPPING");
    //        entity.Property(e => e.SupWebServiceUrl)
    //            .HasMaxLength(300)
    //            .IsUnicode(false)
    //            .HasColumnName("SUP_WEB_SERVICE_URL");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UploadFileType)
    //            .HasMaxLength(50)
    //            .HasColumnName("UPLOAD_FILE_TYPE");

    //        entity.HasOne(d => d.Address).WithMany(p => p.SmAddressConfigs)
    //            .HasForeignKey(d => d.Addressid)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK_SM_ADDRESS_CONFIG_SM_ADDRESS");
    //    });

    //    modelBuilder.Entity<SmAttachment>(entity =>
    //    {
    //        entity.HasKey(e => e.Attachmentid);

    //        entity.ToTable("SM_ATTACHMENT");

    //        entity.Property(e => e.Attachmentid).HasColumnName("ATTACHMENTID");
    //        entity.Property(e => e.Attachmenttype)
    //            .HasMaxLength(50)
    //            .HasColumnName("ATTACHMENTTYPE");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Exported).HasColumnName("EXPORTED");
    //        entity.Property(e => e.FileLocation).HasColumnName("FILE_LOCATION");
    //        entity.Property(e => e.FileName)
    //            .HasMaxLength(512)
    //            .HasColumnName("FILE_NAME");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //    });

    //    modelBuilder.Entity<SmAuditlog>(entity =>
    //    {
    //        entity.HasKey(e => e.LogId);

    //        entity.ToTable("SM_AUDITLOG");

    //        entity.HasIndex(e => e.UpdateDate, "IX_Audit_UpdateDate");

    //        entity.Property(e => e.LogId).HasColumnName("LogID");
    //        entity.Property(e => e.AuditValue).HasMaxLength(2000);
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false);
    //        entity.Property(e => e.BuyerId).HasColumnName("BUYER_ID");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(30)
    //            .IsUnicode(false);
    //        entity.Property(e => e.FileName).HasMaxLength(150);
    //        entity.Property(e => e.Filename2)
    //            .HasMaxLength(150)
    //            .HasColumnName("FILENAME2");
    //        entity.Property(e => e.Filename3)
    //            .HasMaxLength(150)
    //            .HasColumnName("FILENAME3");
    //        entity.Property(e => e.KeyRef1).HasMaxLength(150);
    //        entity.Property(e => e.KeyRef2).HasMaxLength(150);
    //        entity.Property(e => e.LogType).HasMaxLength(50);
    //        entity.Property(e => e.ModuleName).HasMaxLength(50);
    //        entity.Property(e => e.ProcessorName)
    //            .HasMaxLength(150)
    //            .HasColumnName("PROCESSOR_NAME");
    //        entity.Property(e => e.ServerName)
    //            .HasMaxLength(50)
    //            .IsUnicode(false);
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false);
    //        entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
    //        entity.Property(e => e.UpdateDate).HasColumnType("datetime");
    //    });

    //    modelBuilder.Entity<SmBuyerSupplierGroup>(entity =>
    //    {
    //        entity.HasKey(e => e.GroupId).HasName("PK_BUYER_SUPPLIER_GROUPS");

    //        entity.ToTable("SM_BUYER_SUPPLIER_GROUPS");

    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.SupplierFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_FORMAT");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmBuyerSupplierGroupFlow>(entity =>
    //    {
    //        entity.HasKey(e => e.GroupFlowid).HasName("PK_SM_BUYER_SUPPLIER_GROUPS_FLOW");

    //        entity.ToTable("SM_BUYER_SUPPLIER_GROUP_FLOW", tb => tb.HasTrigger("AUTO_UPDATE_SM_BUYER_SUPPLIER_GROUP_FLOW"));

    //        entity.Property(e => e.GroupFlowid).HasColumnName("GROUP_FLOWID");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.Po).HasColumnName("PO");
    //        entity.Property(e => e.PoEndState).HasColumnName("PO_END_STATE");
    //        entity.Property(e => e.Poc).HasColumnName("POC");
    //        entity.Property(e => e.PocBuyerExportMarker).HasColumnName("POC_BUYER_EXPORT_MARKER");
    //        entity.Property(e => e.PocEndState).HasColumnName("POC_END_STATE");
    //        entity.Property(e => e.PocExportMarker).HasColumnName("POC_EXPORT_MARKER");
    //        entity.Property(e => e.Quote).HasColumnName("QUOTE");
    //        entity.Property(e => e.QuoteBuyerExportMarker).HasColumnName("QUOTE_BUYER_EXPORT_MARKER");
    //        entity.Property(e => e.QuoteEndState).HasColumnName("QUOTE_END_STATE");
    //        entity.Property(e => e.QuoteExportMarker).HasColumnName("QUOTE_EXPORT_MARKER");
    //        entity.Property(e => e.Rfq).HasColumnName("RFQ");
    //        entity.Property(e => e.RfqEndState).HasColumnName("RFQ_END_STATE");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.Voucher).HasColumnName("VOUCHER");
    //    });

    //    modelBuilder.Entity<SmBuyerSupplierItemRef>(entity =>
    //    {
    //        entity.HasKey(e => e.Refid).HasName("PK__SM_BUYER_SUPPLIE__1B93E30A");

    //        entity.ToTable("SM_BUYER_SUPPLIER_ITEM_REF");

    //        entity.HasIndex(e => new { e.BuyerRef, e.SupplierRef, e.SupplierId, e.BuyerSupplierLinkid }, "NonClusteredIndex_ByrRef_SuppREF_SupId-20191220-173620");

    //        entity.HasIndex(e => new { e.BuyerRef, e.SupplierRef, e.SupplierId }, "NonClusteredIndex_SupID_ByrRef_SupREf-20191220-173730");

    //        entity.Property(e => e.Refid).HasColumnName("REFID");
    //        entity.Property(e => e.BuyerId).HasColumnName("BUYER_ID");
    //        entity.Property(e => e.BuyerItemDesc)
    //            .HasMaxLength(500)
    //            .HasColumnName("BUYER_ITEM_DESC");
    //        entity.Property(e => e.BuyerRef)
    //            .HasMaxLength(250)
    //            .HasColumnName("BUYER_REF");
    //        entity.Property(e => e.BuyerSupplierLinkid).HasColumnName("BUYER_SUPPLIER_LINKID");
    //        entity.Property(e => e.Comments)
    //            .HasMaxLength(500)
    //            .HasColumnName("COMMENTS");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.ItemDesc)
    //            .HasMaxLength(500)
    //            .HasColumnName("ITEM_DESC");
    //        entity.Property(e => e.Reftype)
    //            .HasMaxLength(50)
    //            .HasColumnName("REFTYPE");
    //        entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
    //        entity.Property(e => e.SupplierRef)
    //            .HasMaxLength(250)
    //            .HasColumnName("SUPPLIER_REF");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmBuyerSupplierItemRefTemp>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToTable("SM_BUYER_SUPPLIER_ITEM_REF_TEMP");

    //        entity.Property(e => e.BuyerId).HasColumnName("BUYER_ID");
    //        entity.Property(e => e.BuyerRef)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_REF");
    //        entity.Property(e => e.Comments)
    //            .HasMaxLength(250)
    //            .HasColumnName("COMMENTS");
    //        entity.Property(e => e.ItemDesc)
    //            .HasMaxLength(250)
    //            .HasColumnName("ITEM_DESC");
    //        entity.Property(e => e.Refid).HasColumnName("REFID");
    //        entity.Property(e => e.Reftype)
    //            .HasMaxLength(50)
    //            .HasColumnName("REFTYPE");
    //        entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
    //        entity.Property(e => e.SupplierRef)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_REF");
    //    });

    //    modelBuilder.Entity<SmBuyerSupplierLink>(entity =>
    //    {
    //        entity.HasKey(e => e.Linkid);

    //        entity.ToTable("SM_BUYER_SUPPLIER_LINK");

    //        entity.HasIndex(e => new { e.Buyerid, e.Supplierid }, "IDX_BUYERID_SUPPLIERID");

    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.ActivatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("ACTIVATED_DATE");
    //        entity.Property(e => e.AsmbExportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_EXPORT_CLASS");
    //        entity.Property(e => e.AsmbImportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_IMPORT_CLASS");
    //        entity.Property(e => e.AssemblyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASSEMBLY_NAME");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(500)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.BuyerPhone)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_PHONE");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.CreatedDate)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.DefaultPrice)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("EXPORT_FUNCTION");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPo).HasColumnName("EXPORT_PO");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("IMPORT_FUNCTION");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportPoc).HasColumnName("IMPORT_POC");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.LinkType)
    //            .HasMaxLength(50)
    //            .HasColumnName("LINK_TYPE");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupWebServiceUrl)
    //            .HasMaxLength(300)
    //            .IsUnicode(false)
    //            .HasColumnName("SUP_WEB_SERVICE_URL");
    //        entity.Property(e => e.SuppExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_EXPORT_PATH");
    //        entity.Property(e => e.SuppImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_IMPORT_PATH");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.SupplierImportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_IMPORT_FORMAT");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.SupplierPhone)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_PHONE");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UploadFileType)
    //            .HasMaxLength(50)
    //            .HasColumnName("UPLOAD_FILE_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(500)
    //            .HasColumnName("VENDOR_LINK_CODE");

    //        entity.HasOne(d => d.Buyer).WithMany(p => p.SmBuyerSupplierLinkBuyers)
    //            .HasForeignKey(d => d.Buyerid)
    //            .HasConstraintName("fk_BuyerID");

    //        entity.HasOne(d => d.Supplier).WithMany(p => p.SmBuyerSupplierLinkSuppliers)
    //            .HasForeignKey(d => d.Supplierid)
    //            .HasConstraintName("fk_SupplierID");
    //    });

    //    modelBuilder.Entity<SmBuyerSupplierLinkRule>(entity =>
    //    {
    //        entity.HasKey(e => e.LinkRuleId);

    //        entity.ToTable("SM_BUYER_SUPPLIER_LINK_RULE");

    //        entity.HasIndex(e => e.Linkid, "IDX_LINKID");

    //        entity.Property(e => e.LinkRuleId).HasColumnName("LINK_RULE_ID");
    //        entity.Property(e => e.InheritRule)
    //            .HasDefaultValueSql("((1))")
    //            .HasColumnName("INHERIT_RULE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.RuleValue).HasColumnName("RULE_VALUE");
    //        entity.Property(e => e.Ruleid).HasColumnName("RULEID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmBuyerSupplierLinkRuleVoucher>(entity =>
    //    {
    //        entity.HasKey(e => e.LinkRuleId);

    //        entity.ToTable("SM_BUYER_SUPPLIER_LINK_RULE_VOUCHER");

    //        entity.Property(e => e.LinkRuleId).HasColumnName("LINK_RULE_ID");
    //        entity.Property(e => e.InheritRule)
    //            .HasDefaultValueSql("((1))")
    //            .HasColumnName("INHERIT_RULE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.RuleValue).HasColumnName("RULE_VALUE");
    //        entity.Property(e => e.Ruleid).HasColumnName("RULEID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmBuyerSupplierRule>(entity =>
    //    {
    //        entity.HasKey(e => e.GroupRuleId);

    //        entity.ToTable("SM_BUYER_SUPPLIER_RULES");

    //        entity.Property(e => e.GroupRuleId).HasColumnName("GROUP_RULE_ID");
    //        entity.Property(e => e.BuyerId).HasColumnName("BUYER_ID");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.RuleCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("RULE_CODE");
    //        entity.Property(e => e.RuleId).HasColumnName("RULE_ID");
    //        entity.Property(e => e.RuleValue).HasColumnName("RULE_VALUE");
    //        entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmByrSuppMailConfig>(entity =>
    //    {
    //        entity.HasKey(e => e.ConfigId).HasName("PK__SM_BYR_S__8AEE09EE6DF163DE");

    //        entity.ToTable("SM_BYR_SUPP_MAIL_CONFIG");

    //        entity.Property(e => e.ConfigId).HasColumnName("CONFIG_ID");
    //        entity.Property(e => e.BuyerId).HasColumnName("BUYER_ID");
    //        entity.Property(e => e.ByrSupLinkid).HasColumnName("BYR_SUP_LINKID");
    //        entity.Property(e => e.ClientId)
    //            .HasMaxLength(50)
    //            .HasColumnName("CLIENT_ID");
    //        entity.Property(e => e.ClientSecret)
    //            .HasMaxLength(50)
    //            .HasColumnName("CLIENT_SECRET");
    //        entity.Property(e => e.DisplayName)
    //            .HasMaxLength(50)
    //            .HasColumnName("DISPLAY_NAME");
    //        entity.Property(e => e.FromEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("FROM_EMAIL");
    //        entity.Property(e => e.FromPwd)
    //            .HasMaxLength(100)
    //            .HasColumnName("FROM_PWD");
    //        entity.Property(e => e.FromUser)
    //            .HasMaxLength(50)
    //            .HasColumnName("FROM_USER");
    //        entity.Property(e => e.IsAuthorised)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("IS_AUTHORISED");
    //        entity.Property(e => e.IsHtml).HasColumnName("IS_HTML");
    //        entity.Property(e => e.IsSsl)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("IS_SSL");
    //        entity.Property(e => e.IsTls).HasColumnName("IS_TLS");
    //        entity.Property(e => e.ProtocolType)
    //            .HasMaxLength(30)
    //            .HasColumnName("PROTOCOL_TYPE");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SmtpHost)
    //            .HasMaxLength(50)
    //            .HasColumnName("SMTP_HOST");
    //        entity.Property(e => e.SmtpPort).HasColumnName("SMTP_PORT");
    //        entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
    //        entity.Property(e => e.TenantId)
    //            .HasMaxLength(50)
    //            .HasColumnName("TENANT_ID");
    //        entity.Property(e => e.Udf1)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF1");
    //        entity.Property(e => e.Udf2)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF2");
    //        entity.Property(e => e.UpdateDate)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmCompanyGroupCode>(entity =>
    //    {
    //        entity.HasKey(e => e.CompanyGroupId);

    //        entity.ToTable("SM_COMPANY_GROUP_CODE");

    //        entity.Property(e => e.CompanyGroupId).HasColumnName("COMPANY_GROUP_ID");
    //        entity.Property(e => e.CompanyGroupCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("COMPANY_GROUP_CODE");
    //        entity.Property(e => e.CompanyGroupType)
    //            .HasMaxLength(50)
    //            .HasColumnName("COMPANY_GROUP_TYPE");
    //    });

    //    modelBuilder.Entity<SmCountryCode>(entity =>
    //    {
    //        entity.HasKey(e => e.CountryId);

    //        entity.ToTable("SM_COUNTRY_CODE");

    //        entity.Property(e => e.CountryId).HasColumnName("COUNTRY_ID");
    //        entity.Property(e => e.CountryCode2)
    //            .HasMaxLength(50)
    //            .HasColumnName("COUNTRY_CODE2");
    //        entity.Property(e => e.CountryCode3)
    //            .HasMaxLength(50)
    //            .HasColumnName("COUNTRY_CODE3");
    //        entity.Property(e => e.CountryName).HasColumnName("COUNTRY_NAME");
    //        entity.Property(e => e.CountryNumber).HasColumnName("COUNTRY_NUMBER");
    //    });

    //    modelBuilder.Entity<SmCurrency>(entity =>
    //    {
    //        entity.HasKey(e => e.Currencyid).IsClustered(false);

    //        entity.ToTable("SM_CURRENCY");

    //        entity.HasIndex(e => new { e.CurrCode, e.Siteid }, "IX_SM_CURRENCY").IsUnique();

    //        entity.Property(e => e.Currencyid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("CURRENCYID");
    //        entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(3)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.CurrDescr)
    //            .HasMaxLength(20)
    //            .HasColumnName("CURR_DESCR");
    //        entity.Property(e => e.CurrRemarks)
    //            .HasColumnType("ntext")
    //            .HasColumnName("CURR_REMARKS");
    //        entity.Property(e => e.CurrSymbol)
    //            .HasMaxLength(255)
    //            .IsUnicode(false)
    //            .HasColumnName("CURR_SYMBOL");
    //        entity.Property(e => e.CurrValidityDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CURR_VALIDITY_DATE");
    //        entity.Property(e => e.ExchRate).HasColumnName("EXCH_RATE");
    //        entity.Property(e => e.Exported).HasColumnName("EXPORTED");
    //        entity.Property(e => e.Siteid).HasColumnName("SITEID");
    //        entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UpdateSite).HasColumnName("UPDATE_SITE");
    //        entity.Property(e => e.ValidFrom)
    //            .HasColumnType("datetime")
    //            .HasColumnName("VALID_FROM");
    //    });

    //    modelBuilder.Entity<SmCurrencyMapped>(entity =>
    //    {
    //        entity.HasKey(e => e.Autoid);

    //        entity.ToTable("SM_CURRENCY_MAPPED");

    //        entity.Property(e => e.Autoid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("AUTOID");
    //        entity.Property(e => e.Mapid).HasColumnName("MAPID");
    //        entity.Property(e => e.SourceCurrCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("SOURCE_CURR_CODE");
    //        entity.Property(e => e.TargetCurrCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("TARGET_CURR_CODE");
    //    });

    //    modelBuilder.Entity<SmCurrencylog>(entity =>
    //    {
    //        entity.HasKey(e => e.Currencylogid).HasName("PK__SM_CURRE__0AEF4454B9724134");

    //        entity.ToTable("SM_CURRENCYLOG");

    //        entity.Property(e => e.Currencylogid).HasColumnName("CURRENCYLOGID");
    //        entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Currencyid).HasColumnName("CURRENCYID");
    //        entity.Property(e => e.ExchRate).HasColumnName("EXCH_RATE");
    //        entity.Property(e => e.UpdateBy).HasColumnName("UPDATE_BY");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.ValidFrom)
    //            .HasColumnType("datetime")
    //            .HasColumnName("VALID_FROM");
    //        entity.Property(e => e.ValidTo)
    //            .HasColumnType("datetime")
    //            .HasColumnName("VALID_TO");
    //    });

    //    modelBuilder.Entity<SmDefaultRule>(entity =>
    //    {
    //        entity.HasKey(e => e.DefId);

    //        entity.ToTable("SM_DEFAULT_RULES");

    //        entity.Property(e => e.DefId).HasColumnName("DEF_ID");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.GroupFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("GROUP_FORMAT");
    //        entity.Property(e => e.RuleId).HasColumnName("RULE_ID");
    //        entity.Property(e => e.RuleValue)
    //            .HasMaxLength(50)
    //            .HasColumnName("RULE_VALUE");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmDocEquipment>(entity =>
    //    {
    //        entity.HasKey(e => e.DocEquipId);

    //        entity.ToTable("SM_DOC_EQUIPMENT");

    //        entity.Property(e => e.EquipDescription).HasMaxLength(150);
    //        entity.Property(e => e.EquipDrgNo).HasMaxLength(50);
    //        entity.Property(e => e.EquipMaker).HasMaxLength(150);
    //        entity.Property(e => e.EquipName).HasMaxLength(150);
    //        entity.Property(e => e.EquipRemarks).HasMaxLength(300);
    //        entity.Property(e => e.EquipSerNo).HasMaxLength(50);
    //        entity.Property(e => e.EquipType).HasMaxLength(50);
    //    });

    //    modelBuilder.Entity<SmDocumentFormat>(entity =>
    //    {
    //        entity.HasKey(e => e.Docformatid);

    //        entity.ToTable("SM_DOCUMENT_FORMATS");

    //        entity.Property(e => e.Docformatid).HasColumnName("DOCFORMATID");
    //        entity.Property(e => e.AddrType)
    //            .HasMaxLength(10)
    //            .HasColumnName("ADDR_TYPE");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.DocumentFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOCUMENT_FORMAT");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.UpdatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATED_DATE");
    //    });

    //    modelBuilder.Entity<SmDocumentformatRule>(entity =>
    //    {
    //        entity.HasKey(e => e.DocumentformatRuleid);

    //        entity.ToTable("SM_DOCUMENTFORMAT_RULES");

    //        entity.Property(e => e.DocumentformatRuleid).HasColumnName("DOCUMENTFORMAT_RULEID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Docformatid).HasColumnName("DOCFORMATID");
    //        entity.Property(e => e.RuleId).HasColumnName("RULE_ID");
    //        entity.Property(e => e.RuleValue)
    //            .HasMaxLength(50)
    //            .HasColumnName("RULE_VALUE");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmErrorDetail>(entity =>
    //    {
    //        entity.HasKey(e => e.ErrorId).HasName("PK_SM_ERROR_DETAIL1");

    //        entity.ToTable("SM_ERROR_DETAIL");

    //        entity.Property(e => e.ErrorId).HasColumnName("ERROR_ID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.ErrorDesc).HasColumnName("ERROR_DESC");
    //        entity.Property(e => e.ErrorNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("ERROR_NO");
    //        entity.Property(e => e.ErrorProblem).HasColumnName("ERROR_PROBLEM");
    //        entity.Property(e => e.ErrorSolution).HasColumnName("ERROR_SOLUTION");
    //        entity.Property(e => e.ErrorTemplate).HasColumnName("ERROR_TEMPLATE");
    //        entity.Property(e => e.UpdatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATED_DATE");
    //    });

    //    modelBuilder.Entity<SmErrorLog>(entity =>
    //    {
    //        entity.HasKey(e => e.ErrorLogid);

    //        entity.ToTable("SM_ERROR_LOG");

    //        entity.Property(e => e.ErrorLogid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("ERROR_LOGID");
    //        entity.Property(e => e.AssignTo)
    //            .HasMaxLength(50)
    //            .HasColumnName("ASSIGN_TO");
    //        entity.Property(e => e.ErrorProblem)
    //            .HasMaxLength(1000)
    //            .HasColumnName("ERROR_PROBLEM");
    //        entity.Property(e => e.ErrorSolution)
    //            .HasMaxLength(2000)
    //            .HasColumnName("ERROR_SOLUTION");
    //        entity.Property(e => e.ErrorStatus).HasColumnName("ERROR_STATUS");
    //        entity.Property(e => e.Logid).HasColumnName("LOGID");
    //        entity.Property(e => e.PriorityFlag).HasColumnName("PRIORITY_FLAG");
    //        entity.Property(e => e.UpdateDate)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmEsupplierRule>(entity =>
    //    {
    //        entity.HasKey(e => e.Ruleid);

    //        entity.ToTable("SM_ESUPPLIER_RULES");

    //        entity.Property(e => e.Ruleid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("RULEID");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(30)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.RuleCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("RULE_CODE");
    //        entity.Property(e => e.RuleComments).HasColumnName("RULE_COMMENTS");
    //        entity.Property(e => e.RuleDesc)
    //            .HasMaxLength(300)
    //            .HasColumnName("RULE_DESC");
    //        entity.Property(e => e.RuleNumber)
    //            .HasMaxLength(50)
    //            .HasColumnName("RULE_NUMBER");
    //        entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmExportedQuotation>(entity =>
    //    {
    //        entity.HasKey(e => e.Quotationid);

    //        entity.ToTable("SM_EXPORTED_QUOTATIONS");

    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.AddDiscType).HasColumnName("ADD_DISC_TYPE");
    //        entity.Property(e => e.AdditionalDisc).HasColumnName("ADDITIONAL_DISC");
    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.BuyerRemarks).HasColumnName("BUYER_REMARKS");
    //        entity.Property(e => e.ByrSuppLinkid).HasColumnName("BYR_SUPP_LINKID");
    //        entity.Property(e => e.ChangedByVendor).HasColumnName("CHANGED_BY_VENDOR");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(3)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.Currencyid).HasColumnName("CURRENCYID");
    //        entity.Property(e => e.DeliveryPromised)
    //            .HasColumnType("datetime")
    //            .HasColumnName("DELIVERY_PROMISED");
    //        entity.Property(e => e.Deliverydays).HasColumnName("DELIVERYDAYS");
    //        entity.Property(e => e.Deliverytime)
    //            .HasColumnType("datetime")
    //            .HasColumnName("DELIVERYTIME");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.DocXml)
    //            .HasMaxLength(5)
    //            .HasColumnName("DOC_XML");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(256)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.Exported).HasColumnName("EXPORTED");
    //        entity.Property(e => e.Freightamt)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("FREIGHTAMT");
    //        entity.Property(e => e.GeneralTerms)
    //            .HasMaxLength(100)
    //            .HasColumnName("GENERAL_TERMS");
    //        entity.Property(e => e.IsDeclined)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("IS_DECLINED");
    //        entity.Property(e => e.ItemTotal)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("ITEM_TOTAL");
    //        entity.Property(e => e.Latedate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("LATEDATE");
    //        entity.Property(e => e.Othercosts)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("OTHERCOSTS");
    //        entity.Property(e => e.PayTerms)
    //            .HasMaxLength(100)
    //            .HasColumnName("PAY_TERMS");
    //        entity.Property(e => e.Payloadid)
    //            .HasMaxLength(100)
    //            .HasColumnName("PAYLOADID");
    //        entity.Property(e => e.PaymentTerms).HasColumnName("PAYMENT_TERMS");
    //        entity.Property(e => e.PoAckDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PO_ACK_DATE");
    //        entity.Property(e => e.PocBy).HasColumnName("POC_BY");
    //        entity.Property(e => e.PocDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("POC_DATE");
    //        entity.Property(e => e.PocReference)
    //            .HasMaxLength(30)
    //            .HasColumnName("POC_REFERENCE");
    //        entity.Property(e => e.Podate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PODATE");
    //        entity.Property(e => e.PortCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("PORT_CODE");
    //        entity.Property(e => e.PortName)
    //            .HasMaxLength(100)
    //            .HasColumnName("PORT_NAME");
    //        entity.Property(e => e.PrintStatus).HasColumnName("PRINT_STATUS");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.QuoteAmount)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("QUOTE_AMOUNT");
    //        entity.Property(e => e.QuoteApproveddate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_APPROVEDDATE");
    //        entity.Property(e => e.QuoteDiscount)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("QUOTE_DISCOUNT");
    //        entity.Property(e => e.QuoteExchrate)
    //            .HasDefaultValueSql("((1))")
    //            .HasColumnName("QUOTE_EXCHRATE");
    //        entity.Property(e => e.QuoteFileRef)
    //            .HasMaxLength(150)
    //            .HasColumnName("QUOTE_FILE_REF");
    //        entity.Property(e => e.QuoteFileStamp)
    //            .HasMaxLength(50)
    //            .HasColumnName("QUOTE_FILE_STAMP");
    //        entity.Property(e => e.QuoteRecvdDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_RECVD_DATE");
    //        entity.Property(e => e.QuoteReference)
    //            .HasMaxLength(100)
    //            .HasColumnName("QUOTE_REFERENCE");
    //        entity.Property(e => e.QuoteRemarks)
    //            .HasColumnType("ntext")
    //            .HasColumnName("QUOTE_REMARKS");
    //        entity.Property(e => e.QuoteSubject)
    //            .HasMaxLength(100)
    //            .HasColumnName("QUOTE_SUBJECT");
    //        entity.Property(e => e.QuoteSubmitBy).HasColumnName("QUOTE_SUBMIT_BY");
    //        entity.Property(e => e.QuoteSubmitDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_SUBMIT_DATE");
    //        entity.Property(e => e.QuoteValidity)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_VALIDITY");
    //        entity.Property(e => e.QuoteVersion).HasColumnName("QUOTE_VERSION");
    //        entity.Property(e => e.ReplyByDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("REPLY_BY_DATE");
    //        entity.Property(e => e.RfqAckDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_ACK_DATE");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //        entity.Property(e => e.RfqSentDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_SENT_DATE");
    //        entity.Property(e => e.SentBy).HasColumnName("SENT_BY");
    //        entity.Property(e => e.Siteid).HasColumnName("SITEID");
    //        entity.Property(e => e.SpMasRemark)
    //            .HasMaxLength(500)
    //            .HasColumnName("SP_MAS_REMARK");
    //        entity.Property(e => e.TaxPercnt).HasColumnName("TAX_PERCNT");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.VendorStatus)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.Version).HasColumnName("VERSION");
    //        entity.Property(e => e.VesselIdno)
    //            .HasMaxLength(100)
    //            .HasColumnName("VESSEL_IDNO");
    //        entity.Property(e => e.VesselName)
    //            .HasMaxLength(100)
    //            .HasColumnName("VESSEL_NAME");
    //        entity.Property(e => e.VesselOwner)
    //            .HasMaxLength(150)
    //            .HasColumnName("VESSEL_OWNER");
    //        entity.Property(e => e.VesselOwnerCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("VESSEL_OWNER_CODE");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmExportedQuoteItem>(entity =>
    //    {
    //        entity.HasKey(e => e.Quotationdetailid);

    //        entity.ToTable("SM_EXPORTED_QUOTE_ITEMS");

    //        entity.Property(e => e.Quotationdetailid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("QUOTATIONDETAILID");
    //        entity.Property(e => e.BuyerUnitCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_UNIT_CODE");
    //        entity.Property(e => e.ChangedByVendor).HasColumnName("CHANGED_BY_VENDOR");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Deliverytime).HasColumnName("DELIVERYTIME");
    //        entity.Property(e => e.Discount)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("DISCOUNT");
    //        entity.Property(e => e.Docitemid)
    //            .HasMaxLength(256)
    //            .HasColumnName("DOCITEMID");
    //        entity.Property(e => e.Drawingno)
    //            .HasMaxLength(200)
    //            .HasColumnName("DRAWINGNO");
    //        entity.Property(e => e.EquipMaker)
    //            .HasMaxLength(512)
    //            .HasColumnName("EQUIP_MAKER");
    //        entity.Property(e => e.EquipName)
    //            .HasMaxLength(200)
    //            .HasColumnName("EQUIP_NAME");
    //        entity.Property(e => e.EquipRemarks)
    //            .HasMaxLength(1000)
    //            .HasColumnName("EQUIP_REMARKS");
    //        entity.Property(e => e.EquipSerno)
    //            .HasMaxLength(200)
    //            .HasColumnName("EQUIP_SERNO");
    //        entity.Property(e => e.EquipType)
    //            .HasMaxLength(200)
    //            .HasColumnName("EQUIP_TYPE");
    //        entity.Property(e => e.ExportedPrice).HasColumnName("EXPORTED_PRICE");
    //        entity.Property(e => e.ExportedQty).HasColumnName("EXPORTED_QTY");
    //        entity.Property(e => e.ItemMarkedRemark)
    //            .HasMaxLength(1000)
    //            .HasColumnName("ITEM_MARKED_REMARK");
    //        entity.Property(e => e.ItemRemark)
    //            .HasMaxLength(2048)
    //            .HasColumnName("ITEM_REMARK");
    //        entity.Property(e => e.Itemno).HasColumnName("ITEMNO");
    //        entity.Property(e => e.Itemstatus)
    //            .HasDefaultValueSql("((1))")
    //            .HasColumnName("ITEMSTATUS");
    //        entity.Property(e => e.Originatingsystemref)
    //            .HasMaxLength(50)
    //            .HasColumnName("ORIGINATINGSYSTEMREF");
    //        entity.Property(e => e.Partname)
    //            .HasMaxLength(1000)
    //            .HasColumnName("PARTNAME");
    //        entity.Property(e => e.Posno)
    //            .HasMaxLength(200)
    //            .HasColumnName("POSNO");
    //        entity.Property(e => e.QtyOrd)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("QTY_ORD");
    //        entity.Property(e => e.QtyQuoted)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("QTY_QUOTED");
    //        entity.Property(e => e.QtyReq)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("QTY_REQ");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteExchrate)
    //            .HasDefaultValueSql("((1))")
    //            .HasColumnName("QUOTE_EXCHRATE");
    //        entity.Property(e => e.QuoteFile)
    //            .HasMaxLength(50)
    //            .HasColumnName("QUOTE_FILE");
    //        entity.Property(e => e.QuotedPrice)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("QUOTED_PRICE");
    //        entity.Property(e => e.QuoteitemRemark)
    //            .HasColumnType("ntext")
    //            .HasColumnName("QUOTEITEM_REMARK");
    //        entity.Property(e => e.Refno)
    //            .HasMaxLength(200)
    //            .HasColumnName("REFNO");
    //        entity.Property(e => e.Siteid).HasColumnName("SITEID");
    //        entity.Property(e => e.SysItemno).HasColumnName("SYS_ITEMNO");
    //        entity.Property(e => e.UnitCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("UNIT_CODE");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.VendorItemno)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_ITEMNO");
    //        entity.Property(e => e.VendorRefno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VENDOR_REFNO");
    //    });

    //    modelBuilder.Entity<SmExternalUser>(entity =>
    //    {
    //        entity.HasKey(e => e.ExUserid);

    //        entity.ToTable("SM_EXTERNAL_USERS");

    //        entity.Property(e => e.ExUserid).HasColumnName("EX_USERID");
    //        entity.Property(e => e.AccessLevel).HasColumnName("ACCESS_LEVEL");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.CompanyId).HasMaxLength(100);
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.DashboardAccess)
    //            .HasDefaultValueSql("((-1))")
    //            .HasColumnName("DASHBOARD_ACCESS");
    //        entity.Property(e => e.ExEmailid).HasColumnName("EX_EMAILID");
    //        entity.Property(e => e.ExPassword)
    //            .HasMaxLength(50)
    //            .HasColumnName("EX_PASSWORD");
    //        entity.Property(e => e.ExUsercode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("EX_USERCODE");
    //        entity.Property(e => e.ExUsername).HasColumnName("EX_USERNAME");
    //        entity.Property(e => e.Exported).HasColumnName("EXPORTED");
    //        entity.Property(e => e.InvUsertype).HasColumnName("INV_USERTYPE");
    //        entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.PwdExpired).HasColumnName("PWD_EXPIRED");
    //        entity.Property(e => e.Siteid).HasColumnName("SITEID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UpdateInvoice).HasColumnName("UPDATE_INVOICE");
    //        entity.Property(e => e.UpdateSite).HasColumnName("UPDATE_SITE");
    //        entity.Property(e => e.Usertype).HasColumnName("USERTYPE");
    //        entity.Property(e => e.UsertypeLesmonitor).HasColumnName("Usertype_Lesmonitor");
    //    });

    //    modelBuilder.Entity<SmFileAudit>(entity =>
    //    {
    //        entity.HasKey(e => e.Recordid).HasName("PK_SM_FILE_AUDIT_1");

    //        entity.ToTable("SM_FILE_AUDIT");

    //        entity.Property(e => e.Recordid).HasColumnName("RECORDID");
    //        entity.Property(e => e.BuyerRef)
    //            .HasMaxLength(100)
    //            .HasColumnName("BUYER_REF");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.NotToCheck).HasColumnName("NOT_TO_CHECK");
    //        entity.Property(e => e.OrderMail)
    //            .HasMaxLength(30)
    //            .HasColumnName("ORDER_MAIL");
    //        entity.Property(e => e.PoDownload)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PO_DOWNLOAD");
    //        entity.Property(e => e.PoExp)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PO_EXP");
    //        entity.Property(e => e.PoId).HasColumnName("PO_ID");
    //        entity.Property(e => e.PoImp)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PO_IMP");
    //        entity.Property(e => e.PoMailSent)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PO_MAIL_SENT");
    //        entity.Property(e => e.PoUpload)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PO_UPLOAD");
    //        entity.Property(e => e.PocDownload)
    //            .HasColumnType("datetime")
    //            .HasColumnName("POC_DOWNLOAD");
    //        entity.Property(e => e.PocExp)
    //            .HasColumnType("datetime")
    //            .HasColumnName("POC_EXP");
    //        entity.Property(e => e.PocId).HasColumnName("POC_ID");
    //        entity.Property(e => e.PocImp)
    //            .HasColumnType("datetime")
    //            .HasColumnName("POC_IMP");
    //        entity.Property(e => e.PocMailSent)
    //            .HasColumnType("datetime")
    //            .HasColumnName("POC_MAIL_SENT");
    //        entity.Property(e => e.PocUpload)
    //            .HasColumnType("datetime")
    //            .HasColumnName("POC_UPLOAD");
    //        entity.Property(e => e.QuoteDownload)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_DOWNLOAD");
    //        entity.Property(e => e.QuoteExp)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_EXP");
    //        entity.Property(e => e.QuoteId).HasColumnName("QUOTE_ID");
    //        entity.Property(e => e.QuoteImp)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_IMP");
    //        entity.Property(e => e.QuoteMailSent)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_MAIL_SENT");
    //        entity.Property(e => e.QuoteUpload)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_UPLOAD");
    //        entity.Property(e => e.RfqDownload)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_DOWNLOAD");
    //        entity.Property(e => e.RfqExp)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_EXP");
    //        entity.Property(e => e.RfqId).HasColumnName("RFQ_ID");
    //        entity.Property(e => e.RfqImp)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_IMP");
    //        entity.Property(e => e.RfqMail)
    //            .HasMaxLength(30)
    //            .HasColumnName("RFQ_MAIL");
    //        entity.Property(e => e.RfqMailSent)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_MAIL_SENT");
    //        entity.Property(e => e.RfqUpload)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_UPLOAD");
    //        entity.Property(e => e.SupplierRef)
    //            .HasMaxLength(100)
    //            .HasColumnName("SUPPLIER_REF");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.Version).HasColumnName("VERSION");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmInvoiceAddrlink>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToTable("SM_INVOICE_ADDRLINK");

    //        entity.Property(e => e.AccountNum)
    //            .HasMaxLength(50)
    //            .HasColumnName("ACCOUNT_NUM");
    //        entity.Property(e => e.BankDetails)
    //            .HasMaxLength(200)
    //            .HasColumnName("BANK_DETAILS");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.IbanNum)
    //            .HasMaxLength(50)
    //            .HasColumnName("IBAN_NUM");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.SwiftNum)
    //            .HasMaxLength(50)
    //            .HasColumnName("SWIFT_NUM");
    //    });

    //    modelBuilder.Entity<SmInvoiceFormat>(entity =>
    //    {
    //        entity.HasKey(e => e.Invformatid);

    //        entity.ToTable("SM_INVOICE_FORMATS");

    //        entity.Property(e => e.Invformatid).HasColumnName("INVFORMATID");
    //        entity.Property(e => e.AddrType)
    //            .HasMaxLength(10)
    //            .HasColumnName("ADDR_TYPE");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.InvoiceFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("INVOICE_FORMAT");
    //        entity.Property(e => e.UpdatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATED_DATE");
    //    });

    //    modelBuilder.Entity<SmItemUomMapping>(entity =>
    //    {
    //        entity.HasKey(e => e.ItemUomMapid);

    //        entity.ToTable("SM_ITEM_UOM_MAPPING");

    //        entity.Property(e => e.ItemUomMapid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("ITEM_UOM_MAPID");
    //        entity.Property(e => e.BuyerId).HasColumnName("BUYER_ID");
    //        entity.Property(e => e.BuyerItemUom)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_ITEM_UOM");
    //        entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
    //        entity.Property(e => e.SupplierItemUom)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_ITEM_UOM");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmMailDownloadLog>(entity =>
    //    {
    //        entity.HasKey(e => e.LogId);

    //        entity.ToTable("SM_MAIL_DOWNLOAD_LOG");

    //        entity.Property(e => e.LogId).HasColumnName("LogID");
    //        entity.Property(e => e.AuditValue)
    //            .HasMaxLength(500)
    //            .IsUnicode(false);
    //        entity.Property(e => e.BuyerId).HasColumnName("BUYER_ID");
    //        entity.Property(e => e.FromMail)
    //            .HasMaxLength(200)
    //            .IsUnicode(false);
    //        entity.Property(e => e.KeyRef1)
    //            .HasMaxLength(150)
    //            .IsUnicode(false);
    //        entity.Property(e => e.KeyRef2)
    //            .HasMaxLength(150)
    //            .IsUnicode(false);
    //        entity.Property(e => e.LogType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false);
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .IsUnicode(false);
    //        entity.Property(e => e.MessageId)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("MessageID");
    //        entity.Property(e => e.ModuleName)
    //            .HasMaxLength(50)
    //            .IsUnicode(false);
    //        entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
    //        entity.Property(e => e.ToMail)
    //            .HasMaxLength(200)
    //            .IsUnicode(false);
    //        entity.Property(e => e.UpdateDate).HasColumnType("datetime");
    //    });

    //    modelBuilder.Entity<SmMailTransactionLog>(entity =>
    //    {
    //        entity.HasKey(e => e.TransId);

    //        entity.ToTable("SM_MAIL_TRANSACTION_LOG", tb => tb.HasTrigger("AUTO_INSERT_SM_MAIL_TRANSACTION_LOG"));

    //        entity.Property(e => e.TransId).HasColumnName("TRANS_ID");
    //        entity.Property(e => e.BuyerId).HasColumnName("BUYER_ID");
    //        entity.Property(e => e.Comments)
    //            .HasMaxLength(500)
    //            .HasColumnName("COMMENTS");
    //        entity.Property(e => e.File1)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("FILE1");
    //        entity.Property(e => e.File2)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("FILE2");
    //        entity.Property(e => e.FromMail)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("FROM_MAIL");
    //        entity.Property(e => e.KeyRefno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("KEY_REFNO");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.LogType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("LOG_TYPE");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(400)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.ModuleName)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("MODULE_NAME");
    //        entity.Property(e => e.Msgfile)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MSGFILE");
    //        entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
    //        entity.Property(e => e.ToMail)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("TO_MAIL");
    //        entity.Property(e => e.TransStatus).HasColumnName("TRANS_STATUS");
    //        entity.Property(e => e.Updatedate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATEDATE");
    //    });

    //    modelBuilder.Entity<SmPartunit>(entity =>
    //    {
    //        entity.HasKey(e => e.Partunitid).IsClustered(false);

    //        entity.ToTable("SM_PARTUNIT");

    //        entity.Property(e => e.Partunitid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("PARTUNITID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Exported).HasColumnName("EXPORTED");
    //        entity.Property(e => e.Siteid).HasColumnName("SITEID");
    //        entity.Property(e => e.UnitCode)
    //            .HasMaxLength(10)
    //            .HasColumnName("UNIT_CODE");
    //        entity.Property(e => e.UnitDescr)
    //            .HasMaxLength(25)
    //            .HasColumnName("UNIT_DESCR");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UpdateSite).HasColumnName("UPDATE_SITE");
    //    });

    //    modelBuilder.Entity<SmPdfBuyerLink>(entity =>
    //    {
    //        entity.HasKey(e => e.MapId).HasName("PK_SM_PDF_BUYER_SUPPLIER_LINK");

    //        entity.ToTable("SM_PDF_BUYER_LINK");

    //        entity.Property(e => e.MapId)
    //            .ValueGeneratedNever()
    //            .HasColumnName("MAP_ID");
    //        entity.Property(e => e.BuyerSuppLinkid).HasColumnName("BUYER_SUPP_LINKID");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.DoNotUse).HasColumnName("DO_NOT_USE");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.FormatMapCode)
    //            .HasMaxLength(150)
    //            .HasColumnName("FORMAT_MAP_CODE");
    //        entity.Property(e => e.Mapping1)
    //            .HasMaxLength(20)
    //            .HasColumnName("MAPPING_1");
    //        entity.Property(e => e.Mapping1Value)
    //            .HasMaxLength(100)
    //            .HasColumnName("MAPPING_1_VALUE");
    //        entity.Property(e => e.Mapping2)
    //            .HasMaxLength(20)
    //            .HasColumnName("MAPPING_2");
    //        entity.Property(e => e.Mapping2Value)
    //            .HasMaxLength(100)
    //            .HasColumnName("MAPPING_2_VALUE");
    //        entity.Property(e => e.Mapping3)
    //            .HasMaxLength(20)
    //            .HasColumnName("MAPPING_3");
    //        entity.Property(e => e.Mapping3Value)
    //            .HasMaxLength(100)
    //            .HasColumnName("MAPPING_3_VALUE");
    //        entity.Property(e => e.PdfMapid).HasColumnName("PDF_MAPID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmPdfItemMapping>(entity =>
    //    {
    //        entity.HasKey(e => e.ItemMapid);

    //        entity.ToTable("SM_PDF_ITEM_MAPPING");

    //        entity.Property(e => e.ItemMapid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("ITEM_MAPID");
    //        entity.Property(e => e.AppendRefNo).HasColumnName("APPEND_REF_NO");
    //        entity.Property(e => e.AppendUom).HasColumnName("APPEND_UOM");
    //        entity.Property(e => e.CheckContentBelowItem).HasColumnName("CHECK_CONTENT_BELOW_ITEM");
    //        entity.Property(e => e.EquipMakerRange)
    //            .HasMaxLength(50)
    //            .HasColumnName("EQUIP_MAKER_RANGE");
    //        entity.Property(e => e.EquipNameRange)
    //            .HasMaxLength(50)
    //            .HasColumnName("EQUIP_NAME_RANGE");
    //        entity.Property(e => e.EquipNoteRange)
    //            .HasMaxLength(50)
    //            .HasColumnName("EQUIP_NOTE_RANGE");
    //        entity.Property(e => e.EquipSernoRange)
    //            .HasMaxLength(50)
    //            .HasColumnName("EQUIP_SERNO_RANGE");
    //        entity.Property(e => e.EquipTypeRange)
    //            .HasMaxLength(50)
    //            .HasColumnName("EQUIP_TYPE_RANGE");
    //        entity.Property(e => e.ExtraColumns).HasColumnName("EXTRA_COLUMNS");
    //        entity.Property(e => e.ExtraColumnsHeader).HasColumnName("EXTRA_COLUMNS_HEADER");
    //        entity.Property(e => e.ExtranoRange)
    //            .HasMaxLength(50)
    //            .HasColumnName("EXTRANO_RANGE");
    //        entity.Property(e => e.HasNoEquipHeader).HasColumnName("HAS_NO_EQUIP_HEADER");
    //        entity.Property(e => e.InitialItemSpace).HasColumnName("INITIAL_ITEM_SPACE");
    //        entity.Property(e => e.IsBoldText).HasColumnName("IS_BOLD_TEXT");
    //        entity.Property(e => e.IsQtyUomMerged).HasColumnName("IS_QTY_UOM_MERGED");
    //        entity.Property(e => e.ItemCurrency)
    //            .HasMaxLength(50)
    //            .HasColumnName("ITEM_CURRENCY");
    //        entity.Property(e => e.ItemDescr)
    //            .HasMaxLength(50)
    //            .HasColumnName("ITEM_DESCR");
    //        entity.Property(e => e.ItemDiscount)
    //            .HasMaxLength(50)
    //            .HasColumnName("ITEM_DISCOUNT");
    //        entity.Property(e => e.ItemEndContent)
    //            .HasMaxLength(100)
    //            .HasColumnName("ITEM_END_CONTENT");
    //        entity.Property(e => e.ItemEquipment)
    //            .HasMaxLength(500)
    //            .HasColumnName("ITEM_EQUIPMENT");
    //        entity.Property(e => e.ItemGroupHeader)
    //            .HasMaxLength(100)
    //            .HasColumnName("ITEM_GROUP_HEADER");
    //        entity.Property(e => e.ItemHeaderContent)
    //            .HasMaxLength(500)
    //            .HasColumnName("ITEM_HEADER_CONTENT");
    //        entity.Property(e => e.ItemHeaderLineCount).HasColumnName("ITEM_HEADER_LINE_COUNT");
    //        entity.Property(e => e.ItemLeaddays)
    //            .HasMaxLength(50)
    //            .HasColumnName("ITEM_LEADDAYS");
    //        entity.Property(e => e.ItemMinLines).HasColumnName("ITEM_MIN_LINES");
    //        entity.Property(e => e.ItemNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("ITEM_NO");
    //        entity.Property(e => e.ItemQty)
    //            .HasMaxLength(50)
    //            .HasColumnName("ITEM_QTY");
    //        entity.Property(e => e.ItemRefNoHeader).HasColumnName("ITEM_REF_NO_HEADER");
    //        entity.Property(e => e.ItemRefno)
    //            .HasMaxLength(50)
    //            .HasColumnName("ITEM_REFNO");
    //        entity.Property(e => e.ItemRemark)
    //            .HasMaxLength(50)
    //            .HasColumnName("ITEM_REMARK");
    //        entity.Property(e => e.ItemRemarksAppendText)
    //            .HasMaxLength(100)
    //            .HasColumnName("ITEM_REMARKS_APPEND_TEXT");
    //        entity.Property(e => e.ItemRemarksInitials)
    //            .HasMaxLength(100)
    //            .HasColumnName("ITEM_REMARKS_INITIALS");
    //        entity.Property(e => e.ItemTotal)
    //            .HasMaxLength(50)
    //            .HasColumnName("ITEM_TOTAL");
    //        entity.Property(e => e.ItemUnit)
    //            .HasMaxLength(50)
    //            .HasColumnName("ITEM_UNIT");
    //        entity.Property(e => e.ItemUnitprice)
    //            .HasMaxLength(50)
    //            .HasColumnName("ITEM_UNITPRICE");
    //        entity.Property(e => e.LeaddaysInDate).HasColumnName("LEADDAYS_IN_DATE");
    //        entity.Property(e => e.MakerrefExtranoLineCount).HasColumnName("MAKERREF_EXTRANO_LINE_COUNT");
    //        entity.Property(e => e.MakerrefRange)
    //            .HasMaxLength(50)
    //            .HasColumnName("MAKERREF_RANGE");
    //        entity.Property(e => e.MapNumber).HasColumnName("MAP_NUMBER");
    //        entity.Property(e => e.MaxEquipRange).HasColumnName("MAX_EQUIP_RANGE");
    //        entity.Property(e => e.MaxEquipRows).HasColumnName("MAX_EQUIP_ROWS");
    //        entity.Property(e => e.PdfMapid).HasColumnName("PDF_MAPID");
    //        entity.Property(e => e.ReadItemnoUptoMinlines).HasColumnName("READ_ITEMNO_UPTO_MINLINES");
    //        entity.Property(e => e.ReadPartnoFromLastLine).HasColumnName("READ_PARTNO_FROM_LAST_LINE");
    //        entity.Property(e => e.RemoveDigitInUom).HasColumnName("REMOVE_DIGIT_IN_UOM");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.ValidateItemPriceTotal).HasColumnName("VALIDATE_ITEM_PRICE_TOTAL");
    //    });

    //    modelBuilder.Entity<SmPdfMapping>(entity =>
    //    {
    //        entity.HasKey(e => e.PdfMapid).HasName("PK_SM_PDF_MAPPING_TEMP");

    //        entity.ToTable("SM_PDF_MAPPING");

    //        entity.Property(e => e.PdfMapid)
    //            .ValueGeneratedNever()
    //            .HasColumnName("PDF_MAPID");
    //        entity.Property(e => e.AddDiscountHeader)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADD_DISCOUNT_HEADER");
    //        entity.Property(e => e.AddFooterToComments).HasColumnName("ADD_FOOTER_TO_COMMENTS");
    //        entity.Property(e => e.AddHeaderToComments).HasColumnName("ADD_HEADER_TO_COMMENTS");
    //        entity.Property(e => e.AddItemDeldateToHeader).HasColumnName("ADD_ITEM_DELDATE_TO_HEADER");
    //        entity.Property(e => e.AddSkippedTxtToRemakrs).HasColumnName("ADD_SKIPPED_TXT_TO_REMAKRS");
    //        entity.Property(e => e.AllowanceAmtHeader)
    //            .HasMaxLength(50)
    //            .HasColumnName("ALLOWANCE_AMT_HEADER");
    //        entity.Property(e => e.BillAddrHeader)
    //            .HasMaxLength(200)
    //            .HasColumnName("BILL_ADDR_HEADER");
    //        entity.Property(e => e.BillAddress)
    //            .HasMaxLength(50)
    //            .HasColumnName("BILL_ADDRESS");
    //        entity.Property(e => e.BillContact)
    //            .HasMaxLength(50)
    //            .HasColumnName("BILL_CONTACT");
    //        entity.Property(e => e.BillContactHeader)
    //            .HasMaxLength(100)
    //            .HasColumnName("BILL_CONTACT_HEADER");
    //        entity.Property(e => e.BillEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("BILL_EMAIL");
    //        entity.Property(e => e.BillFax)
    //            .HasMaxLength(50)
    //            .HasColumnName("BILL_FAX");
    //        entity.Property(e => e.BillName)
    //            .HasMaxLength(50)
    //            .HasColumnName("BILL_NAME");
    //        entity.Property(e => e.BillTel)
    //            .HasMaxLength(50)
    //            .HasColumnName("BILL_TEL");
    //        entity.Property(e => e.BuyerAddress)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_ADDRESS");
    //        entity.Property(e => e.BuyerComments)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_COMMENTS");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerContactHeader)
    //            .HasMaxLength(100)
    //            .HasColumnName("BUYER_CONTACT_HEADER");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerFax)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_FAX");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.BuyerTel)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_TEL");
    //        entity.Property(e => e.ByrAddrHeader)
    //            .HasMaxLength(200)
    //            .HasColumnName("BYR_ADDR_HEADER");
    //        entity.Property(e => e.CenterAlignedItems).HasColumnName("CENTER_ALIGNED_ITEMS");
    //        entity.Property(e => e.CommentsColRange)
    //            .HasMaxLength(100)
    //            .HasColumnName("COMMENTS_COL_RANGE");
    //        entity.Property(e => e.ConsignAddress)
    //            .HasMaxLength(50)
    //            .HasColumnName("CONSIGN_ADDRESS");
    //        entity.Property(e => e.ConsignContact)
    //            .HasMaxLength(50)
    //            .HasColumnName("CONSIGN_CONTACT");
    //        entity.Property(e => e.ConsignEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("CONSIGN_EMAIL");
    //        entity.Property(e => e.ConsignFax)
    //            .HasMaxLength(50)
    //            .HasColumnName("CONSIGN_FAX");
    //        entity.Property(e => e.ConsignName)
    //            .HasMaxLength(50)
    //            .HasColumnName("CONSIGN_NAME");
    //        entity.Property(e => e.ConsignTel)
    //            .HasMaxLength(50)
    //            .HasColumnName("CONSIGN_TEL");
    //        entity.Property(e => e.ConstantRows)
    //            .HasMaxLength(50)
    //            .HasColumnName("CONSTANT_ROWS");
    //        entity.Property(e => e.CreatedDate)
    //            .HasMaxLength(50)
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.CurrHeader)
    //            .HasMaxLength(200)
    //            .HasColumnName("CURR_HEADER");
    //        entity.Property(e => e.Currency)
    //            .HasMaxLength(50)
    //            .HasColumnName("CURRENCY");
    //        entity.Property(e => e.DateFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("DATE_FORMAT");
    //        entity.Property(e => e.DateFormat1)
    //            .HasMaxLength(50)
    //            .HasColumnName("DATE_FORMAT_1");
    //        entity.Property(e => e.DateFormat2)
    //            .HasMaxLength(50)
    //            .HasColumnName("DATE_FORMAT_2");
    //        entity.Property(e => e.DecimalSeprator)
    //            .HasMaxLength(3)
    //            .HasColumnName("DECIMAL_SEPRATOR");
    //        entity.Property(e => e.DefaultVessel)
    //            .HasMaxLength(100)
    //            .HasColumnName("DEFAULT_VESSEL");
    //        entity.Property(e => e.DelDateHeader)
    //            .HasMaxLength(200)
    //            .HasColumnName("DEL_DATE_HEADER");
    //        entity.Property(e => e.DeliveryPort)
    //            .HasMaxLength(50)
    //            .HasColumnName("DELIVERY_PORT");
    //        entity.Property(e => e.DeliveryPortHeader)
    //            .HasMaxLength(100)
    //            .HasColumnName("DELIVERY_PORT_HEADER");
    //        entity.Property(e => e.Department)
    //            .HasMaxLength(50)
    //            .HasColumnName("DEPARTMENT");
    //        entity.Property(e => e.DeptHeader)
    //            .HasMaxLength(200)
    //            .HasColumnName("DEPT_HEADER");
    //        entity.Property(e => e.DiscountInPrcnt).HasColumnName("DISCOUNT_IN_PRCNT");
    //        entity.Property(e => e.DocDateHeader)
    //            .HasMaxLength(200)
    //            .HasColumnName("DOC_DATE_HEADER");
    //        entity.Property(e => e.EndCommentStartContent)
    //            .HasMaxLength(100)
    //            .HasColumnName("END_COMMENT_START_CONTENT");
    //        entity.Property(e => e.EquipMaker)
    //            .HasMaxLength(50)
    //            .HasColumnName("EQUIP_MAKER");
    //        entity.Property(e => e.EquipMakerHeader)
    //            .HasMaxLength(50)
    //            .HasColumnName("EQUIP_MAKER_HEADER");
    //        entity.Property(e => e.EquipName)
    //            .HasMaxLength(50)
    //            .HasColumnName("EQUIP_NAME");
    //        entity.Property(e => e.EquipNameHeader)
    //            .HasMaxLength(50)
    //            .HasColumnName("EQUIP_NAME_HEADER");
    //        entity.Property(e => e.EquipRemarks)
    //            .HasMaxLength(50)
    //            .HasColumnName("EQUIP_REMARKS");
    //        entity.Property(e => e.EquipRemarksHeader)
    //            .HasMaxLength(50)
    //            .HasColumnName("EQUIP_REMARKS_HEADER");
    //        entity.Property(e => e.EquipSerno)
    //            .HasMaxLength(50)
    //            .HasColumnName("EQUIP_SERNO");
    //        entity.Property(e => e.EquipSernoHeader)
    //            .HasMaxLength(50)
    //            .HasColumnName("EQUIP_SERNO_HEADER");
    //        entity.Property(e => e.EquipType)
    //            .HasMaxLength(50)
    //            .HasColumnName("EQUIP_TYPE");
    //        entity.Property(e => e.EquipTypeHeader)
    //            .HasMaxLength(50)
    //            .HasColumnName("EQUIP_TYPE_HEADER");
    //        entity.Property(e => e.EtaHeader)
    //            .HasMaxLength(200)
    //            .HasColumnName("ETA_HEADER");
    //        entity.Property(e => e.EtdHeader)
    //            .HasMaxLength(200)
    //            .HasColumnName("ETD_HEADER");
    //        entity.Property(e => e.ExtraFields).HasColumnName("EXTRA_FIELDS");
    //        entity.Property(e => e.ExtraFieldsHeader).HasColumnName("EXTRA_FIELDS_HEADER");
    //        entity.Property(e => e.FieldsFromFooter)
    //            .HasMaxLength(1000)
    //            .HasColumnName("FIELDS_FROM_FOOTER");
    //        entity.Property(e => e.FieldsFromHeader)
    //            .HasMaxLength(1000)
    //            .HasColumnName("FIELDS_FROM_HEADER");
    //        entity.Property(e => e.FooterFlineContent)
    //            .HasMaxLength(100)
    //            .HasColumnName("FOOTER_FLINE_CONTENT");
    //        entity.Property(e => e.FooterLineCount).HasColumnName("FOOTER_LINE_COUNT");
    //        entity.Property(e => e.FooterLlineContent)
    //            .HasMaxLength(100)
    //            .HasColumnName("FOOTER_LLINE_CONTENT");
    //        entity.Property(e => e.FrieghtAmtHeader)
    //            .HasMaxLength(50)
    //            .HasColumnName("FRIEGHT_AMT_HEADER");
    //        entity.Property(e => e.GrantTotalHeader)
    //            .HasMaxLength(50)
    //            .HasColumnName("GRANT_TOTAL_HEADER");
    //        entity.Property(e => e.Groupid).HasColumnName("GROUPID");
    //        entity.Property(e => e.HeaderCommentsEndText).HasColumnName("HEADER_COMMENTS_END_TEXT");
    //        entity.Property(e => e.HeaderCommentsStartText).HasColumnName("HEADER_COMMENTS_START_TEXT");
    //        entity.Property(e => e.HeaderFlineContent)
    //            .HasMaxLength(100)
    //            .HasColumnName("HEADER_FLINE_CONTENT");
    //        entity.Property(e => e.HeaderLineCount).HasColumnName("HEADER_LINE_COUNT");
    //        entity.Property(e => e.HeaderLlineContent)
    //            .HasMaxLength(100)
    //            .HasColumnName("HEADER_LLINE_CONTENT");
    //        entity.Property(e => e.ImoNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("IMO_NO");
    //        entity.Property(e => e.ImoNoHeader)
    //            .HasMaxLength(50)
    //            .HasColumnName("IMO_NO_HEADER");
    //        entity.Property(e => e.IncludeBlanckLines).HasColumnName("INCLUDE_BLANCK_LINES");
    //        entity.Property(e => e.ItemCountHeader)
    //            .HasMaxLength(512)
    //            .HasColumnName("ITEM_COUNT_HEADER");
    //        entity.Property(e => e.ItemDescrUptoLineCount).HasColumnName("ITEM_DESCR_UPTO_LINE_COUNT");
    //        entity.Property(e => e.ItemFormat)
    //            .HasMaxLength(512)
    //            .HasColumnName("ITEM_FORMAT");
    //        entity.Property(e => e.ItemSeparatedByNewline).HasColumnName("ITEM_SEPARATED_BY_NEWLINE");
    //        entity.Property(e => e.ItemsTotalHeader)
    //            .HasMaxLength(50)
    //            .HasColumnName("ITEMS_TOTAL_HEADER");
    //        entity.Property(e => e.LateDate)
    //            .HasMaxLength(50)
    //            .HasColumnName("LATE_DATE");
    //        entity.Property(e => e.OverrideItemQty).HasColumnName("OVERRIDE_ITEM_QTY");
    //        entity.Property(e => e.PackingAmtHeader)
    //            .HasMaxLength(50)
    //            .HasColumnName("PACKING_AMT_HEADER");
    //        entity.Property(e => e.PaymentTerms)
    //            .HasMaxLength(50)
    //            .HasColumnName("PAYMENT_TERMS");
    //        entity.Property(e => e.PaymentTermsHeader)
    //            .HasMaxLength(100)
    //            .HasColumnName("PAYMENT_TERMS_HEADER");
    //        entity.Property(e => e.PoReference)
    //            .HasMaxLength(50)
    //            .HasColumnName("PO_REFERENCE");
    //        entity.Property(e => e.PocRefHeader)
    //            .HasMaxLength(200)
    //            .HasColumnName("POC_REF_HEADER");
    //        entity.Property(e => e.PortCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("PORT_CODE");
    //        entity.Property(e => e.PortCodeHeader)
    //            .HasMaxLength(100)
    //            .HasColumnName("PORT_CODE_HEADER");
    //        entity.Property(e => e.QuoteExpHeader)
    //            .HasMaxLength(200)
    //            .HasColumnName("QUOTE_EXP_HEADER");
    //        entity.Property(e => e.QuoteRefHeader)
    //            .HasMaxLength(200)
    //            .HasColumnName("QUOTE_REF_HEADER");
    //        entity.Property(e => e.QuoteReference)
    //            .HasMaxLength(50)
    //            .HasColumnName("QUOTE_REFERENCE");
    //        entity.Property(e => e.QuoteValidity)
    //            .HasMaxLength(50)
    //            .HasColumnName("QUOTE_VALIDITY");
    //        entity.Property(e => e.ReadContentBelowItem).HasColumnName("READ_CONTENT_BELOW_ITEM");
    //        entity.Property(e => e.RemHeaderRemarkSpace).HasColumnName("REM_HEADER_REMARK_SPACE");
    //        entity.Property(e => e.SampleFile)
    //            .HasMaxLength(250)
    //            .HasColumnName("SAMPLE_FILE");
    //        entity.Property(e => e.ShipAddrHeader)
    //            .HasMaxLength(200)
    //            .HasColumnName("SHIP_ADDR_HEADER");
    //        entity.Property(e => e.ShipContactHeader)
    //            .HasMaxLength(100)
    //            .HasColumnName("SHIP_CONTACT_HEADER");
    //        entity.Property(e => e.SkipLines)
    //            .HasMaxLength(50)
    //            .HasColumnName("SKIP_LINES");
    //        entity.Property(e => e.SkipTextEnd).HasColumnName("SKIP_TEXT_END");
    //        entity.Property(e => e.SkipTextStart).HasColumnName("SKIP_TEXT_START");
    //        entity.Property(e => e.SplitFile).HasColumnName("SPLIT_FILE");
    //        entity.Property(e => e.SplitStartContent)
    //            .HasMaxLength(100)
    //            .HasColumnName("SPLIT_START_CONTENT");
    //        entity.Property(e => e.Subject)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUBJECT");
    //        entity.Property(e => e.SubjectHeader)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUBJECT_HEADER");
    //        entity.Property(e => e.SuppAddrHeader)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPP_ADDR_HEADER");
    //        entity.Property(e => e.SuppAddress)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_ADDRESS");
    //        entity.Property(e => e.SuppComments)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_COMMENTS");
    //        entity.Property(e => e.SuppContact)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_CONTACT");
    //        entity.Property(e => e.SuppContactHeader)
    //            .HasMaxLength(100)
    //            .HasColumnName("SUPP_CONTACT_HEADER");
    //        entity.Property(e => e.SuppEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_EMAIL");
    //        entity.Property(e => e.SuppFax)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_FAX");
    //        entity.Property(e => e.SuppName)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_NAME");
    //        entity.Property(e => e.SuppTel)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_TEL");
    //        entity.Property(e => e.TermCondition)
    //            .HasMaxLength(50)
    //            .HasColumnName("TERM_CONDITION");
    //        entity.Property(e => e.TermConditionHeader)
    //            .HasMaxLength(100)
    //            .HasColumnName("TERM_CONDITION_HEADER");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.ValidateItemDescr).HasColumnName("VALIDATE_ITEM_DESCR");
    //        entity.Property(e => e.Vessel)
    //            .HasMaxLength(50)
    //            .HasColumnName("VESSEL");
    //        entity.Property(e => e.VesselEta)
    //            .HasMaxLength(50)
    //            .HasColumnName("VESSEL_ETA");
    //        entity.Property(e => e.VesselEtd)
    //            .HasMaxLength(50)
    //            .HasColumnName("VESSEL_ETD");
    //        entity.Property(e => e.VesselHeader)
    //            .HasMaxLength(100)
    //            .HasColumnName("VESSEL_HEADER");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VRNO");
    //        entity.Property(e => e.VrnoHeader)
    //            .HasMaxLength(100)
    //            .HasColumnName("VRNO_HEADER");
    //    });

    //    modelBuilder.Entity<SmQuotationdetailVendor>(entity =>
    //    {
    //        entity.HasKey(e => e.Quotationdetailid).IsClustered(false);

    //        entity.ToTable("SM_QUOTATIONDETAIL_VENDOR");

    //        entity.HasIndex(e => e.Quotationid, "\"IDX_QUOTATIONDETAIL_ITEMNO\"");

    //        entity.HasIndex(e => e.Quotationid, "NonClusteredIndex-20220620-173715_QUOTATIONID");

    //        entity.Property(e => e.Quotationdetailid).HasColumnName("QUOTATIONDETAILID");
    //        entity.Property(e => e.BuyerOrgref)
    //            .HasMaxLength(40)
    //            .HasColumnName("BuyerORGRef");
    //        entity.Property(e => e.BuyerPrice).HasColumnName("Buyer_Price");
    //        entity.Property(e => e.BuyerUnitCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_UNIT_CODE");
    //        entity.Property(e => e.ByrOriginatingsystemref)
    //            .HasMaxLength(50)
    //            .HasColumnName("BYR_ORIGINATINGSYSTEMREF");
    //        entity.Property(e => e.ChangedByVendor).HasColumnName("CHANGED_BY_VENDOR");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Deliverytime).HasColumnName("DELIVERYTIME");
    //        entity.Property(e => e.Department)
    //            .HasMaxLength(200)
    //            .HasColumnName("DEPARTMENT");
    //        entity.Property(e => e.Discount)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("DISCOUNT");
    //        entity.Property(e => e.Docitemid)
    //            .HasMaxLength(256)
    //            .HasColumnName("DOCITEMID");
    //        entity.Property(e => e.Drawingno)
    //            .HasMaxLength(200)
    //            .HasColumnName("DRAWINGNO");
    //        entity.Property(e => e.EquipMaker)
    //            .HasMaxLength(512)
    //            .HasColumnName("EQUIP_MAKER");
    //        entity.Property(e => e.EquipName)
    //            .HasMaxLength(500)
    //            .HasColumnName("EQUIP_NAME");
    //        entity.Property(e => e.EquipRemarks)
    //            .HasMaxLength(1000)
    //            .HasColumnName("EQUIP_REMARKS");
    //        entity.Property(e => e.EquipSerno)
    //            .HasMaxLength(200)
    //            .HasColumnName("EQUIP_SERNO");
    //        entity.Property(e => e.EquipType)
    //            .HasMaxLength(200)
    //            .HasColumnName("EQUIP_TYPE");
    //        entity.Property(e => e.ExternalItemNumber).HasMaxLength(50);
    //        entity.Property(e => e.Impa)
    //            .HasMaxLength(50)
    //            .HasColumnName("IMPA");
    //        entity.Property(e => e.Issa)
    //            .HasMaxLength(50)
    //            .HasColumnName("ISSA");
    //        entity.Property(e => e.ItemMarkedRemark).HasColumnName("ITEM_MARKED_REMARK");
    //        entity.Property(e => e.ItemPacketSize)
    //            .HasMaxLength(100)
    //            .HasColumnName("ITEM_PACKET_SIZE");
    //        entity.Property(e => e.ItemRemark)
    //            .HasMaxLength(2048)
    //            .HasColumnName("ITEM_REMARK");
    //        entity.Property(e => e.ItemType)
    //            .HasMaxLength(50)
    //            .HasColumnName("ITEM_TYPE");
    //        entity.Property(e => e.Itemno).HasColumnName("ITEMNO");
    //        entity.Property(e => e.Itemstatus)
    //            .HasDefaultValueSql("((1))")
    //            .HasColumnName("ITEMSTATUS");
    //        entity.Property(e => e.LinkRecordId).HasColumnName("LINK_RECORD_ID");
    //        entity.Property(e => e.Originatingsystemref)
    //            .HasMaxLength(50)
    //            .HasColumnName("ORIGINATINGSYSTEMREF");
    //        entity.Property(e => e.Partname)
    //            .HasMaxLength(1000)
    //            .HasColumnName("PARTNAME");
    //        entity.Property(e => e.Posno)
    //            .HasMaxLength(200)
    //            .HasColumnName("POSNO");
    //        entity.Property(e => e.QtyOrd)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("QTY_ORD");
    //        entity.Property(e => e.QtyQuoted)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("QTY_QUOTED");
    //        entity.Property(e => e.QtyReq)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("QTY_REQ");
    //        entity.Property(e => e.QualityLevel)
    //            .HasMaxLength(100)
    //            .HasColumnName("QUALITY_LEVEL");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteExchrate)
    //            .HasDefaultValueSql("((1))")
    //            .HasColumnName("QUOTE_EXCHRATE");
    //        entity.Property(e => e.QuoteFile)
    //            .HasMaxLength(50)
    //            .HasColumnName("QUOTE_FILE");
    //        entity.Property(e => e.QuotedPrice)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("QUOTED_PRICE");
    //        entity.Property(e => e.QuoteitemRemark)
    //            .HasColumnType("ntext")
    //            .HasColumnName("QUOTEITEM_REMARK");
    //        entity.Property(e => e.ReferenceNo)
    //            .HasMaxLength(200)
    //            .HasColumnName("REFERENCE_NO");
    //        entity.Property(e => e.Refno)
    //            .HasMaxLength(200)
    //            .HasColumnName("REFNO");
    //        entity.Property(e => e.Siteid).HasColumnName("SITEID");
    //        entity.Property(e => e.SupplierOrgref)
    //            .HasMaxLength(20)
    //            .HasColumnName("SupplierORGRef");
    //        entity.Property(e => e.SysItemno).HasColumnName("SYS_ITEMNO");
    //        entity.Property(e => e.TaxAmount).HasColumnName("TAX_AMOUNT");
    //        entity.Property(e => e.Udf1)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF1");
    //        entity.Property(e => e.Udf2)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF2");
    //        entity.Property(e => e.Udf3)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF3");
    //        entity.Property(e => e.UnitCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("UNIT_CODE");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.VendorItemname)
    //            .HasMaxLength(500)
    //            .HasColumnName("VENDOR_ITEMNAME");
    //        entity.Property(e => e.VendorItemno)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_ITEMNO");
    //        entity.Property(e => e.VendorRefno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VENDOR_REFNO");
    //    });

    //    modelBuilder.Entity<SmQuotationsVendor>(entity =>
    //    {
    //        entity.HasKey(e => e.Quotationid);

    //        entity.ToTable("SM_QUOTATIONS_VENDOR");

    //        entity.HasIndex(e => e.Docid, "NonClusteredIndex-20201112-123241_DOCID");

    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.AddDiscType).HasColumnName("ADD_DISC_TYPE");
    //        entity.Property(e => e.AdditionalDisc).HasColumnName("ADDITIONAL_DISC");
    //        entity.Property(e => e.Allowance).HasColumnName("ALLOWANCE");
    //        entity.Property(e => e.Attachment1)
    //            .HasMaxLength(150)
    //            .HasColumnName("ATTACHMENT1");
    //        entity.Property(e => e.Attachment2)
    //            .HasMaxLength(150)
    //            .HasColumnName("ATTACHMENT2");
    //        entity.Property(e => e.AttentionRemark)
    //            .HasMaxLength(500)
    //            .HasColumnName("ATTENTION_REMARK");
    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.BuyerRecipient)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_RECIPIENT");
    //        entity.Property(e => e.BuyerRemarks).HasColumnName("BUYER_REMARKS");
    //        entity.Property(e => e.BuyerSender)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_SENDER");
    //        entity.Property(e => e.BuyerVrno)
    //            .HasMaxLength(250)
    //            .HasColumnName("BUYER_VRNO");
    //        entity.Property(e => e.ByrSuppLinkid).HasColumnName("BYR_SUPP_LINKID");
    //        entity.Property(e => e.Category)
    //            .HasMaxLength(50)
    //            .HasColumnName("CATEGORY");
    //        entity.Property(e => e.ChangedByVendor).HasColumnName("CHANGED_BY_VENDOR");
    //        entity.Property(e => e.ContractType).HasMaxLength(50);
    //        entity.Property(e => e.CostAmount1).HasColumnName("COST_AMOUNT1");
    //        entity.Property(e => e.CostAmount2).HasColumnName("COST_AMOUNT2");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.CreatedDateInt).HasColumnName("CREATED_DATE_INT");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(3)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.Currencyid).HasColumnName("CURRENCYID");
    //        entity.Property(e => e.DeliveryPromised)
    //            .HasColumnType("datetime")
    //            .HasColumnName("DELIVERY_PROMISED");
    //        entity.Property(e => e.Deliverydays).HasColumnName("DELIVERYDAYS");
    //        entity.Property(e => e.Deliverytime)
    //            .HasColumnType("datetime")
    //            .HasColumnName("DELIVERYTIME");
    //        entity.Property(e => e.Department)
    //            .HasMaxLength(200)
    //            .HasColumnName("DEPARTMENT");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.DocXml)
    //            .HasMaxLength(5)
    //            .HasColumnName("DOC_XML");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(256)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.Exported).HasColumnName("EXPORTED");
    //        entity.Property(e => e.ExportedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("EXPORTED_DATE");
    //        entity.Property(e => e.Freightamt)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("FREIGHTAMT");
    //        entity.Property(e => e.GeneralTerms).HasColumnName("GENERAL_TERMS");
    //        entity.Property(e => e.IsDeclined)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("IS_DECLINED");
    //        entity.Property(e => e.ItemTotal)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("ITEM_TOTAL");
    //        entity.Property(e => e.Latedate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("LATEDATE");
    //        entity.Property(e => e.LinkRecordid).HasColumnName("LINK_RECORDID");
    //        entity.Property(e => e.Location)
    //            .HasMaxLength(200)
    //            .HasColumnName("LOCATION");
    //        entity.Property(e => e.MessageNumber)
    //            .HasMaxLength(250)
    //            .HasColumnName("MESSAGE_NUMBER");
    //        entity.Property(e => e.OrderHandling).HasMaxLength(50);
    //        entity.Property(e => e.OrderType).HasMaxLength(300);
    //        entity.Property(e => e.OrgSystemRef).HasMaxLength(100);
    //        entity.Property(e => e.OriginatingRequestNo).HasMaxLength(50);
    //        entity.Property(e => e.OtherCost2)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("OTHER_COST2");
    //        entity.Property(e => e.OtherCost3)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("OTHER_COST3");
    //        entity.Property(e => e.Othercosts)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("OTHERCOSTS");
    //        entity.Property(e => e.PayTerms).HasColumnName("PAY_TERMS");
    //        entity.Property(e => e.Payloadid)
    //            .HasMaxLength(100)
    //            .HasColumnName("PAYLOADID");
    //        entity.Property(e => e.PaymentTerms).HasColumnName("PAYMENT_TERMS");
    //        entity.Property(e => e.PoAckDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PO_ACK_DATE");
    //        entity.Property(e => e.PocBy).HasColumnName("POC_BY");
    //        entity.Property(e => e.PocDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("POC_DATE");
    //        entity.Property(e => e.PocReference)
    //            .HasMaxLength(50)
    //            .HasColumnName("POC_REFERENCE");
    //        entity.Property(e => e.Podate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PODATE");
    //        entity.Property(e => e.PortCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("PORT_CODE");
    //        entity.Property(e => e.PortName)
    //            .HasMaxLength(100)
    //            .HasColumnName("PORT_NAME");
    //        entity.Property(e => e.PrintStatus).HasColumnName("PRINT_STATUS");
    //        entity.Property(e => e.Priority).HasColumnName("PRIORITY");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.QuoteAmount)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("QUOTE_AMOUNT");
    //        entity.Property(e => e.QuoteApproveddate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_APPROVEDDATE");
    //        entity.Property(e => e.QuoteDiscount)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("QUOTE_DISCOUNT");
    //        entity.Property(e => e.QuoteExchrate)
    //            .HasDefaultValueSql("((1))")
    //            .HasColumnName("QUOTE_EXCHRATE");
    //        entity.Property(e => e.QuoteFileRef)
    //            .HasMaxLength(150)
    //            .HasColumnName("QUOTE_FILE_REF");
    //        entity.Property(e => e.QuoteFileStamp)
    //            .HasMaxLength(50)
    //            .HasColumnName("QUOTE_FILE_STAMP");
    //        entity.Property(e => e.QuoteRecvdDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_RECVD_DATE");
    //        entity.Property(e => e.QuoteReference)
    //            .HasMaxLength(50)
    //            .HasColumnName("QUOTE_REFERENCE");
    //        entity.Property(e => e.QuoteRemarks).HasColumnName("QUOTE_REMARKS");
    //        entity.Property(e => e.QuoteSubject)
    //            .HasMaxLength(1000)
    //            .HasColumnName("QUOTE_SUBJECT");
    //        entity.Property(e => e.QuoteSubmitBy).HasColumnName("QUOTE_SUBMIT_BY");
    //        entity.Property(e => e.QuoteSubmitDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_SUBMIT_DATE");
    //        entity.Property(e => e.QuoteValidity)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_VALIDITY");
    //        entity.Property(e => e.QuoteVersion).HasColumnName("QUOTE_VERSION");
    //        entity.Property(e => e.ReplyByDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("REPLY_BY_DATE");
    //        entity.Property(e => e.RevisionNumber).HasMaxLength(50);
    //        entity.Property(e => e.RfqAckDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_ACK_DATE");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //        entity.Property(e => e.RfqSentDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_SENT_DATE");
    //        entity.Property(e => e.SentBy).HasColumnName("SENT_BY");
    //        entity.Property(e => e.ShipComplete).HasMaxLength(20);
    //        entity.Property(e => e.Siteid).HasColumnName("SITEID");
    //        entity.Property(e => e.SpMasRemark)
    //            .HasMaxLength(500)
    //            .HasColumnName("SP_MAS_REMARK");
    //        entity.Property(e => e.SupplierOrgref)
    //            .HasMaxLength(50)
    //            .HasColumnName("SupplierORGRef");
    //        entity.Property(e => e.SupplierVrno)
    //            .HasMaxLength(250)
    //            .HasColumnName("SUPPLIER_VRNO");
    //        entity.Property(e => e.TaxAmount).HasColumnName("TAX_AMOUNT");
    //        entity.Property(e => e.TaxPercnt).HasColumnName("TAX_PERCNT");
    //        entity.Property(e => e.TransportMode)
    //            .HasMaxLength(20)
    //            .HasColumnName("TRANSPORT_MODE");
    //        entity.Property(e => e.Udf1)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF1");
    //        entity.Property(e => e.Udf2)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF2");
    //        entity.Property(e => e.Udf3)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF3");
    //        entity.Property(e => e.UpdType).HasMaxLength(50);
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UpdateDateInt).HasColumnName("UPDATE_DATE_INT");
    //        entity.Property(e => e.VendorStatus)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.Version).HasColumnName("VERSION");
    //        entity.Property(e => e.VesselEta)
    //            .HasColumnType("datetime")
    //            .HasColumnName("VESSEL_ETA");
    //        entity.Property(e => e.VesselEtd)
    //            .HasColumnType("datetime")
    //            .HasColumnName("VESSEL_ETD");
    //        entity.Property(e => e.VesselIdno)
    //            .HasMaxLength(100)
    //            .HasColumnName("VESSEL_IDNO");
    //        entity.Property(e => e.VesselName)
    //            .HasMaxLength(200)
    //            .HasColumnName("VESSEL_NAME");
    //        entity.Property(e => e.VesselOwner)
    //            .HasMaxLength(150)
    //            .HasColumnName("VESSEL_OWNER");
    //        entity.Property(e => e.VesselOwnerCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("VESSEL_OWNER_CODE");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(250)
    //            .HasColumnName("VRNO");

    //        entity.HasOne(d => d.ByrSuppLink).WithMany(p => p.SmQuotationsVendors)
    //            .HasForeignKey(d => d.ByrSuppLinkid)
    //            .HasConstraintName("FK_SM_QUOTATIONS_VENDOR_SM_BUYER_SUPPLIER_LINK");
    //    });

    //    modelBuilder.Entity<SmQuotationsVendorAdditionalDetail>(entity =>
    //    {
    //        entity.HasKey(e => e.QuotationAddId);

    //        entity.ToTable("SM_QUOTATIONS_VENDOR_ADDITIONAL_DETAILS");

    //        entity.Property(e => e.QuotationAddId).HasColumnName("QUOTATION_ADD_ID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.DeliveryTermLocation).HasMaxLength(250);
    //        entity.Property(e => e.DepartmentCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("DEPARTMENT_CODE");
    //        entity.Property(e => e.DepartmentDesc)
    //            .HasMaxLength(500)
    //            .HasColumnName("DEPARTMENT_DESC");
    //        entity.Property(e => e.Jobnumber)
    //            .HasMaxLength(50)
    //            .HasColumnName("JOBNumber");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Sqnumber)
    //            .HasMaxLength(50)
    //            .HasColumnName("SQNumber");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");

    //        entity.HasOne(d => d.Quotation).WithMany(p => p.SmQuotationsVendorAdditionalDetails)
    //            .HasForeignKey(d => d.Quotationid)
    //            .HasConstraintName("FK_SM_QUOTATIONS_VENDOR_ADDITIONAL_DETAILS_SM_QUOTATIONS_VENDOR");
    //    });

    //    modelBuilder.Entity<SmQuotationsVendorAddress>(entity =>
    //    {
    //        entity.HasKey(e => e.Addressid);

    //        entity.ToTable("SM_QUOTATIONS_VENDOR_ADDRESS", tb => tb.HasTrigger("trgCopyAddrNameToContact"));

    //        entity.HasIndex(e => new { e.Quotationid, e.AddrType }, "NonClusteredIndex-20160706-183030");

    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.AddrCity)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDR_CITY");
    //        entity.Property(e => e.AddrCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDR_CODE");
    //        entity.Property(e => e.AddrCountry)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDR_COUNTRY");
    //        entity.Property(e => e.AddrEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("ADDR_EMAIL");
    //        entity.Property(e => e.AddrFax)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDR_FAX");
    //        entity.Property(e => e.AddrMobilephone)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDR_MOBILEPHONE");
    //        entity.Property(e => e.AddrName)
    //            .HasMaxLength(512)
    //            .HasColumnName("ADDR_NAME");
    //        entity.Property(e => e.AddrPhone1)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDR_PHONE1");
    //        entity.Property(e => e.AddrPhone2)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDR_PHONE2");
    //        entity.Property(e => e.AddrRemarks)
    //            .HasMaxLength(2000)
    //            .HasColumnName("ADDR_REMARKS");
    //        entity.Property(e => e.AddrTelex)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDR_TELEX");
    //        entity.Property(e => e.AddrType)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("ADDR_TYPE");
    //        entity.Property(e => e.AddrZipcode)
    //            .HasMaxLength(50)
    //            .HasColumnName("ADDR_ZIPCODE");
    //        entity.Property(e => e.Address1)
    //            .HasMaxLength(512)
    //            .HasColumnName("ADDRESS1");
    //        entity.Property(e => e.Address2)
    //            .HasMaxLength(512)
    //            .HasColumnName("ADDRESS2");
    //        entity.Property(e => e.Address3)
    //            .HasMaxLength(512)
    //            .HasColumnName("ADDRESS3");
    //        entity.Property(e => e.Address4)
    //            .HasMaxLength(512)
    //            .HasColumnName("ADDRESS4");
    //        entity.Property(e => e.ContactPerson)
    //            .HasMaxLength(100)
    //            .HasColumnName("CONTACT_PERSON");
    //        entity.Property(e => e.EmailBcc)
    //            .HasMaxLength(50)
    //            .HasColumnName("EMAIL_BCC");
    //        entity.Property(e => e.EmailCc)
    //            .HasMaxLength(50)
    //            .HasColumnName("EMAIL_CC");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmReqnInvoice>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToTable("SM_REQN_INVOICE");

    //        entity.Property(e => e.AcBicId)
    //            .HasMaxLength(50)
    //            .HasColumnName("AC_BIC_ID");
    //        entity.Property(e => e.AcIbanId)
    //            .HasMaxLength(50)
    //            .HasColumnName("AC_IBAN_ID");
    //        entity.Property(e => e.AccountNum)
    //            .HasMaxLength(50)
    //            .HasColumnName("ACCOUNT_NUM");
    //        entity.Property(e => e.AccountOwner)
    //            .HasMaxLength(50)
    //            .HasColumnName("ACCOUNT_OWNER");
    //        entity.Property(e => e.AddrMtsCode)
    //            .IsUnicode(false)
    //            .HasColumnName("Addr_MTS_CODE");
    //        entity.Property(e => e.Amount).HasColumnName("AMOUNT");
    //        entity.Property(e => e.ApprovedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("APPROVED_DATE");
    //        entity.Property(e => e.Attachment1)
    //            .HasMaxLength(250)
    //            .HasColumnName("ATTACHMENT1");
    //        entity.Property(e => e.Attachment2)
    //            .HasMaxLength(250)
    //            .HasColumnName("ATTACHMENT2");
    //        entity.Property(e => e.BuyerId).HasColumnName("BUYER_ID");
    //        entity.Property(e => e.Buyerid1).HasColumnName("BUYERID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.Currencyid).HasColumnName("CURRENCYID");
    //        entity.Property(e => e.DueDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("DUE_DATE");
    //        entity.Property(e => e.Exported)
    //            .HasColumnType("numeric(18, 0)")
    //            .HasColumnName("EXPORTED");
    //        entity.Property(e => e.FinalInvoice).HasColumnName("FINAL_INVOICE");
    //        entity.Property(e => e.IbanNum)
    //            .HasMaxLength(50)
    //            .HasColumnName("IBAN_NUM");
    //        entity.Property(e => e.InvFilename)
    //            .HasMaxLength(250)
    //            .HasColumnName("INV_FILENAME");
    //        entity.Property(e => e.InvoiceAmount).HasColumnName("INVOICE_AMOUNT");
    //        entity.Property(e => e.InvoiceComment)
    //            .HasMaxLength(200)
    //            .HasColumnName("INVOICE_COMMENT");
    //        entity.Property(e => e.InvoiceDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("INVOICE_DATE");
    //        entity.Property(e => e.InvoiceExchrate).HasColumnName("INVOICE_EXCHRATE");
    //        entity.Property(e => e.InvoiceRecvDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("INVOICE_RECV_DATE");
    //        entity.Property(e => e.InvoiceRemark)
    //            .HasMaxLength(200)
    //            .HasColumnName("INVOICE_REMARK");
    //        entity.Property(e => e.InvoiceStatus).HasColumnName("INVOICE_STATUS");
    //        entity.Property(e => e.InvoiceType).HasColumnName("INVOICE_TYPE");
    //        entity.Property(e => e.Invoiceno)
    //            .HasMaxLength(50)
    //            .HasColumnName("INVOICENO");
    //        entity.Property(e => e.Invoicetype1)
    //            .HasMaxLength(50)
    //            .HasColumnName("INVOICETYPE");
    //        entity.Property(e => e.NetInvoiceAmount).HasColumnName("NET_INVOICE_AMOUNT");
    //        entity.Property(e => e.PaidAmount).HasColumnName("PAID_AMOUNT");
    //        entity.Property(e => e.PaidDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PAID_DATE");
    //        entity.Property(e => e.PaymentRef)
    //            .HasMaxLength(50)
    //            .HasColumnName("PAYMENT_REF");
    //        entity.Property(e => e.PoNo)
    //            .HasMaxLength(20)
    //            .HasColumnName("PO_NO");
    //        entity.Property(e => e.PortalStatus)
    //            .IsUnicode(false)
    //            .HasColumnName("PORTAL_STATUS");
    //        entity.Property(e => e.Reqninvoiceid).HasColumnName("REQNINVOICEID");
    //        entity.Property(e => e.Status)
    //            .HasMaxLength(20)
    //            .HasColumnName("STATUS");
    //        entity.Property(e => e.SubmitDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("SUBMIT_DATE");
    //        entity.Property(e => e.SumLineItem).HasColumnName("Sum_Line_Item");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SwiftNum)
    //            .HasMaxLength(50)
    //            .HasColumnName("SWIFT_NUM");
    //        entity.Property(e => e.TotTax).HasColumnName("TOT_TAX");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.Variance).HasColumnName("VARIANCE");
    //        entity.Property(e => e.VatAmount).HasColumnName("VAT_AMOUNT");
    //        entity.Property(e => e.VatPrcnt).HasColumnName("VAT_PRCNT");
    //        entity.Property(e => e.VendorId).HasColumnName("VENDOR_ID");
    //        entity.Property(e => e.Vesselcode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VESSELCODE");
    //        entity.Property(e => e.Vesselname)
    //            .HasMaxLength(50)
    //            .HasColumnName("VESSELNAME");
    //    });

    //    modelBuilder.Entity<SmReqnInvoiceItem>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToTable("SM_REQN_INVOICE_ITEM");

    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Discount).HasColumnName("DISCOUNT");
    //        entity.Property(e => e.Drawingno)
    //            .HasMaxLength(50)
    //            .HasColumnName("DRAWINGNO");
    //        entity.Property(e => e.Exchrate)
    //            .HasDefaultValueSql("((1))")
    //            .HasColumnName("EXCHRATE");
    //        entity.Property(e => e.Exported).HasColumnName("EXPORTED");
    //        entity.Property(e => e.FinalDelivery).HasColumnName("FINAL_DELIVERY");
    //        entity.Property(e => e.InvoiceItemid).HasColumnName("INVOICE_ITEMID");
    //        entity.Property(e => e.InvoicePrice)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("INVOICE_PRICE");
    //        entity.Property(e => e.InvoiceQty)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("INVOICE_QTY");
    //        entity.Property(e => e.ItemRemarks)
    //            .HasMaxLength(200)
    //            .HasColumnName("ITEM_REMARKS");
    //        entity.Property(e => e.Itemno).HasColumnName("ITEMNO");
    //        entity.Property(e => e.Partname)
    //            .HasMaxLength(50)
    //            .HasColumnName("PARTNAME");
    //        entity.Property(e => e.Partunit)
    //            .HasMaxLength(50)
    //            .HasColumnName("PARTUNIT");
    //        entity.Property(e => e.Posno)
    //            .HasMaxLength(50)
    //            .HasColumnName("POSNO");
    //        entity.Property(e => e.Refno)
    //            .HasMaxLength(50)
    //            .HasColumnName("REFNO");
    //        entity.Property(e => e.Reqninvoiceid).HasColumnName("REQNINVOICEID");
    //        entity.Property(e => e.UnitCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("UNIT_CODE");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmSendMailAudit>(entity =>
    //    {
    //        entity.HasKey(e => e.MailAuditid);

    //        entity.ToTable("SM_SEND_MAIL_AUDIT");

    //        entity.Property(e => e.MailAuditid).HasColumnName("MAIL_AUDITID");
    //        entity.Property(e => e.ByrSuppLinkid).HasColumnName("BYR_SUPP_LINKID");
    //        entity.Property(e => e.EmlFile)
    //            .HasMaxLength(500)
    //            .IsUnicode(false)
    //            .HasColumnName("EML_FILE");
    //        entity.Property(e => e.MailAttachments)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_ATTACHMENTS");
    //        entity.Property(e => e.MailBcc)
    //            .HasMaxLength(1000)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_BCC");
    //        entity.Property(e => e.MailBody)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_BODY");
    //        entity.Property(e => e.MailCc)
    //            .HasMaxLength(1000)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_CC");
    //        entity.Property(e => e.MailDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("MAIL_DATE");
    //        entity.Property(e => e.MailGuid)
    //            .HasMaxLength(80)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_GUID");
    //        entity.Property(e => e.MailReply)
    //            .HasMaxLength(1000)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_REPLY");
    //        entity.Property(e => e.MailSubject)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.MailTo)
    //            .HasMaxLength(1000)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_TO");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.ReceivedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RECEIVED_DATE");
    //        entity.Property(e => e.Remarks)
    //            .IsUnicode(false)
    //            .HasColumnName("REMARKS");
    //    });

    //    modelBuilder.Entity<SmSendMailQueue>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToTable("SM_SEND_MAIL_QUEUE", tb => tb.HasTrigger("trg_aftInsert_SM_SEND_MAIL_QUEUE"));

    //        entity.Property(e => e.ActionType)
    //            .HasMaxLength(50)
    //            .HasColumnName("ACTION_TYPE");
    //        entity.Property(e => e.Attachments).HasColumnName("ATTACHMENTS");
    //        entity.Property(e => e.BuyerId).HasColumnName("BUYER_ID");
    //        entity.Property(e => e.ByrCode)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BYR_CODE");
    //        entity.Property(e => e.DelayMailMin)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("DELAY_MAIL_MIN");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.HtmlNotToSend).HasColumnName("HTML_NOT_TO_SEND");
    //        entity.Property(e => e.MailBcc)
    //            .HasMaxLength(500)
    //            .HasColumnName("MAIL_BCC");
    //        entity.Property(e => e.MailBody).HasColumnName("MAIL_BODY");
    //        entity.Property(e => e.MailCc)
    //            .HasMaxLength(500)
    //            .HasColumnName("MAIL_CC");
    //        entity.Property(e => e.MailDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("MAIL_DATE");
    //        entity.Property(e => e.MailFrom)
    //            .HasMaxLength(100)
    //            .HasColumnName("MAIL_FROM");
    //        entity.Property(e => e.MailSubject).HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.MailTo)
    //            .HasMaxLength(500)
    //            .HasColumnName("MAIL_TO");
    //        entity.Property(e => e.Module)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("MODULE");
    //        entity.Property(e => e.NotToSent).HasColumnName("NOT_TO_SENT");
    //        entity.Property(e => e.QueueId)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUEUE_ID");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteExported).HasColumnName("QUOTE_EXPORTED");
    //        entity.Property(e => e.ReceiverName)
    //            .HasMaxLength(200)
    //            .HasColumnName("RECEIVER_NAME");
    //        entity.Property(e => e.RefKey)
    //            .HasMaxLength(150)
    //            .HasColumnName("REF_KEY");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SendHtmlMsg).HasColumnName("SEND_HTML_MSG");
    //        entity.Property(e => e.SenderName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SENDER_NAME");
    //        entity.Property(e => e.SuppCode)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPP_CODE");
    //        entity.Property(e => e.SuppRef)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPP_REF");
    //        entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
    //        entity.Property(e => e.TimeStamp)
    //            .HasMaxLength(50)
    //            .HasColumnName("TIME_STAMP");
    //        entity.Property(e => e.UseHtmlFileMsg).HasColumnName("USE_HTML_FILE_MSG");
    //    });

    //    modelBuilder.Entity<SmSendMailQueueTemp>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToTable("SM_SEND_MAIL_QUEUE_TEMP");

    //        entity.Property(e => e.ActionType)
    //            .HasMaxLength(50)
    //            .HasColumnName("ACTION_TYPE");
    //        entity.Property(e => e.Attachments).HasColumnName("ATTACHMENTS");
    //        entity.Property(e => e.BuyerId).HasColumnName("BUYER_ID");
    //        entity.Property(e => e.ByrCode)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BYR_CODE");
    //        entity.Property(e => e.DelayMailMin).HasColumnName("DELAY_MAIL_MIN");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.HtmlNotToSend).HasColumnName("HTML_NOT_TO_SEND");
    //        entity.Property(e => e.MailBcc)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_BCC");
    //        entity.Property(e => e.MailBody).HasColumnName("MAIL_BODY");
    //        entity.Property(e => e.MailCc)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_CC");
    //        entity.Property(e => e.MailDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("MAIL_DATE");
    //        entity.Property(e => e.MailFrom)
    //            .HasMaxLength(100)
    //            .HasColumnName("MAIL_FROM");
    //        entity.Property(e => e.MailSubject).HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.MailTo)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_TO");
    //        entity.Property(e => e.Module)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("MODULE");
    //        entity.Property(e => e.NotToSent).HasColumnName("NOT_TO_SENT");
    //        entity.Property(e => e.QueueId).HasColumnName("QUEUE_ID");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteExported).HasColumnName("QUOTE_EXPORTED");
    //        entity.Property(e => e.ReceiverName)
    //            .HasMaxLength(200)
    //            .HasColumnName("RECEIVER_NAME");
    //        entity.Property(e => e.RefKey)
    //            .HasMaxLength(100)
    //            .HasColumnName("REF_KEY");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SendHtmlMsg).HasColumnName("SEND_HTML_MSG");
    //        entity.Property(e => e.SenderName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SENDER_NAME");
    //        entity.Property(e => e.SuppCode)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPP_CODE");
    //        entity.Property(e => e.SuppRef)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPP_REF");
    //        entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
    //        entity.Property(e => e.TimeStamp)
    //            .HasMaxLength(50)
    //            .HasColumnName("TIME_STAMP");
    //        entity.Property(e => e.UseHtmlFileMsg).HasColumnName("USE_HTML_FILE_MSG");
    //    });

    //    modelBuilder.Entity<SmServerSync>(entity =>
    //    {
    //        entity.HasKey(e => e.Serverid);

    //        entity.ToTable("SM_SERVER_SYNC");

    //        entity.Property(e => e.Serverid).HasColumnName("SERVERID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.ServerName)
    //            .HasMaxLength(150)
    //            .HasColumnName("SERVER_NAME");
    //        entity.Property(e => e.ServiceUrl)
    //            .HasMaxLength(200)
    //            .HasColumnName("SERVICE_URL");
    //        entity.Property(e => e.UpdatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATED_DATE");
    //    });

    //    modelBuilder.Entity<SmShipmentDocument>(entity =>
    //    {
    //        entity.HasKey(e => e.ShipmentId);

    //        entity.ToTable("SM_SHIPMENT_DOCUMENTS");

    //        entity.Property(e => e.ShipmentId).HasColumnName("SHIPMENT_ID");
    //        entity.Property(e => e.ActDelDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("ACT_DEL_DATE");
    //        entity.Property(e => e.BillingNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("BILLING_NO");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(10)
    //            .IsUnicode(false)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(25)
    //            .IsUnicode(false)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.Exported).HasColumnName("EXPORTED");
    //        entity.Property(e => e.HdrRemarks)
    //            .IsUnicode(false)
    //            .HasColumnName("HDR_REMARKS");
    //        entity.Property(e => e.Location)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("LOCATION");
    //        entity.Property(e => e.MsgRef)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MSG_REF");
    //        entity.Property(e => e.PoDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PO_DATE");
    //        entity.Property(e => e.PoNo)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("PO_NO");
    //        entity.Property(e => e.PoTotal).HasColumnName("PO_TOTAL");
    //        entity.Property(e => e.PortCode)
    //            .HasMaxLength(30)
    //            .IsUnicode(false)
    //            .HasColumnName("PORT_CODE");
    //        entity.Property(e => e.PortName)
    //            .HasMaxLength(80)
    //            .IsUnicode(false)
    //            .HasColumnName("PORT_NAME");
    //        entity.Property(e => e.QtyShipment).HasColumnName("QTY_SHIPMENT");
    //        entity.Property(e => e.ReceiverCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("RECEIVER_CODE");
    //        entity.Property(e => e.ReceiverName)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("RECEIVER_NAME");
    //        entity.Property(e => e.ReqDelDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("REQ_DEL_DATE");
    //        entity.Property(e => e.SenderCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("SENDER_CODE");
    //        entity.Property(e => e.SenderName)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("SENDER_NAME");
    //        entity.Property(e => e.ShipmentDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("SHIPMENT_DATE");
    //        entity.Property(e => e.ShipmentNo)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SHIPMENT_NO");
    //        entity.Property(e => e.SmTotal).HasColumnName("SM_TOTAL");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.TransportMode)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("TRANSPORT_MODE");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.VesselImono)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("VESSEL_IMONO");
    //        entity.Property(e => e.VesselName)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("VESSEL_NAME");
    //        entity.Property(e => e.WeightUom)
    //            .HasMaxLength(10)
    //            .IsUnicode(false)
    //            .HasColumnName("WEIGHT_UOM");
    //        entity.Property(e => e.WeightValue)
    //            .HasMaxLength(10)
    //            .IsUnicode(false)
    //            .HasColumnName("WEIGHT_VALUE");
    //    });

    //    modelBuilder.Entity<SmShipmentItem>(entity =>
    //    {
    //        entity.HasKey(e => e.ShipmentItemId);

    //        entity.ToTable("SM_SHIPMENT_ITEMS");

    //        entity.Property(e => e.ShipmentItemId).HasColumnName("SHIPMENT_ITEM_ID");
    //        entity.Property(e => e.BuyerOrgref)
    //            .HasMaxLength(40)
    //            .HasColumnName("BuyerORGRef");
    //        entity.Property(e => e.ChangedByVendor).HasColumnName("CHANGED_BY_VENDOR");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Deliverytime).HasColumnName("DELIVERYTIME");
    //        entity.Property(e => e.Discount).HasColumnName("DISCOUNT");
    //        entity.Property(e => e.Drawingno)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("DRAWINGNO");
    //        entity.Property(e => e.ItemRemark)
    //            .HasMaxLength(2048)
    //            .HasColumnName("ITEM_REMARK");
    //        entity.Property(e => e.ItemType)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("ITEM_TYPE");
    //        entity.Property(e => e.Itemno).HasColumnName("ITEMNO");
    //        entity.Property(e => e.Itemstatus).HasColumnName("ITEMSTATUS");
    //        entity.Property(e => e.Originatingsystemref)
    //            .HasMaxLength(50)
    //            .HasColumnName("ORIGINATINGSYSTEMREF");
    //        entity.Property(e => e.Partname)
    //            .HasMaxLength(1000)
    //            .IsUnicode(false)
    //            .HasColumnName("PARTNAME");
    //        entity.Property(e => e.Posno)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("POSNO");
    //        entity.Property(e => e.QtyOrd).HasColumnName("QTY_ORD");
    //        entity.Property(e => e.QtyShipment).HasColumnName("QTY_SHIPMENT");
    //        entity.Property(e => e.QuoteExchrate).HasColumnName("QUOTE_EXCHRATE");
    //        entity.Property(e => e.QuotedPrice).HasColumnName("QUOTED_PRICE");
    //        entity.Property(e => e.Refno)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("REFNO");
    //        entity.Property(e => e.ShipmentId).HasColumnName("SHIPMENT_ID");
    //        entity.Property(e => e.SupplierOrgref)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("SupplierORGRef");
    //        entity.Property(e => e.SysItemno).HasColumnName("SYS_ITEMNO");
    //        entity.Property(e => e.Udf1)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("UDF1");
    //        entity.Property(e => e.Udf2)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("UDF2");
    //        entity.Property(e => e.Udf3)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("UDF3");
    //        entity.Property(e => e.UnitCode)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("UNIT_CODE");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.VendorItemname)
    //            .HasMaxLength(500)
    //            .HasColumnName("VENDOR_ITEMNAME");
    //        entity.Property(e => e.VendorItemno)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_ITEMNO");
    //        entity.Property(e => e.VendorRefno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VENDOR_REFNO");

    //        entity.HasOne(d => d.Shipment).WithMany(p => p.SmShipmentItems)
    //            .HasForeignKey(d => d.ShipmentId)
    //            .HasConstraintName("FK_SM_SHIPMENT_ITEMS_SM_SHIPMENT_DOCUMENTS");
    //    });

    //    modelBuilder.Entity<SmXlsBuyerFixedMapping>(entity =>
    //    {
    //        entity.HasKey(e => e.XlsByrMapid);

    //        entity.ToTable("SM_XLS_BUYER_FIXED_MAPPING");

    //        entity.Property(e => e.XlsByrMapid).HasColumnName("XLS_BYR_MAPID");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ExcelCell)
    //            .HasMaxLength(50)
    //            .HasColumnName("EXCEL_CELL");
    //        entity.Property(e => e.ExcelValue)
    //            .HasMaxLength(100)
    //            .HasColumnName("EXCEL_VALUE");
    //        entity.Property(e => e.Location)
    //            .HasMaxLength(50)
    //            .HasColumnName("LOCATION");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmXlsBuyerLink>(entity =>
    //    {
    //        entity.HasKey(e => e.XlsBuyerMapid);

    //        entity.ToTable("SM_XLS_BUYER_LINK");

    //        entity.Property(e => e.XlsBuyerMapid).HasColumnName("XLS_BUYER_MAPID");
    //        entity.Property(e => e.BuyerSuppLinkid).HasColumnName("BUYER_SUPP_LINKID");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.CompanyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("COMPANY_NAME");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.ExcelMapid).HasColumnName("EXCEL_MAPID");
    //        entity.Property(e => e.FormatMapCode)
    //            .HasMaxLength(150)
    //            .HasColumnName("FORMAT_MAP_CODE");
    //        entity.Property(e => e.MapCell1)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("MAP_CELL1");
    //        entity.Property(e => e.MapCell1Val1)
    //            .HasMaxLength(150)
    //            .HasColumnName("MAP_CELL1_VAL1");
    //        entity.Property(e => e.MapCell1Val2)
    //            .HasMaxLength(150)
    //            .HasColumnName("MAP_CELL1_VAL2");
    //        entity.Property(e => e.MapCell2)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("MAP_CELL2");
    //        entity.Property(e => e.MapCell2Val)
    //            .HasMaxLength(150)
    //            .HasColumnName("MAP_CELL2_VAL");
    //        entity.Property(e => e.MapCellNodisc)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("MAP_CELL_NODISC");
    //        entity.Property(e => e.MapCellNodiscVal)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("MAP_CELL_NODISC_VAL");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.XlsSampleFile)
    //            .HasMaxLength(250)
    //            .HasColumnName("XLS_SAMPLE_FILE");
    //    });

    //    modelBuilder.Entity<SmXlsBuyerMapping>(entity =>
    //    {
    //        entity.HasKey(e => e.Mapid);

    //        entity.ToTable("SM_XLS_BUYER_MAPPING");

    //        entity.Property(e => e.Mapid).HasColumnName("MAPID");
    //        entity.Property(e => e.ActiveSheet).HasColumnName("ACTIVE_SHEET");
    //        entity.Property(e => e.AddToVrno)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("ADD_TO_VRNO");
    //        entity.Property(e => e.ApplyTotalFormula)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("APPLY_TOTAL_FORMULA");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Cell2MapValue)
    //            .HasMaxLength(100)
    //            .HasColumnName("CELL2_MAP_VALUE");
    //        entity.Property(e => e.Cell2Mapping)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL2_MAPPING");
    //        entity.Property(e => e.CellBuyerRemarks)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_BUYER_REMARKS");
    //        entity.Property(e => e.CellContact)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_CONTACT");
    //        entity.Property(e => e.CellCurrCode)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_CURR_CODE");
    //        entity.Property(e => e.CellDelTerms)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_DEL_TERMS");
    //        entity.Property(e => e.CellLateDt)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_LATE_DT");
    //        entity.Property(e => e.CellMapping)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_MAPPING");
    //        entity.Property(e => e.CellPayTerms)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_PAY_TERMS");
    //        entity.Property(e => e.CellPort)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_PORT");
    //        entity.Property(e => e.CellRfqDt)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_RFQ_DT");
    //        entity.Property(e => e.CellSuplrRemarks)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_SUPLR_REMARKS");
    //        entity.Property(e => e.CellSuppRef)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_SUPP_REF");
    //        entity.Property(e => e.CellValidUpto)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_VALID_UPTO");
    //        entity.Property(e => e.CellVessel)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_VESSEL");
    //        entity.Property(e => e.CellVrno)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_VRNO");
    //        entity.Property(e => e.ColItemAltPrice)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_ALT_PRICE");
    //        entity.Property(e => e.ColItemAltQty)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_ALT_QTY");
    //        entity.Property(e => e.ColItemAltUnit)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_ALT_UNIT");
    //        entity.Property(e => e.ColItemBuyerRemarks)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_BUYER_REMARKS");
    //        entity.Property(e => e.ColItemComments)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("COL_ITEM_COMMENTS");
    //        entity.Property(e => e.ColItemCurr)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_CURR");
    //        entity.Property(e => e.ColItemDelDays)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_DEL_DAYS");
    //        entity.Property(e => e.ColItemDiscount)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_DISCOUNT");
    //        entity.Property(e => e.ColItemName)
    //            .HasMaxLength(10)
    //            .HasColumnName("COL_ITEM_NAME");
    //        entity.Property(e => e.ColItemPrice)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_PRICE");
    //        entity.Property(e => e.ColItemQty)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_QTY");
    //        entity.Property(e => e.ColItemRefno)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_REFNO");
    //        entity.Property(e => e.ColItemRemarks)
    //            .HasMaxLength(10)
    //            .HasColumnName("COL_ITEM_REMARKS");
    //        entity.Property(e => e.ColItemTotal)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_TOTAL");
    //        entity.Property(e => e.ColItemUnit)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_UNIT");
    //        entity.Property(e => e.ColItemno)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEMNO");
    //        entity.Property(e => e.ColSection)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_SECTION");
    //        entity.Property(e => e.DynSupRmrkOffset).HasColumnName("DYN_SUP_RMRK_OFFSET");
    //        entity.Property(e => e.ExitForNoitem).HasColumnName("EXIT_FOR_NOITEM");
    //        entity.Property(e => e.ItemDiscPercnt)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("ITEM_DISC_PERCNT");
    //        entity.Property(e => e.ItemNoAsRowno)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("ITEM_NO_AS_ROWNO");
    //        entity.Property(e => e.ItemRowStart).HasColumnName("ITEM_ROW_START");
    //        entity.Property(e => e.MappingVal1)
    //            .HasMaxLength(100)
    //            .HasColumnName("MAPPING_VAL1");
    //        entity.Property(e => e.MappingVal2)
    //            .HasMaxLength(100)
    //            .HasColumnName("MAPPING_VAL2");
    //        entity.Property(e => e.OverrideAltQty).HasColumnName("Override_ALT_QTY");
    //        entity.Property(e => e.ReadItemRemarksUptoNo).HasColumnName("READ_ITEM_REMARKS_UPTO_NO");
    //        entity.Property(e => e.RemoveFromVrno)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("REMOVE_FROM_VRNO");
    //        entity.Property(e => e.SectionRowStart).HasColumnName("SECTION_ROW_START");
    //        entity.Property(e => e.SkipHiddenRows).HasColumnName("SKIP_HIDDEN_ROWS");
    //        entity.Property(e => e.SkipRowsAftItem)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("SKIP_ROWS_AFT_ITEM");
    //        entity.Property(e => e.SkipRowsAftSection).HasColumnName("SKIP_ROWS_AFT_SECTION");
    //        entity.Property(e => e.SkipRowsBefItem).HasColumnName("SKIP_ROWS_BEF_ITEM");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //    });

    //    modelBuilder.Entity<SmXlsGroupMapping>(entity =>
    //    {
    //        entity.HasKey(e => e.ExcelMapid);

    //        entity.ToTable("SM_XLS_GROUP_MAPPING");

    //        entity.Property(e => e.ExcelMapid).HasColumnName("EXCEL_MAPID");
    //        entity.Property(e => e.ActiveSheet).HasColumnName("ACTIVE_SHEET");
    //        entity.Property(e => e.AddToVrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("ADD_TO_VRNO");
    //        entity.Property(e => e.AltItemCount).HasColumnName("ALT_ITEM_COUNT");
    //        entity.Property(e => e.AltItemStartOffset).HasColumnName("ALT_ITEM_START_OFFSET");
    //        entity.Property(e => e.ApplyTotalFormula)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("APPLY_TOTAL_FORMULA");
    //        entity.Property(e => e.CellAttentionRemarks)
    //            .HasMaxLength(10)
    //            .HasColumnName("CELL_ATTENTION_REMARKS");
    //        entity.Property(e => e.CellBillAddr1)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_ADDR1");
    //        entity.Property(e => e.CellBillAddr2)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_ADDR2");
    //        entity.Property(e => e.CellBillCompany)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_COMPANY");
    //        entity.Property(e => e.CellBillContact)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_CONTACT");
    //        entity.Property(e => e.CellBillEmail)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_EMAIL");
    //        entity.Property(e => e.CellBillFax)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_FAX");
    //        entity.Property(e => e.CellBillMob)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_MOB");
    //        entity.Property(e => e.CellBillPhone)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_PHONE");
    //        entity.Property(e => e.CellBuyerRemarks)
    //            .HasMaxLength(15)
    //            .HasColumnName("CELL_BUYER_REMARKS");
    //        entity.Property(e => e.CellByrAddr1)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_ADDR1");
    //        entity.Property(e => e.CellByrAddr2)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_ADDR2");
    //        entity.Property(e => e.CellByrCompany)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_COMPANY");
    //        entity.Property(e => e.CellByrContact)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_CONTACT");
    //        entity.Property(e => e.CellByrEmail)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_EMAIL");
    //        entity.Property(e => e.CellByrFax)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_FAX");
    //        entity.Property(e => e.CellByrMob)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_MOB");
    //        entity.Property(e => e.CellByrPhone)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_PHONE");
    //        entity.Property(e => e.CellByrReplyBefDate)
    //            .HasMaxLength(30)
    //            .HasColumnName("CELL_BYR_REPLY_BEF_DATE");
    //        entity.Property(e => e.CellContact)
    //            .HasMaxLength(30)
    //            .HasColumnName("CELL_CONTACT");
    //        entity.Property(e => e.CellCurrCode)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_CURR_CODE");
    //        entity.Property(e => e.CellDelTerms)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_DEL_TERMS");
    //        entity.Property(e => e.CellDiscProvsn)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_DISC_PROVSN");
    //        entity.Property(e => e.CellDocType)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_DOC_TYPE");
    //        entity.Property(e => e.CellEquipDtls)
    //            .HasMaxLength(30)
    //            .HasColumnName("CELL_EQUIP_DTLS");
    //        entity.Property(e => e.CellEquipMaker)
    //            .HasMaxLength(30)
    //            .HasColumnName("CELL_EQUIP_MAKER");
    //        entity.Property(e => e.CellEquipName)
    //            .HasMaxLength(30)
    //            .HasColumnName("CELL_EQUIP_NAME");
    //        entity.Property(e => e.CellEquipSerno)
    //            .HasMaxLength(30)
    //            .HasColumnName("CELL_EQUIP_SERNO");
    //        entity.Property(e => e.CellEquipType)
    //            .HasMaxLength(30)
    //            .HasColumnName("CELL_EQUIP_TYPE");
    //        entity.Property(e => e.CellEtaDate)
    //            .HasMaxLength(40)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_ETA_DATE");
    //        entity.Property(e => e.CellEtdDate)
    //            .HasMaxLength(40)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_ETD_DATE");
    //        entity.Property(e => e.CellFreightAmt)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_FREIGHT_AMT");
    //        entity.Property(e => e.CellLateDt)
    //            .HasMaxLength(30)
    //            .HasColumnName("CELL_LATE_DT");
    //        entity.Property(e => e.CellLesLinkid)
    //            .HasMaxLength(10)
    //            .HasColumnName("CELL_LES_LINKID");
    //        entity.Property(e => e.CellLesMapid)
    //            .HasMaxLength(10)
    //            .HasColumnName("CELL_LES_MAPID");
    //        entity.Property(e => e.CellLesRecordid)
    //            .HasMaxLength(10)
    //            .HasColumnName("CELL_LES_RECORDID");
    //        entity.Property(e => e.CellMsgno)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_MSGNO");
    //        entity.Property(e => e.CellOrderIdentifier)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_ORDER_IDENTIFIER");
    //        entity.Property(e => e.CellOtherAmt)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_OTHER_AMT");
    //        entity.Property(e => e.CellPayTerms)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_PAY_TERMS");
    //        entity.Property(e => e.CellPort)
    //            .HasMaxLength(150)
    //            .HasColumnName("CELL_PORT");
    //        entity.Property(e => e.CellPortName)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_PORT_NAME");
    //        entity.Property(e => e.CellRfqDept)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_RFQ_DEPT");
    //        entity.Property(e => e.CellRfqDt)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_RFQ_DT");
    //        entity.Property(e => e.CellRfqTitle)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_RFQ_TITLE");
    //        entity.Property(e => e.CellSalesGroup)
    //            .HasMaxLength(30)
    //            .HasColumnName("CELL_SalesGroup");
    //        entity.Property(e => e.CellShipAddr1)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_ADDR1");
    //        entity.Property(e => e.CellShipAddr2)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_ADDR2");
    //        entity.Property(e => e.CellShipCompany)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_COMPANY");
    //        entity.Property(e => e.CellShipContact)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_CONTACT");
    //        entity.Property(e => e.CellShipEmail)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_EMAIL");
    //        entity.Property(e => e.CellShipFax)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_FAX");
    //        entity.Property(e => e.CellShipMob)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_MOB");
    //        entity.Property(e => e.CellShipPhone)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_PHONE");
    //        entity.Property(e => e.CellSupAccount)
    //            .HasMaxLength(10)
    //            .HasColumnName("CELL_SUP_ACCOUNT");
    //        entity.Property(e => e.CellSuplrRemarks)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_SUPLR_REMARKS");
    //        entity.Property(e => e.CellSuppAddr1)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_ADDR1");
    //        entity.Property(e => e.CellSuppAddr2)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_ADDR2");
    //        entity.Property(e => e.CellSuppCompany)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_COMPANY");
    //        entity.Property(e => e.CellSuppContact)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_CONTACT");
    //        entity.Property(e => e.CellSuppEmail)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_EMAIL");
    //        entity.Property(e => e.CellSuppExpDt)
    //            .HasMaxLength(30)
    //            .HasColumnName("CELL_SUPP_EXP_DT");
    //        entity.Property(e => e.CellSuppFax)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_FAX");
    //        entity.Property(e => e.CellSuppLateDt)
    //            .HasMaxLength(30)
    //            .HasColumnName("CELL_SUPP_LATE_DT");
    //        entity.Property(e => e.CellSuppLeadDays)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_LEAD_DAYS");
    //        entity.Property(e => e.CellSuppMob)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_MOB");
    //        entity.Property(e => e.CellSuppPhone)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_PHONE");
    //        entity.Property(e => e.CellSuppQuoteDt)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_QUOTE_DT");
    //        entity.Property(e => e.CellSuppRef)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_SUPP_REF");
    //        entity.Property(e => e.CellUdf1)
    //            .HasMaxLength(30)
    //            .HasColumnName("CELL_UDF1");
    //        entity.Property(e => e.CellUdf2)
    //            .HasMaxLength(30)
    //            .HasColumnName("CELL_UDF2");
    //        entity.Property(e => e.CellUdf3)
    //            .HasMaxLength(30)
    //            .HasColumnName("CELL_UDF3");
    //        entity.Property(e => e.CellValidUpto)
    //            .HasMaxLength(30)
    //            .HasColumnName("CELL_VALID_UPTO");
    //        entity.Property(e => e.CellVessel)
    //            .HasMaxLength(150)
    //            .HasColumnName("CELL_VESSEL");
    //        entity.Property(e => e.CellVrno)
    //            .HasMaxLength(150)
    //            .HasColumnName("CELL_VRNO");
    //        entity.Property(e => e.CellVslImono)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_VSL_IMONO");
    //        entity.Property(e => e.ColItemAltName)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("COL_ITEM_ALT_NAME");
    //        entity.Property(e => e.ColItemAltPrice)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_ALT_PRICE");
    //        entity.Property(e => e.ColItemAltQty)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_ALT_QTY");
    //        entity.Property(e => e.ColItemAltUnit)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_ALT_UNIT");
    //        entity.Property(e => e.ColItemBuyerRemarks)
    //            .HasMaxLength(20)
    //            .HasColumnName("COL_ITEM_BUYER_REMARKS");
    //        entity.Property(e => e.ColItemByrRemark)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("COL_ITEM_BYR_REMARK");
    //        entity.Property(e => e.ColItemComments)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("COL_ITEM_COMMENTS");
    //        entity.Property(e => e.ColItemCurr)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_CURR");
    //        entity.Property(e => e.ColItemDelDays)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_DEL_DAYS");
    //        entity.Property(e => e.ColItemDiscount)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_DISCOUNT");
    //        entity.Property(e => e.ColItemExternalNo)
    //            .HasMaxLength(10)
    //            .HasColumnName("COL_ITEM_EXTERNAL_NO");
    //        entity.Property(e => e.ColItemImpa)
    //            .HasMaxLength(10)
    //            .HasColumnName("COL_ITEM_IMPA");
    //        entity.Property(e => e.ColItemIssa)
    //            .HasMaxLength(10)
    //            .HasColumnName("COL_ITEM_ISSA");
    //        entity.Property(e => e.ColItemName)
    //            .HasMaxLength(20)
    //            .HasColumnName("COL_ITEM_NAME");
    //        entity.Property(e => e.ColItemPacketSize)
    //            .HasMaxLength(10)
    //            .HasColumnName("COL_ITEM_PACKET_SIZE");
    //        entity.Property(e => e.ColItemPrice)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_PRICE");
    //        entity.Property(e => e.ColItemQty)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_QTY");
    //        entity.Property(e => e.ColItemRefno)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_REFNO");
    //        entity.Property(e => e.ColItemRemarks)
    //            .HasMaxLength(20)
    //            .HasColumnName("COL_ITEM_REMARKS");
    //        entity.Property(e => e.ColItemSuppRefno)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("COL_ITEM_SUPP_REFNO");
    //        entity.Property(e => e.ColItemTotal)
    //            .HasMaxLength(5)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("COL_ITEM_TOTAL");
    //        entity.Property(e => e.ColItemUdf1)
    //            .HasMaxLength(10)
    //            .HasColumnName("COL_ITEM_UDF1");
    //        entity.Property(e => e.ColItemUdf2)
    //            .HasMaxLength(10)
    //            .HasColumnName("COL_ITEM_UDF2");
    //        entity.Property(e => e.ColItemUdf3)
    //            .HasMaxLength(10)
    //            .HasColumnName("COL_ITEM_UDF3");
    //        entity.Property(e => e.ColItemUnit)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_UNIT");
    //        entity.Property(e => e.ColItemno)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEMNO");
    //        entity.Property(e => e.ColSection)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_SECTION");
    //        entity.Property(e => e.DecimalSeparator)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("DECIMAL_SEPARATOR");
    //        entity.Property(e => e.DefaultUom)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("DEFAULT_UOM");
    //        entity.Property(e => e.DiscProvsnValue)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("DISC_PROVSN_VALUE");
    //        entity.Property(e => e.DynByrRmrkOffset)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("DYN_BYR_RMRK_OFFSET");
    //        entity.Property(e => e.DynHdrDiscountOffset)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("DYN_HDR_DISCOUNT_OFFSET");
    //        entity.Property(e => e.DynOthercostOffset).HasColumnName("DYN_OTHERCOST_OFFSET");
    //        entity.Property(e => e.DynSupCurrOffset).HasColumnName("DYN_SUP_CURR_OFFSET");
    //        entity.Property(e => e.DynSupFreightOffset).HasColumnName("DYN_SUP_FREIGHT_OFFSET");
    //        entity.Property(e => e.DynSupRmrkOffset).HasColumnName("DYN_SUP_RMRK_OFFSET");
    //        entity.Property(e => e.ExcelNameManager)
    //            .HasMaxLength(500)
    //            .IsUnicode(false)
    //            .HasColumnName("EXCEL_NAME_MANAGER");
    //        entity.Property(e => e.ExitForNoitem).HasColumnName("EXIT_FOR_NOITEM");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ItemDiscPercnt)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("ITEM_DISC_PERCNT");
    //        entity.Property(e => e.ItemNoAsRowno)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("ITEM_NO_AS_ROWNO");
    //        entity.Property(e => e.ItemRowStart).HasColumnName("ITEM_ROW_START");
    //        entity.Property(e => e.MultilineItemDescr).HasColumnName("MULTILINE_ITEM_DESCR");
    //        entity.Property(e => e.OverrideAltQty).HasColumnName("OVERRIDE_ALT_QTY");
    //        entity.Property(e => e.ReadItemRemarksUptoNo).HasColumnName("READ_ITEM_REMARKS_UPTO_NO");
    //        entity.Property(e => e.RemoveFromVesselName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("REMOVE_FROM_VESSEL_NAME");
    //        entity.Property(e => e.RemoveFromVrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("REMOVE_FROM_VRNO");
    //        entity.Property(e => e.SampleFile)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SAMPLE_FILE");
    //        entity.Property(e => e.SectionRowStart).HasColumnName("SECTION_ROW_START");
    //        entity.Property(e => e.SkipHiddenRows).HasColumnName("SKIP_HIDDEN_ROWS");
    //        entity.Property(e => e.SkipRowsAftItem)
    //            .HasDefaultValueSql("((0))")
    //            .HasColumnName("SKIP_ROWS_AFT_ITEM");
    //        entity.Property(e => e.SkipRowsAftSection).HasColumnName("SKIP_ROWS_AFT_SECTION");
    //        entity.Property(e => e.SkipRowsBefItem).HasColumnName("SKIP_ROWS_BEF_ITEM");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.XlsMapCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("XLS_MAP_CODE");
    //    });

    //    modelBuilder.Entity<SmXlsSection>(entity =>
    //    {
    //        entity.HasKey(e => e.Sectionid);

    //        entity.ToTable("SM_XLS_SECTIONS");

    //        entity.Property(e => e.Sectionid).HasColumnName("SECTIONID");
    //        entity.Property(e => e.SectionCode)
    //            .HasMaxLength(10)
    //            .HasColumnName("SECTION_CODE");
    //        entity.Property(e => e.SectionDesc)
    //            .HasMaxLength(100)
    //            .HasColumnName("SECTION_DESC");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmvAuditLog>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_AUDIT_LOG");

    //        entity.Property(e => e.AuditValue).HasMaxLength(2000);
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false);
    //        entity.Property(e => e.BuyerId).HasColumnName("BUYER_ID");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(30)
    //            .IsUnicode(false);
    //        entity.Property(e => e.FileName).HasMaxLength(150);
    //        entity.Property(e => e.Filename2)
    //            .HasMaxLength(150)
    //            .HasColumnName("FILENAME2");
    //        entity.Property(e => e.Filename3)
    //            .HasMaxLength(150)
    //            .HasColumnName("FILENAME3");
    //        entity.Property(e => e.KeyRef1).HasMaxLength(150);
    //        entity.Property(e => e.KeyRef2).HasMaxLength(150);
    //        entity.Property(e => e.LogId)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LogID");
    //        entity.Property(e => e.LogType).HasMaxLength(50);
    //        entity.Property(e => e.ModuleName).HasMaxLength(50);
    //        entity.Property(e => e.ProcessorName)
    //            .HasMaxLength(150)
    //            .HasColumnName("PROCESSOR_NAME");
    //        entity.Property(e => e.ServerName)
    //            .HasMaxLength(50)
    //            .IsUnicode(false);
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false);
    //        entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
    //        entity.Property(e => e.UpdateDate).HasColumnType("datetime");
    //    });

    //    modelBuilder.Entity<SmvBuyerSupplierDefaultRule>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_BUYER_SUPPLIER_DEFAULT_RULES");

    //        entity.Property(e => e.AddrCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("ADDR_CODE");
    //        entity.Property(e => e.AddrName)
    //            .HasMaxLength(200)
    //            .HasColumnName("ADDR_NAME");
    //        entity.Property(e => e.AddrType)
    //            .HasMaxLength(10)
    //            .HasColumnName("ADDR_TYPE");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.DefId).HasColumnName("DEF_ID");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(30)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.GroupFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_FORMAT");
    //        entity.Property(e => e.RuleCode)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("RULE_CODE");
    //        entity.Property(e => e.RuleComments)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("RULE_COMMENTS");
    //        entity.Property(e => e.RuleDesc)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("RULE_DESC");
    //        entity.Property(e => e.RuleId).HasColumnName("RULE_ID");
    //        entity.Property(e => e.RuleNumber)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("RULE_NUMBER");
    //        entity.Property(e => e.RuleValue)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("RULE_VALUE");
    //    });

    //    modelBuilder.Entity<SmvBuyerSupplierDefaultRulesUnique>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_BUYER_SUPPLIER_DEFAULT_RULES_UNIQUE");

    //        entity.Property(e => e.AddrCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("ADDR_CODE");
    //        entity.Property(e => e.AddrName)
    //            .HasMaxLength(200)
    //            .HasColumnName("ADDR_NAME");
    //        entity.Property(e => e.AddrType)
    //            .HasMaxLength(10)
    //            .HasColumnName("ADDR_TYPE");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.GroupFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_FORMAT");
    //        entity.Property(e => e.Row).HasColumnName("ROW");
    //    });

    //    modelBuilder.Entity<SmvBuyerSupplierExcelGroup>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_BUYER_SUPPLIER_EXCEL_GROUPS");

    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("GROUP_ID");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.SupplierFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_FORMAT");
    //    });

    //    modelBuilder.Entity<SmvBuyerSupplierGroupFlow>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_BUYER_SUPPLIER_GROUP_FLOW");

    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.Po).HasColumnName("PO");
    //        entity.Property(e => e.PoEndState).HasColumnName("PO_END_STATE");
    //        entity.Property(e => e.Poc).HasColumnName("POC");
    //        entity.Property(e => e.PocEndState).HasColumnName("POC_END_STATE");
    //        entity.Property(e => e.Quote).HasColumnName("QUOTE");
    //        entity.Property(e => e.QuoteEndState).HasColumnName("QUOTE_END_STATE");
    //        entity.Property(e => e.Rfq).HasColumnName("RFQ");
    //        entity.Property(e => e.RfqEndState).HasColumnName("RFQ_END_STATE");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.SupplierFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_FORMAT");
    //    });

    //    modelBuilder.Entity<SmvBuyerSupplierLink>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_BUYER_SUPPLIER_LINK");

    //        entity.Property(e => e.AsmbExportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_EXPORT_CLASS");
    //        entity.Property(e => e.AsmbImportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_IMPORT_CLASS");
    //        entity.Property(e => e.AssemblyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASSEMBLY_NAME");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerAddrEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_ADDR_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.BuyerMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTML_CODE");
    //        entity.Property(e => e.BuyerMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTS_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("EXPORT_FUNCTION");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("IMPORT_FUNCTION");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupWebServiceUrl)
    //            .HasMaxLength(300)
    //            .IsUnicode(false)
    //            .HasColumnName("SUP_WEB_SERVICE_URL");
    //        entity.Property(e => e.SuppExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_EXPORT_PATH");
    //        entity.Property(e => e.SuppImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_IMPORT_PATH");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierAddrEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_ADDR_EMAIL");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.SupplierMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTML_CODE");
    //        entity.Property(e => e.SupplierMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTS_CODE");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvBuyerSupplierLinkDetail>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_BUYER_SUPPLIER_LINK_DETAILS");

    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(500)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.BuyerPhone)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_PHONE");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExPassword)
    //            .HasMaxLength(50)
    //            .HasColumnName("EX_PASSWORD");
    //        entity.Property(e => e.ExUserid).HasColumnName("EX_USERID");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPo).HasColumnName("EXPORT_PO");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportPoc).HasColumnName("IMPORT_POC");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.LinkType)
    //            .HasMaxLength(50)
    //            .HasColumnName("LINK_TYPE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupWebServiceUrl)
    //            .HasMaxLength(300)
    //            .IsUnicode(false)
    //            .HasColumnName("SUP_WEB_SERVICE_URL");
    //        entity.Property(e => e.SuppExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_EXPORT_PATH");
    //        entity.Property(e => e.SuppImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_IMPORT_PATH");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.SupplierPhone)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_PHONE");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UploadFileType)
    //            .HasMaxLength(50)
    //            .HasColumnName("UPLOAD_FILE_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(500)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvBuyerSupplierLinkInvoice>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_BUYER_SUPPLIER_LINK_INVOICE");

    //        entity.Property(e => e.AsmbExportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_EXPORT_CLASS");
    //        entity.Property(e => e.AsmbImportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_IMPORT_CLASS");
    //        entity.Property(e => e.AssemblyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASSEMBLY_NAME");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyAddrPhone1)
    //            .HasMaxLength(30)
    //            .HasColumnName("BUY_ADDR_PHONE1");
    //        entity.Property(e => e.BuyAddrPhone2)
    //            .HasMaxLength(30)
    //            .HasColumnName("BUY_ADDR_PHONE2");
    //        entity.Property(e => e.BuyerAddrCity)
    //            .HasMaxLength(30)
    //            .HasColumnName("BUYER_ADDR_CITY");
    //        entity.Property(e => e.BuyerAddrCountry)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_ADDR_COUNTRY");
    //        entity.Property(e => e.BuyerAddrEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_ADDR_EMAIL");
    //        entity.Property(e => e.BuyerAddrFax)
    //            .HasMaxLength(30)
    //            .HasColumnName("BUYER_ADDR_FAX");
    //        entity.Property(e => e.BuyerAddrZipcode)
    //            .HasMaxLength(12)
    //            .HasColumnName("BUYER_ADDR_ZIPCODE");
    //        entity.Property(e => e.BuyerAddress1).HasColumnName("BUYER_ADDRESS1");
    //        entity.Property(e => e.BuyerAddress2)
    //            .HasMaxLength(40)
    //            .HasColumnName("BUYER_ADDRESS2");
    //        entity.Property(e => e.BuyerAddress3)
    //            .HasMaxLength(40)
    //            .HasColumnName("BUYER_ADDRESS3");
    //        entity.Property(e => e.BuyerAddress4)
    //            .HasMaxLength(40)
    //            .HasColumnName("BUYER_ADDRESS4");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerContactPerson)
    //            .HasMaxLength(100)
    //            .HasColumnName("BUYER_CONTACT_PERSON");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.BuyerMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTML_CODE");
    //        entity.Property(e => e.BuyerMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTS_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("EXPORT_FUNCTION");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("IMPORT_FUNCTION");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupWebServiceUrl)
    //            .HasMaxLength(300)
    //            .IsUnicode(false)
    //            .HasColumnName("SUP_WEB_SERVICE_URL");
    //        entity.Property(e => e.SuppExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_EXPORT_PATH");
    //        entity.Property(e => e.SuppImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_IMPORT_PATH");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierAddrCity)
    //            .HasMaxLength(30)
    //            .HasColumnName("SUPPLIER_ADDR_CITY");
    //        entity.Property(e => e.SupplierAddrCountry)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_ADDR_COUNTRY");
    //        entity.Property(e => e.SupplierAddrEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_ADDR_EMAIL");
    //        entity.Property(e => e.SupplierAddrFax)
    //            .HasMaxLength(30)
    //            .HasColumnName("SUPPLIER_ADDR_FAX");
    //        entity.Property(e => e.SupplierAddrPhone1)
    //            .HasMaxLength(30)
    //            .HasColumnName("SUPPLIER_ADDR_PHONE1");
    //        entity.Property(e => e.SupplierAddrPhone2)
    //            .HasMaxLength(30)
    //            .HasColumnName("SUPPLIER_ADDR_PHONE2");
    //        entity.Property(e => e.SupplierAddrZipcode)
    //            .HasMaxLength(12)
    //            .HasColumnName("SUPPLIER_ADDR_ZIPCODE");
    //        entity.Property(e => e.SupplierAddress1).HasColumnName("SUPPLIER_ADDRESS1");
    //        entity.Property(e => e.SupplierAddress2)
    //            .HasMaxLength(40)
    //            .HasColumnName("SUPPLIER_ADDRESS2");
    //        entity.Property(e => e.SupplierAddress3)
    //            .HasMaxLength(40)
    //            .HasColumnName("SUPPLIER_ADDRESS3");
    //        entity.Property(e => e.SupplierAddress4)
    //            .HasMaxLength(40)
    //            .HasColumnName("SUPPLIER_ADDRESS4");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierContactPerson)
    //            .HasMaxLength(100)
    //            .HasColumnName("SUPPLIER_CONTACT_PERSON");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.SupplierImportFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_IMPORT_FORMAT");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.SupplierMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTML_CODE");
    //        entity.Property(e => e.SupplierMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTS_CODE");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvBuyerSupplierLinkRule>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_BUYER_SUPPLIER_LINK_RULE");

    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(30)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.InheritRule).HasColumnName("INHERIT_RULE");
    //        entity.Property(e => e.LinkRuleId).HasColumnName("LINK_RULE_ID");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.RuleCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("RULE_CODE");
    //        entity.Property(e => e.RuleComments).HasColumnName("RULE_COMMENTS");
    //        entity.Property(e => e.RuleDesc)
    //            .HasMaxLength(300)
    //            .HasColumnName("RULE_DESC");
    //        entity.Property(e => e.RuleNumber)
    //            .HasMaxLength(50)
    //            .HasColumnName("RULE_NUMBER");
    //        entity.Property(e => e.RuleValue).HasColumnName("RULE_VALUE");
    //        entity.Property(e => e.Ruleid).HasColumnName("RULEID");
    //        entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmvBuyerSupplierLinkRuleVoucher>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_BUYER_SUPPLIER_LINK_RULE_VOUCHER");

    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(30)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.InheritRule).HasColumnName("INHERIT_RULE");
    //        entity.Property(e => e.LinkRuleId).HasColumnName("LINK_RULE_ID");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.RuleCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("RULE_CODE");
    //        entity.Property(e => e.RuleComments).HasColumnName("RULE_COMMENTS");
    //        entity.Property(e => e.RuleDesc)
    //            .HasMaxLength(300)
    //            .HasColumnName("RULE_DESC");
    //        entity.Property(e => e.RuleNumber)
    //            .HasMaxLength(50)
    //            .HasColumnName("RULE_NUMBER");
    //        entity.Property(e => e.RuleValue).HasColumnName("RULE_VALUE");
    //        entity.Property(e => e.Ruleid).HasColumnName("RULEID");
    //        entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmvBuyerSupplierPdfGroup>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_BUYER_SUPPLIER_PDF_GROUPS");

    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("GROUP_ID");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.SupplierFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_FORMAT");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmvBuyerSupplierVoucherGroup>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_BUYER_SUPPLIER_VOUCHER_GROUPS");

    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.SupplierFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_FORMAT");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmvByrSuppQuote>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_BYR_SUPP_QUOTE");

    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvCompanyGroup>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_COMPANY_GROUPS");

    //        entity.Property(e => e.AddrCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("ADDR_CODE");
    //        entity.Property(e => e.AddrName)
    //            .HasMaxLength(200)
    //            .HasColumnName("ADDR_NAME");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.CompanyGroupCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("COMPANY_GROUP_CODE");
    //        entity.Property(e => e.CompanyGroupId).HasColumnName("COMPANY_GROUP_ID");
    //        entity.Property(e => e.CompanyGroupType)
    //            .HasMaxLength(50)
    //            .HasColumnName("COMPANY_GROUP_TYPE");
    //    });

    //    modelBuilder.Entity<SmvDistinctBuyerSupplierDefaultRule>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_DISTINCT_BUYER_SUPPLIER_DEFAULT_RULES");

    //        entity.Property(e => e.AddrCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("ADDR_CODE");
    //        entity.Property(e => e.AddrName)
    //            .HasMaxLength(200)
    //            .HasColumnName("ADDR_NAME");
    //        entity.Property(e => e.AddrType)
    //            .HasMaxLength(10)
    //            .HasColumnName("ADDR_TYPE");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.GroupFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_FORMAT");
    //    });

    //    modelBuilder.Entity<SmvDocumentformatRule>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_DOCUMENTFORMAT_RULES");

    //        entity.Property(e => e.AddrType)
    //            .HasMaxLength(10)
    //            .HasColumnName("ADDR_TYPE");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(30)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Docformatid).HasColumnName("DOCFORMATID");
    //        entity.Property(e => e.DocumentFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOCUMENT_FORMAT");
    //        entity.Property(e => e.DocumentformatRuleid).HasColumnName("DOCUMENTFORMAT_RULEID");
    //        entity.Property(e => e.RuleCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("RULE_CODE");
    //        entity.Property(e => e.RuleComments)
    //            .HasMaxLength(200)
    //            .HasColumnName("RULE_COMMENTS");
    //        entity.Property(e => e.RuleDesc)
    //            .HasMaxLength(150)
    //            .HasColumnName("RULE_DESC");
    //        entity.Property(e => e.RuleId).HasColumnName("RULE_ID");
    //        entity.Property(e => e.RuleNumber)
    //            .HasMaxLength(50)
    //            .HasColumnName("RULE_NUMBER");
    //        entity.Property(e => e.RuleValue)
    //            .HasMaxLength(50)
    //            .HasColumnName("RULE_VALUE");
    //        entity.Property(e => e.Ruleid1).HasColumnName("RULEID");
    //    });

    //    modelBuilder.Entity<SmvEpbPushdataFinalQuote>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EPB_PUSHDATA_FINAL_QUOTE");

    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(256)
    //            .IsUnicode(false)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvEpbPushdataPo>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EPB_PUSHDATA_PO");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //    });

    //    modelBuilder.Entity<SmvEpbPushdataRfq>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EPB_PUSHDATA_RFQ");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //    });

    //    modelBuilder.Entity<SmvErrorLog>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_ERROR_LOG");

    //        entity.Property(e => e.Auditvalue)
    //            .HasMaxLength(500)
    //            .HasColumnName("AUDITVALUE");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerCode1)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("BuyerCode");
    //        entity.Property(e => e.BuyerId).HasColumnName("BUYER_ID");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(30)
    //            .IsUnicode(false);
    //        entity.Property(e => e.ErrorLogid).HasColumnName("ERROR_LOGID");
    //        entity.Property(e => e.ErrorProblem)
    //            .HasMaxLength(1000)
    //            .HasColumnName("ERROR_PROBLEM");
    //        entity.Property(e => e.ErrorSolution)
    //            .HasMaxLength(2000)
    //            .HasColumnName("ERROR_SOLUTION");
    //        entity.Property(e => e.ErrorStatus).HasColumnName("ERROR_STATUS");
    //        entity.Property(e => e.Filename)
    //            .HasMaxLength(150)
    //            .HasColumnName("FILENAME");
    //        entity.Property(e => e.KeyRef1).HasMaxLength(150);
    //        entity.Property(e => e.Keyref2)
    //            .HasMaxLength(150)
    //            .HasColumnName("KEYREF2");
    //        entity.Property(e => e.Logid).HasColumnName("LOGID");
    //        entity.Property(e => e.Modulename)
    //            .HasMaxLength(50)
    //            .HasColumnName("MODULENAME");
    //        entity.Property(e => e.PriorityFlag).HasColumnName("PRIORITY_FLAG");
    //        entity.Property(e => e.ProcessorName)
    //            .HasMaxLength(150)
    //            .HasColumnName("PROCESSOR_NAME");
    //        entity.Property(e => e.ServerName)
    //            .HasMaxLength(50)
    //            .IsUnicode(false);
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false);
    //        entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
    //        entity.Property(e => e.Updatedate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATEDATE");
    //        entity.Property(e => e.VendorCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("VENDOR_CODE");
    //    });

    //    modelBuilder.Entity<SmvEsupplierRulesVoucher>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_ESUPPLIER_RULES_VOUCHER");

    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(30)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.RuleCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("RULE_CODE");
    //        entity.Property(e => e.RuleComments).HasColumnName("RULE_COMMENTS");
    //        entity.Property(e => e.RuleDesc)
    //            .HasMaxLength(300)
    //            .HasColumnName("RULE_DESC");
    //        entity.Property(e => e.RuleNumber)
    //            .HasMaxLength(50)
    //            .HasColumnName("RULE_NUMBER");
    //        entity.Property(e => e.Ruleid).HasColumnName("RULEID");
    //        entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmvExcelRfqMappingDetail>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXCEL_RFQ_MAPPING_DETAILS");

    //        entity.Property(e => e.ActiveSheet).HasColumnName("ACTIVE_SHEET");
    //        entity.Property(e => e.AddToVrno)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("ADD_TO_VRNO");
    //        entity.Property(e => e.ApplyTotalFormula).HasColumnName("APPLY_TOTAL_FORMULA");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerEmailid)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_EMAILID");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Cell2MapValue)
    //            .HasMaxLength(100)
    //            .HasColumnName("CELL2_MAP_VALUE");
    //        entity.Property(e => e.Cell2Mapping)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL2_MAPPING");
    //        entity.Property(e => e.CellBuyerRemarks)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_BUYER_REMARKS");
    //        entity.Property(e => e.CellContact)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_CONTACT");
    //        entity.Property(e => e.CellCurrCode)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_CURR_CODE");
    //        entity.Property(e => e.CellDelTerms)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_DEL_TERMS");
    //        entity.Property(e => e.CellLateDt)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_LATE_DT");
    //        entity.Property(e => e.CellMapping)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_MAPPING");
    //        entity.Property(e => e.CellPayTerms)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_PAY_TERMS");
    //        entity.Property(e => e.CellPort)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_PORT");
    //        entity.Property(e => e.CellRfqDt)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_RFQ_DT");
    //        entity.Property(e => e.CellSuplrRemarks)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_SUPLR_REMARKS");
    //        entity.Property(e => e.CellSuppRef)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_SUPP_REF");
    //        entity.Property(e => e.CellValidUpto)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_VALID_UPTO");
    //        entity.Property(e => e.CellVessel)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_VESSEL");
    //        entity.Property(e => e.CellVrno)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_VRNO");
    //        entity.Property(e => e.ColItemAltPrice)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_ALT_PRICE");
    //        entity.Property(e => e.ColItemAltQty)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_ALT_QTY");
    //        entity.Property(e => e.ColItemAltUnit)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_ALT_UNIT");
    //        entity.Property(e => e.ColItemBuyerRemarks)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_BUYER_REMARKS");
    //        entity.Property(e => e.ColItemComments)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("COL_ITEM_COMMENTS");
    //        entity.Property(e => e.ColItemCurr)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_CURR");
    //        entity.Property(e => e.ColItemDelDays)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_DEL_DAYS");
    //        entity.Property(e => e.ColItemDiscount)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_DISCOUNT");
    //        entity.Property(e => e.ColItemName)
    //            .HasMaxLength(10)
    //            .HasColumnName("COL_ITEM_NAME");
    //        entity.Property(e => e.ColItemPrice)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_PRICE");
    //        entity.Property(e => e.ColItemQty)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_QTY");
    //        entity.Property(e => e.ColItemRefno)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_REFNO");
    //        entity.Property(e => e.ColItemRemarks)
    //            .HasMaxLength(10)
    //            .HasColumnName("COL_ITEM_REMARKS");
    //        entity.Property(e => e.ColItemTotal)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_TOTAL");
    //        entity.Property(e => e.ColItemUnit)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_UNIT");
    //        entity.Property(e => e.ColItemno)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEMNO");
    //        entity.Property(e => e.ColSection)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_SECTION");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(3)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.DynSupRmrkOffset).HasColumnName("DYN_SUP_RMRK_OFFSET");
    //        entity.Property(e => e.ExitForNoitem).HasColumnName("EXIT_FOR_NOITEM");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ItemDiscPercnt).HasColumnName("ITEM_DISC_PERCNT");
    //        entity.Property(e => e.ItemNoAsRowno).HasColumnName("ITEM_NO_AS_ROWNO");
    //        entity.Property(e => e.ItemRowStart).HasColumnName("ITEM_ROW_START");
    //        entity.Property(e => e.Mapid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("MAPID");
    //        entity.Property(e => e.MappingVal1)
    //            .HasMaxLength(100)
    //            .HasColumnName("MAPPING_VAL1");
    //        entity.Property(e => e.MappingVal2)
    //            .HasMaxLength(100)
    //            .HasColumnName("MAPPING_VAL2");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.OverrideAltQty).HasColumnName("Override_ALT_QTY");
    //        entity.Property(e => e.ReadItemRemarksUptoNo).HasColumnName("READ_ITEM_REMARKS_UPTO_NO");
    //        entity.Property(e => e.RemoveFromVrno)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("REMOVE_FROM_VRNO");
    //        entity.Property(e => e.SectionRowStart).HasColumnName("SECTION_ROW_START");
    //        entity.Property(e => e.SkipHiddenRows).HasColumnName("SKIP_HIDDEN_ROWS");
    //        entity.Property(e => e.SkipRowsAftItem).HasColumnName("SKIP_ROWS_AFT_ITEM");
    //        entity.Property(e => e.SkipRowsAftSection).HasColumnName("SKIP_ROWS_AFT_SECTION");
    //        entity.Property(e => e.SkipRowsBefItem).HasColumnName("SKIP_ROWS_BEF_ITEM");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.SupplrEmailid)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLR_EMAILID");
    //        entity.Property(e => e.SupplrName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLR_NAME");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvExportAceShipQuote>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_ACE_SHIP_QUOTE");

    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.Controlreference)
    //            .HasMaxLength(128)
    //            .IsUnicode(false)
    //            .HasColumnName("CONTROLREFERENCE");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.IsDeclined).HasColumnName("IS_DECLINED");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Mtmldocid).HasColumnName("MTMLDOCID");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.VendorStatus).HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportAmos2ExcelPo>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_AMOS2_EXCEL_PO");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //    });

    //    modelBuilder.Entity<SmvExportAmos2ExcelRfq>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_AMOS2_EXCEL_RFQ");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //    });

    //    modelBuilder.Entity<SmvExportAmos2MtmlPoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_AMOS2_MTML_POC");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportAmos2MtmlPocLe>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_AMOS2_MTML_POC_LES");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.SysDocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("sysDOC_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportAmos2MtmlQuote>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_AMOS2_MTML_QUOTE");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(256)
    //            .IsUnicode(false)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.SysDocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("sysDOC_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportAmos2MtmlQuoteLe>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_AMOS2_MTML_QUOTE_LES");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(256)
    //            .IsUnicode(false)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.SysDocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("sysDOC_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportAmos2MtmlRfq>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_AMOS2_MTML_RFQ");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //        entity.Property(e => e.SysDocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("sysDOC_TYPE");
    //    });

    //    modelBuilder.Entity<SmvExportEdiMtmlPo>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_EDI_MTML_PO");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //    });

    //    modelBuilder.Entity<SmvExportEdiMtmlRfq>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_EDI_MTML_RFQ");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //    });

    //    modelBuilder.Entity<SmvExportEdiQuotePoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_EDI_QUOTE_POC");

    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.IsDeclined).HasColumnName("IS_DECLINED");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(250)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(150)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Mtmldocid).HasColumnName("MTMLDOCID");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.VendorStatus).HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportEmsMtmlPo>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_EMS_MTML_PO");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //    });

    //    modelBuilder.Entity<SmvExportEmsMtmlRfq>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_EMS_MTML_RFQ");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //    });

    //    modelBuilder.Entity<SmvExportEsupplierInternalQuotePoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_ESUPPLIER_INTERNAL_QUOTE_POC");

    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.IsDeclined).HasColumnName("IS_DECLINED");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(250)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(150)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Mtmldocid).HasColumnName("MTMLDOCID");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.VendorStatus).HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportEsupplierInternalRfqPo>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_ESUPPLIER_INTERNAL_RFQ_PO");

    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.IsDeclined).HasColumnName("IS_DECLINED");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.VendorStatus).HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(250)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportEsupplierLiteRfqPo>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_ESUPPLIER_LITE_RFQ_PO");

    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.IsDeclined).HasColumnName("IS_DECLINED");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.VendorStatus).HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportExcelDocumentPo>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_EXCEL_DOCUMENT_PO");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //    });

    //    modelBuilder.Entity<SmvExportExcelDocumentPoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_EXCEL_DOCUMENT_POC");

    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.SysDocType)
    //            .HasMaxLength(13)
    //            .IsUnicode(false)
    //            .HasColumnName("sysDOC_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportExcelDocumentQuote>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_EXCEL_DOCUMENT_QUOTE");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(256)
    //            .IsUnicode(false)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportExcelDocumentRfq>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_EXCEL_DOCUMENT_RFQ");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //    });

    //    modelBuilder.Entity<SmvExportExcelQuote>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_EXCEL_QUOTE");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(256)
    //            .IsUnicode(false)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportExcelQuoteLe>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_EXCEL_QUOTE_LES");

    //        entity.Property(e => e.AsmbExportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_EXPORT_CLASS");
    //        entity.Property(e => e.AsmbImportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_IMPORT_CLASS");
    //        entity.Property(e => e.AssemblyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASSEMBLY_NAME");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrSuppLinkid).HasColumnName("BYR_SUPP_LINKID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(256)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.ExportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("EXPORT_FUNCTION");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("IMPORT_FUNCTION");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(250)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(150)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(250)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportGoodwoodPoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_GOODWOOD_POC");

    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Deliverytime)
    //            .HasColumnType("datetime")
    //            .HasColumnName("DELIVERYTIME");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.PocReference)
    //            .HasMaxLength(30)
    //            .IsUnicode(false)
    //            .HasColumnName("POC_REFERENCE");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteRemarks)
    //            .IsUnicode(false)
    //            .HasColumnName("QUOTE_REMARKS");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportGoodwoodQuote>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_GOODWOOD_QUOTE");

    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //        entity.Property(e => e.XlsFile)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("XLS_FILE");
    //    });

    //    modelBuilder.Entity<SmvExportHtmlQuote>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_HTML_QUOTE");

    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.IsDeclined).HasColumnName("IS_DECLINED");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(250)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(150)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Mtmldocid).HasColumnName("MTMLDOCID");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.SuppCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPP_CODE");
    //        entity.Property(e => e.VendorStatus).HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportMarineLinkPo>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_MARINE_LINK_PO");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //    });

    //    modelBuilder.Entity<SmvExportMarineLinkRfq>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_MARINE_LINK_RFQ");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //    });

    //    modelBuilder.Entity<SmvExportMespasQuote>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_MESPAS_QUOTE");

    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.IsDeclined).HasColumnName("IS_DECLINED");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(250)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(150)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Mtmldocid).HasColumnName("MTMLDOCID");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.VendorStatus).HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportMtmlV2Po>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_MTML_V2_PO");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //    });

    //    modelBuilder.Entity<SmvExportMtmlV2QuotePoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_MTML_V2_QUOTE_POC");

    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.IsDeclined).HasColumnName("IS_DECLINED");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(250)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(150)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Mtmldocid).HasColumnName("MTMLDOCID");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.VendorStatus).HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportMtmlV2Rfq>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_MTML_V2_RFQ");

    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //    });

    //    modelBuilder.Entity<SmvExportPoAckDoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_PO_ACK_DOC");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportPoAckMarineLink>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_PO_ACK_MARINE_LINK");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.SysDocType)
    //            .HasMaxLength(16)
    //            .IsUnicode(false)
    //            .HasColumnName("sysDOC_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportPocDoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_POC_DOC");

    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportPocMarineLink>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_POC_MARINE_LINK");

    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.SysDocType)
    //            .HasMaxLength(13)
    //            .IsUnicode(false)
    //            .HasColumnName("sysDOC_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportQuoteDoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_QUOTE_DOC");

    //        entity.Property(e => e.AsmbExportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_EXPORT_CLASS");
    //        entity.Property(e => e.AsmbImportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_IMPORT_CLASS");
    //        entity.Property(e => e.AssemblyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASSEMBLY_NAME");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrSuppLinkid).HasColumnName("BYR_SUPP_LINKID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(256)
    //            .IsUnicode(false)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.ExportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("EXPORT_FUNCTION");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("IMPORT_FUNCTION");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportQuoteMarineLink>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_QUOTE_MARINE_LINK");

    //        entity.Property(e => e.AsmbExportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_EXPORT_CLASS");
    //        entity.Property(e => e.AsmbImportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_IMPORT_CLASS");
    //        entity.Property(e => e.AssemblyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASSEMBLY_NAME");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrSuppLinkid).HasColumnName("BYR_SUPP_LINKID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(256)
    //            .IsUnicode(false)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.ExportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("EXPORT_FUNCTION");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("IMPORT_FUNCTION");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.SysDocType)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("sysDOC_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportRealMarinePoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_REAL_MARINE_POC");

    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.SysDocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("sysDOC_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportRealMarineQuote>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_REAL_MARINE_QUOTE");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(256)
    //            .IsUnicode(false)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportRealMarineQuoteLe>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_REAL_MARINE_QUOTE_LES");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(256)
    //            .IsUnicode(false)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.SysDocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("sysDOC_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportRfqAckDoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_RFQ_ACK_DOC");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.RfqAckDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_ACK_DATE");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportRfqAckMarineLink>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_RFQ_ACK_MARINE_LINK");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.RfqAckDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_ACK_DATE");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.SysDocType)
    //            .HasMaxLength(18)
    //            .IsUnicode(false)
    //            .HasColumnName("sysDOC_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportRickmersQuote>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_RICKMERS_QUOTE");

    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportRmsExcelDocumentPo>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_RMS_EXCEL_DOCUMENT_PO");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //    });

    //    modelBuilder.Entity<SmvExportRmsExcelDocumentRfq>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_RMS_EXCEL_DOCUMENT_RFQ");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //    });

    //    modelBuilder.Entity<SmvExportSeaProcQuotePoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_SEA_PROC_QUOTE_POC");

    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.IsDeclined).HasColumnName("IS_DECLINED");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(250)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(150)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Mtmldocid).HasColumnName("MTMLDOCID");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.VendorStatus).HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportShipSmartQuote>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_SHIP_SMART_QUOTE");

    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportShipmentDoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_SHIPMENT_DOCS");

    //        entity.Property(e => e.ActDelDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("ACT_DEL_DATE");
    //        entity.Property(e => e.BillingNo)
    //            .HasMaxLength(50)
    //            .HasColumnName("BILLING_NO");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(10)
    //            .IsUnicode(false)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(25)
    //            .IsUnicode(false)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.Exported).HasColumnName("EXPORTED");
    //        entity.Property(e => e.HdrRemarks)
    //            .IsUnicode(false)
    //            .HasColumnName("HDR_REMARKS");
    //        entity.Property(e => e.Location)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("LOCATION");
    //        entity.Property(e => e.MsgRef)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MSG_REF");
    //        entity.Property(e => e.PoDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PO_DATE");
    //        entity.Property(e => e.PoNo)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("PO_NO");
    //        entity.Property(e => e.PoTotal).HasColumnName("PO_TOTAL");
    //        entity.Property(e => e.PortCode)
    //            .HasMaxLength(30)
    //            .IsUnicode(false)
    //            .HasColumnName("PORT_CODE");
    //        entity.Property(e => e.PortName)
    //            .HasMaxLength(80)
    //            .IsUnicode(false)
    //            .HasColumnName("PORT_NAME");
    //        entity.Property(e => e.QtyShipment).HasColumnName("QTY_SHIPMENT");
    //        entity.Property(e => e.ReceiverCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("RECEIVER_CODE");
    //        entity.Property(e => e.ReceiverName)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("RECEIVER_NAME");
    //        entity.Property(e => e.ReqDelDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("REQ_DEL_DATE");
    //        entity.Property(e => e.SenderCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("SENDER_CODE");
    //        entity.Property(e => e.SenderName)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("SENDER_NAME");
    //        entity.Property(e => e.ShipmentDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("SHIPMENT_DATE");
    //        entity.Property(e => e.ShipmentId)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("SHIPMENT_ID");
    //        entity.Property(e => e.ShipmentNo)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SHIPMENT_NO");
    //        entity.Property(e => e.SmTotal).HasColumnName("SM_TOTAL");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.TransportMode)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("TRANSPORT_MODE");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.VesselImono)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("VESSEL_IMONO");
    //        entity.Property(e => e.VesselName)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("VESSEL_NAME");
    //        entity.Property(e => e.WeightUom)
    //            .HasMaxLength(10)
    //            .IsUnicode(false)
    //            .HasColumnName("WEIGHT_UOM");
    //        entity.Property(e => e.WeightValue)
    //            .HasMaxLength(10)
    //            .IsUnicode(false)
    //            .HasColumnName("WEIGHT_VALUE");
    //    });

    //    modelBuilder.Entity<SmvExportShipnetQuote>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_SHIPNET_QUOTE");

    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.IsDeclined).HasColumnName("IS_DECLINED");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Mtmldocid).HasColumnName("MTMLDOCID");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.VendorStatus).HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportShipservQuotePoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_SHIPSERV_QUOTE_POC");

    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.IsDeclined).HasColumnName("IS_DECLINED");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(250)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(150)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Mtmldocid).HasColumnName("MTMLDOCID");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.VendorStatus).HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(250)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportShipservQuotePocThomeUat>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_SHIPSERV_QUOTE_POC_THOME_UAT");

    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.IsDeclined).HasColumnName("IS_DECLINED");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(250)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(150)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Mtmldocid).HasColumnName("MTMLDOCID");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.VendorStatus).HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(250)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportSinwaRfq>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_SINWA_RFQ");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //    });

    //    modelBuilder.Entity<SmvExportStamcoExcelQuote>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_STAMCO_EXCEL_QUOTE");

    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(256)
    //            .IsUnicode(false)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportVshipsQuote>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORT_VSHIPS_QUOTE");

    //        entity.Property(e => e.AsmbExportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_EXPORT_CLASS");
    //        entity.Property(e => e.AsmbImportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_IMPORT_CLASS");
    //        entity.Property(e => e.AssemblyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASSEMBLY_NAME");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrSuppLinkid).HasColumnName("BYR_SUPP_LINKID");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(256)
    //            .IsUnicode(false)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.ExportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("EXPORT_FUNCTION");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("IMPORT_FUNCTION");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.SysDocType)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("sysDOC_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvExportedQuoteAmountVendor>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_EXPORTED_QUOTE_AMOUNT_VENDOR");

    //        entity.Property(e => e.GrossItemTotal).HasColumnName("GROSS_ITEM_TOTAL");
    //        entity.Property(e => e.NetItemTotal).HasColumnName("NET_ITEM_TOTAL");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //    });

    //    modelBuilder.Entity<SmvFileAudit>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_FILE_AUDIT");

    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.Po).HasColumnName("PO");
    //        entity.Property(e => e.PoDownload)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PO_DOWNLOAD");
    //        entity.Property(e => e.PoEndState).HasColumnName("PO_END_STATE");
    //        entity.Property(e => e.PoExp)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PO_EXP");
    //        entity.Property(e => e.PoImp)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PO_IMP");
    //        entity.Property(e => e.PoMailSent)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PO_MAIL_SENT");
    //        entity.Property(e => e.PoUpload)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PO_UPLOAD");
    //        entity.Property(e => e.Poc).HasColumnName("POC");
    //        entity.Property(e => e.PocDownload)
    //            .HasColumnType("datetime")
    //            .HasColumnName("POC_DOWNLOAD");
    //        entity.Property(e => e.PocEndState).HasColumnName("POC_END_STATE");
    //        entity.Property(e => e.PocExp)
    //            .HasColumnType("datetime")
    //            .HasColumnName("POC_EXP");
    //        entity.Property(e => e.PocImp)
    //            .HasColumnType("datetime")
    //            .HasColumnName("POC_IMP");
    //        entity.Property(e => e.PocMailSent)
    //            .HasColumnType("datetime")
    //            .HasColumnName("POC_MAIL_SENT");
    //        entity.Property(e => e.PocUpload)
    //            .HasColumnType("datetime")
    //            .HasColumnName("POC_UPLOAD");
    //        entity.Property(e => e.Quote).HasColumnName("QUOTE");
    //        entity.Property(e => e.QuoteDownload)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_DOWNLOAD");
    //        entity.Property(e => e.QuoteEndState).HasColumnName("QUOTE_END_STATE");
    //        entity.Property(e => e.QuoteExp)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_EXP");
    //        entity.Property(e => e.QuoteImp)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_IMP");
    //        entity.Property(e => e.QuoteMailSent)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_MAIL_SENT");
    //        entity.Property(e => e.QuoteUpload)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_UPLOAD");
    //        entity.Property(e => e.Recordid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("RECORDID");
    //        entity.Property(e => e.Rfq).HasColumnName("RFQ");
    //        entity.Property(e => e.RfqDownload)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_DOWNLOAD");
    //        entity.Property(e => e.RfqEndState).HasColumnName("RFQ_END_STATE");
    //        entity.Property(e => e.RfqExp)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_EXP");
    //        entity.Property(e => e.RfqImp)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_IMP");
    //        entity.Property(e => e.RfqMailSent)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_MAIL_SENT");
    //        entity.Property(e => e.RfqUpload)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_UPLOAD");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.Version).HasColumnName("VERSION");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvFileAuditNew>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_FILE_AUDIT_NEW");

    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.Po).HasColumnName("PO");
    //        entity.Property(e => e.PoDownload)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("PO_DOWNLOAD");
    //        entity.Property(e => e.PoEndState).HasColumnName("PO_END_STATE");
    //        entity.Property(e => e.PoExp)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("PO_EXP");
    //        entity.Property(e => e.PoImp)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("PO_IMP");
    //        entity.Property(e => e.PoMailSent)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("PO_MAIL_SENT");
    //        entity.Property(e => e.PoUpload)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("PO_UPLOAD");
    //        entity.Property(e => e.Poc).HasColumnName("POC");
    //        entity.Property(e => e.PocDownload)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("POC_DOWNLOAD");
    //        entity.Property(e => e.PocEndState).HasColumnName("POC_END_STATE");
    //        entity.Property(e => e.PocExp)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("POC_EXP");
    //        entity.Property(e => e.PocImp)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("POC_IMP");
    //        entity.Property(e => e.PocMailSent)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("POC_MAIL_SENT");
    //        entity.Property(e => e.PocUpload)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("POC_UPLOAD");
    //        entity.Property(e => e.Quote).HasColumnName("QUOTE");
    //        entity.Property(e => e.QuoteDownload)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("QUOTE_DOWNLOAD");
    //        entity.Property(e => e.QuoteEndState).HasColumnName("QUOTE_END_STATE");
    //        entity.Property(e => e.QuoteExp)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("QUOTE_EXP");
    //        entity.Property(e => e.QuoteImp)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("QUOTE_IMP");
    //        entity.Property(e => e.QuoteMailSent)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("QUOTE_MAIL_SENT");
    //        entity.Property(e => e.QuoteUpload)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("QUOTE_UPLOAD");
    //        entity.Property(e => e.Recordid).HasColumnName("RECORDID");
    //        entity.Property(e => e.Rfq).HasColumnName("RFQ");
    //        entity.Property(e => e.RfqDownload)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("RFQ_DOWNLOAD");
    //        entity.Property(e => e.RfqEndState).HasColumnName("RFQ_END_STATE");
    //        entity.Property(e => e.RfqExp)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("RFQ_EXP");
    //        entity.Property(e => e.RfqImp)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("RFQ_IMP");
    //        entity.Property(e => e.RfqMailSent)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("RFQ_MAIL_SENT");
    //        entity.Property(e => e.RfqUpload)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("RFQ_UPLOAD");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.Version).HasColumnName("VERSION");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvGetLeSconnectClient>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_Get_LeSConnect_Clients");

    //        entity.Property(e => e.AddrCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("ADDR_CODE");
    //        entity.Property(e => e.AddrName)
    //            .HasMaxLength(200)
    //            .HasColumnName("ADDR_NAME");
    //        entity.Property(e => e.Clientid).HasColumnName("CLIENTID");
    //        entity.Property(e => e.LastConnect)
    //            .HasColumnType("datetime")
    //            .HasColumnName("LAST_CONNECT");
    //    });

    //    modelBuilder.Entity<SmvGetSendMailQueue>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_GET_SEND_MAIL_QUEUE");

    //        entity.Property(e => e.ActionType)
    //            .HasMaxLength(50)
    //            .HasColumnName("ACTION_TYPE");
    //        entity.Property(e => e.Attachments).HasColumnName("ATTACHMENTS");
    //        entity.Property(e => e.BuyerId).HasColumnName("BUYER_ID");
    //        entity.Property(e => e.ByrCode)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BYR_CODE");
    //        entity.Property(e => e.DelayMailMin).HasColumnName("DELAY_MAIL_MIN");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.HtmlNotToSend).HasColumnName("HTML_NOT_TO_SEND");
    //        entity.Property(e => e.MailBcc)
    //            .HasMaxLength(500)
    //            .HasColumnName("MAIL_BCC");
    //        entity.Property(e => e.MailBody).HasColumnName("MAIL_BODY");
    //        entity.Property(e => e.MailCc)
    //            .HasMaxLength(500)
    //            .HasColumnName("MAIL_CC");
    //        entity.Property(e => e.MailDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("MAIL_DATE");
    //        entity.Property(e => e.MailFrom)
    //            .HasMaxLength(100)
    //            .HasColumnName("MAIL_FROM");
    //        entity.Property(e => e.MailSubject).HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.MailTo)
    //            .HasMaxLength(500)
    //            .HasColumnName("MAIL_TO");
    //        entity.Property(e => e.Module)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("MODULE");
    //        entity.Property(e => e.NotToSent).HasColumnName("NOT_TO_SENT");
    //        entity.Property(e => e.QueueId)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUEUE_ID");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteExported).HasColumnName("QUOTE_EXPORTED");
    //        entity.Property(e => e.ReceiverName)
    //            .HasMaxLength(200)
    //            .HasColumnName("RECEIVER_NAME");
    //        entity.Property(e => e.RefKey)
    //            .HasMaxLength(150)
    //            .HasColumnName("REF_KEY");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SendHtmlMsg).HasColumnName("SEND_HTML_MSG");
    //        entity.Property(e => e.SenderName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SENDER_NAME");
    //        entity.Property(e => e.SuppCode)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPP_CODE");
    //        entity.Property(e => e.SuppRef)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPP_REF");
    //        entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
    //        entity.Property(e => e.TimeStamp)
    //            .HasMaxLength(50)
    //            .HasColumnName("TIME_STAMP");
    //        entity.Property(e => e.UseHtmlFileMsg).HasColumnName("USE_HTML_FILE_MSG");
    //    });

    //    modelBuilder.Entity<SmvGetSendMailQueueSendgrid>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_GET_SEND_MAIL_QUEUE_SENDGRID");

    //        entity.Property(e => e.ActionType)
    //            .HasMaxLength(50)
    //            .HasColumnName("ACTION_TYPE");
    //        entity.Property(e => e.Attachments).HasColumnName("ATTACHMENTS");
    //        entity.Property(e => e.BuyerId).HasColumnName("BUYER_ID");
    //        entity.Property(e => e.ByrCode)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BYR_CODE");
    //        entity.Property(e => e.DelayMailMin).HasColumnName("DELAY_MAIL_MIN");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.HtmlNotToSend).HasColumnName("HTML_NOT_TO_SEND");
    //        entity.Property(e => e.MailBcc)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_BCC");
    //        entity.Property(e => e.MailBody).HasColumnName("MAIL_BODY");
    //        entity.Property(e => e.MailCc)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_CC");
    //        entity.Property(e => e.MailDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("MAIL_DATE");
    //        entity.Property(e => e.MailFrom)
    //            .HasMaxLength(100)
    //            .HasColumnName("MAIL_FROM");
    //        entity.Property(e => e.MailSubject).HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.MailTo)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_TO");
    //        entity.Property(e => e.Module)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("MODULE");
    //        entity.Property(e => e.NotToSent).HasColumnName("NOT_TO_SENT");
    //        entity.Property(e => e.QueueId)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUEUE_ID");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteExported).HasColumnName("QUOTE_EXPORTED");
    //        entity.Property(e => e.ReceiverName)
    //            .HasMaxLength(200)
    //            .HasColumnName("RECEIVER_NAME");
    //        entity.Property(e => e.RefKey)
    //            .HasMaxLength(150)
    //            .HasColumnName("REF_KEY");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SendHtmlMsg).HasColumnName("SEND_HTML_MSG");
    //        entity.Property(e => e.SenderName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SENDER_NAME");
    //        entity.Property(e => e.SuppCode)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPP_CODE");
    //        entity.Property(e => e.SuppRef)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPP_REF");
    //        entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
    //        entity.Property(e => e.TimeStamp)
    //            .HasMaxLength(50)
    //            .HasColumnName("TIME_STAMP");
    //        entity.Property(e => e.UseHtmlFileMsg).HasColumnName("USE_HTML_FILE_MSG");
    //    });

    //    modelBuilder.Entity<SmvImportAceWebRfq>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_ACE_WEB_RFQ");

    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPo).HasColumnName("EXPORT_PO");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UploadFileType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("UPLOAD_FILE_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportAmos2ExcelQuote>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_AMOS2_EXCEL_QUOTE");

    //        entity.Property(e => e.AddrCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("ADDR_CODE");
    //        entity.Property(e => e.AddrInbox)
    //            .HasMaxLength(2000)
    //            .HasColumnName("ADDR_INBOX");
    //        entity.Property(e => e.AddrName)
    //            .HasMaxLength(200)
    //            .HasColumnName("ADDR_NAME");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //    });

    //    modelBuilder.Entity<SmvImportAmos2ExcelQuoteLe>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_AMOS2_EXCEL_QUOTE_LES");

    //        entity.Property(e => e.AddrCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("ADDR_CODE");
    //        entity.Property(e => e.AddrInbox)
    //            .HasMaxLength(150)
    //            .HasColumnName("ADDR_INBOX");
    //        entity.Property(e => e.AddrName)
    //            .HasMaxLength(200)
    //            .HasColumnName("ADDR_NAME");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //    });

    //    modelBuilder.Entity<SmvImportAmos2MtmlDoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_AMOS2_MTML_DOCS");

    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTML_CODE");
    //        entity.Property(e => e.BuyerMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTS_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTML_CODE");
    //        entity.Property(e => e.SupplierMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTS_CODE");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //    });

    //    modelBuilder.Entity<SmvImportAmos2MtmlDocsLe>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_AMOS2_MTML_DOCS_LES");

    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerAddrEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_ADDR_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTML_CODE");
    //        entity.Property(e => e.BuyerMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTS_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupplierAddrEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_ADDR_EMAIL");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTML_CODE");
    //        entity.Property(e => e.SupplierMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTS_CODE");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportAnobelPdf>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_ANOBEL_PDF");

    //        entity.Property(e => e.AsmbExportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_EXPORT_CLASS");
    //        entity.Property(e => e.AsmbImportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_IMPORT_CLASS");
    //        entity.Property(e => e.AssemblyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASSEMBLY_NAME");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("EXPORT_FUNCTION");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPo).HasColumnName("EXPORT_PO");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("IMPORT_FUNCTION");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportPoc).HasColumnName("IMPORT_POC");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.LinkType)
    //            .HasMaxLength(50)
    //            .HasColumnName("LINK_TYPE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupWebServiceUrl)
    //            .HasMaxLength(300)
    //            .IsUnicode(false)
    //            .HasColumnName("SUP_WEB_SERVICE_URL");
    //        entity.Property(e => e.SuppExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_EXPORT_PATH");
    //        entity.Property(e => e.SuppImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_IMPORT_PATH");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.SupplierImportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_IMPORT_FORMAT");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UploadFileType)
    //            .HasMaxLength(50)
    //            .HasColumnName("UPLOAD_FILE_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportCbedPdf>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_CBED_PDF");

    //        entity.Property(e => e.AsmbExportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_EXPORT_CLASS");
    //        entity.Property(e => e.AsmbImportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_IMPORT_CLASS");
    //        entity.Property(e => e.AssemblyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASSEMBLY_NAME");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("EXPORT_FUNCTION");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPo).HasColumnName("EXPORT_PO");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("IMPORT_FUNCTION");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupWebServiceUrl)
    //            .HasMaxLength(300)
    //            .IsUnicode(false)
    //            .HasColumnName("SUP_WEB_SERVICE_URL");
    //        entity.Property(e => e.SuppExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_EXPORT_PATH");
    //        entity.Property(e => e.SuppImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_IMPORT_PATH");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.SupplierImportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_IMPORT_FORMAT");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UploadFileType)
    //            .HasMaxLength(50)
    //            .HasColumnName("UPLOAD_FILE_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportEdiByrDoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_EDI_BYR_DOCS");

    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportEdiSuppDoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_EDI_SUPP_DOCS");

    //        entity.Property(e => e.AddrInbox)
    //            .HasMaxLength(2000)
    //            .HasColumnName("ADDR_INBOX");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportEmsSuppDoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_EMS_SUPP_DOCS");

    //        entity.Property(e => e.AddrInbox)
    //            .HasMaxLength(2000)
    //            .HasColumnName("ADDR_INBOX");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(500)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(500)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportExcelDocsByr>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_EXCEL_DOCS_BYR");

    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerAddrEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_ADDR_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.BuyerMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTML_CODE");
    //        entity.Property(e => e.BuyerMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTS_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierAddrEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_ADDR_EMAIL");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.SupplierMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTML_CODE");
    //        entity.Property(e => e.SupplierMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTS_CODE");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportExcelDocsSupp>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_EXCEL_DOCS_SUPP");

    //        entity.Property(e => e.AddrInbox)
    //            .HasMaxLength(2000)
    //            .HasColumnName("ADDR_INBOX");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportExcelRfq>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_EXCEL_RFQS");

    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTML_CODE");
    //        entity.Property(e => e.BuyerMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTS_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTML_CODE");
    //        entity.Property(e => e.SupplierMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTS_CODE");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //    });

    //    modelBuilder.Entity<SmvImportExcelRfqsLe>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_EXCEL_RFQS_LES");

    //        entity.Property(e => e.AsmbExportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_EXPORT_CLASS");
    //        entity.Property(e => e.AsmbImportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_IMPORT_CLASS");
    //        entity.Property(e => e.AssemblyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASSEMBLY_NAME");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerAddrEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_ADDR_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.BuyerMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTML_CODE");
    //        entity.Property(e => e.BuyerMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTS_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("EXPORT_FUNCTION");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("IMPORT_FUNCTION");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierAddrEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_ADDR_EMAIL");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.SupplierMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTML_CODE");
    //        entity.Property(e => e.SupplierMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTS_CODE");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportGoodwoodRfq>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_GOODWOOD_RFQ");

    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPo).HasColumnName("EXPORT_PO");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SuppCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPP_CODE");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UploadFileType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("UPLOAD_FILE_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportHidroviaPdf>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_HIDROVIA_PDF");

    //        entity.Property(e => e.AsmbExportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_EXPORT_CLASS");
    //        entity.Property(e => e.AsmbImportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_IMPORT_CLASS");
    //        entity.Property(e => e.AssemblyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASSEMBLY_NAME");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("EXPORT_FUNCTION");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPo).HasColumnName("EXPORT_PO");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("IMPORT_FUNCTION");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportPoc).HasColumnName("IMPORT_POC");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.LinkType)
    //            .HasMaxLength(50)
    //            .HasColumnName("LINK_TYPE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupWebServiceUrl)
    //            .HasMaxLength(300)
    //            .IsUnicode(false)
    //            .HasColumnName("SUP_WEB_SERVICE_URL");
    //        entity.Property(e => e.SuppExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_EXPORT_PATH");
    //        entity.Property(e => e.SuppImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_IMPORT_PATH");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.SupplierImportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_IMPORT_FORMAT");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UploadFileType)
    //            .HasMaxLength(50)
    //            .HasColumnName("UPLOAD_FILE_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportJandenulPdf>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_JANDENUL_PDF");

    //        entity.Property(e => e.AsmbExportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_EXPORT_CLASS");
    //        entity.Property(e => e.AsmbImportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_IMPORT_CLASS");
    //        entity.Property(e => e.AssemblyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASSEMBLY_NAME");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("EXPORT_FUNCTION");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPo).HasColumnName("EXPORT_PO");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("IMPORT_FUNCTION");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportPoc).HasColumnName("IMPORT_POC");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.LinkType)
    //            .HasMaxLength(50)
    //            .HasColumnName("LINK_TYPE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupWebServiceUrl)
    //            .HasMaxLength(300)
    //            .IsUnicode(false)
    //            .HasColumnName("SUP_WEB_SERVICE_URL");
    //        entity.Property(e => e.SuppExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_EXPORT_PATH");
    //        entity.Property(e => e.SuppImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_IMPORT_PATH");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.SupplierImportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_IMPORT_FORMAT");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UploadFileType)
    //            .HasMaxLength(50)
    //            .HasColumnName("UPLOAD_FILE_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportManPdf>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_MAN_PDF");

    //        entity.Property(e => e.Buyer)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(2000)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.Supplier)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportMarineExcelRfq>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_MARINE_EXCEL_RFQ");

    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTML_CODE");
    //        entity.Property(e => e.BuyerMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTS_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTML_CODE");
    //        entity.Property(e => e.SupplierMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTS_CODE");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //    });

    //    modelBuilder.Entity<SmvImportMarineLinkDoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_MARINE_LINK_DOCS");

    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportMarineLinkSuppDoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_MARINE_LINK_SUPP_DOCS");

    //        entity.Property(e => e.AddrInbox)
    //            .HasMaxLength(2000)
    //            .HasColumnName("ADDR_INBOX");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportMtmPoPdf>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_MTM_PO_PDF");

    //        entity.Property(e => e.AsmbExportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_EXPORT_CLASS");
    //        entity.Property(e => e.AsmbImportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_IMPORT_CLASS");
    //        entity.Property(e => e.AssemblyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASSEMBLY_NAME");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("EXPORT_FUNCTION");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPo).HasColumnName("EXPORT_PO");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("IMPORT_FUNCTION");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupWebServiceUrl)
    //            .HasMaxLength(300)
    //            .IsUnicode(false)
    //            .HasColumnName("SUP_WEB_SERVICE_URL");
    //        entity.Property(e => e.SuppExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_EXPORT_PATH");
    //        entity.Property(e => e.SuppImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_IMPORT_PATH");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.SupplierImportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_IMPORT_FORMAT");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UploadFileType)
    //            .HasMaxLength(50)
    //            .HasColumnName("UPLOAD_FILE_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportMtmlV2ByrDoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_MTML_V2_BYR_DOCS");

    //        entity.Property(e => e.AddrInbox)
    //            .HasMaxLength(2000)
    //            .HasColumnName("ADDR_INBOX");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportMtmlV2SuppDoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_MTML_V2_SUPP_DOCS");

    //        entity.Property(e => e.AddrInbox)
    //            .HasMaxLength(2000)
    //            .HasColumnName("ADDR_INBOX");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportMtmshipRfq>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_MTMSHIP_RFQ");

    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPo).HasColumnName("EXPORT_PO");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportPaccSdsHub>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_PACC_SDS_HUB");

    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerAddrEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_ADDR_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.BuyerMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTML_CODE");
    //        entity.Property(e => e.BuyerMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTS_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierAddrEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_ADDR_EMAIL");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.SupplierMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTML_CODE");
    //        entity.Property(e => e.SupplierMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTS_CODE");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportPdfDoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_PDF_DOCS");

    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MapId).HasColumnName("MAP_ID");
    //        entity.Property(e => e.PdfMapid).HasColumnName("PDF_MAPID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //    });

    //    modelBuilder.Entity<SmvImportPdfFile>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_PDF_FILES");

    //        entity.Property(e => e.Buyer)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.Supplier)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportPdfMaritec>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_PDF_MARITEC");

    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //    });

    //    modelBuilder.Entity<SmvImportPolskaPdf>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_POLSKA_PDF");

    //        entity.Property(e => e.AsmbExportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_EXPORT_CLASS");
    //        entity.Property(e => e.AsmbImportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_IMPORT_CLASS");
    //        entity.Property(e => e.AssemblyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASSEMBLY_NAME");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("EXPORT_FUNCTION");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPo).HasColumnName("EXPORT_PO");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("IMPORT_FUNCTION");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportPoc).HasColumnName("IMPORT_POC");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.LinkType)
    //            .HasMaxLength(50)
    //            .HasColumnName("LINK_TYPE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupWebServiceUrl)
    //            .HasMaxLength(300)
    //            .IsUnicode(false)
    //            .HasColumnName("SUP_WEB_SERVICE_URL");
    //        entity.Property(e => e.SuppExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_EXPORT_PATH");
    //        entity.Property(e => e.SuppImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_IMPORT_PATH");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.SupplierImportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_IMPORT_FORMAT");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UploadFileType)
    //            .HasMaxLength(50)
    //            .HasColumnName("UPLOAD_FILE_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportRealMarineDoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_REAL_MARINE_DOCS");

    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTML_CODE");
    //        entity.Property(e => e.BuyerMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTS_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.Expr1)
    //            .HasMaxLength(100)
    //            .IsUnicode(false);
    //        entity.Property(e => e.Expr2)
    //            .HasMaxLength(100)
    //            .IsUnicode(false);
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTML_CODE");
    //        entity.Property(e => e.SupplierMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTS_CODE");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportRealMarineDocsLe>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_REAL_MARINE_DOCS_LES");

    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerAddrEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_ADDR_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTML_CODE");
    //        entity.Property(e => e.BuyerMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTS_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupplierAddrEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_ADDR_EMAIL");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTML_CODE");
    //        entity.Property(e => e.SupplierMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTS_CODE");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportRmsExcelDocsSupp>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_RMS_EXCEL_DOCS_SUPP");

    //        entity.Property(e => e.AddrInbox)
    //            .HasMaxLength(2000)
    //            .HasColumnName("ADDR_INBOX");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportScannedPdfDoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_SCANNED_PDF_DOCS");

    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.MapId).HasColumnName("MAP_ID");
    //        entity.Property(e => e.PdfMapid).HasColumnName("PDF_MAPID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //    });

    //    modelBuilder.Entity<SmvImportSeaProcByrDoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_SEA_PROC_BYR_DOCS");

    //        entity.Property(e => e.AddrInbox)
    //            .HasMaxLength(2000)
    //            .HasColumnName("ADDR_INBOX");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportShipServByrDoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_SHIP_SERV_BYR_DOCS");

    //        entity.Property(e => e.AddrInbox)
    //            .HasMaxLength(2000)
    //            .HasColumnName("ADDR_INBOX");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(500)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(500)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportShipServByrDocsThomeUat>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_SHIP_SERV_BYR_DOCS_THOME_UAT");

    //        entity.Property(e => e.AddrInbox)
    //            .HasMaxLength(2000)
    //            .HasColumnName("ADDR_INBOX");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(500)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(500)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportShipnetRfq>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_SHIPNET_RFQ");

    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPo).HasColumnName("EXPORT_PO");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportShipsmartRfq>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_SHIPSMART_RFQ");

    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPo).HasColumnName("EXPORT_PO");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportSilverseaPdf>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_SILVERSEA_PDF");

    //        entity.Property(e => e.AsmbExportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_EXPORT_CLASS");
    //        entity.Property(e => e.AsmbImportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_IMPORT_CLASS");
    //        entity.Property(e => e.AssemblyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASSEMBLY_NAME");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.Buyer)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("EXPORT_FUNCTION");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPo).HasColumnName("EXPORT_PO");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("IMPORT_FUNCTION");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportPoc).HasColumnName("IMPORT_POC");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.LinkType)
    //            .HasMaxLength(50)
    //            .HasColumnName("LINK_TYPE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupWebServiceUrl)
    //            .HasMaxLength(300)
    //            .IsUnicode(false)
    //            .HasColumnName("SUP_WEB_SERVICE_URL");
    //        entity.Property(e => e.SuppExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_EXPORT_PATH");
    //        entity.Property(e => e.SuppImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_IMPORT_PATH");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.Supplier)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.SupplierImportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_IMPORT_FORMAT");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UploadFileType)
    //            .HasMaxLength(50)
    //            .HasColumnName("UPLOAD_FILE_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportSincereindPdf>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_SINCEREIND_PDF");

    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //    });

    //    modelBuilder.Entity<SmvImportSinwaQuote>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_SINWA_QUOTE");

    //        entity.Property(e => e.AddrCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("ADDR_CODE");
    //        entity.Property(e => e.AddrInbox)
    //            .HasMaxLength(2000)
    //            .HasColumnName("ADDR_INBOX");
    //        entity.Property(e => e.AddrName)
    //            .HasMaxLength(200)
    //            .HasColumnName("ADDR_NAME");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //    });

    //    modelBuilder.Entity<SmvImportSinwaQuoteLe>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_SINWA_QUOTE_LES");

    //        entity.Property(e => e.AddrCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("ADDR_CODE");
    //        entity.Property(e => e.AddrInbox)
    //            .HasMaxLength(2000)
    //            .HasColumnName("ADDR_INBOX");
    //        entity.Property(e => e.AddrName)
    //            .HasMaxLength(200)
    //            .HasColumnName("ADDR_NAME");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //    });

    //    modelBuilder.Entity<SmvImportSpPdfFile>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_SP_PDF_FILES");

    //        entity.Property(e => e.AsmbExportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_EXPORT_CLASS");
    //        entity.Property(e => e.AsmbImportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_IMPORT_CLASS");
    //        entity.Property(e => e.AssemblyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASSEMBLY_NAME");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(500)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("EXPORT_FUNCTION");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPo).HasColumnName("EXPORT_PO");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("IMPORT_FUNCTION");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportPoc).HasColumnName("IMPORT_POC");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.LinkType)
    //            .HasMaxLength(50)
    //            .HasColumnName("LINK_TYPE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupWebServiceUrl)
    //            .HasMaxLength(300)
    //            .IsUnicode(false)
    //            .HasColumnName("SUP_WEB_SERVICE_URL");
    //        entity.Property(e => e.SuppExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_EXPORT_PATH");
    //        entity.Property(e => e.SuppImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_IMPORT_PATH");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(500)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.SupplierImportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_IMPORT_FORMAT");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UploadFileType)
    //            .HasMaxLength(50)
    //            .HasColumnName("UPLOAD_FILE_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(500)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportStamcoExcelRfq>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_STAMCO_EXCEL_RFQ");

    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTML_CODE");
    //        entity.Property(e => e.BuyerMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTS_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTML_CODE");
    //        entity.Property(e => e.SupplierMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("SUPPLIER_MTS_CODE");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //    });

    //    modelBuilder.Entity<SmvImportSwirePo>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_SWIRE_PO");

    //        entity.Property(e => e.Buyer)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.Supplier)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportUnionmarinePdf>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_UNIONMARINE_PDF");

    //        entity.Property(e => e.AsmbExportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_EXPORT_CLASS");
    //        entity.Property(e => e.AsmbImportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_IMPORT_CLASS");
    //        entity.Property(e => e.AssemblyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASSEMBLY_NAME");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("EXPORT_FUNCTION");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPo).HasColumnName("EXPORT_PO");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("IMPORT_FUNCTION");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportPoc).HasColumnName("IMPORT_POC");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.LinkType)
    //            .HasMaxLength(50)
    //            .HasColumnName("LINK_TYPE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupWebServiceUrl)
    //            .HasMaxLength(300)
    //            .IsUnicode(false)
    //            .HasColumnName("SUP_WEB_SERVICE_URL");
    //        entity.Property(e => e.SuppExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_EXPORT_PATH");
    //        entity.Property(e => e.SuppImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_IMPORT_PATH");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.SupplierImportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_IMPORT_FORMAT");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UploadFileType)
    //            .HasMaxLength(50)
    //            .HasColumnName("UPLOAD_FILE_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportVshipPdf>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_VSHIP_PDF");

    //        entity.Property(e => e.AsmbExportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_EXPORT_CLASS");
    //        entity.Property(e => e.AsmbImportClass)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASMB_IMPORT_CLASS");
    //        entity.Property(e => e.AssemblyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("ASSEMBLY_NAME");
    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.Company).HasMaxLength(50);
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ErrNotifyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("ERR_NOTIFY_EMAIL");
    //        entity.Property(e => e.ExportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("EXPORT_FUNCTION");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPo).HasColumnName("EXPORT_PO");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportFunction)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("IMPORT_FUNCTION");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportPoc).HasColumnName("IMPORT_POC");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.LinkType)
    //            .HasMaxLength(50)
    //            .HasColumnName("LINK_TYPE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupWebServiceUrl)
    //            .HasMaxLength(300)
    //            .IsUnicode(false)
    //            .HasColumnName("SUP_WEB_SERVICE_URL");
    //        entity.Property(e => e.SuppExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_EXPORT_PATH");
    //        entity.Property(e => e.SuppImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPP_IMPORT_PATH");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("SUPPLIER_CONTACT");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.SupplierImportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_IMPORT_FORMAT");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.UploadFileType)
    //            .HasMaxLength(50)
    //            .HasColumnName("UPLOAD_FILE_TYPE");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvImportVshipsDoc>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_IMPORT_VSHIPS_DOCS");

    //        entity.Property(e => e.BccEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("BCC_EMAIL");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.CcEmail)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("CC_EMAIL");
    //        entity.Property(e => e.DefaultPrice).HasColumnName("DEFAULT_PRICE");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.ExportPoAck).HasColumnName("EXPORT_PO_ACK");
    //        entity.Property(e => e.ExportPoc).HasColumnName("EXPORT_POC");
    //        entity.Property(e => e.ExportQuote).HasColumnName("EXPORT_QUOTE");
    //        entity.Property(e => e.ExportRfq).HasColumnName("EXPORT_RFQ");
    //        entity.Property(e => e.ExportRfqAck).HasColumnName("EXPORT_RFQ_ACK");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.ImportPo).HasColumnName("IMPORT_PO");
    //        entity.Property(e => e.ImportQuote).HasColumnName("IMPORT_QUOTE");
    //        entity.Property(e => e.ImportRfq).HasColumnName("IMPORT_RFQ");
    //        entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
    //        entity.Property(e => e.Linkid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LINKID");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.ReplyEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("REPLY_EMAIL");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //    });

    //    modelBuilder.Entity<SmvInvoiceAddrlink>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_INVOICE_ADDRLINKS");

    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(100)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.SuppCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPP_CODE");
    //        entity.Property(e => e.SuppId).HasColumnName("SUPP_ID");
    //        entity.Property(e => e.SuppName)
    //            .HasMaxLength(100)
    //            .HasColumnName("SUPP_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //    });

    //    modelBuilder.Entity<SmvInvoiceDetailsPortal>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_INVOICE_DETAILS_PORTAL");

    //        entity.Property(e => e.AcBicId)
    //            .HasMaxLength(50)
    //            .HasColumnName("AC_BIC_ID");
    //        entity.Property(e => e.AcIbanId)
    //            .HasMaxLength(50)
    //            .HasColumnName("AC_IBAN_ID");
    //        entity.Property(e => e.AccountNum)
    //            .HasMaxLength(50)
    //            .HasColumnName("ACCOUNT_NUM");
    //        entity.Property(e => e.AccountOwner)
    //            .HasMaxLength(50)
    //            .HasColumnName("ACCOUNT_OWNER");
    //        entity.Property(e => e.AddrCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("ADDR_CODE");
    //        entity.Property(e => e.AddrMtsCode)
    //            .IsUnicode(false)
    //            .HasColumnName("Addr_MTS_CODE");
    //        entity.Property(e => e.AddrName)
    //            .HasMaxLength(100)
    //            .HasColumnName("ADDR_NAME");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.Amount).HasColumnName("AMOUNT");
    //        entity.Property(e => e.ApprovedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("APPROVED_DATE");
    //        entity.Property(e => e.Attachment1)
    //            .HasMaxLength(250)
    //            .HasColumnName("ATTACHMENT1");
    //        entity.Property(e => e.Attachment2)
    //            .HasMaxLength(250)
    //            .HasColumnName("ATTACHMENT2");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerId).HasColumnName("BUYER_ID");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(100)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.BuyerXmlNo).HasColumnName("BUYER_XML_NO");
    //        entity.Property(e => e.Buyerid1).HasColumnName("BUYERID");
    //        entity.Property(e => e.BuyersId).HasColumnName("BUYERS_ID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.Currencyid).HasColumnName("CURRENCYID");
    //        entity.Property(e => e.DueDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("DUE_DATE");
    //        entity.Property(e => e.Exported)
    //            .HasColumnType("numeric(18, 0)")
    //            .HasColumnName("EXPORTED");
    //        entity.Property(e => e.Expr1).HasMaxLength(50);
    //        entity.Property(e => e.FinalInvoice).HasColumnName("FINAL_INVOICE");
    //        entity.Property(e => e.IbanNum)
    //            .HasMaxLength(50)
    //            .HasColumnName("IBAN_NUM");
    //        entity.Property(e => e.InvFilename)
    //            .HasMaxLength(250)
    //            .HasColumnName("INV_FILENAME");
    //        entity.Property(e => e.InvoiceAmount).HasColumnName("INVOICE_AMOUNT");
    //        entity.Property(e => e.InvoiceComment)
    //            .HasMaxLength(200)
    //            .HasColumnName("INVOICE_COMMENT");
    //        entity.Property(e => e.InvoiceDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("INVOICE_DATE");
    //        entity.Property(e => e.InvoiceExchrate).HasColumnName("INVOICE_EXCHRATE");
    //        entity.Property(e => e.InvoiceRecvDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("INVOICE_RECV_DATE");
    //        entity.Property(e => e.InvoiceRemark)
    //            .HasMaxLength(200)
    //            .HasColumnName("INVOICE_REMARK");
    //        entity.Property(e => e.InvoiceStatus).HasColumnName("INVOICE_STATUS");
    //        entity.Property(e => e.InvoiceType).HasColumnName("INVOICE_TYPE");
    //        entity.Property(e => e.Invoiceno)
    //            .HasMaxLength(50)
    //            .HasColumnName("INVOICENO");
    //        entity.Property(e => e.Invoicetype1)
    //            .HasMaxLength(13)
    //            .IsUnicode(false)
    //            .HasColumnName("INVOICETYPE");
    //        entity.Property(e => e.NetInvoiceAmountView).HasColumnName("NET_INVOICE_AMOUNT_VIEW");
    //        entity.Property(e => e.PaidAmount).HasColumnName("PAID_AMOUNT");
    //        entity.Property(e => e.PaidDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PAID_DATE");
    //        entity.Property(e => e.PaymentRef)
    //            .HasMaxLength(50)
    //            .HasColumnName("PAYMENT_REF");
    //        entity.Property(e => e.PoNo)
    //            .HasMaxLength(20)
    //            .HasColumnName("PO_NO");
    //        entity.Property(e => e.PortalStatus)
    //            .IsUnicode(false)
    //            .HasColumnName("PORTAL_STATUS");
    //        entity.Property(e => e.Portalstatus1)
    //            .HasMaxLength(10)
    //            .IsUnicode(false)
    //            .HasColumnName("PORTALSTATUS");
    //        entity.Property(e => e.Reqninvoiceid).HasColumnName("REQNINVOICEID");
    //        entity.Property(e => e.Status)
    //            .HasMaxLength(20)
    //            .HasColumnName("STATUS");
    //        entity.Property(e => e.SubmitDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("SUBMIT_DATE");
    //        entity.Property(e => e.SumLineItem).HasColumnName("Sum_Line_Item");
    //        entity.Property(e => e.SupplierEmail)
    //            .HasMaxLength(100)
    //            .HasColumnName("SUPPLIER_EMAIL");
    //        entity.Property(e => e.SupplierXmlNo).HasColumnName("SUPPLIER_XML_NO");
    //        entity.Property(e => e.SwiftNum)
    //            .HasMaxLength(50)
    //            .HasColumnName("SWIFT_NUM");
    //        entity.Property(e => e.TotTax).HasColumnName("TOT_TAX");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.Variance).HasColumnName("VARIANCE");
    //        entity.Property(e => e.VatAmount).HasColumnName("VAT_AMOUNT");
    //        entity.Property(e => e.VatPrcnt).HasColumnName("VAT_PRCNT");
    //        entity.Property(e => e.VendorId).HasColumnName("VENDOR_ID");
    //        entity.Property(e => e.Vesselcode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VESSELCODE");
    //        entity.Property(e => e.Vesselname)
    //            .HasMaxLength(50)
    //            .HasColumnName("VESSELNAME");
    //    });

    //    modelBuilder.Entity<SmvInvoiceItemdetailsPortal>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_INVOICE_ITEMDETAILS_PORTAL");

    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.Discount).HasColumnName("DISCOUNT");
    //        entity.Property(e => e.Drawingno)
    //            .HasMaxLength(50)
    //            .HasColumnName("DRAWINGNO");
    //        entity.Property(e => e.Exchrate).HasColumnName("EXCHRATE");
    //        entity.Property(e => e.FinalDelivery).HasColumnName("FINAL_DELIVERY");
    //        entity.Property(e => e.InvoiceItemid).HasColumnName("INVOICE_ITEMID");
    //        entity.Property(e => e.InvoicePrice).HasColumnName("INVOICE_PRICE");
    //        entity.Property(e => e.InvoiceQty).HasColumnName("INVOICE_QTY");
    //        entity.Property(e => e.Invoiceno)
    //            .HasMaxLength(50)
    //            .HasColumnName("INVOICENO");
    //        entity.Property(e => e.ItemRemarks)
    //            .HasMaxLength(200)
    //            .HasColumnName("ITEM_REMARKS");
    //        entity.Property(e => e.ItemTotal).HasColumnName("ITEM_TOTAL");
    //        entity.Property(e => e.Itemno).HasColumnName("ITEMNO");
    //        entity.Property(e => e.Partname)
    //            .HasMaxLength(50)
    //            .HasColumnName("PARTNAME");
    //        entity.Property(e => e.Partunit)
    //            .HasMaxLength(50)
    //            .HasColumnName("PARTUNIT");
    //        entity.Property(e => e.Posno)
    //            .HasMaxLength(50)
    //            .HasColumnName("POSNO");
    //        entity.Property(e => e.Refno)
    //            .HasMaxLength(50)
    //            .HasColumnName("REFNO");
    //        entity.Property(e => e.Reqninvoiceid).HasColumnName("REQNINVOICEID");
    //        entity.Property(e => e.UnitCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("UNIT_CODE");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.Vesselname)
    //            .HasMaxLength(50)
    //            .HasColumnName("VESSELNAME");
    //    });

    //    modelBuilder.Entity<SmvLesClientsLog>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_LES_CLIENTS_LOG");

    //        entity.Property(e => e.AddrCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("ADDR_CODE");
    //        entity.Property(e => e.AddrName)
    //            .HasMaxLength(200)
    //            .HasColumnName("ADDR_NAME");
    //        entity.Property(e => e.AddrType)
    //            .HasMaxLength(10)
    //            .HasColumnName("ADDR_TYPE");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.Connectid).HasColumnName("CONNECTID");
    //        entity.Property(e => e.Interval).HasColumnName("INTERVAL");
    //        entity.Property(e => e.LastConnect)
    //            .HasColumnType("datetime")
    //            .HasColumnName("LAST_CONNECT");
    //        entity.Property(e => e.LastConnect1)
    //            .HasColumnType("datetime")
    //            .HasColumnName("LAST_CONNECT1");
    //        entity.Property(e => e.LisenceKey)
    //            .HasMaxLength(50)
    //            .HasColumnName("LISENCE_KEY");
    //        entity.Property(e => e.NextConnect)
    //            .HasColumnType("datetime")
    //            .HasColumnName("NEXT_CONNECT");
    //    });

    //    modelBuilder.Entity<SmvLogin>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_LOGIN");

    //        entity.Property(e => e.AddrCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("ADDR_CODE");
    //        entity.Property(e => e.AddrIsactive).HasColumnName("ADDR_ISACTIVE");
    //        entity.Property(e => e.AddrName)
    //            .HasMaxLength(200)
    //            .HasColumnName("ADDR_NAME");
    //        entity.Property(e => e.AddrType)
    //            .HasMaxLength(10)
    //            .HasColumnName("ADDR_TYPE");
    //        entity.Property(e => e.Addressid).HasColumnName("ADDRESSID");
    //        entity.Property(e => e.ExEmailid)
    //            .HasMaxLength(150)
    //            .HasColumnName("EX_EMAILID");
    //        entity.Property(e => e.ExPassword)
    //            .HasMaxLength(50)
    //            .HasColumnName("EX_PASSWORD");
    //        entity.Property(e => e.ExUsercode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("EX_USERCODE");
    //        entity.Property(e => e.ExUserid).HasColumnName("EX_USERID");
    //        entity.Property(e => e.ExUsername)
    //            .HasMaxLength(50)
    //            .HasColumnName("EX_USERNAME");
    //        entity.Property(e => e.ExusersIsactive).HasColumnName("EXUSERS_ISACTIVE");
    //        entity.Property(e => e.InvUsertype).HasColumnName("INV_USERTYPE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.Usertype).HasColumnName("USERTYPE");
    //    });

    //    modelBuilder.Entity<SmvMailLog>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_MAIL_LOG");

    //        entity.Property(e => e.Accepted)
    //            .HasMaxLength(14)
    //            .IsUnicode(false)
    //            .HasColumnName("ACCEPTED");
    //        entity.Property(e => e.BuyerAddr)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_ADDR");
    //        entity.Property(e => e.BuyerId).HasColumnName("BUYER_ID");
    //        entity.Property(e => e.Comments)
    //            .HasMaxLength(500)
    //            .HasColumnName("COMMENTS");
    //        entity.Property(e => e.File1)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("FILE1");
    //        entity.Property(e => e.File2)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("FILE2");
    //        entity.Property(e => e.FromMail)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("FROM_MAIL");
    //        entity.Property(e => e.KeyRefno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("KEY_REFNO");
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(400)
    //            .IsUnicode(false)
    //            .HasColumnName("MAIL_SUBJECT");
    //        entity.Property(e => e.Msgfile)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("MSGFILE");
    //        entity.Property(e => e.Processed)
    //            .HasMaxLength(14)
    //            .IsUnicode(false)
    //            .HasColumnName("PROCESSED");
    //        entity.Property(e => e.SupplierAddr)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_ADDR");
    //        entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
    //        entity.Property(e => e.ToMail)
    //            .HasMaxLength(200)
    //            .IsUnicode(false)
    //            .HasColumnName("TO_MAIL");
    //        entity.Property(e => e.UpdateDate)
    //            .HasMaxLength(45)
    //            .IsUnicode(false)
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.Updatedate1)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATEDATE");
    //    });

    //    modelBuilder.Entity<SmvPdfBuyerLink>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_PDF_BUYER_LINK");

    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.BuyerSuppLinkid).HasColumnName("BUYER_SUPP_LINKID");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.FormatMapCode)
    //            .HasMaxLength(150)
    //            .HasColumnName("FORMAT_MAP_CODE");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.MapId).HasColumnName("MAP_ID");
    //        entity.Property(e => e.Mapping1)
    //            .HasMaxLength(20)
    //            .HasColumnName("MAPPING_1");
    //        entity.Property(e => e.Mapping1Value)
    //            .HasMaxLength(100)
    //            .HasColumnName("MAPPING_1_VALUE");
    //        entity.Property(e => e.Mapping2)
    //            .HasMaxLength(20)
    //            .HasColumnName("MAPPING_2");
    //        entity.Property(e => e.Mapping2Value)
    //            .HasMaxLength(100)
    //            .HasColumnName("MAPPING_2_VALUE");
    //        entity.Property(e => e.Mapping3)
    //            .HasMaxLength(20)
    //            .HasColumnName("MAPPING_3");
    //        entity.Property(e => e.Mapping3Value)
    //            .HasMaxLength(100)
    //            .HasColumnName("MAPPING_3_VALUE");
    //        entity.Property(e => e.PdfMapid).HasColumnName("PDF_MAPID");
    //        entity.Property(e => e.SampleFile)
    //            .HasMaxLength(250)
    //            .HasColumnName("SAMPLE_FILE");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmvPdfBuyerLinkNew>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_PDF_BUYER_LINK_NEW");

    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.BuyerSuppLinkid).HasColumnName("BUYER_SUPP_LINKID");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.FormatMapCode)
    //            .HasMaxLength(150)
    //            .HasColumnName("FORMAT_MAP_CODE");
    //        entity.Property(e => e.MapId).HasColumnName("MAP_ID");
    //        entity.Property(e => e.Mapping1)
    //            .HasMaxLength(20)
    //            .HasColumnName("MAPPING_1");
    //        entity.Property(e => e.Mapping1Value)
    //            .HasMaxLength(100)
    //            .HasColumnName("MAPPING_1_VALUE");
    //        entity.Property(e => e.Mapping2)
    //            .HasMaxLength(20)
    //            .HasColumnName("MAPPING_2");
    //        entity.Property(e => e.Mapping2Value)
    //            .HasMaxLength(100)
    //            .HasColumnName("MAPPING_2_VALUE");
    //        entity.Property(e => e.Mapping3)
    //            .HasMaxLength(20)
    //            .HasColumnName("MAPPING_3");
    //        entity.Property(e => e.Mapping3Value)
    //            .HasMaxLength(100)
    //            .HasColumnName("MAPPING_3_VALUE");
    //        entity.Property(e => e.PdfMapid).HasColumnName("PDF_MAPID");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //    });

    //    modelBuilder.Entity<SmvQuotationsActiveItem>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_QUOTATIONS_ACTIVE_ITEMS");

    //        entity.Property(e => e.ChangedByVendor).HasColumnName("CHANGED_BY_VENDOR");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(3)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.Deliverytime).HasColumnName("DELIVERYTIME");
    //        entity.Property(e => e.Department)
    //            .HasMaxLength(200)
    //            .HasColumnName("DEPARTMENT");
    //        entity.Property(e => e.Discount).HasColumnName("DISCOUNT");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(256)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.Drawingno)
    //            .HasMaxLength(200)
    //            .HasColumnName("DRAWINGNO");
    //        entity.Property(e => e.EquipDetails)
    //            .HasMaxLength(2460)
    //            .HasColumnName("EQUIP_DETAILS");
    //        entity.Property(e => e.EquipDrawingno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("EQUIP_DRAWINGNO");
    //        entity.Property(e => e.EquipMaker)
    //            .HasMaxLength(512)
    //            .HasColumnName("EQUIP_MAKER");
    //        entity.Property(e => e.EquipModel)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("EQUIP_MODEL");
    //        entity.Property(e => e.EquipName)
    //            .HasMaxLength(500)
    //            .HasColumnName("EQUIP_NAME");
    //        entity.Property(e => e.EquipSerno)
    //            .HasMaxLength(200)
    //            .HasColumnName("EQUIP_SERNO");
    //        entity.Property(e => e.EquipType)
    //            .HasMaxLength(200)
    //            .HasColumnName("EQUIP_TYPE");
    //        entity.Property(e => e.GrossItemPrice).HasColumnName("GROSS_ITEM_PRICE");
    //        entity.Property(e => e.GrossItemTotal).HasColumnName("GROSS_ITEM_TOTAL");
    //        entity.Property(e => e.ItemMarkedRemark).HasColumnName("ITEM_MARKED_REMARK");
    //        entity.Property(e => e.ItemRemark)
    //            .HasMaxLength(2048)
    //            .HasColumnName("ITEM_REMARK");
    //        entity.Property(e => e.ItemUnit)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("ITEM_UNIT");
    //        entity.Property(e => e.Itemno).HasColumnName("ITEMNO");
    //        entity.Property(e => e.Itemstatus).HasColumnName("ITEMSTATUS");
    //        entity.Property(e => e.ListPrice).HasColumnName("LIST_PRICE");
    //        entity.Property(e => e.NetItemPrice).HasColumnName("NET_ITEM_PRICE");
    //        entity.Property(e => e.NetItemTotal).HasColumnName("NET_ITEM_TOTAL");
    //        entity.Property(e => e.Originatingsystemref)
    //            .HasMaxLength(50)
    //            .HasColumnName("ORIGINATINGSYSTEMREF");
    //        entity.Property(e => e.PartName1)
    //            .HasMaxLength(1635)
    //            .HasColumnName("PART_NAME");
    //        entity.Property(e => e.Partname)
    //            .HasMaxLength(1000)
    //            .HasColumnName("PARTNAME");
    //        entity.Property(e => e.Posno)
    //            .HasMaxLength(200)
    //            .HasColumnName("POSNO");
    //        entity.Property(e => e.QtyOrd).HasColumnName("QTY_ORD");
    //        entity.Property(e => e.QtyQuoted).HasColumnName("QTY_QUOTED");
    //        entity.Property(e => e.QtyReq).HasColumnName("QTY_REQ");
    //        entity.Property(e => e.Quotationdetailid).HasColumnName("QUOTATIONDETAILID");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteExchrate).HasColumnName("QUOTE_EXCHRATE");
    //        entity.Property(e => e.QuotedPrice).HasColumnName("QUOTED_PRICE");
    //        entity.Property(e => e.QuoteitemRemark)
    //            .HasColumnType("ntext")
    //            .HasColumnName("QUOTEITEM_REMARK");
    //        entity.Property(e => e.Refno)
    //            .HasMaxLength(200)
    //            .HasColumnName("REFNO");
    //        entity.Property(e => e.SysItemno).HasColumnName("SYS_ITEMNO");
    //        entity.Property(e => e.UnitCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("UNIT_CODE");
    //        entity.Property(e => e.UnitPrice).HasColumnName("UNIT_PRICE");
    //        entity.Property(e => e.VendorItemno)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_ITEMNO");
    //        entity.Property(e => e.VendorRefno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VENDOR_REFNO");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvQuotationsItem>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_QUOTATIONS_ITEMS");

    //        entity.Property(e => e.ChangedByVendor).HasColumnName("CHANGED_BY_VENDOR");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(3)
    //            .IsUnicode(false)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.Deliverytime).HasColumnName("DELIVERYTIME");
    //        entity.Property(e => e.Discount).HasColumnName("DISCOUNT");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(256)
    //            .IsUnicode(false)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.Drawingno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DRAWINGNO");
    //        entity.Property(e => e.EquipDetails)
    //            .HasMaxLength(1376)
    //            .IsUnicode(false)
    //            .HasColumnName("EQUIP_DETAILS");
    //        entity.Property(e => e.EquipDrawingno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("EQUIP_DRAWINGNO");
    //        entity.Property(e => e.EquipMaker)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("EQUIP_MAKER");
    //        entity.Property(e => e.EquipModel)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("EQUIP_MODEL");
    //        entity.Property(e => e.EquipName)
    //            .HasMaxLength(128)
    //            .IsUnicode(false)
    //            .HasColumnName("EQUIP_NAME");
    //        entity.Property(e => e.EquipSerno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("EQUIP_SERNO");
    //        entity.Property(e => e.EquipType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("EQUIP_TYPE");
    //        entity.Property(e => e.GrossItemPrice).HasColumnName("GROSS_ITEM_PRICE");
    //        entity.Property(e => e.GrossItemTotal).HasColumnName("GROSS_ITEM_TOTAL");
    //        entity.Property(e => e.ItemMarkedRemark)
    //            .HasMaxLength(1000)
    //            .IsUnicode(false)
    //            .HasColumnName("ITEM_MARKED_REMARK");
    //        entity.Property(e => e.ItemRemark)
    //            .HasMaxLength(2048)
    //            .HasColumnName("ITEM_REMARK");
    //        entity.Property(e => e.ItemUnit)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("ITEM_UNIT");
    //        entity.Property(e => e.Itemno).HasColumnName("ITEMNO");
    //        entity.Property(e => e.Itemstatus).HasColumnName("ITEMSTATUS");
    //        entity.Property(e => e.ListPrice).HasColumnName("LIST_PRICE");
    //        entity.Property(e => e.NetItemPrice).HasColumnName("NET_ITEM_PRICE");
    //        entity.Property(e => e.NetItemTotal).HasColumnName("NET_ITEM_TOTAL");
    //        entity.Property(e => e.Originatingsystemref)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("ORIGINATINGSYSTEMREF");
    //        entity.Property(e => e.PartName1)
    //            .HasMaxLength(1185)
    //            .IsUnicode(false)
    //            .HasColumnName("PART_NAME");
    //        entity.Property(e => e.Partname)
    //            .HasMaxLength(1000)
    //            .IsUnicode(false)
    //            .HasColumnName("PARTNAME");
    //        entity.Property(e => e.Posno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("POSNO");
    //        entity.Property(e => e.QtyOrd).HasColumnName("QTY_ORD");
    //        entity.Property(e => e.QtyQuoted).HasColumnName("QTY_QUOTED");
    //        entity.Property(e => e.QtyReq).HasColumnName("QTY_REQ");
    //        entity.Property(e => e.Quotationdetailid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONDETAILID");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteExchrate).HasColumnName("QUOTE_EXCHRATE");
    //        entity.Property(e => e.QuotedPrice).HasColumnName("QUOTED_PRICE");
    //        entity.Property(e => e.QuoteitemRemark)
    //            .HasColumnType("ntext")
    //            .HasColumnName("QUOTEITEM_REMARK");
    //        entity.Property(e => e.Refno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("REFNO");
    //        entity.Property(e => e.UnitCode)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("UNIT_CODE");
    //        entity.Property(e => e.UnitPrice).HasColumnName("UNIT_PRICE");
    //        entity.Property(e => e.VendorItemno)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_ITEMNO");
    //        entity.Property(e => e.VendorRefno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VENDOR_REFNO");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvQuotationsVendor>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_QUOTATIONS_VENDOR");

    //        entity.Property(e => e.AdditionalDisc).HasColumnName("ADDITIONAL_DISC");
    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(500)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.BuyerMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTML_CODE");
    //        entity.Property(e => e.BuyerMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTS_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.BuyerRemarks).HasColumnName("BUYER_REMARKS");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.ByrSuppLinkid).HasColumnName("BYR_SUPP_LINKID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(3)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.Deliverydays).HasColumnName("DELIVERYDAYS");
    //        entity.Property(e => e.Deliverytime)
    //            .HasColumnType("datetime")
    //            .HasColumnName("DELIVERYTIME");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.DocXml)
    //            .HasMaxLength(5)
    //            .HasColumnName("DOC_XML");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(256)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.Exported).HasColumnName("EXPORTED");
    //        entity.Property(e => e.Freightamt).HasColumnName("FREIGHTAMT");
    //        entity.Property(e => e.GeneralTerms).HasColumnName("GENERAL_TERMS");
    //        entity.Property(e => e.GrossItemTotal).HasColumnName("GROSS_ITEM_TOTAL");
    //        entity.Property(e => e.IsDeclined).HasColumnName("IS_DECLINED");
    //        entity.Property(e => e.Latedate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("LATEDATE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.NetItemTotal).HasColumnName("NET_ITEM_TOTAL");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.Othercosts).HasColumnName("OTHERCOSTS");
    //        entity.Property(e => e.PayTerms).HasColumnName("PAY_TERMS");
    //        entity.Property(e => e.PocReference)
    //            .HasMaxLength(50)
    //            .HasColumnName("POC_REFERENCE");
    //        entity.Property(e => e.Podate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PODATE");
    //        entity.Property(e => e.PortCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("PORT_CODE");
    //        entity.Property(e => e.PortName)
    //            .HasMaxLength(100)
    //            .HasColumnName("PORT_NAME");
    //        entity.Property(e => e.PrintStatus).HasColumnName("PRINT_STATUS");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.QuoteAmount).HasColumnName("QUOTE_AMOUNT");
    //        entity.Property(e => e.QuoteApproveddate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_APPROVEDDATE");
    //        entity.Property(e => e.QuoteDiscount).HasColumnName("QUOTE_DISCOUNT");
    //        entity.Property(e => e.QuoteExchrate).HasColumnName("QUOTE_EXCHRATE");
    //        entity.Property(e => e.QuoteFileRef)
    //            .HasMaxLength(150)
    //            .HasColumnName("QUOTE_FILE_REF");
    //        entity.Property(e => e.QuoteFileStamp)
    //            .HasMaxLength(50)
    //            .HasColumnName("QUOTE_FILE_STAMP");
    //        entity.Property(e => e.QuoteGrossAmt).HasColumnName("QUOTE_GROSS_AMT");
    //        entity.Property(e => e.QuoteNetAmt).HasColumnName("QUOTE_NET_AMT");
    //        entity.Property(e => e.QuoteRecvdDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_RECVD_DATE");
    //        entity.Property(e => e.QuoteReference)
    //            .HasMaxLength(50)
    //            .HasColumnName("QUOTE_REFERENCE");
    //        entity.Property(e => e.QuoteRemarks).HasColumnName("QUOTE_REMARKS");
    //        entity.Property(e => e.QuoteSubject)
    //            .HasMaxLength(1000)
    //            .HasColumnName("QUOTE_SUBJECT");
    //        entity.Property(e => e.QuoteSubmitDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_SUBMIT_DATE");
    //        entity.Property(e => e.QuoteValidity)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_VALIDITY");
    //        entity.Property(e => e.ReplyByDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("REPLY_BY_DATE");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //        entity.Property(e => e.RfqSentDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_SENT_DATE");
    //        entity.Property(e => e.ShipidType)
    //            .HasMaxLength(1)
    //            .IsUnicode(false)
    //            .HasColumnName("SHIPID_TYPE");
    //        entity.Property(e => e.SpMasRemark)
    //            .HasMaxLength(500)
    //            .HasColumnName("SP_MAS_REMARK");
    //        entity.Property(e => e.StatusText)
    //            .HasMaxLength(14)
    //            .IsUnicode(false)
    //            .HasColumnName("STATUS_TEXT");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.SupplierVrno)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_VRNO");
    //        entity.Property(e => e.TaxPercnt).HasColumnName("TAX_PERCNT");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.VendorAddr1).HasColumnName("VENDOR_ADDR1");
    //        entity.Property(e => e.VendorCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("VENDOR_CODE");
    //        entity.Property(e => e.VendorContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("VENDOR_CONTACT");
    //        entity.Property(e => e.VendorCountry)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_COUNTRY");
    //        entity.Property(e => e.VendorEmail)
    //            .HasMaxLength(50)
    //            .HasColumnName("VENDOR_EMAIL");
    //        entity.Property(e => e.VendorFax)
    //            .HasMaxLength(30)
    //            .HasColumnName("VENDOR_FAX");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(500)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //        entity.Property(e => e.VendorMob)
    //            .HasMaxLength(30)
    //            .HasColumnName("VENDOR_MOB");
    //        entity.Property(e => e.VendorMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_MTML_CODE");
    //        entity.Property(e => e.VendorMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_MTS_CODE");
    //        entity.Property(e => e.VendorName)
    //            .HasMaxLength(200)
    //            .HasColumnName("VENDOR_NAME");
    //        entity.Property(e => e.VendorPhone)
    //            .HasMaxLength(30)
    //            .HasColumnName("VENDOR_PHONE");
    //        entity.Property(e => e.VendorStatus).HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.VendorTelex)
    //            .HasMaxLength(30)
    //            .HasColumnName("VENDOR_TELEX");
    //        entity.Property(e => e.Version).HasColumnName("VERSION");
    //        entity.Property(e => e.VesselIdno)
    //            .HasMaxLength(100)
    //            .HasColumnName("VESSEL_IDNO");
    //        entity.Property(e => e.VesselName)
    //            .HasMaxLength(200)
    //            .HasColumnName("VESSEL_NAME");
    //        entity.Property(e => e.VesselOwner)
    //            .HasMaxLength(150)
    //            .HasColumnName("VESSEL_OWNER");
    //        entity.Property(e => e.ViewStatus)
    //            .HasMaxLength(23)
    //            .IsUnicode(false)
    //            .HasColumnName("VIEW_STATUS");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvQuotationsVendorAddress>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_QUOTATIONS_VENDOR_ADDRESS");

    //        entity.Property(e => e.BillAddrType)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("BILL_ADDR_TYPE");
    //        entity.Property(e => e.BillAddress1)
    //            .HasMaxLength(512)
    //            .IsUnicode(false)
    //            .HasColumnName("BILL_ADDRESS1");
    //        entity.Property(e => e.BillAddress2)
    //            .HasMaxLength(512)
    //            .IsUnicode(false)
    //            .HasColumnName("BILL_ADDRESS2");
    //        entity.Property(e => e.BillCity)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BILL_CITY");
    //        entity.Property(e => e.BillContact)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("BILL_CONTACT");
    //        entity.Property(e => e.BillCountry)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BILL_COUNTRY");
    //        entity.Property(e => e.BillEmail)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BILL_EMAIL");
    //        entity.Property(e => e.BillName)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("BILL_NAME");
    //        entity.Property(e => e.BillPhone)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BILL_PHONE");
    //        entity.Property(e => e.BillZipcode)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BILL_ZIPCODE");
    //        entity.Property(e => e.BuyerAddrType)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_ADDR_TYPE");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.BuyerRemarks)
    //            .HasMaxLength(2048)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_REMARKS");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(3)
    //            .IsUnicode(false)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.Deliverytime)
    //            .HasColumnType("datetime")
    //            .HasColumnName("DELIVERYTIME");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(23)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Doctype1)
    //            .HasMaxLength(23)
    //            .IsUnicode(false)
    //            .HasColumnName("DOCTYPE");
    //        entity.Property(e => e.Latedate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("LATEDATE");
    //        entity.Property(e => e.NetItemTotal)
    //            .HasMaxLength(30)
    //            .HasColumnName("NET_ITEM_TOTAL");
    //        entity.Property(e => e.PocReference)
    //            .HasMaxLength(30)
    //            .IsUnicode(false)
    //            .HasColumnName("POC_REFERENCE");
    //        entity.Property(e => e.Podate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PODATE");
    //        entity.Property(e => e.PortName)
    //            .HasMaxLength(100)
    //            .HasColumnName("PORT_NAME");
    //        entity.Property(e => e.Quotationid)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteReference)
    //            .HasMaxLength(30)
    //            .HasColumnName("QUOTE_REFERENCE");
    //        entity.Property(e => e.QuoteRemarks)
    //            .HasColumnType("ntext")
    //            .HasColumnName("QUOTE_REMARKS");
    //        entity.Property(e => e.QuoteSubmitDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_SUBMIT_DATE");
    //        entity.Property(e => e.QuoteValidity)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_VALIDITY");
    //        entity.Property(e => e.ReplyByDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("REPLY_BY_DATE");
    //        entity.Property(e => e.ShipAddrType)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("SHIP_ADDR_TYPE");
    //        entity.Property(e => e.ShipAddress1)
    //            .HasMaxLength(512)
    //            .IsUnicode(false)
    //            .HasColumnName("SHIP_ADDRESS1");
    //        entity.Property(e => e.ShipAddress2)
    //            .HasMaxLength(512)
    //            .IsUnicode(false)
    //            .HasColumnName("SHIP_ADDRESS2");
    //        entity.Property(e => e.ShipCity)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SHIP_CITY");
    //        entity.Property(e => e.ShipContact)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("SHIP_CONTACT");
    //        entity.Property(e => e.ShipCountry)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SHIP_COUNTRY");
    //        entity.Property(e => e.ShipEmail)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SHIP_EMAIL");
    //        entity.Property(e => e.ShipName)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("SHIP_NAME");
    //        entity.Property(e => e.ShipPhone)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SHIP_PHONE");
    //        entity.Property(e => e.ShipZipcode)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SHIP_ZIPCODE");
    //        entity.Property(e => e.VendorStatus).HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.Version).HasColumnName("VERSION");
    //        entity.Property(e => e.VesselName)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VESSEL_NAME");
    //        entity.Property(e => e.VesselOwner)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("VESSEL_OWNER");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvQuotationsVendorInvoice>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_QUOTATIONS_VENDOR_INVOICE");

    //        entity.Property(e => e.AdditionalDisc).HasColumnName("ADDITIONAL_DISC");
    //        entity.Property(e => e.AddrOutbox)
    //            .HasMaxLength(150)
    //            .HasColumnName("ADDR_OUTBOX");
    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("BUYER_CONTACT");
    //        entity.Property(e => e.BuyerEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_EMAIL");
    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.BuyerLinkCode)
    //            .HasMaxLength(500)
    //            .HasColumnName("BUYER_LINK_CODE");
    //        entity.Property(e => e.BuyerMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("BUYER_MAPPING");
    //        entity.Property(e => e.BuyerMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTML_CODE");
    //        entity.Property(e => e.BuyerMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_MTS_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.BuyerRemarks).HasColumnName("BUYER_REMARKS");
    //        entity.Property(e => e.ByrReceiverCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("BYR_RECEIVER_CODE");
    //        entity.Property(e => e.ByrSenderCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("BYR_SENDER_CODE");
    //        entity.Property(e => e.ByrSuppLinkid).HasColumnName("BYR_SUPP_LINKID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(3)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.Deliverydays).HasColumnName("DELIVERYDAYS");
    //        entity.Property(e => e.Deliverytime)
    //            .HasColumnType("datetime")
    //            .HasColumnName("DELIVERYTIME");
    //        entity.Property(e => e.Department)
    //            .HasMaxLength(200)
    //            .HasColumnName("DEPARTMENT");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.DocXml)
    //            .HasMaxLength(5)
    //            .HasColumnName("DOC_XML");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(256)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.Exported).HasColumnName("EXPORTED");
    //        entity.Property(e => e.Freightamt).HasColumnName("FREIGHTAMT");
    //        entity.Property(e => e.GeneralTerms).HasColumnName("GENERAL_TERMS");
    //        entity.Property(e => e.IsDeclined).HasColumnName("IS_DECLINED");
    //        entity.Property(e => e.Latedate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("LATEDATE");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.NotifyBuyer).HasColumnName("NOTIFY_BUYER");
    //        entity.Property(e => e.NotifySupplr).HasColumnName("NOTIFY_SUPPLR");
    //        entity.Property(e => e.OrderType).HasMaxLength(300);
    //        entity.Property(e => e.Othercosts).HasColumnName("OTHERCOSTS");
    //        entity.Property(e => e.PayTerms).HasColumnName("PAY_TERMS");
    //        entity.Property(e => e.PocReference)
    //            .HasMaxLength(50)
    //            .HasColumnName("POC_REFERENCE");
    //        entity.Property(e => e.Podate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PODATE");
    //        entity.Property(e => e.PortCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("PORT_CODE");
    //        entity.Property(e => e.PortName)
    //            .HasMaxLength(100)
    //            .HasColumnName("PORT_NAME");
    //        entity.Property(e => e.PrintStatus).HasColumnName("PRINT_STATUS");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.QuoteAmount).HasColumnName("QUOTE_AMOUNT");
    //        entity.Property(e => e.QuoteApproveddate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_APPROVEDDATE");
    //        entity.Property(e => e.QuoteDiscount).HasColumnName("QUOTE_DISCOUNT");
    //        entity.Property(e => e.QuoteExchrate).HasColumnName("QUOTE_EXCHRATE");
    //        entity.Property(e => e.QuoteFileRef)
    //            .HasMaxLength(150)
    //            .HasColumnName("QUOTE_FILE_REF");
    //        entity.Property(e => e.QuoteFileStamp)
    //            .HasMaxLength(50)
    //            .HasColumnName("QUOTE_FILE_STAMP");
    //        entity.Property(e => e.QuoteRecvdDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_RECVD_DATE");
    //        entity.Property(e => e.QuoteReference)
    //            .HasMaxLength(50)
    //            .HasColumnName("QUOTE_REFERENCE");
    //        entity.Property(e => e.QuoteRemarks).HasColumnName("QUOTE_REMARKS");
    //        entity.Property(e => e.QuoteSubject)
    //            .HasMaxLength(1000)
    //            .HasColumnName("QUOTE_SUBJECT");
    //        entity.Property(e => e.QuoteSubmitDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_SUBMIT_DATE");
    //        entity.Property(e => e.QuoteValidity)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_VALIDITY");
    //        entity.Property(e => e.ReplyByDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("REPLY_BY_DATE");
    //        entity.Property(e => e.RfqExport).HasColumnName("RFQ_EXPORT");
    //        entity.Property(e => e.RfqSentDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_SENT_DATE");
    //        entity.Property(e => e.ShipidType)
    //            .HasMaxLength(1)
    //            .IsUnicode(false)
    //            .HasColumnName("SHIPID_TYPE");
    //        entity.Property(e => e.SpMasRemark)
    //            .HasMaxLength(500)
    //            .HasColumnName("SP_MAS_REMARK");
    //        entity.Property(e => e.StatusText)
    //            .HasMaxLength(14)
    //            .IsUnicode(false)
    //            .HasColumnName("STATUS_TEXT");
    //        entity.Property(e => e.SuppReceiverCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPP_RECEIVER_CODE");
    //        entity.Property(e => e.SuppSenderCode)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPP_SENDER_CODE");
    //        entity.Property(e => e.SupplierMapping)
    //            .HasMaxLength(150)
    //            .HasColumnName("SUPPLIER_MAPPING");
    //        entity.Property(e => e.SupplierVrno)
    //            .HasMaxLength(250)
    //            .HasColumnName("SUPPLIER_VRNO");
    //        entity.Property(e => e.TaxPercnt).HasColumnName("TAX_PERCNT");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.VendorAddr1).HasColumnName("VENDOR_ADDR1");
    //        entity.Property(e => e.VendorCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("VENDOR_CODE");
    //        entity.Property(e => e.VendorContact)
    //            .HasMaxLength(100)
    //            .HasColumnName("VENDOR_CONTACT");
    //        entity.Property(e => e.VendorCountry)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_COUNTRY");
    //        entity.Property(e => e.VendorEmail)
    //            .HasMaxLength(200)
    //            .HasColumnName("VENDOR_EMAIL");
    //        entity.Property(e => e.VendorFax)
    //            .HasMaxLength(30)
    //            .HasColumnName("VENDOR_FAX");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorLinkCode)
    //            .HasMaxLength(500)
    //            .HasColumnName("VENDOR_LINK_CODE");
    //        entity.Property(e => e.VendorMob)
    //            .HasMaxLength(30)
    //            .HasColumnName("VENDOR_MOB");
    //        entity.Property(e => e.VendorMtmlCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_MTML_CODE");
    //        entity.Property(e => e.VendorMtsCode)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_MTS_CODE");
    //        entity.Property(e => e.VendorName)
    //            .HasMaxLength(200)
    //            .HasColumnName("VENDOR_NAME");
    //        entity.Property(e => e.VendorPhone)
    //            .HasMaxLength(30)
    //            .HasColumnName("VENDOR_PHONE");
    //        entity.Property(e => e.VendorStatus).HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.VendorTelex)
    //            .HasMaxLength(30)
    //            .HasColumnName("VENDOR_TELEX");
    //        entity.Property(e => e.Version).HasColumnName("VERSION");
    //        entity.Property(e => e.VesselIdno)
    //            .HasMaxLength(100)
    //            .HasColumnName("VESSEL_IDNO");
    //        entity.Property(e => e.VesselName)
    //            .HasMaxLength(200)
    //            .HasColumnName("VESSEL_NAME");
    //        entity.Property(e => e.VesselOwner)
    //            .HasMaxLength(150)
    //            .HasColumnName("VESSEL_OWNER");
    //        entity.Property(e => e.ViewStatus)
    //            .HasMaxLength(23)
    //            .IsUnicode(false)
    //            .HasColumnName("VIEW_STATUS");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(250)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvQuoteAmountBuyerItem>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_QUOTE_AMOUNT_BUYER_ITEMS");

    //        entity.Property(e => e.GrossItemTotal).HasColumnName("GROSS_ITEM_TOTAL");
    //        entity.Property(e => e.NetItemTotal).HasColumnName("NET_ITEM_TOTAL");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //    });

    //    modelBuilder.Entity<SmvQuoteAmountVendor>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_QUOTE_AMOUNT_VENDOR");

    //        entity.Property(e => e.GrossItemTotal).HasColumnName("GROSS_ITEM_TOTAL");
    //        entity.Property(e => e.NetItemTotal).HasColumnName("NET_ITEM_TOTAL");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //    });

    //    modelBuilder.Entity<SmvQuoteAmountVendorNoAdditionalItem>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_QUOTE_AMOUNT_VENDOR_NO_ADDITIONAL_ITEM");

    //        entity.Property(e => e.GrossItemTotal).HasColumnName("GROSS_ITEM_TOTAL");
    //        entity.Property(e => e.NetItemTotal).HasColumnName("NET_ITEM_TOTAL");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //    });

    //    modelBuilder.Entity<SmvQuoteHeader>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_QUOTE_HEADER");

    //        entity.Property(e => e.DeliveryPort)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("DELIVERY_PORT");
    //        entity.Property(e => e.DocPayloadid)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_PAYLOADID");
    //        entity.Property(e => e.Doctype)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("DOCTYPE");
    //        entity.Property(e => e.FromAdapteruid)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("FROM_ADAPTERUID");
    //        entity.Property(e => e.FromPartyid)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("FROM_PARTYID");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Mxmldocid).HasColumnName("MXMLDOCID");
    //        entity.Property(e => e.Originatingsystemref)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("ORIGINATINGSYSTEMREF");
    //        entity.Property(e => e.Payloadid)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("PAYLOADID");
    //        entity.Property(e => e.PoMessagenumber)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("PO_MESSAGENUMBER");
    //        entity.Property(e => e.PoPayloadid)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("PO_PAYLOADID");
    //        entity.Property(e => e.QuoteDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_DATE");
    //        entity.Property(e => e.QuoteExpiryDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_EXPIRY_DATE");
    //        entity.Property(e => e.Quoteid)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("QUOTEID");
    //        entity.Property(e => e.ReqDeliveryDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("REQ_DELIVERY_DATE");
    //        entity.Property(e => e.ServerTimestamp)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SERVER_TIMESTAMP");
    //        entity.Property(e => e.ToPartyid)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("TO_PARTYID");
    //        entity.Property(e => e.Useragent)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("USERAGENT");
    //        entity.Property(e => e.VesselId)
    //            .HasMaxLength(25)
    //            .IsUnicode(false)
    //            .HasColumnName("VESSEL_ID");
    //        entity.Property(e => e.VesselName)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VESSEL_NAME");
    //    });

    //    modelBuilder.Entity<SmvQuoteHeaderAmount>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_QUOTE_HEADER_AMOUNT");

    //        entity.Property(e => e.AddDiscValue).HasColumnName("ADD_DISC_VALUE");
    //        entity.Property(e => e.AdditionalDisc).HasColumnName("ADDITIONAL_DISC");
    //        entity.Property(e => e.Allowance).HasColumnName("ALLOWANCE");
    //        entity.Property(e => e.Docid)
    //            .HasMaxLength(256)
    //            .IsUnicode(false)
    //            .HasColumnName("DOCID");
    //        entity.Property(e => e.Freightamt).HasColumnName("FREIGHTAMT");
    //        entity.Property(e => e.GrandTotal).HasColumnName("GRAND_TOTAL");
    //        entity.Property(e => e.ItemTotal).HasColumnName("ITEM_TOTAL");
    //        entity.Property(e => e.NetItemTotal).HasColumnName("NET_ITEM_TOTAL");
    //        entity.Property(e => e.OtherCost2).HasColumnName("OTHER_COST2");
    //        entity.Property(e => e.OtherCost3).HasColumnName("OTHER_COST3");
    //        entity.Property(e => e.Othercosts).HasColumnName("OTHERCOSTS");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAmount).HasColumnName("QUOTE_AMOUNT");
    //        entity.Property(e => e.QuoteDiscount).HasColumnName("QUOTE_DISCOUNT");
    //        entity.Property(e => e.TaxPercnt).HasColumnName("TAX_PERCNT");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvQuoteHeaderMtml>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_QUOTE_HEADER_MTML");

    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.ByrSuppLinkid).HasColumnName("BYR_SUPP_LINKID");
    //        entity.Property(e => e.Controlreference)
    //            .HasMaxLength(150)
    //            .HasColumnName("CONTROLREFERENCE");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(3)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.ExportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("EXPORT_PATH");
    //        entity.Property(e => e.Identifier)
    //            .HasMaxLength(10)
    //            .HasColumnName("IDENTIFIER");
    //        entity.Property(e => e.ImportPath)
    //            .HasMaxLength(150)
    //            .HasColumnName("IMPORT_PATH");
    //        entity.Property(e => e.Linecount).HasColumnName("LINECOUNT");
    //        entity.Property(e => e.Linkid).HasColumnName("LINKID");
    //        entity.Property(e => e.Messagenumber)
    //            .HasMaxLength(250)
    //            .HasColumnName("MESSAGENUMBER");
    //        entity.Property(e => e.Messagereferencenumber)
    //            .HasMaxLength(150)
    //            .HasColumnName("MESSAGEREFERENCENUMBER");
    //        entity.Property(e => e.Mtmldocid).HasColumnName("MTMLDOCID");
    //        entity.Property(e => e.Originatingsystemref)
    //            .HasMaxLength(100)
    //            .HasColumnName("ORIGINATINGSYSTEMREF");
    //        entity.Property(e => e.PoAckDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PO_ACK_DATE");
    //        entity.Property(e => e.Preparationdate)
    //            .HasMaxLength(20)
    //            .HasColumnName("PREPARATIONDATE");
    //        entity.Property(e => e.Preparationtime)
    //            .HasMaxLength(20)
    //            .HasColumnName("PREPARATIONTIME");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.QuoteFileRef)
    //            .HasMaxLength(150)
    //            .HasColumnName("QUOTE_FILE_REF");
    //        entity.Property(e => e.Recipeint)
    //            .HasMaxLength(50)
    //            .HasColumnName("RECIPEINT");
    //        entity.Property(e => e.Referencenumber)
    //            .HasMaxLength(50)
    //            .HasColumnName("REFERENCENUMBER");
    //        entity.Property(e => e.RfqAckDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_ACK_DATE");
    //        entity.Property(e => e.Sender)
    //            .HasMaxLength(50)
    //            .HasColumnName("SENDER");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.VendorFormat)
    //            .HasMaxLength(20)
    //            .HasColumnName("VENDOR_FORMAT");
    //        entity.Property(e => e.VendorStatus).HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.Versionnumber)
    //            .HasMaxLength(50)
    //            .HasColumnName("VERSIONNUMBER");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvSmMailDownloadLog>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_SM_MAIL_DOWNLOAD_LOG");

    //        entity.Property(e => e.AuditValue)
    //            .HasMaxLength(500)
    //            .IsUnicode(false);
    //        entity.Property(e => e.BuyerId).HasColumnName("BUYER_ID");
    //        entity.Property(e => e.FromMail)
    //            .HasMaxLength(200)
    //            .IsUnicode(false);
    //        entity.Property(e => e.KeyRef1)
    //            .HasMaxLength(150)
    //            .IsUnicode(false);
    //        entity.Property(e => e.KeyRef2)
    //            .HasMaxLength(150)
    //            .IsUnicode(false);
    //        entity.Property(e => e.LogId)
    //            .ValueGeneratedOnAdd()
    //            .HasColumnName("LogID");
    //        entity.Property(e => e.LogType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false);
    //        entity.Property(e => e.MailSubject)
    //            .HasMaxLength(200)
    //            .IsUnicode(false);
    //        entity.Property(e => e.ModuleName)
    //            .HasMaxLength(50)
    //            .IsUnicode(false);
    //        entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");
    //        entity.Property(e => e.ToMail)
    //            .HasMaxLength(200)
    //            .IsUnicode(false);
    //        entity.Property(e => e.Updatedate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATEDATE");
    //    });

    //    modelBuilder.Entity<SmvTransactionsCreditnote>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_TRANSACTIONS_CREDITNOTE");

    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(3)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Freightamt).HasColumnName("FREIGHTAMT");
    //        entity.Property(e => e.GrnStatus).HasColumnName("GRN_STATUS");
    //        entity.Property(e => e.Invoiceid).HasColumnName("INVOICEID");
    //        entity.Property(e => e.Invoiceno)
    //            .HasMaxLength(50)
    //            .HasColumnName("INVOICENO");
    //        entity.Property(e => e.IsDeclined).HasColumnName("IS_DECLINED");
    //        entity.Property(e => e.Ordertype)
    //            .HasMaxLength(300)
    //            .HasColumnName("ORDERTYPE");
    //        entity.Property(e => e.Othercosts).HasColumnName("OTHERCOSTS");
    //        entity.Property(e => e.PoAckDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PO_ACK_DATE");
    //        entity.Property(e => e.PocDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("POC_DATE");
    //        entity.Property(e => e.PocReference)
    //            .HasMaxLength(50)
    //            .HasColumnName("POC_REFERENCE");
    //        entity.Property(e => e.Podate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PODATE");
    //        entity.Property(e => e.PortName)
    //            .HasMaxLength(100)
    //            .HasColumnName("PORT_NAME");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.QuoteAmount).HasColumnName("QUOTE_AMOUNT");
    //        entity.Property(e => e.QuoteRecvdDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_RECVD_DATE");
    //        entity.Property(e => e.QuoteReference)
    //            .HasMaxLength(50)
    //            .HasColumnName("QUOTE_REFERENCE");
    //        entity.Property(e => e.QuoteValidity)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_VALIDITY");
    //        entity.Property(e => e.RfqAckDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_ACK_DATE");
    //        entity.Property(e => e.Supplierorgref)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIERORGREF");
    //        entity.Property(e => e.Udf1)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF1");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.VendorStatus).HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.Version).HasColumnName("VERSION");
    //        entity.Property(e => e.VesselIdno)
    //            .HasMaxLength(100)
    //            .HasColumnName("VESSEL_IDNO");
    //        entity.Property(e => e.VesselName)
    //            .HasMaxLength(200)
    //            .HasColumnName("VESSEL_NAME");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvTransactionsInvoice>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_TRANSACTIONS_INVOICE");

    //        entity.Property(e => e.BuyerAddressid).HasColumnName("BUYER_ADDRESSID");
    //        entity.Property(e => e.CreatedDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("CREATED_DATE");
    //        entity.Property(e => e.CurrCode)
    //            .HasMaxLength(3)
    //            .HasColumnName("CURR_CODE");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.Freightamt).HasColumnName("FREIGHTAMT");
    //        entity.Property(e => e.GrnStatus).HasColumnName("GRN_STATUS");
    //        entity.Property(e => e.Invoiceid).HasColumnName("INVOICEID");
    //        entity.Property(e => e.Invoiceno)
    //            .HasMaxLength(50)
    //            .HasColumnName("INVOICENO");
    //        entity.Property(e => e.IsDeclined).HasColumnName("IS_DECLINED");
    //        entity.Property(e => e.Ordertype)
    //            .HasMaxLength(300)
    //            .HasColumnName("ORDERTYPE");
    //        entity.Property(e => e.Othercosts).HasColumnName("OTHERCOSTS");
    //        entity.Property(e => e.PoAckDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PO_ACK_DATE");
    //        entity.Property(e => e.PocDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("POC_DATE");
    //        entity.Property(e => e.PocReference)
    //            .HasMaxLength(50)
    //            .HasColumnName("POC_REFERENCE");
    //        entity.Property(e => e.Podate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("PODATE");
    //        entity.Property(e => e.PortName)
    //            .HasMaxLength(100)
    //            .HasColumnName("PORT_NAME");
    //        entity.Property(e => e.Quotationid).HasColumnName("QUOTATIONID");
    //        entity.Property(e => e.QuoteAddressid).HasColumnName("QUOTE_ADDRESSID");
    //        entity.Property(e => e.QuoteAmount).HasColumnName("QUOTE_AMOUNT");
    //        entity.Property(e => e.QuoteRecvdDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_RECVD_DATE");
    //        entity.Property(e => e.QuoteReference)
    //            .HasMaxLength(50)
    //            .HasColumnName("QUOTE_REFERENCE");
    //        entity.Property(e => e.QuoteValidity)
    //            .HasColumnType("datetime")
    //            .HasColumnName("QUOTE_VALIDITY");
    //        entity.Property(e => e.RfqAckDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("RFQ_ACK_DATE");
    //        entity.Property(e => e.Supplierorgref)
    //            .HasMaxLength(50)
    //            .HasColumnName("SUPPLIERORGREF");
    //        entity.Property(e => e.Udf1)
    //            .HasMaxLength(50)
    //            .HasColumnName("UDF1");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.VendorStatus).HasColumnName("VENDOR_STATUS");
    //        entity.Property(e => e.Version).HasColumnName("VERSION");
    //        entity.Property(e => e.VesselIdno)
    //            .HasMaxLength(100)
    //            .HasColumnName("VESSEL_IDNO");
    //        entity.Property(e => e.VesselName)
    //            .HasMaxLength(200)
    //            .HasColumnName("VESSEL_NAME");
    //        entity.Property(e => e.Vrno)
    //            .HasMaxLength(50)
    //            .HasColumnName("VRNO");
    //    });

    //    modelBuilder.Entity<SmvUsertypeModuleAccess>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_USERTYPE_MODULE_ACCESS");

    //        entity.Property(e => e.AccessLevel).HasColumnName("ACCESS_LEVEL");
    //        entity.Property(e => e.ActionName)
    //            .HasMaxLength(50)
    //            .HasColumnName("ACTION_NAME");
    //        entity.Property(e => e.ExUserid).HasColumnName("EX_USERID");
    //        entity.Property(e => e.ExUsername)
    //            .HasMaxLength(50)
    //            .HasColumnName("EX_USERNAME");
    //        entity.Property(e => e.Moduleaccessid).HasColumnName("MODULEACCESSID");
    //        entity.Property(e => e.Moduleid).HasColumnName("MODULEID");
    //        entity.Property(e => e.UsertypeLevel).HasColumnName("USERTYPE_LEVEL");
    //        entity.Property(e => e.Usertypedescr)
    //            .HasMaxLength(50)
    //            .HasColumnName("USERTYPEDESCR");
    //        entity.Property(e => e.Usertypeid).HasColumnName("USERTYPEID");
    //    });

    //    modelBuilder.Entity<SmvVoucherBuyerSupplierGroup>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_VOUCHER_BUYER_SUPPLIER_GROUPS");

    //        entity.Property(e => e.BuyerExportFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_EXPORT_FORMAT");
    //        entity.Property(e => e.BuyerFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("BUYER_FORMAT");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupDesc)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_DESC");
    //        entity.Property(e => e.GroupFlowid).HasColumnName("GROUP_FLOWID");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.Po).HasColumnName("PO");
    //        entity.Property(e => e.PoEndState).HasColumnName("PO_END_STATE");
    //        entity.Property(e => e.Poc).HasColumnName("POC");
    //        entity.Property(e => e.PocEndState).HasColumnName("POC_END_STATE");
    //        entity.Property(e => e.Quote).HasColumnName("QUOTE");
    //        entity.Property(e => e.QuoteEndState).HasColumnName("QUOTE_END_STATE");
    //        entity.Property(e => e.Rfq).HasColumnName("RFQ");
    //        entity.Property(e => e.RfqEndState).HasColumnName("RFQ_END_STATE");
    //        entity.Property(e => e.SupplierExportFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_EXPORT_FORMAT");
    //        entity.Property(e => e.SupplierFormat)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("SUPPLIER_FORMAT");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.Voucher).HasColumnName("VOUCHER");
    //    });

    //    modelBuilder.Entity<SmvXlsMapping>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_XLS_MAPPING");

    //        entity.Property(e => e.ActiveSheet).HasColumnName("ACTIVE_SHEET");
    //        entity.Property(e => e.AddToVrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("ADD_TO_VRNO");
    //        entity.Property(e => e.AltItemCount).HasColumnName("ALT_ITEM_COUNT");
    //        entity.Property(e => e.AltItemStartOffset).HasColumnName("ALT_ITEM_START_OFFSET");
    //        entity.Property(e => e.ApplyTotalFormula).HasColumnName("APPLY_TOTAL_FORMULA");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.BuyerSuppLinkid).HasColumnName("BUYER_SUPP_LINKID");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.CellBillAddr1)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_ADDR1");
    //        entity.Property(e => e.CellBillAddr2)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_ADDR2");
    //        entity.Property(e => e.CellBillCompany)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_COMPANY");
    //        entity.Property(e => e.CellBillContact)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_CONTACT");
    //        entity.Property(e => e.CellBillEmail)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_EMAIL");
    //        entity.Property(e => e.CellBillFax)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_FAX");
    //        entity.Property(e => e.CellBillMob)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_MOB");
    //        entity.Property(e => e.CellBillPhone)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_PHONE");
    //        entity.Property(e => e.CellBuyerRemarks)
    //            .HasMaxLength(15)
    //            .HasColumnName("CELL_BUYER_REMARKS");
    //        entity.Property(e => e.CellByrAddr1)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_ADDR1");
    //        entity.Property(e => e.CellByrAddr2)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_ADDR2");
    //        entity.Property(e => e.CellByrCompany)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_COMPANY");
    //        entity.Property(e => e.CellByrContact)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_CONTACT");
    //        entity.Property(e => e.CellByrEmail)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_EMAIL");
    //        entity.Property(e => e.CellByrFax)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_FAX");
    //        entity.Property(e => e.CellByrMob)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_MOB");
    //        entity.Property(e => e.CellByrPhone)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_PHONE");
    //        entity.Property(e => e.CellContact)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_CONTACT");
    //        entity.Property(e => e.CellCurrCode)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_CURR_CODE");
    //        entity.Property(e => e.CellDelTerms)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_DEL_TERMS");
    //        entity.Property(e => e.CellDiscProvsn)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_DISC_PROVSN");
    //        entity.Property(e => e.CellDocType)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_DOC_TYPE");
    //        entity.Property(e => e.CellEquipDtls)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_EQUIP_DTLS");
    //        entity.Property(e => e.CellEquipMaker)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_EQUIP_MAKER");
    //        entity.Property(e => e.CellEquipName)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_EQUIP_NAME");
    //        entity.Property(e => e.CellEquipSerno)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_EQUIP_SERNO");
    //        entity.Property(e => e.CellEquipType)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_EQUIP_TYPE");
    //        entity.Property(e => e.CellEtaDate)
    //            .HasMaxLength(40)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_ETA_DATE");
    //        entity.Property(e => e.CellEtdDate)
    //            .HasMaxLength(40)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_ETD_DATE");
    //        entity.Property(e => e.CellFreightAmt)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_FREIGHT_AMT");
    //        entity.Property(e => e.CellLateDt)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_LATE_DT");
    //        entity.Property(e => e.CellMsgno)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_MSGNO");
    //        entity.Property(e => e.CellOrderIdentifier)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_ORDER_IDENTIFIER");
    //        entity.Property(e => e.CellOtherAmt)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_OTHER_AMT");
    //        entity.Property(e => e.CellPayTerms)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_PAY_TERMS");
    //        entity.Property(e => e.CellPort)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_PORT");
    //        entity.Property(e => e.CellPortName)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_PORT_NAME");
    //        entity.Property(e => e.CellRfqDept)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_RFQ_DEPT");
    //        entity.Property(e => e.CellRfqDt)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_RFQ_DT");
    //        entity.Property(e => e.CellRfqTitle)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_RFQ_TITLE");
    //        entity.Property(e => e.CellShipAddr1)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_ADDR1");
    //        entity.Property(e => e.CellShipAddr2)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_ADDR2");
    //        entity.Property(e => e.CellShipCompany)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_COMPANY");
    //        entity.Property(e => e.CellShipContact)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_CONTACT");
    //        entity.Property(e => e.CellShipEmail)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_EMAIL");
    //        entity.Property(e => e.CellShipFax)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_FAX");
    //        entity.Property(e => e.CellShipMob)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_MOB");
    //        entity.Property(e => e.CellShipPhone)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_PHONE");
    //        entity.Property(e => e.CellSuplrRemarks)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_SUPLR_REMARKS");
    //        entity.Property(e => e.CellSuppAddr1)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_ADDR1");
    //        entity.Property(e => e.CellSuppAddr2)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_ADDR2");
    //        entity.Property(e => e.CellSuppCompany)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_COMPANY");
    //        entity.Property(e => e.CellSuppContact)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_CONTACT");
    //        entity.Property(e => e.CellSuppEmail)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_EMAIL");
    //        entity.Property(e => e.CellSuppExpDt)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_EXP_DT");
    //        entity.Property(e => e.CellSuppFax)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_FAX");
    //        entity.Property(e => e.CellSuppLateDt)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_LATE_DT");
    //        entity.Property(e => e.CellSuppLeadDays)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_LEAD_DAYS");
    //        entity.Property(e => e.CellSuppMob)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_MOB");
    //        entity.Property(e => e.CellSuppPhone)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_PHONE");
    //        entity.Property(e => e.CellSuppQuoteDt)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_QUOTE_DT");
    //        entity.Property(e => e.CellSuppRef)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_SUPP_REF");
    //        entity.Property(e => e.CellValidUpto)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_VALID_UPTO");
    //        entity.Property(e => e.CellVessel)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_VESSEL");
    //        entity.Property(e => e.CellVrno)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_VRNO");
    //        entity.Property(e => e.CellVslImono)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_VSL_IMONO");
    //        entity.Property(e => e.ColItemAltName)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("COL_ITEM_ALT_NAME");
    //        entity.Property(e => e.ColItemAltPrice)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_ALT_PRICE");
    //        entity.Property(e => e.ColItemAltQty)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_ALT_QTY");
    //        entity.Property(e => e.ColItemAltUnit)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_ALT_UNIT");
    //        entity.Property(e => e.ColItemBuyerRemarks)
    //            .HasMaxLength(20)
    //            .HasColumnName("COL_ITEM_BUYER_REMARKS");
    //        entity.Property(e => e.ColItemByrRemark)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("COL_ITEM_BYR_REMARK");
    //        entity.Property(e => e.ColItemComments)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("COL_ITEM_COMMENTS");
    //        entity.Property(e => e.ColItemCurr)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_CURR");
    //        entity.Property(e => e.ColItemDelDays)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_DEL_DAYS");
    //        entity.Property(e => e.ColItemDiscount)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_DISCOUNT");
    //        entity.Property(e => e.ColItemName)
    //            .HasMaxLength(20)
    //            .HasColumnName("COL_ITEM_NAME");
    //        entity.Property(e => e.ColItemPrice)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_PRICE");
    //        entity.Property(e => e.ColItemQty)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_QTY");
    //        entity.Property(e => e.ColItemRefno)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_REFNO");
    //        entity.Property(e => e.ColItemRemarks)
    //            .HasMaxLength(20)
    //            .HasColumnName("COL_ITEM_REMARKS");
    //        entity.Property(e => e.ColItemSuppRefno)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("COL_ITEM_SUPP_REFNO");
    //        entity.Property(e => e.ColItemTotal)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_TOTAL");
    //        entity.Property(e => e.ColItemUnit)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_UNIT");
    //        entity.Property(e => e.ColItemno)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEMNO");
    //        entity.Property(e => e.ColSection)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_SECTION");
    //        entity.Property(e => e.CompanyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("COMPANY_NAME");
    //        entity.Property(e => e.DecimalSeparator)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("DECIMAL_SEPARATOR");
    //        entity.Property(e => e.DefaultUom)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("DEFAULT_UOM");
    //        entity.Property(e => e.DiscProvsnValue)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("DISC_PROVSN_VALUE");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.DynByrRmrkOffset).HasColumnName("DYN_BYR_RMRK_OFFSET");
    //        entity.Property(e => e.DynHdrDiscountOffset).HasColumnName("DYN_HDR_DISCOUNT_OFFSET");
    //        entity.Property(e => e.DynOthercostOffset).HasColumnName("DYN_OTHERCOST_OFFSET");
    //        entity.Property(e => e.DynSupCurrOffset).HasColumnName("DYN_SUP_CURR_OFFSET");
    //        entity.Property(e => e.DynSupFreightOffset).HasColumnName("DYN_SUP_FREIGHT_OFFSET");
    //        entity.Property(e => e.DynSupRmrkOffset).HasColumnName("DYN_SUP_RMRK_OFFSET");
    //        entity.Property(e => e.ExcelMapid).HasColumnName("EXCEL_MAPID");
    //        entity.Property(e => e.ExcelNameManager)
    //            .HasMaxLength(500)
    //            .IsUnicode(false)
    //            .HasColumnName("EXCEL_NAME_MANAGER");
    //        entity.Property(e => e.ExitForNoitem).HasColumnName("EXIT_FOR_NOITEM");
    //        entity.Property(e => e.GroupCode)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("GROUP_CODE");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ItemDiscPercnt).HasColumnName("ITEM_DISC_PERCNT");
    //        entity.Property(e => e.ItemNoAsRowno).HasColumnName("ITEM_NO_AS_ROWNO");
    //        entity.Property(e => e.ItemRowStart).HasColumnName("ITEM_ROW_START");
    //        entity.Property(e => e.MapCell1)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("MAP_CELL1");
    //        entity.Property(e => e.MapCell1Val1)
    //            .HasMaxLength(150)
    //            .HasColumnName("MAP_CELL1_VAL1");
    //        entity.Property(e => e.MapCell1Val2)
    //            .HasMaxLength(150)
    //            .HasColumnName("MAP_CELL1_VAL2");
    //        entity.Property(e => e.MapCell2)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("MAP_CELL2");
    //        entity.Property(e => e.MapCell2Val)
    //            .HasMaxLength(150)
    //            .HasColumnName("MAP_CELL2_VAL");
    //        entity.Property(e => e.MapCellNodisc)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("MAP_CELL_NODISC");
    //        entity.Property(e => e.MapCellNodiscVal)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("MAP_CELL_NODISC_VAL");
    //        entity.Property(e => e.MultilineItemDescr).HasColumnName("MULTILINE_ITEM_DESCR");
    //        entity.Property(e => e.OverrideAltQty).HasColumnName("OVERRIDE_ALT_QTY");
    //        entity.Property(e => e.ReadItemRemarksUptoNo).HasColumnName("READ_ITEM_REMARKS_UPTO_NO");
    //        entity.Property(e => e.RemoveFromVesselName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("REMOVE_FROM_VESSEL_NAME");
    //        entity.Property(e => e.RemoveFromVrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("REMOVE_FROM_VRNO");
    //        entity.Property(e => e.SampleFile)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SAMPLE_FILE");
    //        entity.Property(e => e.SectionRowStart).HasColumnName("SECTION_ROW_START");
    //        entity.Property(e => e.SkipHiddenRows).HasColumnName("SKIP_HIDDEN_ROWS");
    //        entity.Property(e => e.SkipRowsAftItem).HasColumnName("SKIP_ROWS_AFT_ITEM");
    //        entity.Property(e => e.SkipRowsAftSection).HasColumnName("SKIP_ROWS_AFT_SECTION");
    //        entity.Property(e => e.SkipRowsBefItem).HasColumnName("SKIP_ROWS_BEF_ITEM");
    //        entity.Property(e => e.SupplierCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("SUPPLIER_CODE");
    //        entity.Property(e => e.SupplierName)
    //            .HasMaxLength(200)
    //            .HasColumnName("SUPPLIER_NAME");
    //        entity.Property(e => e.Supplierid).HasColumnName("SUPPLIERID");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.XlsBuyerMapid).HasColumnName("XLS_BUYER_MAPID");
    //        entity.Property(e => e.XlsMapCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("XLS_MAP_CODE");
    //        entity.Property(e => e.XlsSampleFile)
    //            .HasMaxLength(250)
    //            .HasColumnName("XLS_SAMPLE_FILE");
    //    });

    //    modelBuilder.Entity<SmvXlsMappingNew>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToView("SMV_XLS_MAPPING_NEW");

    //        entity.Property(e => e.ActiveSheet).HasColumnName("ACTIVE_SHEET");
    //        entity.Property(e => e.AddToVrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("ADD_TO_VRNO");
    //        entity.Property(e => e.AltItemCount).HasColumnName("ALT_ITEM_COUNT");
    //        entity.Property(e => e.AltItemStartOffset).HasColumnName("ALT_ITEM_START_OFFSET");
    //        entity.Property(e => e.ApplyTotalFormula).HasColumnName("APPLY_TOTAL_FORMULA");
    //        entity.Property(e => e.BuyerCode)
    //            .HasMaxLength(15)
    //            .HasColumnName("BUYER_CODE");
    //        entity.Property(e => e.BuyerName)
    //            .HasMaxLength(200)
    //            .HasColumnName("BUYER_NAME");
    //        entity.Property(e => e.BuyerSuppLinkid).HasColumnName("BUYER_SUPP_LINKID");
    //        entity.Property(e => e.Buyerid).HasColumnName("BUYERID");
    //        entity.Property(e => e.CellBillAddr1)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_ADDR1");
    //        entity.Property(e => e.CellBillAddr2)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_ADDR2");
    //        entity.Property(e => e.CellBillCompany)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_COMPANY");
    //        entity.Property(e => e.CellBillContact)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_CONTACT");
    //        entity.Property(e => e.CellBillEmail)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_EMAIL");
    //        entity.Property(e => e.CellBillFax)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_FAX");
    //        entity.Property(e => e.CellBillMob)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_MOB");
    //        entity.Property(e => e.CellBillPhone)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BILL_PHONE");
    //        entity.Property(e => e.CellBuyerRemarks)
    //            .HasMaxLength(15)
    //            .HasColumnName("CELL_BUYER_REMARKS");
    //        entity.Property(e => e.CellByrAddr1)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_ADDR1");
    //        entity.Property(e => e.CellByrAddr2)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_ADDR2");
    //        entity.Property(e => e.CellByrCompany)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_COMPANY");
    //        entity.Property(e => e.CellByrContact)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_CONTACT");
    //        entity.Property(e => e.CellByrEmail)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_EMAIL");
    //        entity.Property(e => e.CellByrFax)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_FAX");
    //        entity.Property(e => e.CellByrMob)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_MOB");
    //        entity.Property(e => e.CellByrPhone)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_BYR_PHONE");
    //        entity.Property(e => e.CellContact)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_CONTACT");
    //        entity.Property(e => e.CellCurrCode)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_CURR_CODE");
    //        entity.Property(e => e.CellDelTerms)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_DEL_TERMS");
    //        entity.Property(e => e.CellDiscProvsn)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_DISC_PROVSN");
    //        entity.Property(e => e.CellDocType)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_DOC_TYPE");
    //        entity.Property(e => e.CellEquipDtls)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_EQUIP_DTLS");
    //        entity.Property(e => e.CellEquipMaker)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_EQUIP_MAKER");
    //        entity.Property(e => e.CellEquipName)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_EQUIP_NAME");
    //        entity.Property(e => e.CellEquipSerno)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_EQUIP_SERNO");
    //        entity.Property(e => e.CellEquipType)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_EQUIP_TYPE");
    //        entity.Property(e => e.CellEtaDate)
    //            .HasMaxLength(40)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_ETA_DATE");
    //        entity.Property(e => e.CellEtdDate)
    //            .HasMaxLength(40)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_ETD_DATE");
    //        entity.Property(e => e.CellFreightAmt)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_FREIGHT_AMT");
    //        entity.Property(e => e.CellLateDt)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_LATE_DT");
    //        entity.Property(e => e.CellMsgno)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_MSGNO");
    //        entity.Property(e => e.CellOrderIdentifier)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_ORDER_IDENTIFIER");
    //        entity.Property(e => e.CellOtherAmt)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_OTHER_AMT");
    //        entity.Property(e => e.CellPayTerms)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_PAY_TERMS");
    //        entity.Property(e => e.CellPort)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_PORT");
    //        entity.Property(e => e.CellPortName)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_PORT_NAME");
    //        entity.Property(e => e.CellRfqDept)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_RFQ_DEPT");
    //        entity.Property(e => e.CellRfqDt)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_RFQ_DT");
    //        entity.Property(e => e.CellRfqTitle)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_RFQ_TITLE");
    //        entity.Property(e => e.CellShipAddr1)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_ADDR1");
    //        entity.Property(e => e.CellShipAddr2)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_ADDR2");
    //        entity.Property(e => e.CellShipCompany)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_COMPANY");
    //        entity.Property(e => e.CellShipContact)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_CONTACT");
    //        entity.Property(e => e.CellShipEmail)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_EMAIL");
    //        entity.Property(e => e.CellShipFax)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_FAX");
    //        entity.Property(e => e.CellShipMob)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_MOB");
    //        entity.Property(e => e.CellShipPhone)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SHIP_PHONE");
    //        entity.Property(e => e.CellSuplrRemarks)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_SUPLR_REMARKS");
    //        entity.Property(e => e.CellSuppAddr1)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_ADDR1");
    //        entity.Property(e => e.CellSuppAddr2)
    //            .HasMaxLength(15)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_ADDR2");
    //        entity.Property(e => e.CellSuppCompany)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_COMPANY");
    //        entity.Property(e => e.CellSuppContact)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_CONTACT");
    //        entity.Property(e => e.CellSuppEmail)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_EMAIL");
    //        entity.Property(e => e.CellSuppExpDt)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_EXP_DT");
    //        entity.Property(e => e.CellSuppFax)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_FAX");
    //        entity.Property(e => e.CellSuppLateDt)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_LATE_DT");
    //        entity.Property(e => e.CellSuppLeadDays)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_LEAD_DAYS");
    //        entity.Property(e => e.CellSuppMob)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_MOB");
    //        entity.Property(e => e.CellSuppPhone)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_PHONE");
    //        entity.Property(e => e.CellSuppQuoteDt)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_SUPP_QUOTE_DT");
    //        entity.Property(e => e.CellSuppRef)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_SUPP_REF");
    //        entity.Property(e => e.CellValidUpto)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_VALID_UPTO");
    //        entity.Property(e => e.CellVessel)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("CELL_VESSEL");
    //        entity.Property(e => e.CellVrno)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_VRNO");
    //        entity.Property(e => e.CellVslImono)
    //            .HasMaxLength(5)
    //            .HasColumnName("CELL_VSL_IMONO");
    //        entity.Property(e => e.ColItemAltName)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("COL_ITEM_ALT_NAME");
    //        entity.Property(e => e.ColItemAltPrice)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_ALT_PRICE");
    //        entity.Property(e => e.ColItemAltQty)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_ALT_QTY");
    //        entity.Property(e => e.ColItemAltUnit)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_ALT_UNIT");
    //        entity.Property(e => e.ColItemBuyerRemarks)
    //            .HasMaxLength(20)
    //            .HasColumnName("COL_ITEM_BUYER_REMARKS");
    //        entity.Property(e => e.ColItemByrRemark)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("COL_ITEM_BYR_REMARK");
    //        entity.Property(e => e.ColItemComments)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("COL_ITEM_COMMENTS");
    //        entity.Property(e => e.ColItemCurr)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_CURR");
    //        entity.Property(e => e.ColItemDelDays)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_DEL_DAYS");
    //        entity.Property(e => e.ColItemDiscount)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_DISCOUNT");
    //        entity.Property(e => e.ColItemName)
    //            .HasMaxLength(20)
    //            .HasColumnName("COL_ITEM_NAME");
    //        entity.Property(e => e.ColItemPrice)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_PRICE");
    //        entity.Property(e => e.ColItemQty)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_QTY");
    //        entity.Property(e => e.ColItemRefno)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_REFNO");
    //        entity.Property(e => e.ColItemRemarks)
    //            .HasMaxLength(20)
    //            .HasColumnName("COL_ITEM_REMARKS");
    //        entity.Property(e => e.ColItemSuppRefno)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("COL_ITEM_SUPP_REFNO");
    //        entity.Property(e => e.ColItemTotal)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_TOTAL");
    //        entity.Property(e => e.ColItemUnit)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEM_UNIT");
    //        entity.Property(e => e.ColItemno)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_ITEMNO");
    //        entity.Property(e => e.ColSection)
    //            .HasMaxLength(5)
    //            .HasColumnName("COL_SECTION");
    //        entity.Property(e => e.CompanyName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("COMPANY_NAME");
    //        entity.Property(e => e.DecimalSeparator)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("DECIMAL_SEPARATOR");
    //        entity.Property(e => e.DefaultUom)
    //            .HasMaxLength(20)
    //            .IsUnicode(false)
    //            .HasColumnName("DEFAULT_UOM");
    //        entity.Property(e => e.DiscProvsnValue)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("DISC_PROVSN_VALUE");
    //        entity.Property(e => e.DocType)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("DOC_TYPE");
    //        entity.Property(e => e.DynByrRmrkOffset).HasColumnName("DYN_BYR_RMRK_OFFSET");
    //        entity.Property(e => e.DynHdrDiscountOffset).HasColumnName("DYN_HDR_DISCOUNT_OFFSET");
    //        entity.Property(e => e.DynOthercostOffset).HasColumnName("DYN_OTHERCOST_OFFSET");
    //        entity.Property(e => e.DynSupCurrOffset).HasColumnName("DYN_SUP_CURR_OFFSET");
    //        entity.Property(e => e.DynSupFreightOffset).HasColumnName("DYN_SUP_FREIGHT_OFFSET");
    //        entity.Property(e => e.DynSupRmrkOffset).HasColumnName("DYN_SUP_RMRK_OFFSET");
    //        entity.Property(e => e.ExcelMapid).HasColumnName("EXCEL_MAPID");
    //        entity.Property(e => e.ExcelNameManager)
    //            .HasMaxLength(500)
    //            .IsUnicode(false)
    //            .HasColumnName("EXCEL_NAME_MANAGER");
    //        entity.Property(e => e.ExitForNoitem).HasColumnName("EXIT_FOR_NOITEM");
    //        entity.Property(e => e.FormatMapCode)
    //            .HasMaxLength(150)
    //            .HasColumnName("FORMAT_MAP_CODE");
    //        entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
    //        entity.Property(e => e.ItemDiscPercnt).HasColumnName("ITEM_DISC_PERCNT");
    //        entity.Property(e => e.ItemNoAsRowno).HasColumnName("ITEM_NO_AS_ROWNO");
    //        entity.Property(e => e.ItemRowStart).HasColumnName("ITEM_ROW_START");
    //        entity.Property(e => e.MapCell1)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("MAP_CELL1");
    //        entity.Property(e => e.MapCell1Val1)
    //            .HasMaxLength(150)
    //            .HasColumnName("MAP_CELL1_VAL1");
    //        entity.Property(e => e.MapCell1Val2)
    //            .HasMaxLength(150)
    //            .HasColumnName("MAP_CELL1_VAL2");
    //        entity.Property(e => e.MapCell2)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("MAP_CELL2");
    //        entity.Property(e => e.MapCell2Val)
    //            .HasMaxLength(150)
    //            .HasColumnName("MAP_CELL2_VAL");
    //        entity.Property(e => e.MapCellNodisc)
    //            .HasMaxLength(5)
    //            .IsUnicode(false)
    //            .HasColumnName("MAP_CELL_NODISC");
    //        entity.Property(e => e.MapCellNodiscVal)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("MAP_CELL_NODISC_VAL");
    //        entity.Property(e => e.MultilineItemDescr).HasColumnName("MULTILINE_ITEM_DESCR");
    //        entity.Property(e => e.OverrideAltQty).HasColumnName("OVERRIDE_ALT_QTY");
    //        entity.Property(e => e.ReadItemRemarksUptoNo).HasColumnName("READ_ITEM_REMARKS_UPTO_NO");
    //        entity.Property(e => e.RemoveFromVesselName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("REMOVE_FROM_VESSEL_NAME");
    //        entity.Property(e => e.RemoveFromVrno)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("REMOVE_FROM_VRNO");
    //        entity.Property(e => e.SampleFile)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("SAMPLE_FILE");
    //        entity.Property(e => e.SectionRowStart).HasColumnName("SECTION_ROW_START");
    //        entity.Property(e => e.SkipHiddenRows).HasColumnName("SKIP_HIDDEN_ROWS");
    //        entity.Property(e => e.SkipRowsAftItem).HasColumnName("SKIP_ROWS_AFT_ITEM");
    //        entity.Property(e => e.SkipRowsAftSection).HasColumnName("SKIP_ROWS_AFT_SECTION");
    //        entity.Property(e => e.SkipRowsBefItem).HasColumnName("SKIP_ROWS_BEF_ITEM");
    //        entity.Property(e => e.UpdateDate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("UPDATE_DATE");
    //        entity.Property(e => e.XlsBuyerMapid).HasColumnName("XLS_BUYER_MAPID");
    //        entity.Property(e => e.XlsMapCode)
    //            .HasMaxLength(50)
    //            .HasColumnName("XLS_MAP_CODE");
    //    });

    //    OnModelCreatingPartial(modelBuilder);
    //}

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
