// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	public enum EAuthSessionResponse : int
	{
		k_EAuthSessionResponseOK = 0,
		k_EAuthSessionResponseUserNotConnectedToSteam = 1,
		k_EAuthSessionResponseNoLicenseOrExpired = 2,
		k_EAuthSessionResponseVACBanned = 3,
		k_EAuthSessionResponseLoggedInElseWhere = 4,
		k_EAuthSessionResponseVACCheckTimedOut = 5,
		k_EAuthSessionResponseAuthTicketCanceled = 6,
		k_EAuthSessionResponseAuthTicketInvalidAlreadyUsed = 7,
		k_EAuthSessionResponseAuthTicketInvalid = 8,
	};
	
	public enum EBeginAuthSessionResult : int
	{
		k_EBeginAuthSessionResultOK = 0,
		k_EBeginAuthSessionResultInvalidTicket = 1,
		k_EBeginAuthSessionResultDuplicateRequest = 2,
		k_EBeginAuthSessionResultInvalidVersion = 3,
		k_EBeginAuthSessionResultGameMismatch = 4,
		k_EBeginAuthSessionResultExpiredTicket = 5,
	};
	
	public enum EAppUsageEvent : int
	{
		k_EAppUsageEventGameLaunch = 1,
		k_EAppUsageEventGameLaunchTrial = 2,
		k_EAppUsageEventMedia = 3,
		k_EAppUsageEventPreloadStart = 4,
		k_EAppUsageEventPreloadFinish = 5,
		k_EAppUsageEventMarketingMessageView = 6,
		k_EAppUsageEventInGameAdViewed = 7,
		k_EAppUsageEventGameLaunchFreeWeekend = 8,
	};
	
	public enum ERegistrySubTree : int
	{
		k_ERegistrySubTreeNews = 0,
		k_ERegistrySubTreeApps = 1,
		k_ERegistrySubTreeSubscriptions = 2,
		k_ERegistrySubTreeGameServers = 3,
		k_ERegistrySubTreeFriends = 4,
		k_ERegistrySubTreeSystem = 5,
		k_ERegistrySubTreeAppOwnershipTickets = 6,
		k_ERegistrySubTreeLegacyCDKeys = 7,
	};
	
	public enum ELogonState : int
	{
		k_ELogonStateNotLoggedOn = 0,
		k_ELogonStateLoggingOn = 1,
		k_ELogonStateLoggingOff = 2,
		k_ELogonStateLoggedOn = 3,
	};
	
	public enum EVACBan : int
	{
		k_EVACBanGoldsrc = 0,
		k_EVACBanSource = 1,
		k_EVACBanDayOfDefeatSource = 2,
	};
	
	public enum EUserHasLicenseForAppResult : int
	{
		k_EUserHasLicenseResultHasLicense = 0,
		k_EUserHasLicenseResultDoesNotHaveLicense = 1,
		k_EUserHasLicenseResultNoAuth = 2,
	};
	
	public enum ENewsUpdateType : int
	{
		k_EAppNews = 0,
		k_ESteamAds = 1,
		k_ESteamNews = 2,
		k_ECDDBUpdate = 3,
		k_EClientUpdate = 4,
	};
	
	public enum ESteamUsageEvent : int
	{
		k_ESteamUsageEventMarketingMessageView = 1,
		k_ESteamUsageEventHardwareSurvey = 2,
		k_ESteamUsageEventDownloadStarted = 3,
		k_ESteamUsageEventLocalizedAudioChange = 4,
		k_ESteamUsageEventClientGUIUsage = 5,
		k_ESteamUsageEventCharityChoice = 6,
	};
	
	public enum EClientStat : int
	{
		k_EClientStatP2PConnectionsUDP = 0,
		k_EClientStatP2PConnectionsRelay = 1,
		k_EClientStatP2PGameConnections = 2,
		k_EClientStatP2PVoiceConnections = 3,
		k_EClientStatBytesDownloaded = 4,
		k_EClientStatMax = 5,
	};
	
	public enum EMarketingMessageFlags : int
	{
		k_EMarketingMessageFlagsNone = 0,
		k_EMarketingMessageFlagsHighPriority = 1,
		k_EMarketingMessageFlagsPlatformWindows = 2,
		k_EMarketingMessageFlagsPlatformMac = 4,
		k_EMarketingMessageFlagsPlatformRestrictions = 6,
	};
	
	public enum ENatDiscoveryTypes : int
	{
		eNatTypeUntested = 0,
		eNatTypeTestFailed = 1,
		eNatTypeNoUDP = 2,
		eNatTypeOpenInternet = 3,
		eNatTypeFullCone = 4,
		eNatTypeRestrictedCone = 5,
		eNatTypePortRestrictedCone = 6,
		eNatTypeUnspecified = 7,
		eNatTypeSymmetric = 8,
		eNatTypeSymmetricFirewall = 9,
		eNatTypeCount = 10,
	};
	
	public enum EPhysicalSocketConnectionResult : int
	{
		PhysicalSocket_Unknown = 0,
		PhysicalSocket_IsRemoteSide = 1,
		PhysicalSocket_Connected = 2,
		PhysicalSocket_Failed = 3,
		PhysicalSocket_SignalingFailed = 4,
		PhysicalSocket_ResultCount = 5,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct CNatTraversalStat
	{
		public EPhysicalSocketConnectionResult m_eResult;
		public ENatDiscoveryTypes m_eLocalNatType;
		public ENatDiscoveryTypes m_eRemoteNatType;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bMultiUserChat;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bRelay;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct CAmount
	{
		public Int32 m_nAmount;
		public ECurrencyCode m_eCurrencyCode;
	};
	
	public enum EMicroTxnAuthResponse : int
	{
		k_EMicroTxnAuthResponseInvalid = 0,
		k_EMicroTxnAuthResponseAuthorize = 1,
		k_EMicroTxnAuthResponseDeny = 2,
		k_EMicroTxnAuthResponseAutoDeny = 3,
	};
	
	public enum EMicroTxnAuthResult : int
	{
		k_EMicroTxnAuthResultInvalid = 0,
		k_EMicroTxnAuthResultOK = 1,
		k_EMicroTxnAuthResultFail = 2,
		k_EMicroTxnAuthResultInsufficientFunds = 3,
	};
	
	public enum ERequestAccountDataAction : int
	{
		k_ERequestAccountDataActionFindAccountsByEmailAddress = 1,
		k_ERequestAccountDataActionFindAccountsByCdKey = 2,
		k_ERequestAccountDataActionGetNumAccountsWithEmailAddress = 3,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(101)]
	public struct SteamServersConnected_t
	{
		public const int k_iCallback = 101;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(102)]
	public struct SteamServerConnectFailure_t
	{
		public const int k_iCallback = 102;
		public EResult m_eResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(103)]
	public struct SteamServersDisconnected_t
	{
		public const int k_iCallback = 103;
		public EResult m_eResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(104)]
	public struct BeginLogonRetry_t
	{
		public const int k_iCallback = 104;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(113)]
	public struct ClientGameServerDeny_t
	{
		public const int k_iCallback = 113;
		public UInt32 m_uAppID;
		public UInt32 m_unGameServerIP;
		public UInt16 m_usGameServerPort;
		public UInt16 m_bSecure;
		public UInt32 m_uReason;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(114)]
	public struct PrimaryChatDestinationSetOld_t
	{
		public const int k_iCallback = 114;
		public Byte m_bIsPrimary;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(117)]
	public struct IPCFailure_t
	{
		public const int k_iCallback = 117;
		public const int k_EFailureFlushedCallbackQueue = 0;
		public Byte m_eFailureType;
	};
	
	public enum EFailureType : int
	{
		k_EFailureFlushedCallbackQueue = 0,
		k_EFailurePipeFail = 1,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(125)]
	public struct LicensesUpdated_t
	{
		public const int k_iCallback = 125;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(130)]
	public struct AppLifetimeNotice_t
	{
		public const int k_iCallback = 130;
		public UInt32 m_nAppID;
		public Int32 m_nInstanceID;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bExiting;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(141)]
	public struct DRMSDKFileTransferResult_t
	{
		public const int k_iCallback = 141;
		public EResult m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(143)]
	public struct ValidateAuthTicketResponse_t
	{
		public const int k_iCallback = 143;
		public SteamID_t m_SteamID;
		public EAuthSessionResponse m_eAuthSessionResponse;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(152)]
	public struct MicroTxnAuthorizationResponse_t
	{
		public const int k_iCallback = 152;
		public UInt32 m_unAppID;
		public UInt64 m_ulOrderID;
		public Byte m_bAuthorized;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(154)]
	public struct EncryptedAppTicketResponse_t
	{
		public const int k_iCallback = 154;
		public EResult m_eResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(901)]
	public struct SystemIM_t
	{
		public const int k_iCallback = 901;
		public UInt32 m_ESystemIMType;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4096)]
		public string m_rgchMsgBody;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(902)]
	public struct GuestPassGiftTarget_t
	{
		public const int k_iCallback = 902;
		public UInt32 m_unPackageID;
		public UInt64 m_ulSteamIDFriend;
		public Int32 m_iPotentialGiftTarget;
		public Int32 m_cPotentialGiftTargetsTotal;
		public Byte m_bValidGiftTarget;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(903)]
	public struct PrimaryChatDestinationSet_t
	{
		public const int k_iCallback = 903;
		public Byte m_bIsPrimary;
		public Byte m_bWasPrimary;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(905)]
	public struct LicenseChanged_t
	{
		public const int k_iCallback = 905;
		public UInt32 m_nPackageID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(906)]
	public struct RequestClientAppListInfo_t
	{
		public const int k_iCallback = 906;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bMedia;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bTools;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bGames;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bInstalled;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(907)]
	public struct SetClientAppUpdateState_t
	{
		public const int k_iCallback = 907;
		public UInt64 m_ulJobIDToPostResultTo;
		public UInt32 m_nAppID;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bUpdate;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(908)]
	public struct InstallClientApp_t
	{
		public const int k_iCallback = 908;
		public UInt64 m_ulJobIDToPostResultTo;
		public UInt32 m_nAppID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(909)]
	public struct UninstallClientApp_t
	{
		public const int k_iCallback = 909;
		public UInt64 m_ulJobIDToPostResultTo;
		public UInt32 m_nAppID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(910)]
	public struct Steam2TicketChanged_t
	{
		public const int k_iCallback = 910;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(911)]
	public struct ClientAppNewsItemUpdate_t
	{
		public const int k_iCallback = 911;
		public Byte m_eNewsUpdateType;
		public UInt32 m_uNewsID;
		public UInt32 m_uAppID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(912)]
	public struct ClientSteamNewsItemUpdate_t
	{
		public const int k_iCallback = 912;
		public Byte m_eNewsUpdateType;
		public UInt32 m_uNewsID;
		public UInt32 m_uHaveSubID;
		public UInt32 m_uNotHaveSubID;
		public UInt32 m_uHaveAppID;
		public UInt32 m_uNotHaveAppID;
		public UInt32 m_uHaveAppIDInstalled;
		public UInt32 m_uHavePlayedAppID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(913)]
	public struct ClientSteamNewsClientUpdate_t
	{
		public const int k_iCallback = 913;
		public Byte m_eNewsUpdateType;
		public Byte m_bReloadCDDB;
		public UInt32 m_unCurrentBootstrapperVersion;
		public UInt32 m_unCurrentClientVersion;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(914)]
	public struct LegacyCDKeyRegistered_t
	{
		public const int k_iCallback = 914;
		public EResult m_eResult;
		public UInt32 m_iAppID;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string m_rgchCDKey;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(915)]
	public struct AccountInformationUpdated_t
	{
		public const int k_iCallback = 915;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bEmailValidationAction;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(916)]
	public struct GuestPassSent_t
	{
		public const int k_iCallback = 916;
		public EResult m_eResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(917)]
	public struct GuestPassAcked_t
	{
		public const int k_iCallback = 917;
		public EResult m_eResult;
		public UInt32 m_unPackageID;
		public UInt64 m_gidGuestPassID;
		public UInt64 m_ulGuestPassKey;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(918)]
	public struct GuestPassRedeemed_t
	{
		public const int k_iCallback = 918;
		public EResult m_eResult;
		public UInt32 m_unPackageID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(919)]
	public struct UpdateGuestPasses_t
	{
		public const int k_iCallback = 919;
		public EResult m_eResult;
		public UInt32 m_cGuestPassesToGive;
		public UInt32 m_cGuestPassesToRedeem;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(920)]
	public struct LogOnCredentialsChanged_t
	{
		public const int k_iCallback = 920;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(922)]
	public struct CheckPasswordResponse_t
	{
		public const int k_iCallback = 922;
		public EResult m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(923)]
	public struct ResetPasswordResponse_t
	{
		public const int k_iCallback = 923;
		public EResult m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(924)]
	public struct DRMDataRequest_t
	{
		public const int k_iCallback = 924;
		public UInt32 m_EResult;
		public UInt32 m_unAppID;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bRestartApp;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(925)]
	public struct DRMDataResponse_t
	{
		public const int k_iCallback = 925;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(926)]
	public struct DRMFailureResponse_t
	{
		public const int k_iCallback = 926;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(928)]
	public struct AppOwnershipTicketReceived_t
	{
		public const int k_iCallback = 928;
		public UInt32 m_nAppID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(929)]
	public struct PasswordChangeResponse_t
	{
		public const int k_iCallback = 929;
		public EResult m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(930)]
	public struct EmailChangeResponse_t
	{
		public const int k_iCallback = 930;
		public EResult m_EResult;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bFinal;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(931)]
	public struct SecretQAChangeResponse_t
	{
		public const int k_iCallback = 931;
		public EResult m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(932)]
	public struct CreateAccountResponse_t
	{
		public const int k_iCallback = 932;
		public EResult m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(933)]
	public struct SendForgottonPasswordEmailResponse_t
	{
		public const int k_iCallback = 933;
		public EResult m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(934)]
	public struct ResetForgottonPasswordResponse_t
	{
		public const int k_iCallback = 934;
		public EResult m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(935)]
	public struct CreateAccountInformSteam3Response_t
	{
		public const int k_iCallback = 935;
		public UInt32 m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(936)]
	public struct DownloadFromDFSResponse_t
	{
		public const int k_iCallback = 936;
		public EResult m_EResult;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string m_rgchURL;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(937)]
	public struct ClientMarketingMessageUpdate_t
	{
		public const int k_iCallback = 937;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(938)]
	public struct ValidateEmailResponse_t
	{
		public const int k_iCallback = 938;
		public UInt32 m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(939)]
	public struct RequestChangeEmailResponse_t
	{
		public const int k_iCallback = 939;
		public UInt32 m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(940)]
	public struct VerifyPasswordResponse_t
	{
		public const int k_iCallback = 940;
		public UInt32 m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(941)]
	public struct Steam2LoginResponse_t
	{
		public const int k_iCallback = 941;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bSuccessful;
		public UInt32 m_steam2Error;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(942)]
	public struct WebAuthRequestCallback_t
	{
		public const int k_iCallback = 942;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bSuccessful;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
		public string m_rgchToken;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(944)]
	public struct MicroTxnAuthRequestCallback_t
	{
		public const int k_iCallback = 944;
		public UInt64 m_gidTransID;
		public UInt32 m_unAppID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(945)]
	public struct MicroTxnAuthResponse_t
	{
		public const int k_iCallback = 945;
		public EMicroTxnAuthResult m_eAuthResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(946)]
	public struct AppMinutesPlayedDataNotice_t
	{
		public const int k_iCallback = 946;
		public Int32 m_nAppID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(947)]
	public struct MicroTxnInfoUpdated_t
	{
		public const int k_iCallback = 947;
		public EResult m_eResult;
		public UInt64 m_gidTransID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(948)]
	public struct WalletBalanceUpdated_t
	{
		public const int k_iCallback = 948;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(949)]
	public struct EnableMachineLockingResponse_t
	{
		public const int k_iCallback = 949;
		public UInt32 m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(950)]
	public struct MachineLockProgressResponse_t
	{
		public const int k_iCallback = 950;
		public UInt32 m_EResult;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(951)]
	public struct Steam3ExtraLoginProgress_t
	{
		public const int k_iCallback = 951;
		public UInt32 m_EResult;
		public Int32 m_eState;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(952)]
	public struct RequestAccountDataResult_t
	{
		public const int k_iCallback = 952;
		public EResult m_EResult;
		public UInt32 m_cMatches;
		public ERequestAccountDataAction m_eAction;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(953)]
	public struct IsAccountNameInUseResult_t
	{
		public const int k_iCallback = 953;
		public EResult m_EResult;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string m_szAccountNameSuggestion1;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string m_szAccountNameSuggestion2;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string m_szAccountNameSuggestion3;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(955)]
	public struct LoginInformationChanged_t
	{
		public const int k_iCallback = 955;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(956)]
	public struct RequestSpecialSurveyResult_t
	{
		public const int k_iCallback = 956;
		public Int32 m_iSurveyID;
		public EResult m_eResult;
		public Int32 m_eState;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_szName;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
		public string m_szCustomURL;
		[MarshalAs(UnmanagedType.I1)]
		public bool m_bIncludeSoftware;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public Byte[] m_ubToken;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(957)]
	public struct SendSpecialSurveyResponseResult_t
	{
		public const int k_iCallback = 957;
		public Int32 m_iSurveyID;
		public EResult m_eResult;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public Byte[] m_ubToken;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(958)]
	public struct UpdateItemAnnouncement_t
	{
		public const int k_iCallback = 958;
	};
	
}
