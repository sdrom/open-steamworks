// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class IClientUtilsVTable
	{
		public IntPtr GetInstallPath0;
		public IntPtr GetUserBaseFolderInstallImage1;
		public IntPtr GetManagedContentRoot2;
		public IntPtr GetSecondsSinceAppActive3;
		public IntPtr GetSecondsSinceComputerActive4;
		public IntPtr GetConnectedUniverse5;
		public IntPtr GetServerRealTime6;
		public IntPtr GetIPCountry7;
		public IntPtr GetImageSize8;
		public IntPtr GetImageRGBA9;
		public IntPtr GetCSERIPPort10;
		public IntPtr GetNumRunningApps11;
		public IntPtr GetCurrentBatteryPower12;
		public IntPtr SetOfflineMode13;
		public IntPtr GetOfflineMode14;
		public IntPtr SetAppIDForCurrentPipe15;
		public IntPtr GetAppID16;
		public IntPtr SetAPIDebuggingActive17;
		public IntPtr IsAPICallCompleted18;
		public IntPtr GetAPICallFailureReason19;
		public IntPtr GetAPICallResult20;
		public IntPtr SignalAppsToShutDown21;
		public IntPtr GetCellID22;
		public IntPtr BIsGlobalInstance23;
		public IntPtr CheckFileSignature24;
		public IntPtr GetBuildID25;
		private IntPtr DTorIClientUtils26;
	};
	
	[InteropHelp.InterfaceVersion("CLIENTUTILS_INTERFACE_VERSION001")]
	public class IClientUtils : InteropHelp.NativeWrapper<IClientUtilsVTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetInstallPath( IntPtr thisptr );
		public string GetInstallPath(  ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetInstallPath>( this.Functions.GetInstallPath0 )( this.ObjectAddress ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetUserBaseFolderInstallImage( IntPtr thisptr );
		public string GetUserBaseFolderInstallImage(  ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetUserBaseFolderInstallImage>( this.Functions.GetUserBaseFolderInstallImage1 )( this.ObjectAddress ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetManagedContentRoot( IntPtr thisptr );
		public string GetManagedContentRoot(  ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetManagedContentRoot>( this.Functions.GetManagedContentRoot2 )( this.ObjectAddress ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetSecondsSinceAppActive( IntPtr thisptr );
		public UInt32 GetSecondsSinceAppActive(  ) 
		{
			return this.GetFunction<NativeGetSecondsSinceAppActive>( this.Functions.GetSecondsSinceAppActive3 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetSecondsSinceComputerActive( IntPtr thisptr );
		public UInt32 GetSecondsSinceComputerActive(  ) 
		{
			return this.GetFunction<NativeGetSecondsSinceComputerActive>( this.Functions.GetSecondsSinceComputerActive4 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EUniverse NativeGetConnectedUniverse( IntPtr thisptr );
		public EUniverse GetConnectedUniverse(  ) 
		{
			return this.GetFunction<NativeGetConnectedUniverse>( this.Functions.GetConnectedUniverse5 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetServerRealTime( IntPtr thisptr );
		public UInt32 GetServerRealTime(  ) 
		{
			return this.GetFunction<NativeGetServerRealTime>( this.Functions.GetServerRealTime6 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetIPCountry( IntPtr thisptr );
		public string GetIPCountry(  ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetIPCountry>( this.Functions.GetIPCountry7 )( this.ObjectAddress ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetImageSizeIUU( IntPtr thisptr, Int32 iImage, ref UInt32 pnWidth, ref UInt32 pnHeight );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetImageSize( Int32 iImage, ref UInt32 pnWidth, ref UInt32 pnHeight ) 
		{
			return this.GetFunction<NativeGetImageSizeIUU>( this.Functions.GetImageSize8 )( this.ObjectAddress, iImage, ref pnWidth, ref pnHeight ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetImageRGBAIBI( IntPtr thisptr, Int32 iImage, Byte[] pubDest, Int32 nDestBufferSize );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetImageRGBA( Int32 iImage, Byte[] pubDest, Int32 nDestBufferSize ) 
		{
			return this.GetFunction<NativeGetImageRGBAIBI>( this.Functions.GetImageRGBA9 )( this.ObjectAddress, iImage, pubDest, nDestBufferSize ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetCSERIPPortUU( IntPtr thisptr, ref UInt32 unIP, ref UInt16 usPort );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetCSERIPPort( ref UInt32 unIP, ref UInt16 usPort ) 
		{
			return this.GetFunction<NativeGetCSERIPPortUU>( this.Functions.GetCSERIPPort10 )( this.ObjectAddress, ref unIP, ref usPort ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetNumRunningApps( IntPtr thisptr );
		public UInt32 GetNumRunningApps(  ) 
		{
			return this.GetFunction<NativeGetNumRunningApps>( this.Functions.GetNumRunningApps11 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Byte NativeGetCurrentBatteryPower( IntPtr thisptr );
		public Byte GetCurrentBatteryPower(  ) 
		{
			return this.GetFunction<NativeGetCurrentBatteryPower>( this.Functions.GetCurrentBatteryPower12 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetOfflineModeB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bOffline );
		public void SetOfflineMode( bool bOffline ) 
		{
			this.GetFunction<NativeSetOfflineModeB>( this.Functions.SetOfflineMode13 )( this.ObjectAddress, bOffline ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetOfflineMode( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetOfflineMode(  ) 
		{
			return this.GetFunction<NativeGetOfflineMode>( this.Functions.GetOfflineMode14 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeSetAppIDForCurrentPipeUB( IntPtr thisptr, UInt32 nAppID, [MarshalAs(UnmanagedType.I1)] bool bTrackProcess );
		public UInt32 SetAppIDForCurrentPipe( UInt32 nAppID, bool bTrackProcess ) 
		{
			return this.GetFunction<NativeSetAppIDForCurrentPipeUB>( this.Functions.SetAppIDForCurrentPipe15 )( this.ObjectAddress, nAppID, bTrackProcess ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetAppID( IntPtr thisptr );
		public UInt32 GetAppID(  ) 
		{
			return this.GetFunction<NativeGetAppID>( this.Functions.GetAppID16 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetAPIDebuggingActiveBB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bActive, [MarshalAs(UnmanagedType.I1)] bool bVerbose );
		public void SetAPIDebuggingActive( bool bActive, bool bVerbose ) 
		{
			this.GetFunction<NativeSetAPIDebuggingActiveBB>( this.Functions.SetAPIDebuggingActive17 )( this.ObjectAddress, bActive, bVerbose ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsAPICallCompletedUB( IntPtr thisptr, UInt64 hSteamAPICall, ref bool pbFailed );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool IsAPICallCompleted( UInt64 hSteamAPICall, ref bool pbFailed ) 
		{
			return this.GetFunction<NativeIsAPICallCompletedUB>( this.Functions.IsAPICallCompleted18 )( this.ObjectAddress, hSteamAPICall, ref pbFailed ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ESteamAPICallFailure NativeGetAPICallFailureReasonU( IntPtr thisptr, UInt64 hSteamAPICall );
		public ESteamAPICallFailure GetAPICallFailureReason( UInt64 hSteamAPICall ) 
		{
			return this.GetFunction<NativeGetAPICallFailureReasonU>( this.Functions.GetAPICallFailureReason19 )( this.ObjectAddress, hSteamAPICall ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetAPICallResultUBIIB( IntPtr thisptr, UInt64 hSteamAPICall, Byte[] pCallback, Int32 cubCallback, Int32 iCallbackExpected, ref bool pbFailed );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetAPICallResult( UInt64 hSteamAPICall, Byte[] pCallback, Int32 iCallbackExpected, ref bool pbFailed ) 
		{
			return this.GetFunction<NativeGetAPICallResultUBIIB>( this.Functions.GetAPICallResult20 )( this.ObjectAddress, hSteamAPICall, pCallback, (Int32) pCallback.Length, iCallbackExpected, ref pbFailed ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSignalAppsToShutDown( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SignalAppsToShutDown(  ) 
		{
			return this.GetFunction<NativeSignalAppsToShutDown>( this.Functions.SignalAppsToShutDown21 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetCellID( IntPtr thisptr );
		public UInt32 GetCellID(  ) 
		{
			return this.GetFunction<NativeGetCellID>( this.Functions.GetCellID22 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsGlobalInstance( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool BIsGlobalInstance(  ) 
		{
			return this.GetFunction<NativeBIsGlobalInstance>( this.Functions.BIsGlobalInstance23 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeCheckFileSignatureS( IntPtr thisptr, string szFileName );
		public UInt64 CheckFileSignature( string szFileName ) 
		{
			return this.GetFunction<NativeCheckFileSignatureS>( this.Functions.CheckFileSignature24 )( this.ObjectAddress, szFileName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetBuildID( IntPtr thisptr );
		public UInt64 GetBuildID(  ) 
		{
			return this.GetFunction<NativeGetBuildID>( this.Functions.GetBuildID25 )( this.ObjectAddress ); 
		}
		
	};
}
