using System.Text.Json.Serialization;

namespace AliExpress.UnAuth.API
{
    public class AbTestComponent
    {
        [JsonPropertyName("detailNewVersion")]
        public int? DetailNewVersion { get; set; }

        [JsonPropertyName("openDescHover")]
        public bool? OpenDescHover { get; set; }

        [JsonPropertyName("hideCustomerService")]
        public bool? HideCustomerService { get; set; }

        [JsonPropertyName("rmStoreLevelAB")]
        public bool? RmStoreLevelAB { get; set; }
    }

    public class ActionConfs
    {
        [JsonPropertyName("buyNowBtn")]
        public BuyNowBtn BuyNowBtn { get; set; }

        [JsonPropertyName("message")]
        public Message Message { get; set; }
    }

    public class ActionModule
    {
        [JsonPropertyName("VIEW_DETAIL")]
        public string VIEWDETAIL { get; set; }

        [JsonPropertyName("WISH_MAX_NOTICE")]
        public string WISHMAXNOTICE { get; set; }

        [JsonPropertyName("BUYER_ABLE")]
        public string BUYERABLE { get; set; }

        [JsonPropertyName("WISHLIST_SAVE_BUTTON")]
        public string WISHLISTSAVEBUTTON { get; set; }

        [JsonPropertyName("WISH_MOVE_TO_ANOTHER_LIST_TIPS")]
        public string WISHMOVETOANOTHERLISTTIPS { get; set; }

        [JsonPropertyName("ADD_X_MORE")]
        public string ADDXMORE { get; set; }

        [JsonPropertyName("COMING_SOON")]
        public string COMINGSOON { get; set; }

        [JsonPropertyName("SC_ADD_SUCC")]
        public string SCADDSUCC { get; set; }

        [JsonPropertyName("WISHLIST_PUBLIC_NOTICE")]
        public string WISHLISTPUBLICNOTICE { get; set; }

        [JsonPropertyName("WISH_DETAULT_LIST")]
        public string WISHDETAULTLIST { get; set; }

        [JsonPropertyName("WISH_CREATE_LIST")]
        public string WISHCREATELIST { get; set; }

        [JsonPropertyName("WL_ERROR")]
        public string WLERROR { get; set; }

        [JsonPropertyName("WISH_NAME_ALREADY_USE")]
        public string WISHNAMEALREADYUSE { get; set; }

        [JsonPropertyName("WISH_REVISELIST")]
        public string WISHREVISELIST { get; set; }

        [JsonPropertyName("ADD_TO_MY_PICKS")]
        public string ADDTOMYPICKS { get; set; }

        [JsonPropertyName("SC_ADD_FAILED")]
        public string SCADDFAILED { get; set; }

        [JsonPropertyName("SC_HAVE")]
        public string SCHAVE { get; set; }

        [JsonPropertyName("ADD_TO_CART")]
        public string ADDTOCART { get; set; }

        [JsonPropertyName("WISH_CANCEL_WISHLIST")]
        public string WISHCANCELWISHLIST { get; set; }

        [JsonPropertyName("BUY_NOW")]
        public string BUYNOW { get; set; }

        [JsonPropertyName("WISH_SYSTEM_ERROR")]
        public string WISHSYSTEMERROR { get; set; }

        [JsonPropertyName("SC_ADD_MAX")]
        public string SCADDMAX { get; set; }

        [JsonPropertyName("SC_VIEW")]
        public string SCVIEW { get; set; }

        [JsonPropertyName("WISH_YOUMAYLIKE")]
        public string WISHYOUMAYLIKE { get; set; }

        [JsonPropertyName("WISH_VIEW_WISH_LIST")]
        public string WISHVIEWWISHLIST { get; set; }

        [JsonPropertyName("SC_RECOMMEND")]
        public string SCRECOMMEND { get; set; }

        [JsonPropertyName("CONTINUE")]
        public string CONTINUE { get; set; }

        [JsonPropertyName("ADDED_TO")]
        public string ADDEDTO { get; set; }

        [JsonPropertyName("ORDER_NOW")]
        public string ORDERNOW { get; set; }

        [JsonPropertyName("SELECT_TIP")]
        public string SELECTTIP { get; set; }

        [JsonPropertyName("NO_LONGER_AVAILABLE")]
        public string NOLONGERAVAILABLE { get; set; }

        [JsonPropertyName("PREVIEW_PERIOD")]
        public string PREVIEWPERIOD { get; set; }

        [JsonPropertyName("WISH_MAX_GROUP")]
        public string WISHMAXGROUP { get; set; }

        [JsonPropertyName("FIND_SIMILAR")]
        public string FINDSIMILAR { get; set; }

        [JsonPropertyName("WISHLIST_PUBLIC_TIP")]
        public string WISHLISTPUBLICTIP { get; set; }
    }

    public class AdditionLayout
    {
        [JsonPropertyName("displayCondition")]
        public string DisplayCondition { get; set; }

        [JsonPropertyName("componentId")]
        public string ComponentId { get; set; }

        [JsonPropertyName("distance")]
        public int? Distance { get; set; }

        [JsonPropertyName("blockType")]
        public string BlockType { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("blockGroup")]
        public string BlockGroup { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("useInDeliveryOptionPanel")]
        public bool? UseInDeliveryOptionPanel { get; set; }

        [JsonPropertyName("useInDetailFirstScreen")]
        public bool? UseInDetailFirstScreen { get; set; }

        [JsonPropertyName("medusaKey")]
        public string MedusaKey { get; set; }

        [JsonPropertyName("useInSkuSwitch")]
        public bool? UseInSkuSwitch { get; set; }

        [JsonPropertyName("order")]
        public int? Order { get; set; }
    }

    public class AssuranceComponent
    {
        [JsonPropertyName("assuranceDetails")]
        public AssuranceDetails AssuranceDetails { get; set; }
    }

    public class AssuranceDetails
    {
        [JsonPropertyName("details")]
        public List<Detail> Details { get; set; }

        [JsonPropertyName("actionTarget")]
        public string ActionTarget { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }

    public class Background
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class BannerComponent
    {
        [JsonPropertyName("promotionBannerInfo")]
        public PromotionBannerInfo PromotionBannerInfo { get; set; }

        [JsonPropertyName("bannerType")]
        public string BannerType { get; set; }
    }

    public class BannerInfo
    {
        [JsonPropertyName("promotionBanner")]
        public PromotionBanner PromotionBanner { get; set; }
    }

    public class BizData
    {
        [JsonPropertyName("patternId")]
        public int? PatternId { get; set; }

        [JsonPropertyName("logisticsComposeThreshold")]
        public string LogisticsComposeThreshold { get; set; }

        [JsonPropertyName("discount")]
        public double? Discount { get; set; }

        [JsonPropertyName("tracking")]
        public string Tracking { get; set; }

        [JsonPropertyName("workDayOneFourBeforeCutTime")]
        public string WorkDayOneFourBeforeCutTime { get; set; }

        [JsonPropertyName("delayCompensationTime")]
        public string DelayCompensationTime { get; set; }

        [JsonPropertyName("displayTomorrow")]
        public string DisplayTomorrow { get; set; }

        [JsonPropertyName("itemScene")]
        public string ItemScene { get; set; }

        [JsonPropertyName("shipToCode")]
        public string ShipToCode { get; set; }

        [JsonPropertyName("thresholdOverZero")]
        public string ThresholdOverZero { get; set; }

        [JsonPropertyName("delayCompensationOriginalCurrency")]
        public string DelayCompensationOriginalCurrency { get; set; }

        [JsonPropertyName("delayCompensationOriginalAmount")]
        public int? DelayCompensationOriginalAmount { get; set; }

        [JsonPropertyName("shipFrom")]
        public string ShipFrom { get; set; }

        [JsonPropertyName("deliveryDayMax")]
        public int? DeliveryDayMax { get; set; }

        [JsonPropertyName("displayEtaMinDate")]
        public string DisplayEtaMinDate { get; set; }

        [JsonPropertyName("guaranteedDeliveryTime")]
        public int? GuaranteedDeliveryTime { get; set; }

        [JsonPropertyName("etaVersionDisplayType")]
        public string EtaVersionDisplayType { get; set; }

        [JsonPropertyName("freightCommitDay")]
        public string FreightCommitDay { get; set; }

        [JsonPropertyName("etaTraceId")]
        public string EtaTraceId { get; set; }

        [JsonPropertyName("delayCompensationAmountDisplay")]
        public string DelayCompensationAmountDisplay { get; set; }

        [JsonPropertyName("etaVersionStrategyId")]
        public int? EtaVersionStrategyId { get; set; }

        [JsonPropertyName("workDayOneFiveBeforeCutTime")]
        public string WorkDayOneFiveBeforeCutTime { get; set; }

        [JsonPropertyName("delayCompensationType")]
        public string DelayCompensationType { get; set; }

        [JsonPropertyName("itemId")]
        public long? ItemId { get; set; }

        [JsonPropertyName("solutionBusinessType")]
        public string SolutionBusinessType { get; set; }

        [JsonPropertyName("etaVersionSceneId")]
        public int? EtaVersionSceneId { get; set; }

        [JsonPropertyName("displayAmount")]
        public double? DisplayAmount { get; set; }

        [JsonPropertyName("shippingFee")]
        public string ShippingFee { get; set; }

        [JsonPropertyName("displayEtaMaxDate")]
        public string DisplayEtaMaxDate { get; set; }

        [JsonPropertyName("deliveryDayMin")]
        public int? DeliveryDayMin { get; set; }

        [JsonPropertyName("delayCompensationMode")]
        public string DelayCompensationMode { get; set; }

        [JsonPropertyName("warehouseType")]
        public string WarehouseType { get; set; }

        [JsonPropertyName("solutionId")]
        public int? SolutionId { get; set; }

        [JsonPropertyName("deliveryOptionCode")]
        public string DeliveryOptionCode { get; set; }

        [JsonPropertyName("leadTimeSort")]
        public List<int?> LeadTimeSort { get; set; }

        [JsonPropertyName("deliveryProviderName")]
        public string DeliveryProviderName { get; set; }

        [JsonPropertyName("subWarehouseType")]
        public string SubWarehouseType { get; set; }

        [JsonPropertyName("utParams")]
        public string UtParams { get; set; }

        [JsonPropertyName("warehouseCode")]
        public string WarehouseCode { get; set; }

        [JsonPropertyName("existEtaMinTime")]
        public string ExistEtaMinTime { get; set; }

        [JsonPropertyName("provider")]
        public string Provider { get; set; }

        [JsonPropertyName("itemShipFromType")]
        public string ItemShipFromType { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("company")]
        public string Company { get; set; }

        [JsonPropertyName("deliveryDate")]
        public string DeliveryDate { get; set; }

        [JsonPropertyName("formattedAmount")]
        public string FormattedAmount { get; set; }

        [JsonPropertyName("passiveDelayCompensationDelayDisplay")]
        public string PassiveDelayCompensationDelayDisplay { get; set; }

        [JsonPropertyName("choiceFreeShipping")]
        public string ChoiceFreeShipping { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("leadTimeType")]
        public string LeadTimeType { get; set; }

        [JsonPropertyName("existEtaMaxTime")]
        public string ExistEtaMaxTime { get; set; }

        [JsonPropertyName("solutionBusinessXDays")]
        public int? SolutionBusinessXDays { get; set; }

        [JsonPropertyName("guaranteedDeliveryTimeProviderName")]
        public string GuaranteedDeliveryTimeProviderName { get; set; }

        [JsonPropertyName("showXDayDeliveryTips")]
        public string ShowXDayDeliveryTips { get; set; }

        [JsonPropertyName("shipFromCode")]
        public string ShipFromCode { get; set; }

        [JsonPropertyName("displayCurrency")]
        public string DisplayCurrency { get; set; }

        [JsonPropertyName("deliveryProviderCode")]
        public string DeliveryProviderCode { get; set; }

        [JsonPropertyName("shipTo")]
        public string ShipTo { get; set; }
    }

    public class BlacklistComponent
    {
        [JsonPropertyName("inBlackList")]
        public bool? InBlackList { get; set; }
    }

    public class BlockIcon
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class BpDomesticReturn7
    {
        [JsonPropertyName("brief")]
        public string Brief { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("desc")]
        public string Desc { get; set; }
    }

    public class BpFreeReturn30
    {
        [JsonPropertyName("brief")]
        public string Brief { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("desc")]
        public string Desc { get; set; }
    }

    public class BpLocalDomesticReturn
    {
        [JsonPropertyName("brief")]
        public string Brief { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("desc")]
        public string Desc { get; set; }
    }

    public class BpLocalReturn15
    {
        [JsonPropertyName("brief")]
        public string Brief { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("desc")]
        public string Desc { get; set; }
    }

    public class BpSpainFreeReturn
    {
        [JsonPropertyName("brief")]
        public string Brief { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("desc")]
        public string Desc { get; set; }
    }

    public class BreadcrumbComponent
    {
        [JsonPropertyName("categoryUrl")]
        public string CategoryUrl { get; set; }

        [JsonPropertyName("pathList")]
        public List<PathList> PathList { get; set; }

        [JsonPropertyName("categoryName")]
        public string CategoryName { get; set; }
    }

    public class BuriedLogComponent
    {
        [JsonPropertyName("buriedData")]
        public string BuriedData { get; set; }

        [JsonPropertyName("priceCenterBuriedData")]
        public string PriceCenterBuriedData { get; set; }

        [JsonPropertyName("choice3")]
        public bool? Choice3 { get; set; }
    }

    public class BuyerComponent
    {
        [JsonPropertyName("adultCertificationStatus")]
        public int? AdultCertificationStatus { get; set; }
    }

    public class BuyerProtection
    {
        [JsonPropertyName("brief")]
        public string Brief { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("desc")]
        public string Desc { get; set; }
    }

    public class BuyerProtectionModule
    {
        [JsonPropertyName("PLAZA_BUYER_PROTECTION_TIP")]
        public string PLAZABUYERPROTECTIONTIP { get; set; }

        [JsonPropertyName("PLAZA_BUYER_PROTECTION_TITLE")]
        public string PLAZABUYERPROTECTIONTITLE { get; set; }

        [JsonPropertyName("PLAZA_BUYER_PROTECTION_CONTENT")]
        public string PLAZABUYERPROTECTIONCONTENT { get; set; }
    }

    public class BuyNowBtn
    {
        [JsonPropertyName("bgColorStart")]
        public string BgColorStart { get; set; }

        [JsonPropertyName("bgColorEnd")]
        public string BgColorEnd { get; set; }

        [JsonPropertyName("textContent")]
        public string TextContent { get; set; }

        [JsonPropertyName("textColor")]
        public string TextColor { get; set; }
    }

    public class CAINIAOFULFILLMENTSTD
    {
        [JsonPropertyName("expressionExt")]
        public string ExpressionExt { get; set; }

        [JsonPropertyName("allowBuyNowArouseLayer")]
        public bool? AllowBuyNowArouseLayer { get; set; }

        [JsonPropertyName("discountExt")]
        public string DiscountExt { get; set; }

        [JsonPropertyName("xdays")]
        public bool? Xdays { get; set; }

        [JsonPropertyName("choiceMindList")]
        public List<ChoiceMindList> ChoiceMindList { get; set; }

        [JsonPropertyName("promotionId")]
        public string PromotionId { get; set; }

        [JsonPropertyName("allowArouseLayer")]
        public bool? AllowArouseLayer { get; set; }

        [JsonPropertyName("shippingFeeText")]
        public string ShippingFeeText { get; set; }

        [JsonPropertyName("serviceDetails")]
        public ServiceDetails ServiceDetails { get; set; }
    }

    public class CartSideBarInfoComponent
    {
        [JsonPropertyName("hideCartSideBar")]
        public bool? HideCartSideBar { get; set; }

        [JsonPropertyName("siteType")]
        public string SiteType { get; set; }
    }

    public class CategoryComponent
    {
        [JsonPropertyName("topCategoryId")]
        public int? TopCategoryId { get; set; }

        [JsonPropertyName("kidBaby")]
        public bool? KidBaby { get; set; }

        [JsonPropertyName("secondLevelCategoryId")]
        public int? SecondLevelCategoryId { get; set; }
    }

    public class CategoryTagComponent
    {
        [JsonPropertyName("falseHair")]
        public bool? FalseHair { get; set; }

        [JsonPropertyName("cardCoupon")]
        public bool? CardCoupon { get; set; }

        [JsonPropertyName("giftCard")]
        public bool? GiftCard { get; set; }
    }

    public class ChoiceAtmosphereComponent
    {
        [JsonPropertyName("serviceBlockIcon")]
        public ServiceBlockIcon ServiceBlockIcon { get; set; }

        [JsonPropertyName("logisticsBlockIcon")]
        public LogisticsBlockIcon LogisticsBlockIcon { get; set; }
    }

    public class ChoiceMindList
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class Common
    {
        [JsonPropertyName("recommendationsFrom")]
        public string RecommendationsFrom { get; set; }

        [JsonPropertyName("sharePc")]
        public string SharePc { get; set; }

        [JsonPropertyName("skuEditSelection")]
        public string SkuEditSelection { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("specification")]
        public string Specification { get; set; }

        [JsonPropertyName("skuSelections")]
        public string SkuSelections { get; set; }

        [JsonPropertyName("feedback")]
        public string Feedback { get; set; }

        [JsonPropertyName("youMayAlsoLike")]
        public string YouMayAlsoLike { get; set; }

        [JsonPropertyName("deliveryBlockTitle")]
        public string DeliveryBlockTitle { get; set; }

        [JsonPropertyName("outOfStock")]
        public string OutOfStock { get; set; }

        [JsonPropertyName("topSellingsFrom")]
        public string TopSellingsFrom { get; set; }

        [JsonPropertyName("similarRecommond")]
        public string SimilarRecommond { get; set; }

        [JsonPropertyName("youMayAlsoLikeSeeMore")]
        public string YouMayAlsoLikeSeeMore { get; set; }

        [JsonPropertyName("qanda")]
        public string Qanda { get; set; }
    }

    public class CouponAttributes
    {
        [JsonPropertyName("couponPackageText")]
        public string CouponPackageText { get; set; }
    }

    public class CouponModule
    {
        [JsonPropertyName("GET_COUPONS")]
        public string GETCOUPONS { get; set; }

        [JsonPropertyName("SCP_ERR_HAVE")]
        public string SCPERRHAVE { get; set; }

        [JsonPropertyName("OFF_ON")]
        public string OFFON { get; set; }

        [JsonPropertyName("ORDER_OVER")]
        public string ORDEROVER { get; set; }

        [JsonPropertyName("code52Title")]
        public string Code52Title { get; set; }

        [JsonPropertyName("GET_IT")]
        public string GETIT { get; set; }

        [JsonPropertyName("GET_NOW")]
        public string GETNOW { get; set; }

        [JsonPropertyName("GET_MORE")]
        public string GETMORE { get; set; }

        [JsonPropertyName("systemError")]
        public string SystemError { get; set; }

        [JsonPropertyName("OFF_PER")]
        public string OFFPER { get; set; }

        [JsonPropertyName("STORE_COUPON")]
        public string STORECOUPON { get; set; }

        [JsonPropertyName("SHOP_COUPONE_TIME_START_END")]
        public string SHOPCOUPONETIMESTARTEND { get; set; }

        [JsonPropertyName("NEW_USER_COUPON_ACQUIRE_FAIL_ALREADY_HAVE")]
        public string NEWUSERCOUPONACQUIREFAILALREADYHAVE { get; set; }

        [JsonPropertyName("code50Title")]
        public string Code50Title { get; set; }

        [JsonPropertyName("NEW_USER_COUPON_ACQUIRE_FAIL_NOT_AVAILABLE_NOW")]
        public string NEWUSERCOUPONACQUIREFAILNOTAVAILABLENOW { get; set; }

        [JsonPropertyName("NEW_USER_COUPON_ACQUIRE_FAIL_GROUP_LIMIT")]
        public string NEWUSERCOUPONACQUIREFAILGROUPLIMIT { get; set; }

        [JsonPropertyName("code14Title")]
        public string Code14Title { get; set; }

        [JsonPropertyName("NEW_USER_COUPON_ACQUIRE_FAIL_NOT_NEW_USER")]
        public string NEWUSERCOUPONACQUIREFAILNOTNEWUSER { get; set; }

        [JsonPropertyName("SHOP_PROMO_CODE_COPIED")]
        public string SHOPPROMOCODECOPIED { get; set; }

        [JsonPropertyName("ADDED")]
        public string ADDED { get; set; }

        [JsonPropertyName("NEW_USER_COUPON_ACQUIRE_FAIL_SECURITY")]
        public string NEWUSERCOUPONACQUIREFAILSECURITY { get; set; }

        [JsonPropertyName("SHOP_PROMO_CODE_TITLE")]
        public string SHOPPROMOCODETITLE { get; set; }

        [JsonPropertyName("NEW_USER_COUPON_ACQUIRE_FAIL")]
        public string NEWUSERCOUPONACQUIREFAIL { get; set; }

        [JsonPropertyName("NEW_USER_COUPON_ACQUIRE_FAIL_LIMIT_DAY")]
        public string NEWUSERCOUPONACQUIREFAILLIMITDAY { get; set; }

        [JsonPropertyName("NEW_USER_COUPON_ACQUIRE_FAIL_REGISTER_COUNTRY_LIMIT")]
        public string NEWUSERCOUPONACQUIREFAILREGISTERCOUNTRYLIMIT { get; set; }

        [JsonPropertyName("SCP_ERR_NONE")]
        public string SCPERRNONE { get; set; }

        [JsonPropertyName("NEW_USER_COUPON_ACQUIRE_FAIL_GRANT_ERROR")]
        public string NEWUSERCOUPONACQUIREFAILGRANTERROR { get; set; }

        [JsonPropertyName("code17Title")]
        public string Code17Title { get; set; }

        [JsonPropertyName("SHOP_COUPONE_TIME_EXPIRES")]
        public string SHOPCOUPONETIMEEXPIRES { get; set; }

        [JsonPropertyName("SHOPPONG_CREDIT")]
        public string SHOPPONGCREDIT { get; set; }

        [JsonPropertyName("EXCHANGE_MORE")]
        public string EXCHANGEMORE { get; set; }

        [JsonPropertyName("NEW_USER_COUPON_ACQUIRE_FAIL_SYSTEM_ERROR")]
        public string NEWUSERCOUPONACQUIREFAILSYSTEMERROR { get; set; }

        [JsonPropertyName("MY_BALANCE")]
        public string MYBALANCE { get; set; }

        [JsonPropertyName("INSTANT_DISCOUNT")]
        public string INSTANTDISCOUNT { get; set; }

        [JsonPropertyName("EXCHANGE_NOW")]
        public string EXCHANGENOW { get; set; }

        [JsonPropertyName("CROSS_STORE_VOUCHER_TIP")]
        public string CROSSSTOREVOUCHERTIP { get; set; }

        [JsonPropertyName("NEW_USER_COUPON")]
        public string NEWUSERCOUPON { get; set; }

        [JsonPropertyName("GET")]
        public string GET { get; set; }

        [JsonPropertyName("SHOP_PROMO_CODE_COP_FAILED")]
        public string SHOPPROMOCODECOPFAILED { get; set; }

        [JsonPropertyName("code-30005Title")]
        public string Code30005Title { get; set; }

        [JsonPropertyName("MY_COINS")]
        public string MYCOINS { get; set; }

        [JsonPropertyName("BUY_GET_OFF")]
        public string BUYGETOFF { get; set; }

        [JsonPropertyName("code51Title")]
        public string Code51Title { get; set; }

        [JsonPropertyName("PANEL_TITLE")]
        public string PANELTITLE { get; set; }

        [JsonPropertyName("NEW_USER_COUPON_ACQUIRE_FAIL_LIMIT_HOUR")]
        public string NEWUSERCOUPONACQUIREFAILLIMITHOUR { get; set; }

        [JsonPropertyName("CROSS_STORE_VOUCHER")]
        public string CROSSSTOREVOUCHER { get; set; }
    }

    public class CrossLinkModule
    {
        [JsonPropertyName("BREADCRUMB_PART2")]
        public string BREADCRUMBPART2 { get; set; }

        [JsonPropertyName("BREADCRUMB_PART1")]
        public string BREADCRUMBPART1 { get; set; }

        [JsonPropertyName("CROSSLINK_RELATED_SEARCHES")]
        public string CROSSLINKRELATEDSEARCHES { get; set; }
    }

    public class CurrencyComponent
    {
        [JsonPropertyName("baseCurrencyCode")]
        public string BaseCurrencyCode { get; set; }

        [JsonPropertyName("enableTransaction")]
        public bool? EnableTransaction { get; set; }

        [JsonPropertyName("currencySymbol")]
        public string CurrencySymbol { get; set; }

        [JsonPropertyName("symbolFront")]
        public bool? SymbolFront { get; set; }

        [JsonPropertyName("currencyRate")]
        public double? CurrencyRate { get; set; }

        [JsonPropertyName("baseSymbolFront")]
        public bool? BaseSymbolFront { get; set; }

        [JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonPropertyName("baseCurrencySymbol")]
        public string BaseCurrencySymbol { get; set; }

        [JsonPropertyName("multiCurrency")]
        public bool? MultiCurrency { get; set; }
    }

    public class DeliveryExtraInfoMap
    {
        [JsonPropertyName("CAINIAO_FULFILLMENT_STD")]
        public CAINIAOFULFILLMENTSTD CAINIAOFULFILLMENTSTD { get; set; }
    }

    public class Description
    {
        [JsonPropertyName("spreadStatus")]
        public string SpreadStatus { get; set; }

        [JsonPropertyName("order")]
        public int? Order { get; set; }
    }

    public class Detail
    {
        [JsonPropertyName("viewMoreText")]
        public string ViewMoreText { get; set; }

        [JsonPropertyName("titleColor")]
        public string TitleColor { get; set; }

        [JsonPropertyName("actionTarget")]
        public string ActionTarget { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }

    public class DiscountPrice
    {
        [JsonPropertyName("actMinPrice")]
        public double? ActMinPrice { get; set; }

        [JsonPropertyName("actCurrencyFormatPrice")]
        public string ActCurrencyFormatPrice { get; set; }

        [JsonPropertyName("minActivityAmount")]
        public MinActivityAmount MinActivityAmount { get; set; }

        [JsonPropertyName("actMultiCurrencyMinPrice")]
        public string ActMultiCurrencyMinPrice { get; set; }

        [JsonPropertyName("minActMultiCurrencyPrice")]
        public double? MinActMultiCurrencyPrice { get; set; }

        [JsonPropertyName("maxActMultiCurrencyPrice")]
        public double? MaxActMultiCurrencyPrice { get; set; }

        [JsonPropertyName("maxActivityAmount")]
        public MaxActivityAmount MaxActivityAmount { get; set; }

        [JsonPropertyName("actMinDisplayPrice")]
        public string ActMinDisplayPrice { get; set; }

        [JsonPropertyName("actMaxDisplayPrice")]
        public string ActMaxDisplayPrice { get; set; }

        [JsonPropertyName("actMaxPrice")]
        public double? ActMaxPrice { get; set; }

        [JsonPropertyName("actMultiCurrencyDisplayPrice")]
        public string ActMultiCurrencyDisplayPrice { get; set; }

        [JsonPropertyName("actMultiCurrencyMaxPrice")]
        public string ActMultiCurrencyMaxPrice { get; set; }
    }

    public class DisplayTitleComponent
    {
        [JsonPropertyName("origTitle")]
        public bool? OrigTitle { get; set; }

        [JsonPropertyName("orig")]
        public bool? Orig { get; set; }

        [JsonPropertyName("transTitle")]
        public bool? TransTitle { get; set; }

        [JsonPropertyName("trans")]
        public bool? Trans { get; set; }
    }

    public class DxTemplateInfo
    {
    }

    public class EndTimer
    {
        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("endTime")]
        public object EndTime { get; set; }

        [JsonPropertyName("showCountdown")]
        public string ShowCountdown { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class EnvInfo
    {
        [JsonPropertyName("domestic")]
        public bool? Domestic { get; set; }

        [JsonPropertyName("traceId")]
        public string TraceId { get; set; }

        [JsonPropertyName("crawler")]
        public bool? Crawler { get; set; }
    }

    public class ExtraComponent
    {
        [JsonPropertyName("expressionExt")]
        public string ExpressionExt { get; set; }

        [JsonPropertyName("aeOrderFrom")]
        public string AeOrderFrom { get; set; }

        [JsonPropertyName("showCoinAnim")]
        public bool? ShowCoinAnim { get; set; }

        [JsonPropertyName("uiTestInfo")]
        public UiTestInfo UiTestInfo { get; set; }

        [JsonPropertyName("freightExt")]
        public string FreightExt { get; set; }

        [JsonPropertyName("seoTitle")]
        public string SeoTitle { get; set; }

        [JsonPropertyName("detailPageUrl")]
        public string DetailPageUrl { get; set; }

        [JsonPropertyName("envInfo")]
        public EnvInfo EnvInfo { get; set; }

        [JsonPropertyName("complaintUrl")]
        public string ComplaintUrl { get; set; }

        [JsonPropertyName("productDetailImageUrl")]
        public string ProductDetailImageUrl { get; set; }
    }

    public class FeedbackComponent
    {
        [JsonPropertyName("positiveRate")]
        public string PositiveRate { get; set; }

        [JsonPropertyName("fiveStarNum")]
        public int? FiveStarNum { get; set; }

        [JsonPropertyName("threeStarNum")]
        public int? ThreeStarNum { get; set; }

        [JsonPropertyName("twoStarRate")]
        public int? TwoStarRate { get; set; }

        [JsonPropertyName("display")]
        public bool? Display { get; set; }

        [JsonPropertyName("oneStarRate")]
        public int? OneStarRate { get; set; }

        [JsonPropertyName("fourStarNum")]
        public int? FourStarNum { get; set; }

        [JsonPropertyName("evarageStar")]
        public string EvarageStar { get; set; }

        [JsonPropertyName("fiveStarRate")]
        public int? FiveStarRate { get; set; }

        [JsonPropertyName("threeStarRate")]
        public int? ThreeStarRate { get; set; }

        [JsonPropertyName("totalValidNum")]
        public int? TotalValidNum { get; set; }

        [JsonPropertyName("evarageStarRage")]
        public string EvarageStarRage { get; set; }

        [JsonPropertyName("twoStarNum")]
        public int? TwoStarNum { get; set; }

        [JsonPropertyName("trialReviewNum")]
        public int? TrialReviewNum { get; set; }

        [JsonPropertyName("oneStarNum")]
        public int? OneStarNum { get; set; }

        [JsonPropertyName("fourStarRate")]
        public int? FourStarRate { get; set; }
    }

    public class GagaComponent
    {
        [JsonPropertyName("gagaDataSite")]
        public string GagaDataSite { get; set; }
    }

    public class Group
    {
        [JsonPropertyName("isExpand")]
        public string IsExpand { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class I18nComponent
    {
        [JsonPropertyName("i18nMap")]
        public I18nMap I18nMap { get; set; }
    }

    public class I18nMap
    {
        [JsonPropertyName("SKUModule")]
        public SKUModule SKUModule { get; set; }

        [JsonPropertyName("priceGuarantee")]
        public PriceGuarantee PriceGuarantee { get; set; }

        [JsonPropertyName("ActionModule")]
        public ActionModule ActionModule { get; set; }

        [JsonPropertyName("StoreModule")]
        public StoreModule StoreModule { get; set; }

        [JsonPropertyName("RecommendModule")]
        public RecommendModule RecommendModule { get; set; }

        [JsonPropertyName("StoreInfo")]
        public StoreInfo StoreInfo { get; set; }

        [JsonPropertyName("ItemDetailResp")]
        public ItemDetailResp ItemDetailResp { get; set; }

        [JsonPropertyName("bpFreeReturn30")]
        public BpFreeReturn30 BpFreeReturn30 { get; set; }

        [JsonPropertyName("bpLocalDomesticReturn")]
        public BpLocalDomesticReturn BpLocalDomesticReturn { get; set; }

        [JsonPropertyName("PriceModule")]
        public PriceModule PriceModule { get; set; }

        [JsonPropertyName("ShippingModule")]
        public ShippingModule ShippingModule { get; set; }

        [JsonPropertyName("BuyerProtectionModule")]
        public BuyerProtectionModule BuyerProtectionModule { get; set; }

        [JsonPropertyName("bpSpainFreeReturn")]
        public BpSpainFreeReturn BpSpainFreeReturn { get; set; }

        [JsonPropertyName("Common")]
        public Common Common { get; set; }

        [JsonPropertyName("buyerProtection")]
        public BuyerProtection BuyerProtection { get; set; }

        [JsonPropertyName("QuantityModule")]
        public QuantityModule QuantityModule { get; set; }

        [JsonPropertyName("OtherServiceModule")]
        public OtherServiceModule OtherServiceModule { get; set; }

        [JsonPropertyName("CrossLinkModule")]
        public CrossLinkModule CrossLinkModule { get; set; }

        [JsonPropertyName("bpLocalReturn15")]
        public BpLocalReturn15 BpLocalReturn15 { get; set; }

        [JsonPropertyName("TitleModule")]
        public TitleModule TitleModule { get; set; }

        [JsonPropertyName("MiddleBannerModule")]
        public MiddleBannerModule MiddleBannerModule { get; set; }

        [JsonPropertyName("CouponModule")]
        public CouponModule CouponModule { get; set; }

        [JsonPropertyName("bpDomesticReturn7")]
        public BpDomesticReturn7 BpDomesticReturn7 { get; set; }
    }

    public class ImageComponent
    {
        [JsonPropertyName("image250PathList")]
        public List<string> Image250PathList { get; set; }

        [JsonPropertyName("imagePathList")]
        public List<string> ImagePathList { get; set; }

        [JsonPropertyName("image640PathList")]
        public List<string> Image640PathList { get; set; }

        [JsonPropertyName("imageExist")]
        public bool? ImageExist { get; set; }

        [JsonPropertyName("imageServer")]
        public string ImageServer { get; set; }

        [JsonPropertyName("summImagePathList")]
        public List<string> SummImagePathList { get; set; }
    }

    public class InstallmentComponent
    {
    }

    public class InventoryComponent
    {
        [JsonPropertyName("totalQuantity")]
        public int? TotalQuantity { get; set; }

        [JsonPropertyName("totalAvailQuantity")]
        public int? TotalAvailQuantity { get; set; }
    }

    public class ItemDetailResp
    {
        [JsonPropertyName("ASK_BUYERS")]
        public string ASKBUYERS { get; set; }

        [JsonPropertyName("VIEW_5_MORE_ANSWERS")]
        public string VIEW5MOREANSWERS { get; set; }

        [JsonPropertyName("PAGE_NOT_FOUND_RCMD_TITLE")]
        public string PAGENOTFOUNDRCMDTITLE { get; set; }

        [JsonPropertyName("VIEW_MORE")]
        public string VIEWMORE { get; set; }

        [JsonPropertyName("PAGE_NOT_FOUND_NOTICE")]
        public string PAGENOTFOUNDNOTICE { get; set; }
    }

    public class ItemStatusComponent
    {
        [JsonPropertyName("status")]
        public int? Status { get; set; }
    }

    public class LogisticsBlockIcon
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class MarketingInfo4ChoiceComponent
    {
        [JsonPropertyName("bgColorStart")]
        public string BgColorStart { get; set; }

        [JsonPropertyName("bgColorEnd")]
        public string BgColorEnd { get; set; }

        [JsonPropertyName("blockIcon")]
        public BlockIcon BlockIcon { get; set; }
    }

    public class MarketingInfoComponent
    {
    }

    public class MaxActivityAmount
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("formatedAmount")]
        public string FormatedAmount { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class MaxAmount
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("formatedAmount")]
        public string FormatedAmount { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class Message
    {
        [JsonPropertyName("iconAddress")]
        public string IconAddress { get; set; }

        [JsonPropertyName("textContent")]
        public string TextContent { get; set; }

        [JsonPropertyName("actionTarget")]
        public string ActionTarget { get; set; }
    }

    public class MetaDataComponent
    {
        [JsonPropertyName("keywords")]
        public string Keywords { get; set; }

        [JsonPropertyName("canonicalTag")]
        public string CanonicalTag { get; set; }

        [JsonPropertyName("hreflangTag")]
        public string HreflangTag { get; set; }

        [JsonPropertyName("ogTitle")]
        public string OgTitle { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("mediaTag")]
        public string MediaTag { get; set; }

        [JsonPropertyName("ogurl")]
        public string Ogurl { get; set; }

        [JsonPropertyName("amphtmlTag")]
        public string AmphtmlTag { get; set; }

        [JsonPropertyName("ogDescription")]
        public string OgDescription { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }

    public class MiddleBannerModule
    {
        [JsonPropertyName("END_IN")]
        public string ENDIN { get; set; }

        [JsonPropertyName("DAYS")]
        public string DAYS { get; set; }

        [JsonPropertyName("DAY")]
        public string DAY { get; set; }

        [JsonPropertyName("STARTS_IN")]
        public string STARTSIN { get; set; }
    }

    public class MinActivityAmount
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("formatedAmount")]
        public string FormatedAmount { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class MinAmount
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("formatedAmount")]
        public string FormatedAmount { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class ModuleLayoutInfo
    {
        [JsonPropertyName("questionAndAnswer")]
        public QuestionAndAnswer QuestionAndAnswer { get; set; }

        [JsonPropertyName("review")]
        public Review Review { get; set; }

        [JsonPropertyName("description")]
        public Description Description { get; set; }

        [JsonPropertyName("specification")]
        public Specification Specification { get; set; }
    }

    public class MultiLanguageUrlComponent
    {
        [JsonPropertyName("storeMultilanguageUrlList")]
        public List<StoreMultilanguageUrlList> StoreMultilanguageUrlList { get; set; }

        [JsonPropertyName("storeDetailUrl")]
        public string StoreDetailUrl { get; set; }

        [JsonPropertyName("multilanguageUrlList")]
        public List<MultilanguageUrlList> MultilanguageUrlList { get; set; }

        [JsonPropertyName("itemDetailUrl")]
        public string ItemDetailUrl { get; set; }

        [JsonPropertyName("mSiteUrl")]
        public string MSiteUrl { get; set; }
    }

    public class MultilanguageUrlList
    {
        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("languageUrl")]
        public string LanguageUrl { get; set; }
    }

    public class OriginalLayoutResultList
    {
        //[JsonPropertyName("contentLayout")]
        //public List<List<>> ContentLayout { get; set; }

        [JsonPropertyName("deliveryOptionPanelDisplayList")]
        public List<string> DeliveryOptionPanelDisplayList { get; set; }

        [JsonPropertyName("additionLayout")]
        public List<AdditionLayout> AdditionLayout { get; set; }

        [JsonPropertyName("titleLayout")]
        public List<object> TitleLayout { get; set; }

        [JsonPropertyName("finalPatternId")]
        public int? FinalPatternId { get; set; }

        [JsonPropertyName("bizData")]
        public BizData BizData { get; set; }

        [JsonPropertyName("dxTemplateInfo")]
        public DxTemplateInfo DxTemplateInfo { get; set; }

        [JsonPropertyName("detailFirstScreenDisplayList")]
        public List<string> DetailFirstScreenDisplayList { get; set; }

        [JsonPropertyName("skuSwitchDisplayList")]
        public List<string> SkuSwitchDisplayList { get; set; }
    }

    public class OrigPrice
    {
        [JsonPropertyName("minAmount")]
        public MinAmount MinAmount { get; set; }

        [JsonPropertyName("minMultiCurrencyPrice")]
        public double? MinMultiCurrencyPrice { get; set; }

        [JsonPropertyName("minPrice")]
        public double? MinPrice { get; set; }

        [JsonPropertyName("maxPrice")]
        public double? MaxPrice { get; set; }

        [JsonPropertyName("multiCurrencyFormatPrice")]
        public string MultiCurrencyFormatPrice { get; set; }

        [JsonPropertyName("maxAmount")]
        public MaxAmount MaxAmount { get; set; }

        [JsonPropertyName("currencyFormatPrice")]
        public string CurrencyFormatPrice { get; set; }
    }

    public class OtherPCTagMap
    {
    }

    public class OtherServiceModule
    {
        [JsonPropertyName("TAB_SPECS")]
        public string TABSPECS { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_SUBTITLE_PC")]
        public string PLAZASERVICESUBTITLEPC { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_WARRANTY_EMAIL")]
        public string PLAZASERVICEWARRANTYEMAIL { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_WARRANTY_PHONE")]
        public string PLAZASERVICEWARRANTYPHONE { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_WARRANTY_HOURS")]
        public string PLAZASERVICEWARRANTYHOURS { get; set; }

        [JsonPropertyName("TAB_CUSTOMER_REVIEWS")]
        public string TABCUSTOMERREVIEWS { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_WARRANTY_WEBSITE")]
        public string PLAZASERVICEWARRANTYWEBSITE { get; set; }

        [JsonPropertyName("TAB_OVERVIEW")]
        public string TABOVERVIEW { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_WARRANTY_BRAND")]
        public string PLAZASERVICEWARRANTYBRAND { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_WARRANTY_CATEGORY")]
        public string PLAZASERVICEWARRANTYCATEGORY { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_TITLE_PC")]
        public string PLAZASERVICETITLEPC { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_CONTENT3_3_PC")]
        public string PLAZASERVICECONTENT33PC { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_WARRANTY_TITLE")]
        public string PLAZASERVICEWARRANTYTITLE { get; set; }

        [JsonPropertyName("TAB_REPORT_ITEM")]
        public string TABREPORTITEM { get; set; }

        [JsonPropertyName("TAB_SERVICE")]
        public string TABSERVICE { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_CONTENT3_1_PC")]
        public string PLAZASERVICECONTENT31PC { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_CONTENT3_2_PC")]
        public string PLAZASERVICECONTENT32PC { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_CONTENT1_PC")]
        public string PLAZASERVICECONTENT1PC { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_SUBTITLE2_PC")]
        public string PLAZASERVICESUBTITLE2PC { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_CONTENT2_PC")]
        public string PLAZASERVICECONTENT2PC { get; set; }

        [JsonPropertyName("PLAZA_SERVICE_SUBTITLE3_PC")]
        public string PLAZASERVICESUBTITLE3PC { get; set; }
    }

    public class PackageComponent
    {
        [JsonPropertyName("inch_length")]
        public string InchLength { get; set; }

        [JsonPropertyName("lot")]
        public bool? Lot { get; set; }

        [JsonPropertyName("unitType")]
        public string UnitType { get; set; }

        [JsonPropertyName("length")]
        public int? Length { get; set; }

        [JsonPropertyName("lotNum")]
        public string LotNum { get; set; }

        [JsonPropertyName("width")]
        public int? Width { get; set; }

        [JsonPropertyName("inch_height")]
        public string InchHeight { get; set; }

        [JsonPropertyName("weight")]
        public double? Weight { get; set; }

        [JsonPropertyName("pound_weight")]
        public string PoundWeight { get; set; }

        [JsonPropertyName("packageType")]
        public string PackageType { get; set; }

        [JsonPropertyName("height")]
        public int? Height { get; set; }

        [JsonPropertyName("inch_width")]
        public string InchWidth { get; set; }
    }

    public class PageSizeComponent
    {
        [JsonPropertyName("hasNewSizeInfo")]
        public bool? HasNewSizeInfo { get; set; }

        [JsonPropertyName("hasSizeInfo")]
        public bool? HasSizeInfo { get; set; }
    }

    public class PathList
    {
        [JsonPropertyName("cateId")]
        public int? CateId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class PlazaSellerServiceComponent
    {
        [JsonPropertyName("warranty")]
        public Warranty Warranty { get; set; }

        [JsonPropertyName("hasWarrantyInfo")]
        public bool? HasWarrantyInfo { get; set; }
    }

    public class PriceComponent
    {
        [JsonPropertyName("skuJson")]
        public string SkuJson { get; set; }

        [JsonPropertyName("vatDesc")]
        public string VatDesc { get; set; }

        [JsonPropertyName("displayBulkInfo")]
        public bool? DisplayBulkInfo { get; set; }

        [JsonPropertyName("skuPriceList")]
        public List<SkuPriceList> SkuPriceList { get; set; }

        [JsonPropertyName("discountPrice")]
        public DiscountPrice DiscountPrice { get; set; }

        [JsonPropertyName("origPrice")]
        public OrigPrice OrigPrice { get; set; }

        [JsonPropertyName("priceLocalConfig")]
        public string PriceLocalConfig { get; set; }
    }

    public class PriceGuarantee
    {
        [JsonPropertyName("brief")]
        public string Brief { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("desc")]
        public string Desc { get; set; }
    }

    public class PriceModule
    {
        [JsonPropertyName("LOT")]
        public string LOT { get; set; }

        [JsonPropertyName("PRE_ORDER_PRICE")]
        public string PREORDERPRICE { get; set; }

        [JsonPropertyName("INSTALLMENT")]
        public string INSTALLMENT { get; set; }

        [JsonPropertyName("DEPOSIT")]
        public string DEPOSIT { get; set; }
    }

    public class PriceRuleComponent
    {
    }

    public class ProductDescComponent
    {
        [JsonPropertyName("descriptionUrl")]
        public string DescriptionUrl { get; set; }
    }

    public class ProductGroupsResult
    {
        [JsonPropertyName("groups")]
        public List<Group> Groups { get; set; }
    }

    public class ProductInfoComponent
    {
        [JsonPropertyName("idStr")]
        public string IdStr { get; set; }

        [JsonPropertyName("oddUnitName")]
        public string OddUnitName { get; set; }

        [JsonPropertyName("taobaoSellerName")]
        public string TaobaoSellerName { get; set; }

        [JsonPropertyName("src")]
        public string Src { get; set; }

        [JsonPropertyName("categoryPaths")]
        public string CategoryPaths { get; set; }

        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        [JsonPropertyName("numberPerLot")]
        public int? NumberPerLot { get; set; }

        [JsonPropertyName("adminSeq")]
        public long? AdminSeq { get; set; }

        [JsonPropertyName("fromTaobao")]
        public bool? FromTaobao { get; set; }

        [JsonPropertyName("lot")]
        public bool? Lot { get; set; }

        [JsonPropertyName("multiCurrencyDisplayPrice")]
        public string MultiCurrencyDisplayPrice { get; set; }

        [JsonPropertyName("openOfferPriceRule")]
        public bool? OpenOfferPriceRule { get; set; }

        [JsonPropertyName("minPrice")]
        public double? MinPrice { get; set; }

        [JsonPropertyName("id")]
        public long? Id { get; set; }

        [JsonPropertyName("maxPrice")]
        public double? MaxPrice { get; set; }

        [JsonPropertyName("multiUnitName")]
        public string MultiUnitName { get; set; }

        [JsonPropertyName("categoryId")]
        public int? CategoryId { get; set; }
    }

    public class ProductPropComponent
    {
        [JsonPropertyName("showPropGroups")]
        public bool? ShowPropGroups { get; set; }

        [JsonPropertyName("propGroups")]
        public List<object> PropGroups { get; set; }

        [JsonPropertyName("props")]
        public List<Prop> Props { get; set; }
    }

    public class ProductSKUPropertyList
    {
        [JsonPropertyName("showTypeColor")]
        public bool? ShowTypeColor { get; set; }

        [JsonPropertyName("sizeProperty")]
        public bool? SizeProperty { get; set; }

        [JsonPropertyName("skuPropertyValues")]
        public List<SkuPropertyValue> SkuPropertyValues { get; set; }

        [JsonPropertyName("showType")]
        public string ShowType { get; set; }

        [JsonPropertyName("skuPropertyName")]
        public string SkuPropertyName { get; set; }

        [JsonPropertyName("skuPropertyId")]
        public int? SkuPropertyId { get; set; }

        [JsonPropertyName("order")]
        public int? Order { get; set; }
    }

    public class ProductTagComponent
    {
        [JsonPropertyName("topItem")]
        public bool? TopItem { get; set; }

        [JsonPropertyName("invalidBuyNow")]
        public bool? InvalidBuyNow { get; set; }

        [JsonPropertyName("switchInfo")]
        public SwitchInfo SwitchInfo { get; set; }

        [JsonPropertyName("rechargeProduct")]
        public bool? RechargeProduct { get; set; }

        [JsonPropertyName("x3MoneyBack")]
        public bool? X3MoneyBack { get; set; }

        [JsonPropertyName("f1Scene")]
        public bool? F1Scene { get; set; }

        [JsonPropertyName("hideMessage")]
        public bool? HideMessage { get; set; }

        [JsonPropertyName("otherPCTagMap")]
        public OtherPCTagMap OtherPCTagMap { get; set; }

        [JsonPropertyName("boutique")]
        public bool? Boutique { get; set; }

        [JsonPropertyName("hideBuyNow")]
        public bool? HideBuyNow { get; set; }

        [JsonPropertyName("promotionEnhanceInfoBanner")]
        public PromotionEnhanceInfoBanner PromotionEnhanceInfoBanner { get; set; }

        [JsonPropertyName("madeInItaly")]
        public bool? MadeInItaly { get; set; }

        [JsonPropertyName("installment")]
        public bool? Installment { get; set; }

        [JsonPropertyName("ruHidePruduct")]
        public bool? RuHidePruduct { get; set; }

        [JsonPropertyName("frMall")]
        public bool? FrMall { get; set; }

        [JsonPropertyName("choiceProduct")]
        public bool? ChoiceProduct { get; set; }
    }

    public class PromotionBanner
    {
        [JsonPropertyName("endTimer")]
        public EndTimer EndTimer { get; set; }

        [JsonPropertyName("priceAreaColor")]
        public string PriceAreaColor { get; set; }

        [JsonPropertyName("atmosphereCode")]
        public string AtmosphereCode { get; set; }

        [JsonPropertyName("supplementaryList")]
        public List<SupplementaryList> SupplementaryList { get; set; }

        [JsonPropertyName("background")]
        public Background Background { get; set; }

        [JsonPropertyName("activityStatus")]
        public int? ActivityStatus { get; set; }

        [JsonPropertyName("separator")]
        public Separator Separator { get; set; }

        [JsonPropertyName("slogan")]
        public Slogan Slogan { get; set; }
    }

    public class PromotionBannerInfo
    {
        [JsonPropertyName("endTimer")]
        public EndTimer EndTimer { get; set; }

        [JsonPropertyName("priceAreaColor")]
        public string PriceAreaColor { get; set; }

        [JsonPropertyName("atmosphereCode")]
        public string AtmosphereCode { get; set; }

        [JsonPropertyName("supplementaryList")]
        public List<SupplementaryList> SupplementaryList { get; set; }

        [JsonPropertyName("background")]
        public Background Background { get; set; }

        [JsonPropertyName("activityStatus")]
        public int? ActivityStatus { get; set; }

        [JsonPropertyName("separator")]
        public Separator Separator { get; set; }

        [JsonPropertyName("slogan")]
        public Slogan Slogan { get; set; }
    }

    public class PromotionComponent
    {
        [JsonPropertyName("discountPromotion")]
        public bool? DiscountPromotion { get; set; }

        [JsonPropertyName("activity")]
        public bool? Activity { get; set; }

        [JsonPropertyName("fixedPromotionLeftHours")]
        public int? FixedPromotionLeftHours { get; set; }

        [JsonPropertyName("discount")]
        public int? Discount { get; set; }

        [JsonPropertyName("fixedFreeShipping")]
        public bool? FixedFreeShipping { get; set; }

        [JsonPropertyName("regularPriceActivity")]
        public bool? RegularPriceActivity { get; set; }

        [JsonPropertyName("fixedPromotionLeftSecs")]
        public int? FixedPromotionLeftSecs { get; set; }

        [JsonPropertyName("promotionLeftMinutes")]
        public int? PromotionLeftMinutes { get; set; }

        [JsonPropertyName("promotionLeftSecs")]
        public int? PromotionLeftSecs { get; set; }

        [JsonPropertyName("discountTips")]
        public string DiscountTips { get; set; }

        [JsonPropertyName("fixedPromotionLeftMinutes")]
        public int? FixedPromotionLeftMinutes { get; set; }

        [JsonPropertyName("coinsEnough")]
        public bool? CoinsEnough { get; set; }

        [JsonPropertyName("fireDeals")]
        public bool? FireDeals { get; set; }

        [JsonPropertyName("purchaseLimitMaxTips")]
        public string PurchaseLimitMaxTips { get; set; }

        [JsonPropertyName("superDeals")]
        public bool? SuperDeals { get; set; }

        [JsonPropertyName("fixedPromotionLeftDays")]
        public int? FixedPromotionLeftDays { get; set; }

        [JsonPropertyName("promotionLeftHours")]
        public int? PromotionLeftHours { get; set; }

        [JsonPropertyName("hbaFreeShipping")]
        public bool? HbaFreeShipping { get; set; }

        [JsonPropertyName("showStockPrompt")]
        public bool? ShowStockPrompt { get; set; }

        [JsonPropertyName("enableMultiDiscount")]
        public bool? EnableMultiDiscount { get; set; }

        [JsonPropertyName("purchaseLimitNumMax")]
        public int? PurchaseLimitNumMax { get; set; }

        [JsonPropertyName("discountRatioTips")]
        public string DiscountRatioTips { get; set; }

        [JsonPropertyName("displayIcon")]
        public bool? DisplayIcon { get; set; }

        [JsonPropertyName("preSale")]
        public bool? PreSale { get; set; }

        [JsonPropertyName("promotionLeftDays")]
        public int? PromotionLeftDays { get; set; }

        [JsonPropertyName("availableGroupShareActivity")]
        public bool? AvailableGroupShareActivity { get; set; }

        [JsonPropertyName("coinPreSale")]
        public bool? CoinPreSale { get; set; }

        [JsonPropertyName("fixedDiscountPromotion")]
        public bool? FixedDiscountPromotion { get; set; }

        [JsonPropertyName("comingSoon")]
        public bool? ComingSoon { get; set; }

        [JsonPropertyName("allProduct")]
        public bool? AllProduct { get; set; }

        [JsonPropertyName("memberPriceActivity")]
        public bool? MemberPriceActivity { get; set; }
    }

    public class PromotionEnhanceInfoBanner
    {
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }
    }

    public class PromotionPanelDTO
    {
    }

    public class Prop
    {
        [JsonPropertyName("attrValue")]
        public string AttrValue { get; set; }

        [JsonPropertyName("attrName")]
        public string AttrName { get; set; }
    }

    public class QuantityModule
    {
        [JsonPropertyName("LOT")]
        public string LOT { get; set; }

        [JsonPropertyName("LOTS")]
        public string LOTS { get; set; }

        [JsonPropertyName("BUY_LIMIT")]
        public string BUYLIMIT { get; set; }

        [JsonPropertyName("QUANTITY")]
        public string QUANTITY { get; set; }

        [JsonPropertyName("OFF_OR_MORE")]
        public string OFFORMORE { get; set; }

        [JsonPropertyName("ONLY_QUANTITY_LEFT")]
        public string ONLYQUANTITYLEFT { get; set; }

        [JsonPropertyName("ADDTIONAL")]
        public string ADDTIONAL { get; set; }

        [JsonPropertyName("QUANTITY_AVAILABLE")]
        public string QUANTITYAVAILABLE { get; set; }
    }

    public class QuestionAndAnswer
    {
        [JsonPropertyName("spreadStatus")]
        public string SpreadStatus { get; set; }

        [JsonPropertyName("order")]
        public int? Order { get; set; }
    }

    public class RecommendComponent
    {
        [JsonPropertyName("similarPageSize")]
        public int? SimilarPageSize { get; set; }

        [JsonPropertyName("afChannel")]
        public string AfChannel { get; set; }

        [JsonPropertyName("similarScenario")]
        public string SimilarScenario { get; set; }

        [JsonPropertyName("hideStoreRecommend")]
        public bool? HideStoreRecommend { get; set; }

        [JsonPropertyName("hideTopSelling")]
        public bool? HideTopSelling { get; set; }
    }

    public class RecommendModule
    {
        [JsonPropertyName("MORE_FROM_THIS_SELLER")]
        public string MOREFROMTHISSELLER { get; set; }

        [JsonPropertyName("YOU_MAY_LIKE")]
        public string YOUMAYLIKE { get; set; }

        [JsonPropertyName("TOP_SELLING")]
        public string TOPSELLING { get; set; }

        [JsonPropertyName("FROM_OTHER_SELLER")]
        public string FROMOTHERSELLER { get; set; }

        [JsonPropertyName("VIEW_MORE_LINK")]
        public string VIEWMORELINK { get; set; }

        [JsonPropertyName("PRODUCT_SOLD")]
        public string PRODUCTSOLD { get; set; }
    }

    public class RedirectComponent
    {
    }

    public class ReferComponent
    {
    }

    public class RemindsComponent
    {
        [JsonPropertyName("reminds")]
        public List<object> Reminds { get; set; }
    }

    public class ReturnPromise
    {
        [JsonPropertyName("brief")]
        public string Brief { get; set; }

        [JsonPropertyName("detailDescription")]
        public string DetailDescription { get; set; }

        [JsonPropertyName("oldPromiseId")]
        public string OldPromiseId { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("type")]
        public int? Type { get; set; }

        [JsonPropertyName("descriptionForSeller")]
        public string DescriptionForSeller { get; set; }

        [JsonPropertyName("isValuable")]
        public bool? IsValuable { get; set; }

        [JsonPropertyName("descriptionPretty")]
        public string DescriptionPretty { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }
    }

    public class Review
    {
        [JsonPropertyName("spreadStatus")]
        public string SpreadStatus { get; set; }

        [JsonPropertyName("order")]
        public int? Order { get; set; }
    }

    public class AliexpressItem
    {
        [JsonPropertyName("tradeComponent")]
        public TradeComponent TradeComponent { get; set; }

        [JsonPropertyName("pageSizeComponent")]
        public PageSizeComponent PageSizeComponent { get; set; }

        [JsonPropertyName("redirectComponent")]
        public RedirectComponent RedirectComponent { get; set; }

        [JsonPropertyName("metaDataComponent")]
        public MetaDataComponent MetaDataComponent { get; set; }

        [JsonPropertyName("sellerComponent")]
        public SellerComponent SellerComponent { get; set; }

        [JsonPropertyName("plazaSellerServiceComponent")]
        public PlazaSellerServiceComponent PlazaSellerServiceComponent { get; set; }

        [JsonPropertyName("productPropComponent")]
        public ProductPropComponent ProductPropComponent { get; set; }

        [JsonPropertyName("skuComponent")]
        public SkuComponent SkuComponent { get; set; }

        [JsonPropertyName("webActionConfComponent")]
        public WebActionConfComponent WebActionConfComponent { get; set; }

        [JsonPropertyName("cartSideBarInfoComponent")]
        public CartSideBarInfoComponent CartSideBarInfoComponent { get; set; }

        [JsonPropertyName("packageComponent")]
        public PackageComponent PackageComponent { get; set; }

        [JsonPropertyName("productTagComponent")]
        public ProductTagComponent ProductTagComponent { get; set; }

        [JsonPropertyName("blacklistComponent")]
        public BlacklistComponent BlacklistComponent { get; set; }

        [JsonPropertyName("priceComponent")]
        public PriceComponent PriceComponent { get; set; }

        [JsonPropertyName("webLongImageComponent")]
        public WebLongImageComponent WebLongImageComponent { get; set; }

        [JsonPropertyName("wishListComponent")]
        public WishListComponent WishListComponent { get; set; }

        [JsonPropertyName("multiLanguageUrlComponent")]
        public MultiLanguageUrlComponent MultiLanguageUrlComponent { get; set; }

        [JsonPropertyName("webCouponInfoComponent")]
        public WebCouponInfoComponent WebCouponInfoComponent { get; set; }

        [JsonPropertyName("i18nComponent")]
        public I18nComponent I18nComponent { get; set; }

        [JsonPropertyName("bannerComponent")]
        public BannerComponent BannerComponent { get; set; }

        [JsonPropertyName("categoryComponent")]
        public CategoryComponent CategoryComponent { get; set; }

        [JsonPropertyName("buriedLogComponent")]
        public BuriedLogComponent BuriedLogComponent { get; set; }

        [JsonPropertyName("productInfoComponent")]
        public ProductInfoComponent ProductInfoComponent { get; set; }

        [JsonPropertyName("sellerGuaranteeComponent")]
        public SellerGuaranteeComponent SellerGuaranteeComponent { get; set; }

        [JsonPropertyName("buyerComponent")]
        public BuyerComponent BuyerComponent { get; set; }

        [JsonPropertyName("storeHeaderComponent")]
        public StoreHeaderComponent StoreHeaderComponent { get; set; }

        [JsonPropertyName("breadcrumbComponent")]
        public BreadcrumbComponent BreadcrumbComponent { get; set; }

        [JsonPropertyName("abTestComponent")]
        public AbTestComponent AbTestComponent { get; set; }

        [JsonPropertyName("gagaComponent")]
        public GagaComponent GagaComponent { get; set; }

        [JsonPropertyName("choiceAtmosphereComponent")]
        public ChoiceAtmosphereComponent ChoiceAtmosphereComponent { get; set; }

        [JsonPropertyName("sellingPointInfoComponent")]
        public SellingPointInfoComponent SellingPointInfoComponent { get; set; }

        [JsonPropertyName("siteInfoComponent")]
        public SiteInfoComponent SiteInfoComponent { get; set; }

        [JsonPropertyName("remindsComponent")]
        public RemindsComponent RemindsComponent { get; set; }

        [JsonPropertyName("shopCategoryComponent")]
        public ShopCategoryComponent ShopCategoryComponent { get; set; }

        [JsonPropertyName("promotionComponent")]
        public PromotionComponent PromotionComponent { get; set; }

        [JsonPropertyName("sellerPromiseComponent")]
        public SellerPromiseComponent SellerPromiseComponent { get; set; }

        [JsonPropertyName("extraComponent")]
        public ExtraComponent ExtraComponent { get; set; }

        [JsonPropertyName("marketingInfo4ChoiceComponent")]
        public MarketingInfo4ChoiceComponent MarketingInfo4ChoiceComponent { get; set; }

        [JsonPropertyName("storeFeedbackComponent")]
        public StoreFeedbackComponent StoreFeedbackComponent { get; set; }

        [JsonPropertyName("assuranceComponent")]
        public AssuranceComponent AssuranceComponent { get; set; }

        [JsonPropertyName("priceRuleComponent")]
        public PriceRuleComponent PriceRuleComponent { get; set; }

        [JsonPropertyName("marketingInfoComponent")]
        public MarketingInfoComponent MarketingInfoComponent { get; set; }

        [JsonPropertyName("webGeneralFreightCalculateComponent")]
        public WebGeneralFreightCalculateComponent WebGeneralFreightCalculateComponent { get; set; }

        [JsonPropertyName("inventoryComponent")]
        public InventoryComponent InventoryComponent { get; set; }

        [JsonPropertyName("webCouponPriceComponent")]
        public WebCouponPriceComponent WebCouponPriceComponent { get; set; }

        [JsonPropertyName("webViewComponent")]
        public WebViewComponent WebViewComponent { get; set; }

        [JsonPropertyName("installmentComponent")]
        public InstallmentComponent InstallmentComponent { get; set; }

        [JsonPropertyName("productDescComponent")]
        public ProductDescComponent ProductDescComponent { get; set; }

        [JsonPropertyName("categoryTagComponent")]
        public CategoryTagComponent CategoryTagComponent { get; set; }

        [JsonPropertyName("supplementInfoLayoutComponent")]
        public SupplementInfoLayoutComponent SupplementInfoLayoutComponent { get; set; }

        [JsonPropertyName("imageComponent")]
        public ImageComponent ImageComponent { get; set; }

        [JsonPropertyName("recommendComponent")]
        public RecommendComponent RecommendComponent { get; set; }

        [JsonPropertyName("userComponent")]
        public UserComponent UserComponent { get; set; }

        [JsonPropertyName("currencyComponent")]
        public CurrencyComponent CurrencyComponent { get; set; }

        [JsonPropertyName("itemStatusComponent")]
        public ItemStatusComponent ItemStatusComponent { get; set; }

        [JsonPropertyName("referComponent")]
        public ReferComponent ReferComponent { get; set; }

        [JsonPropertyName("feedbackComponent")]
        public FeedbackComponent FeedbackComponent { get; set; }

        [JsonPropertyName("vehicleComponent")]
        public VehicleComponent VehicleComponent { get; set; }

        [JsonPropertyName("displayTitleComponent")]
        public DisplayTitleComponent DisplayTitleComponent { get; set; }
    }

    public class SellerComponent
    {
        [JsonPropertyName("boutiqueSeller")]
        public bool? BoutiqueSeller { get; set; }

        [JsonPropertyName("topRatedSeller")]
        public bool? TopRatedSeller { get; set; }

        [JsonPropertyName("formatOpenTime")]
        public string FormatOpenTime { get; set; }

        [JsonPropertyName("spanishPlaza")]
        public bool? SpanishPlaza { get; set; }

        [JsonPropertyName("ruConsignmentAndMarketPlace")]
        public bool? RuConsignmentAndMarketPlace { get; set; }

        [JsonPropertyName("esRetailOrConsignment")]
        public bool? EsRetailOrConsignment { get; set; }

        [JsonPropertyName("openedYear")]
        public int? OpenedYear { get; set; }

        [JsonPropertyName("plazaElectronicSeller")]
        public bool? PlazaElectronicSeller { get; set; }

        [JsonPropertyName("ruSelfOperation")]
        public bool? RuSelfOperation { get; set; }

        [JsonPropertyName("storeURL")]
        public string StoreURL { get; set; }

        [JsonPropertyName("storeFeedbackURL")]
        public string StoreFeedbackURL { get; set; }

        [JsonPropertyName("storeName")]
        public string StoreName { get; set; }

        [JsonPropertyName("hasStore")]
        public bool? HasStore { get; set; }

        [JsonPropertyName("openTime")]
        public long? OpenTime { get; set; }

        [JsonPropertyName("localSellerTag")]
        public string LocalSellerTag { get; set; }

        [JsonPropertyName("aeRuSelfOperation")]
        public bool? AeRuSelfOperation { get; set; }

        [JsonPropertyName("showPlazaHeader")]
        public bool? ShowPlazaHeader { get; set; }

        [JsonPropertyName("localSeller")]
        public bool? LocalSeller { get; set; }

        [JsonPropertyName("adminSeq")]
        public long? AdminSeq { get; set; }

        [JsonPropertyName("encryptOwnerMemberId")]
        public string EncryptOwnerMemberId { get; set; }

        [JsonPropertyName("countryCompleteName")]
        public string CountryCompleteName { get; set; }

        [JsonPropertyName("companyId")]
        public long? CompanyId { get; set; }

        [JsonPropertyName("storeLogo")]
        public string StoreLogo { get; set; }

        [JsonPropertyName("storeNum")]
        public int? StoreNum { get; set; }

        [JsonPropertyName("payPalAccount")]
        public bool? PayPalAccount { get; set; }
    }

    public class SellerGuaranteeComponent
    {
        [JsonPropertyName("hasOverseaWarehouse")]
        public bool? HasOverseaWarehouse { get; set; }

        [JsonPropertyName("warranyDetailJson")]
        public string WarranyDetailJson { get; set; }

        [JsonPropertyName("forcePromiseWarrantyJson")]
        public string ForcePromiseWarrantyJson { get; set; }
    }

    public class SellerPromiseComponent
    {
        [JsonPropertyName("returnPolicyGuarantees")]
        public List<object> ReturnPolicyGuarantees { get; set; }

        [JsonPropertyName("hasOverseaWarehouse")]
        public bool? HasOverseaWarehouse { get; set; }

        [JsonPropertyName("hasNoReasonFreeReturn")]
        public bool? HasNoReasonFreeReturn { get; set; }

        [JsonPropertyName("warranyDetailMap")]
        public WarranyDetailMap WarranyDetailMap { get; set; }

        [JsonPropertyName("serviceDetails")]
        public ServiceDetails ServiceDetails { get; set; }

        [JsonPropertyName("sellerGuaranteePromiseList")]
        public List<object> SellerGuaranteePromiseList { get; set; }

        [JsonPropertyName("returnPromise")]
        public ReturnPromise ReturnPromise { get; set; }
    }

    public class SellingPointInfoComponent
    {
        [JsonPropertyName("viewMoreText")]
        public string ViewMoreText { get; set; }

        [JsonPropertyName("limitCnt")]
        public int? LimitCnt { get; set; }

        [JsonPropertyName("viewLessText")]
        public string ViewLessText { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }

    public class Separator
    {
        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class ServiceBlockIcon
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class ServiceDetails
    {
        [JsonPropertyName("more")]
        public bool? More { get; set; }

        [JsonPropertyName("details")]
        public List<Detail> Details { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }

    public class ShippingModule
    {
        [JsonPropertyName("HAB_BALLOON_TRAKING_AVAILABLE")]
        public string HABBALLOONTRAKINGAVAILABLE { get; set; }

        [JsonPropertyName("GENERAL_SHIPPING_TO")]
        public string GENERALSHIPPINGTO { get; set; }

        [JsonPropertyName("SELECT_SHIP_FROM_TIP")]
        public string SELECTSHIPFROMTIP { get; set; }

        [JsonPropertyName("SHIPPING_TO")]
        public string SHIPPINGTO { get; set; }

        [JsonPropertyName("HAB_SHIPPING_TO")]
        public string HABSHIPPINGTO { get; set; }

        [JsonPropertyName("CARRIER")]
        public string CARRIER { get; set; }

        [JsonPropertyName("TO_PROVINCE")]
        public string TOPROVINCE { get; set; }

        [JsonPropertyName("TO_COUNTRY")]
        public string TOCOUNTRY { get; set; }

        [JsonPropertyName("TO_CITY")]
        public string TOCITY { get; set; }

        [JsonPropertyName("CAN_NOE_DELIVER_NOTE")]
        public string CANNOEDELIVERNOTE { get; set; }

        [JsonPropertyName("ESTIMATED_DELIVERT_ON_DAYS")]
        public string ESTIMATEDDELIVERTONDAYS { get; set; }

        [JsonPropertyName("CHOOSE_DELIVERT_METHOD")]
        public string CHOOSEDELIVERTMETHOD { get; set; }

        [JsonPropertyName("HAB_BALLOON_DOOR_DELIVERY")]
        public string HABBALLOONDOORDELIVERY { get; set; }

        [JsonPropertyName("DELIVERED_BY")]
        public string DELIVEREDBY { get; set; }

        [JsonPropertyName("HBA_SHIPPING_INFO")]
        public string HBASHIPPINGINFO { get; set; }

        [JsonPropertyName("IN")]
        public string IN { get; set; }

        [JsonPropertyName("SEARCH")]
        public string SEARCH { get; set; }

        [JsonPropertyName("SELECT_SHIP_FROM")]
        public string SELECTSHIPFROM { get; set; }

        [JsonPropertyName("LOGISTIC_COMPOSE_AE")]
        public string LOGISTICCOMPOSEAE { get; set; }

        [JsonPropertyName("HBA_BALLOON_TIPS")]
        public string HBABALLOONTIPS { get; set; }

        [JsonPropertyName("GENERAL_SHIPPING_DELIVERY")]
        public string GENERALSHIPPINGDELIVERY { get; set; }

        [JsonPropertyName("VAT_DE_DETAIL")]
        public string VATDEDETAIL { get; set; }

        [JsonPropertyName("SELECTED")]
        public string SELECTED { get; set; }

        [JsonPropertyName("HBA_DOR_DELIVERY")]
        public string HBADORDELIVERY { get; set; }

        [JsonPropertyName("ESTIMATED_DELIVERT_ON_DATE")]
        public string ESTIMATEDDELIVERTONDATE { get; set; }

        [JsonPropertyName("OR_FULL_REFOUND")]
        public string ORFULLREFOUND { get; set; }

        [JsonPropertyName("LOGISTIC_COMPOSE_BRAND_MIND")]
        public string LOGISTICCOMPOSEBRANDMIND { get; set; }

        [JsonPropertyName("PLAZA_SHOP_NOW_RECEIVE_ON")]
        public string PLAZASHOPNOWRECEIVEON { get; set; }

        [JsonPropertyName("LOGISTIC_COMPOSE_ORDERS_OVER")]
        public string LOGISTICCOMPOSEORDERSOVER { get; set; }

        [JsonPropertyName("FAST_SHIPPING")]
        public string FASTSHIPPING { get; set; }

        [JsonPropertyName("CAN_NOT_DELIVER")]
        public string CANNOTDELIVER { get; set; }

        [JsonPropertyName("HBA_TRAKING_AVAILABLE")]
        public string HBATRAKINGAVAILABLE { get; set; }

        [JsonPropertyName("DAYS")]
        public string DAYS { get; set; }

        [JsonPropertyName("GENERAL_SHIPPIING_FROM")]
        public string GENERALSHIPPIINGFROM { get; set; }

        [JsonPropertyName("GENERAL_SHPPING_MORE")]
        public string GENERALSHPPINGMORE { get; set; }

        [JsonPropertyName("FREE_SHIPPING")]
        public string FREESHIPPING { get; set; }

        [JsonPropertyName("COST")]
        public string COST { get; set; }

        [JsonPropertyName("BALLOON_TIP")]
        public string BALLOONTIP { get; set; }

        [JsonPropertyName("SHIP_MY_ITEM_TO")]
        public string SHIPMYITEMTO { get; set; }

        [JsonPropertyName("HAB_BALLOON_VAT_INCLUDED")]
        public string HABBALLOONVATINCLUDED { get; set; }

        [JsonPropertyName("TRACKING")]
        public string TRACKING { get; set; }

        [JsonPropertyName("LOGISTIC_COMPOSE_SPEED_UP")]
        public string LOGISTICCOMPOSESPEEDUP { get; set; }

        [JsonPropertyName("PLAZA_BALLOON_TIP")]
        public string PLAZABALLOONTIP { get; set; }

        [JsonPropertyName("HBA_TVAT_INCLUDED")]
        public string HBATVATINCLUDED { get; set; }

        [JsonPropertyName("ESTIMATED_DELIVERY")]
        public string ESTIMATEDDELIVERY { get; set; }

        [JsonPropertyName("TO_WHERE")]
        public string TOWHERE { get; set; }

        [JsonPropertyName("VAT_NUMBER")]
        public string VATNUMBER { get; set; }

        [JsonPropertyName("TO_VIA")]
        public string TOVIA { get; set; }

        [JsonPropertyName("APPLY")]
        public string APPLY { get; set; }
    }

    public class ShopCategoryComponent
    {
        [JsonPropertyName("productGroupsResult")]
        public ProductGroupsResult ProductGroupsResult { get; set; }
    }

    public class SiteInfoComponent
    {
        [JsonPropertyName("wholesaleSubServer")]
        public string WholesaleSubServer { get; set; }

        [JsonPropertyName("crawler")]
        public bool? Crawler { get; set; }

        [JsonPropertyName("siteType")]
        public string SiteType { get; set; }
    }

    public class SkuActivityAmount
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("formatedAmount")]
        public string FormatedAmount { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class SkuAmount
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("formatedAmount")]
        public string FormatedAmount { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class SkuComponent
    {
        [JsonPropertyName("selectedSkuAttr")]
        public string SelectedSkuAttr { get; set; }

        [JsonPropertyName("hasSkuProperty")]
        public bool? HasSkuProperty { get; set; }

        [JsonPropertyName("productSKUPropertyList")]
        public List<ProductSKUPropertyList> ProductSKUPropertyList { get; set; }

        [JsonPropertyName("skuPropertyJson")]
        public string SkuPropertyJson { get; set; }
    }

    public class SKUModule
    {
        [JsonPropertyName("SIZING_INFO")]
        public string SIZINGINFO { get; set; }

        [JsonPropertyName("BUST_PROMPT")]
        public string BUSTPROMPT { get; set; }

        [JsonPropertyName("GLASSES_DIALOG_TITLE")]
        public string GLASSESDIALOGTITLE { get; set; }

        [JsonPropertyName("NV_ADD")]
        public string NVADD { get; set; }

        [JsonPropertyName("SPH")]
        public string SPH { get; set; }

        [JsonPropertyName("PUPILLARY_PROMPT")]
        public string PUPILLARYPROMPT { get; set; }

        [JsonPropertyName("SIZE_HOVER_TITLE")]
        public string SIZEHOVERTITLE { get; set; }

        [JsonPropertyName("FLOOR_CONTENT")]
        public string FLOORCONTENT { get; set; }

        [JsonPropertyName("CUSTOM_SIZE_CONTENT")]
        public string CUSTOMSIZECONTENT { get; set; }

        [JsonPropertyName("NV_ADD_PROMPT")]
        public string NVADDPROMPT { get; set; }

        [JsonPropertyName("PLEASE_ENTER")]
        public string PLEASEENTER { get; set; }

        [JsonPropertyName("WAIST_TITLE")]
        public string WAISTTITLE { get; set; }

        [JsonPropertyName("WAIST_CONTENT")]
        public string WAISTCONTENT { get; set; }

        [JsonPropertyName("CYL")]
        public string CYL { get; set; }

        [JsonPropertyName("SERVICE")]
        public string SERVICE { get; set; }

        [JsonPropertyName("BUST_CONTENT")]
        public string BUSTCONTENT { get; set; }

        [JsonPropertyName("SIZE_INFO")]
        public string SIZEINFO { get; set; }

        [JsonPropertyName("SIZE_INFO_DESC")]
        public string SIZEINFODESC { get; set; }

        [JsonPropertyName("ITEM_CONDITION_TIP")]
        public string ITEMCONDITIONTIP { get; set; }

        [JsonPropertyName("BTN_CANCEL")]
        public string BTNCANCEL { get; set; }

        [JsonPropertyName("HOW_TO_MEASURE")]
        public string HOWTOMEASURE { get; set; }

        [JsonPropertyName("SIZE_INFO_TIP")]
        public string SIZEINFOTIP { get; set; }

        [JsonPropertyName("FLOOR_PROMPT")]
        public string FLOORPROMPT { get; set; }

        [JsonPropertyName("FLOOR_TITLE")]
        public string FLOORTITLE { get; set; }

        [JsonPropertyName("SIZE_INFO_COMPARE_TIP")]
        public string SIZEINFOCOMPARETIP { get; set; }

        [JsonPropertyName("UNIT_PROMPT")]
        public string UNITPROMPT { get; set; }

        [JsonPropertyName("SELECT")]
        public string SELECT { get; set; }

        [JsonPropertyName("HIPS_TITLE")]
        public string HIPSTITLE { get; set; }

        [JsonPropertyName("HEIGHT_PROMPT")]
        public string HEIGHTPROMPT { get; set; }

        [JsonPropertyName("WAIST_PROMPT")]
        public string WAISTPROMPT { get; set; }

        [JsonPropertyName("BTN_SAVE")]
        public string BTNSAVE { get; set; }

        [JsonPropertyName("TITLE_OPTIONAL")]
        public string TITLEOPTIONAL { get; set; }

        [JsonPropertyName("SIZE_DIALOG_TITLE")]
        public string SIZEDIALOGTITLE { get; set; }

        [JsonPropertyName("GLASSES_TIP")]
        public string GLASSESTIP { get; set; }

        [JsonPropertyName("SIZE_CHART")]
        public string SIZECHART { get; set; }

        [JsonPropertyName("HIPS_PROMPT")]
        public string HIPSPROMPT { get; set; }

        [JsonPropertyName("SPH_PROMPT")]
        public string SPHPROMPT { get; set; }

        [JsonPropertyName("HIPS_CONTENT")]
        public string HIPSCONTENT { get; set; }

        [JsonPropertyName("BUST_TITLE")]
        public string BUSTTITLE { get; set; }

        [JsonPropertyName("AXIS")]
        public string AXIS { get; set; }
    }

    public class SkuPriceList
    {
        [JsonPropertyName("skuVal")]
        public SkuVal SkuVal { get; set; }

        [JsonPropertyName("skuPropIds")]
        public string SkuPropIds { get; set; }

        [JsonPropertyName("skuIdStr")]
        public string SkuIdStr { get; set; }

        [JsonPropertyName("bannerInfo")]
        public BannerInfo BannerInfo { get; set; }

        [JsonPropertyName("freightExt")]
        public string FreightExt { get; set; }

        [JsonPropertyName("salable")]
        public bool? Salable { get; set; }

        [JsonPropertyName("skuAttr")]
        public string SkuAttr { get; set; }

        [JsonPropertyName("skuId")]
        public object SkuId { get; set; }
    }

    public class SkuPropertyValue
    {
        [JsonPropertyName("skuColorValue")]
        public string SkuColorValue { get; set; }

        [JsonPropertyName("skuPropertyTips")]
        public string SkuPropertyTips { get; set; }

        [JsonPropertyName("propertyValueName")]
        public string PropertyValueName { get; set; }

        [JsonPropertyName("propertyValueId")]
        public int? PropertyValueId { get; set; }

        [JsonPropertyName("skuPropertyImagePath")]
        public string SkuPropertyImagePath { get; set; }

        [JsonPropertyName("skuPropertyValueTips")]
        public string SkuPropertyValueTips { get; set; }

        [JsonPropertyName("skuPropertyValueShowOrder")]
        public int? SkuPropertyValueShowOrder { get; set; }

        [JsonPropertyName("propertyValueDefinitionName")]
        public string PropertyValueDefinitionName { get; set; }

        [JsonPropertyName("propertyValueIdLong")]
        public int? PropertyValueIdLong { get; set; }

        [JsonPropertyName("skuPropertyImageSummPath")]
        public string SkuPropertyImageSummPath { get; set; }

        [JsonPropertyName("propertyValueDisplayName")]
        public string PropertyValueDisplayName { get; set; }
    }

    public class SkuVal
    {
        [JsonPropertyName("optionalWarrantyPrice")]
        public List<object> OptionalWarrantyPrice { get; set; }

        [JsonPropertyName("skuAmount")]
        public SkuAmount SkuAmount { get; set; }

        [JsonPropertyName("discount")]
        public string Discount { get; set; }

        [JsonPropertyName("availQuantity")]
        public int? AvailQuantity { get; set; }

        [JsonPropertyName("inventory")]
        public int? Inventory { get; set; }

        [JsonPropertyName("hideOriPrice")]
        public bool? HideOriPrice { get; set; }

        [JsonPropertyName("skuCalPrice")]
        public string SkuCalPrice { get; set; }

        [JsonPropertyName("skuAmountLocal")]
        public string SkuAmountLocal { get; set; }

        [JsonPropertyName("skuActivityAmountLocal")]
        public string SkuActivityAmountLocal { get; set; }

        [JsonPropertyName("discountTips")]
        public string DiscountTips { get; set; }

        [JsonPropertyName("isActivity")]
        public bool? IsActivity { get; set; }

        [JsonPropertyName("skuActivityAmount")]
        public SkuActivityAmount SkuActivityAmount { get; set; }
    }

    public class Slogan
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class Specification
    {
        [JsonPropertyName("spreadStatus")]
        public string SpreadStatus { get; set; }

        [JsonPropertyName("order")]
        public int? Order { get; set; }
    }

    public class StoreFeedbackComponent
    {
        [JsonPropertyName("sellerScore")]
        public int? SellerScore { get; set; }

        [JsonPropertyName("sellerTotalNum")]
        public int? SellerTotalNum { get; set; }

        [JsonPropertyName("sellerLevel")]
        public string SellerLevel { get; set; }

        [JsonPropertyName("sellerPositiveRate")]
        public string SellerPositiveRate { get; set; }

        [JsonPropertyName("sellerPositiveNum")]
        public int? SellerPositiveNum { get; set; }
    }

    public class StoreHeaderComponent
    {
        [JsonPropertyName("storeHeaderResult")]
        public StoreHeaderResult StoreHeaderResult { get; set; }
    }

    public class StoreHeaderResult
    {
        [JsonPropertyName("shopTagUrl")]
        public string ShopTagUrl { get; set; }
    }

    public class StoreInfo
    {
        [JsonPropertyName("shippingSpeed")]
        public string ShippingSpeed { get; set; }

        [JsonPropertyName("below_average")]
        public string BelowAverage { get; set; }

        [JsonPropertyName("higher_seller")]
        public string HigherSeller { get; set; }

        [JsonPropertyName("storeId")]
        public string StoreId { get; set; }

        [JsonPropertyName("openSince")]
        public string OpenSince { get; set; }

        [JsonPropertyName("above_average")]
        public string AboveAverage { get; set; }

        [JsonPropertyName("itemAsDescribed")]
        public string ItemAsDescribed { get; set; }

        [JsonPropertyName("lower_seller")]
        public string LowerSeller { get; set; }

        [JsonPropertyName("businessInfo")]
        public string BusinessInfo { get; set; }

        [JsonPropertyName("equal")]
        public string Equal { get; set; }

        [JsonPropertyName("storeName")]
        public string StoreName { get; set; }

        //[JsonPropertyName("storeInfo")]
        //public string StoreInfo { get; set; }

        [JsonPropertyName("storeRating")]
        public string StoreRating { get; set; }

        [JsonPropertyName("businessAddress")]
        public string BusinessAddress { get; set; }

        [JsonPropertyName("communication")]
        public string Communication { get; set; }

        [JsonPropertyName("equal_seller")]
        public string EqualSeller { get; set; }
    }

    public class StoreModule
    {
        [JsonPropertyName("COUSTOMER_SERVICE")]
        public string COUSTOMERSERVICE { get; set; }

        [JsonPropertyName("VISIT_STORE")]
        public string VISITSTORE { get; set; }

        [JsonPropertyName("CONTACT_SELLER")]
        public string CONTACTSELLER { get; set; }

        [JsonPropertyName("FOLLOWING_STATE")]
        public string FOLLOWINGSTATE { get; set; }

        [JsonPropertyName("UNFOLLOWING_STATE")]
        public string UNFOLLOWINGSTATE { get; set; }

        [JsonPropertyName("POSITIVE_FEEDBACK")]
        public string POSITIVEFEEDBACK { get; set; }

        [JsonPropertyName("FOLLOWERS")]
        public string FOLLOWERS { get; set; }

        [JsonPropertyName("FOLLOWER")]
        public string FOLLOWER { get; set; }

        [JsonPropertyName("TOP_SELLER")]
        public string TOPSELLER { get; set; }

        [JsonPropertyName("STORE_CATEGORIES")]
        public string STORECATEGORIES { get; set; }
    }

    public class StoreMultilanguageUrlList
    {
        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("languageUrl")]
        public string LanguageUrl { get; set; }
    }

    public class SupplementaryList
    {
        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class SupplementInfoLayoutComponent
    {
        [JsonPropertyName("moduleLayoutInfo")]
        public ModuleLayoutInfo ModuleLayoutInfo { get; set; }
    }

    public class SwitchInfo
    {
        [JsonPropertyName("showPropOuter")]
        public bool? ShowPropOuter { get; set; }

        [JsonPropertyName("deliveryMigrate")]
        public bool? DeliveryMigrate { get; set; }

        [JsonPropertyName("skuUnavailableRevision")]
        public bool? SkuUnavailableRevision { get; set; }

        [JsonPropertyName("allowUSVisitorCart")]
        public bool? AllowUSVisitorCart { get; set; }

        [JsonPropertyName("showPropGroups")]
        public bool? ShowPropGroups { get; set; }
    }

    public class TitleModule
    {
        [JsonPropertyName("REVIEWS")]
        public string REVIEWS { get; set; }

        [JsonPropertyName("VIEW_ALL_REVIEWS")]
        public string VIEWALLREVIEWS { get; set; }

        [JsonPropertyName("REVIEW")]
        public string REVIEW { get; set; }

        [JsonPropertyName("VIEW_OTHER_TITLE")]
        public string VIEWOTHERTITLE { get; set; }

        [JsonPropertyName("VIEW_EN_TITLE")]
        public string VIEWENTITLE { get; set; }

        [JsonPropertyName("FREEBIE_REVIEW")]
        public string FREEBIEREVIEW { get; set; }

        [JsonPropertyName("FREEBIE_REVIEWS")]
        public string FREEBIEREVIEWS { get; set; }
    }

    public class TradeComponent
    {
        [JsonPropertyName("formatTradeCount")]
        public string FormatTradeCount { get; set; }

        [JsonPropertyName("tradeCountUnit")]
        public string TradeCountUnit { get; set; }
    }

    public class UiTestInfo
    {
    }

    public class UserComponent
    {
        [JsonPropertyName("currentTime")]
        public long? CurrentTime { get; set; }

        [JsonPropertyName("regionCountryName")]
        public string RegionCountryName { get; set; }

        [JsonPropertyName("userCountryName")]
        public string UserCountryName { get; set; }

        [JsonPropertyName("userCountryCode")]
        public string UserCountryCode { get; set; }
    }

    public class VehicleComponent
    {
    }

    public class Warranty
    {
    }

    public class WarranyDetailMap
    {
    }

    public class WebActionConfComponent
    {
        [JsonPropertyName("actionConfs")]
        public ActionConfs ActionConfs { get; set; }

        [JsonPropertyName("orderUrl")]
        public string OrderUrl { get; set; }

        [JsonPropertyName("shoppingCartUrl")]
        public string ShoppingCartUrl { get; set; }
    }

    public class WebCouponInfoComponent
    {
        [JsonPropertyName("usingNewCouponApi")]
        public bool? UsingNewCouponApi { get; set; }

        [JsonPropertyName("couponList")]
        public List<object> CouponList { get; set; }

        [JsonPropertyName("promotionPanelDTO")]
        public PromotionPanelDTO PromotionPanelDTO { get; set; }

        [JsonPropertyName("couponAttributes")]
        public CouponAttributes CouponAttributes { get; set; }
    }

    public class WebCouponPriceComponent
    {
    }

    public class WebGeneralFreightCalculateComponent
    {
        [JsonPropertyName("hideShipFrom")]
        public bool? HideShipFrom { get; set; }

        [JsonPropertyName("allowArouseLayer")]
        public bool? AllowArouseLayer { get; set; }

        [JsonPropertyName("shippingFeeText")]
        public string ShippingFeeText { get; set; }

        [JsonPropertyName("originalLayoutResultList")]
        public List<OriginalLayoutResultList> OriginalLayoutResultList { get; set; }

        [JsonPropertyName("deliveryExtraInfoMap")]
        public DeliveryExtraInfoMap DeliveryExtraInfoMap { get; set; }

        [JsonPropertyName("freightExt")]
        public string FreightExt { get; set; }

        [JsonPropertyName("styleCode")]
        public string StyleCode { get; set; }

        [JsonPropertyName("promotionId")]
        public string PromotionId { get; set; }

        [JsonPropertyName("usingNewFreight")]
        public bool? UsingNewFreight { get; set; }
    }

    public class WebLongImageComponent
    {
        [JsonPropertyName("showLongImage")]
        public bool? ShowLongImage { get; set; }
    }

    public class WebViewComponent
    {
        [JsonPropertyName("viewName")]
        public string ViewName { get; set; }
    }

    public class WishListComponent
    {
        [JsonPropertyName("storeWishedCount")]
        public int? StoreWishedCount { get; set; }

        [JsonPropertyName("itemWishedCount")]
        public int? ItemWishedCount { get; set; }

        [JsonPropertyName("storeWished")]
        public bool? StoreWished { get; set; }

        [JsonPropertyName("itemWished")]
        public bool? ItemWished { get; set; }
    }
}
