// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	public enum EPackageStatus : int
	{
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class IClientBillingVTable
	{
		public IntPtr PurchaseWithActivationCode0;
		public IntPtr CancelLicense1;
		public IntPtr AcknowledgePurchaseReceipt2;
		public IntPtr GetLicensePackageID3;
		public IntPtr GetLicenseTimeCreated4;
		public IntPtr GetLicenseTimeNextProcess5;
		public IntPtr GetLicenseMinuteLimit6;
		public IntPtr GetLicenseMinutesUsed7;
		public IntPtr GetLicensePaymentMethod8;
		public IntPtr GetLicenseFlags9;
		public IntPtr GetLicensePurchaseCountryCode10;
		public IntPtr GetLicenseTerritoryCode11;
		public IntPtr GetLicenseInfo12;
		public IntPtr GetReceiptPackageID13;
		public IntPtr GetReceiptStatus14;
		public IntPtr GetReceiptResultDetail15;
		public IntPtr GetReceiptTransTime16;
		public IntPtr GetReceiptTransID17;
		public IntPtr GetReceiptAcknowledged18;
		public IntPtr GetReceiptPaymentMethod19;
		public IntPtr GetReceiptBaseCost20;
		public IntPtr GetReceiptTotalDiscount21;
		public IntPtr GetReceiptTax22;
		public IntPtr GetReceiptShipping23;
		public IntPtr GetReceiptCurrencyCode24;
		public IntPtr GetReceiptCountryCode25;
		public IntPtr GetReceiptErrorHeadline26;
		public IntPtr GetReceiptErrorString27;
		public IntPtr GetReceiptErrorLinkText28;
		public IntPtr GetReceiptErrorLinkURL29;
		public IntPtr GetReceiptErrorAppID30;
		public IntPtr GetNumLicenses31;
		public IntPtr GetNumReceipts32;
		public IntPtr PurchaseWithMachineID33;
		public IntPtr GetReceiptCardInfo34;
		public IntPtr GetReceiptBillingAddress35;
		public IntPtr GetReceiptLineItemCount36;
		public IntPtr GetReceiptLineItemInfo37;
		public IntPtr EnableTestLicense38;
		public IntPtr DisableTestLicense39;
		public IntPtr ActivateOEMTicket40;
		public IntPtr GetLicenseForAppID41;
		public IntPtr GetPackageName42;
		public IntPtr GetPackageInfo43;
		public IntPtr GetAppsInPackage44;
		public IntPtr GetPackageExtendedInfo45;
		public IntPtr RequestFreeLicenseForApp46;
		private IntPtr DTorIClientBilling47;
	};
	
	[InteropHelp.InterfaceVersion("CLIENTBILLING_INTERFACE_VERSION001")]
	public class IClientBilling : InteropHelp.NativeWrapper<IClientBillingVTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativePurchaseWithActivationCodeS( IntPtr thisptr, string pchActivationCode );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool PurchaseWithActivationCode( string pchActivationCode ) 
		{
			return this.GetFunction<NativePurchaseWithActivationCodeS>( this.Functions.PurchaseWithActivationCode0 )( this.ObjectAddress, pchActivationCode ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeCancelLicenseUI( IntPtr thisptr, UInt32 packageID, Int32 nCancelReason );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool CancelLicense( UInt32 packageID, Int32 nCancelReason ) 
		{
			return this.GetFunction<NativeCancelLicenseUI>( this.Functions.CancelLicense1 )( this.ObjectAddress, packageID, nCancelReason ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeAcknowledgePurchaseReceiptU( IntPtr thisptr, UInt32 nReceiptIndex );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool AcknowledgePurchaseReceipt( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeAcknowledgePurchaseReceiptU>( this.Functions.AcknowledgePurchaseReceipt2 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetLicensePackageIDU( IntPtr thisptr, UInt32 nLicenseIndex );
		public UInt32 GetLicensePackageID( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicensePackageIDU>( this.Functions.GetLicensePackageID3 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetLicenseTimeCreatedU( IntPtr thisptr, UInt32 nLicenseIndex );
		public UInt32 GetLicenseTimeCreated( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicenseTimeCreatedU>( this.Functions.GetLicenseTimeCreated4 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetLicenseTimeNextProcessU( IntPtr thisptr, UInt32 nLicenseIndex );
		public UInt32 GetLicenseTimeNextProcess( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicenseTimeNextProcessU>( this.Functions.GetLicenseTimeNextProcess5 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLicenseMinuteLimitU( IntPtr thisptr, UInt32 nLicenseIndex );
		public Int32 GetLicenseMinuteLimit( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicenseMinuteLimitU>( this.Functions.GetLicenseMinuteLimit6 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLicenseMinutesUsedU( IntPtr thisptr, UInt32 nLicenseIndex );
		public Int32 GetLicenseMinutesUsed( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicenseMinutesUsedU>( this.Functions.GetLicenseMinutesUsed7 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EPaymentMethod NativeGetLicensePaymentMethodU( IntPtr thisptr, UInt32 nLicenseIndex );
		public EPaymentMethod GetLicensePaymentMethod( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicensePaymentMethodU>( this.Functions.GetLicensePaymentMethod8 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ELicenseFlags NativeGetLicenseFlagsU( IntPtr thisptr, UInt32 nLicenseIndex );
		public ELicenseFlags GetLicenseFlags( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicenseFlagsU>( this.Functions.GetLicenseFlags9 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetLicensePurchaseCountryCodeU( IntPtr thisptr, UInt32 nLicenseIndex );
		public string GetLicensePurchaseCountryCode( UInt32 nLicenseIndex ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetLicensePurchaseCountryCodeU>( this.Functions.GetLicensePurchaseCountryCode10 )( this.ObjectAddress, nLicenseIndex ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLicenseTerritoryCodeU( IntPtr thisptr, UInt32 nLicenseIndex );
		public Int32 GetLicenseTerritoryCode( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicenseTerritoryCodeU>( this.Functions.GetLicenseTerritoryCode11 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetLicenseInfoUUUIIEUIS( IntPtr thisptr, UInt32 nLicenseIndex, ref UInt32 pRTime32Created, ref UInt32 pRTime32NextProcess, ref Int32 pnMinuteLimit, ref Int32 pnMinutesUsed, ref EPaymentMethod pePaymentMethod, ref UInt32 punFlags, ref Int32 pnTerritoryCode, StringBuilder prgchPurchaseCountryCode );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetLicenseInfo( UInt32 nLicenseIndex, ref UInt32 pRTime32Created, ref UInt32 pRTime32NextProcess, ref Int32 pnMinuteLimit, ref Int32 pnMinutesUsed, ref EPaymentMethod pePaymentMethod, ref UInt32 punFlags, ref Int32 pnTerritoryCode, StringBuilder prgchPurchaseCountryCode ) 
		{
			return this.GetFunction<NativeGetLicenseInfoUUUIIEUIS>( this.Functions.GetLicenseInfo12 )( this.ObjectAddress, nLicenseIndex, ref pRTime32Created, ref pRTime32NextProcess, ref pnMinuteLimit, ref pnMinutesUsed, ref pePaymentMethod, ref punFlags, ref pnTerritoryCode, prgchPurchaseCountryCode ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetReceiptPackageIDU( IntPtr thisptr, UInt32 nReceiptIndex );
		public UInt32 GetReceiptPackageID( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptPackageIDU>( this.Functions.GetReceiptPackageID13 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EPurchaseStatus NativeGetReceiptStatusU( IntPtr thisptr, UInt32 nReceiptIndex );
		public EPurchaseStatus GetReceiptStatus( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptStatusU>( this.Functions.GetReceiptStatus14 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EPurchaseResultDetail NativeGetReceiptResultDetailU( IntPtr thisptr, UInt32 nReceiptIndex );
		public EPurchaseResultDetail GetReceiptResultDetail( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptResultDetailU>( this.Functions.GetReceiptResultDetail15 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetReceiptTransTimeU( IntPtr thisptr, UInt32 nReceiptIndex );
		public UInt32 GetReceiptTransTime( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptTransTimeU>( this.Functions.GetReceiptTransTime16 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetReceiptTransIDU( IntPtr thisptr, UInt32 nReceiptIndex );
		public UInt64 GetReceiptTransID( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptTransIDU>( this.Functions.GetReceiptTransID17 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetReceiptAcknowledgedU( IntPtr thisptr, UInt32 nReceiptIndex );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetReceiptAcknowledged( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptAcknowledgedU>( this.Functions.GetReceiptAcknowledged18 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EPaymentMethod NativeGetReceiptPaymentMethodU( IntPtr thisptr, UInt32 nReceiptIndex );
		public EPaymentMethod GetReceiptPaymentMethod( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptPaymentMethodU>( this.Functions.GetReceiptPaymentMethod19 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetReceiptBaseCostU( IntPtr thisptr, UInt32 nReceiptIndex );
		public UInt32 GetReceiptBaseCost( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptBaseCostU>( this.Functions.GetReceiptBaseCost20 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetReceiptTotalDiscountU( IntPtr thisptr, UInt32 nReceiptIndex );
		public UInt32 GetReceiptTotalDiscount( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptTotalDiscountU>( this.Functions.GetReceiptTotalDiscount21 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetReceiptTaxU( IntPtr thisptr, UInt32 nReceiptIndex );
		public UInt32 GetReceiptTax( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptTaxU>( this.Functions.GetReceiptTax22 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetReceiptShippingU( IntPtr thisptr, UInt32 nReceiptIndex );
		public UInt32 GetReceiptShipping( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptShippingU>( this.Functions.GetReceiptShipping23 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ECurrencyCode NativeGetReceiptCurrencyCodeU( IntPtr thisptr, UInt32 nReceiptIndex );
		public ECurrencyCode GetReceiptCurrencyCode( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptCurrencyCodeU>( this.Functions.GetReceiptCurrencyCode24 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetReceiptCountryCodeU( IntPtr thisptr, UInt32 nReceiptIndex );
		public string GetReceiptCountryCode( UInt32 nReceiptIndex ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetReceiptCountryCodeU>( this.Functions.GetReceiptCountryCode25 )( this.ObjectAddress, nReceiptIndex ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetReceiptErrorHeadlineU( IntPtr thisptr, UInt32 nReceiptIndex );
		public string GetReceiptErrorHeadline( UInt32 nReceiptIndex ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetReceiptErrorHeadlineU>( this.Functions.GetReceiptErrorHeadline26 )( this.ObjectAddress, nReceiptIndex ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetReceiptErrorStringU( IntPtr thisptr, UInt32 nReceiptIndex );
		public string GetReceiptErrorString( UInt32 nReceiptIndex ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetReceiptErrorStringU>( this.Functions.GetReceiptErrorString27 )( this.ObjectAddress, nReceiptIndex ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetReceiptErrorLinkTextU( IntPtr thisptr, UInt32 nReceiptIndex );
		public string GetReceiptErrorLinkText( UInt32 nReceiptIndex ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetReceiptErrorLinkTextU>( this.Functions.GetReceiptErrorLinkText28 )( this.ObjectAddress, nReceiptIndex ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetReceiptErrorLinkURLU( IntPtr thisptr, UInt32 nReceiptIndex );
		public string GetReceiptErrorLinkURL( UInt32 nReceiptIndex ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetReceiptErrorLinkURLU>( this.Functions.GetReceiptErrorLinkURL29 )( this.ObjectAddress, nReceiptIndex ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetReceiptErrorAppIDU( IntPtr thisptr, UInt32 nReceiptIndex );
		public UInt32 GetReceiptErrorAppID( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptErrorAppIDU>( this.Functions.GetReceiptErrorAppID30 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetNumLicenses( IntPtr thisptr );
		public UInt32 GetNumLicenses(  ) 
		{
			return this.GetFunction<NativeGetNumLicenses>( this.Functions.GetNumLicenses31 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetNumReceipts( IntPtr thisptr );
		public UInt32 GetNumReceipts(  ) 
		{
			return this.GetFunction<NativeGetNumReceipts>( this.Functions.GetNumReceipts32 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativePurchaseWithMachineIDUS( IntPtr thisptr, UInt32 nPackageID, string pchCustomData );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool PurchaseWithMachineID( UInt32 nPackageID, string pchCustomData ) 
		{
			return this.GetFunction<NativePurchaseWithMachineIDUS>( this.Functions.PurchaseWithMachineID33 )( this.ObjectAddress, nPackageID, pchCustomData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetReceiptCardInfoUESSSSS( IntPtr thisptr, UInt32 nReceiptIndex, ref ECreditCardType eCreditCardType, StringBuilder pchCardLast4Digits, StringBuilder pchCardHolderFirstName, StringBuilder pchCardHolderLastName, StringBuilder pchCardExpYear, StringBuilder pchCardExpMonth );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetReceiptCardInfo( UInt32 nReceiptIndex, ref ECreditCardType eCreditCardType, StringBuilder pchCardLast4Digits, StringBuilder pchCardHolderFirstName, StringBuilder pchCardHolderLastName, StringBuilder pchCardExpYear, StringBuilder pchCardExpMonth ) 
		{
			return this.GetFunction<NativeGetReceiptCardInfoUESSSSS>( this.Functions.GetReceiptCardInfo34 )( this.ObjectAddress, nReceiptIndex, ref eCreditCardType, pchCardLast4Digits, pchCardHolderFirstName, pchCardHolderLastName, pchCardExpYear, pchCardExpMonth ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetReceiptBillingAddressUSSSSSSSSS( IntPtr thisptr, UInt32 nReceiptIndex, StringBuilder pchFirstName, StringBuilder pchLastName, StringBuilder pchAddress1, StringBuilder pchAddress2, StringBuilder pchCity, StringBuilder pchPostcode, StringBuilder pchState, StringBuilder pchCountry, StringBuilder pchPhone );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetReceiptBillingAddress( UInt32 nReceiptIndex, StringBuilder pchFirstName, StringBuilder pchLastName, StringBuilder pchAddress1, StringBuilder pchAddress2, StringBuilder pchCity, StringBuilder pchPostcode, StringBuilder pchState, StringBuilder pchCountry, StringBuilder pchPhone ) 
		{
			return this.GetFunction<NativeGetReceiptBillingAddressUSSSSSSSSS>( this.Functions.GetReceiptBillingAddress35 )( this.ObjectAddress, nReceiptIndex, pchFirstName, pchLastName, pchAddress1, pchAddress2, pchCity, pchPostcode, pchState, pchCountry, pchPhone ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetReceiptLineItemCountU( IntPtr thisptr, UInt32 nReceiptIndex );
		public UInt32 GetReceiptLineItemCount( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptLineItemCountU>( this.Functions.GetReceiptLineItemCount36 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetReceiptLineItemInfoUUUUUUUEUS( IntPtr thisptr, UInt32 nReceiptIndex, UInt32 nLineItemIndex, ref UInt32 nPackageID, ref UInt32 nBaseCost, ref UInt32 nDiscount, ref UInt32 nTax, ref UInt32 nShipping, ref ECurrencyCode eCurrencyCode, ref UInt32 punAppId, StringBuilder pchDescription );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetReceiptLineItemInfo( UInt32 nReceiptIndex, UInt32 nLineItemIndex, ref UInt32 nPackageID, ref UInt32 nBaseCost, ref UInt32 nDiscount, ref UInt32 nTax, ref UInt32 nShipping, ref ECurrencyCode eCurrencyCode, ref UInt32 punAppId, StringBuilder pchDescription ) 
		{
			return this.GetFunction<NativeGetReceiptLineItemInfoUUUUUUUEUS>( this.Functions.GetReceiptLineItemInfo37 )( this.ObjectAddress, nReceiptIndex, nLineItemIndex, ref nPackageID, ref nBaseCost, ref nDiscount, ref nTax, ref nShipping, ref eCurrencyCode, ref punAppId, pchDescription ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeEnableTestLicenseU( IntPtr thisptr, UInt32 unPackageID );
		public void EnableTestLicense( UInt32 unPackageID ) 
		{
			this.GetFunction<NativeEnableTestLicenseU>( this.Functions.EnableTestLicense38 )( this.ObjectAddress, unPackageID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeDisableTestLicenseU( IntPtr thisptr, UInt32 unPackageID );
		public void DisableTestLicense( UInt32 unPackageID ) 
		{
			this.GetFunction<NativeDisableTestLicenseU>( this.Functions.DisableTestLicense39 )( this.ObjectAddress, unPackageID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeActivateOEMTicketS( IntPtr thisptr, string pchOEMLicenseFile );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool ActivateOEMTicket( string pchOEMLicenseFile ) 
		{
			return this.GetFunction<NativeActivateOEMTicketS>( this.Functions.ActivateOEMTicket40 )( this.ObjectAddress, pchOEMLicenseFile ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetLicenseForAppIDUU( IntPtr thisptr, UInt32 unAppId, ref UInt32 punPackageID );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetLicenseForAppID( UInt32 unAppId, ref UInt32 punPackageID ) 
		{
			return this.GetFunction<NativeGetLicenseForAppIDUU>( this.Functions.GetLicenseForAppID41 )( this.ObjectAddress, unAppId, ref punPackageID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetPackageNameUSI( IntPtr thisptr, UInt32 unPackageID, StringBuilder pchName, Int32 cubName );
		public UInt32 GetPackageName( UInt32 unPackageID, StringBuilder pchName ) 
		{
			return this.GetFunction<NativeGetPackageNameUSI>( this.Functions.GetPackageName42 )( this.ObjectAddress, unPackageID, pchName, (Int32) pchName.Capacity ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetPackageInfoUUUEEEIIIBB( IntPtr thisptr, UInt32 unPackageID, ref UInt32 puNumAppIds, ref UInt32 puNumDepotIDs, ref EBillingType peBillingType, ref ELicenseType peLicenseType, ref EPackageStatus pePackageStatus, ref Int32 piCodeClass, ref Int32 piGameCode, ref Int32 piTerritoryCode, ref bool pbRequiresShipping, ref bool pbIsPreorder );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetPackageInfo( UInt32 unPackageID, ref UInt32 puNumAppIds, ref UInt32 puNumDepotIDs, ref EBillingType peBillingType, ref ELicenseType peLicenseType, ref EPackageStatus pePackageStatus, ref Int32 piCodeClass, ref Int32 piGameCode, ref Int32 piTerritoryCode, ref bool pbRequiresShipping, ref bool pbIsPreorder ) 
		{
			return this.GetFunction<NativeGetPackageInfoUUUEEEIIIBB>( this.Functions.GetPackageInfo43 )( this.ObjectAddress, unPackageID, ref puNumAppIds, ref puNumDepotIDs, ref peBillingType, ref peLicenseType, ref pePackageStatus, ref piCodeClass, ref piGameCode, ref piTerritoryCode, ref pbRequiresShipping, ref pbIsPreorder ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetAppsInPackageUUUBB( IntPtr thisptr, UInt32 unPackageID, ref UInt32 puIds, UInt32 uMaxIds, [MarshalAs(UnmanagedType.I1)] bool bExcludeDepots, [MarshalAs(UnmanagedType.I1)] bool bExcludeApps );
		public UInt32 GetAppsInPackage( UInt32 unPackageID, ref UInt32 puIds, UInt32 uMaxIds, bool bExcludeDepots, bool bExcludeApps ) 
		{
			return this.GetFunction<NativeGetAppsInPackageUUUBB>( this.Functions.GetAppsInPackage44 )( this.ObjectAddress, unPackageID, ref puIds, uMaxIds, bExcludeDepots, bExcludeApps ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetPackageExtendedInfoUBIB( IntPtr thisptr, UInt32 unPackageID, Byte[] pubData, Int32 cubData, [MarshalAs(UnmanagedType.I1)] bool bSharedKVSymbols );
		public UInt32 GetPackageExtendedInfo( UInt32 unPackageID, Byte[] pubData, bool bSharedKVSymbols ) 
		{
			return this.GetFunction<NativeGetPackageExtendedInfoUBIB>( this.Functions.GetPackageExtendedInfo45 )( this.ObjectAddress, unPackageID, pubData, (Int32) pubData.Length, bSharedKVSymbols ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestFreeLicenseForAppU( IntPtr thisptr, UInt32 unAppId );
		public UInt64 RequestFreeLicenseForApp( UInt32 unAppId ) 
		{
			return this.GetFunction<NativeRequestFreeLicenseForAppU>( this.Functions.RequestFreeLicenseForApp46 )( this.ObjectAddress, unAppId ); 
		}
		
	};
}
