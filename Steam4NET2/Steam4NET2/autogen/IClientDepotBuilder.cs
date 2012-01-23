// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	public enum EDepotBuildStatus : int
	{
		k_EDepotBuildStatusInvalid = 0,
		k_EDepotBuildStatusProcessingConfig = 1,
		k_EDepotBuildStatusBuildingFileList = 2,
		k_EDepotBuildStatusProcessingData = 3,
		k_EDepotBuildStatusUploadingData = 4,
		k_EDepotBuildStatusCompleted = 5,
		k_EDepotBuildStatusFailed = 6,
	};
	
	public enum EStatusDepotVersion : int
	{
		k_EStatusDepotVersionInvalid = 0,
		k_EStatusDepotVersionCompleteDisabled = 1,
		k_EStatusDepotVersionCompleteEnabledBeta = 2,
		k_EStatusDepotVersionCompleteEnabledPublic = 3,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class IClientDepotBuilderVTable
	{
		public IntPtr RegisterAppBuild0;
		public IntPtr GetRegisteredBuildID1;
		public IntPtr InitializeDepotBuildForConfigFile2;
		public IntPtr StartBuild3;
		public IntPtr BGetDepotBuildStatus4;
		public IntPtr CloseDepotBuildHandle5;
		public IntPtr ReconstructDepotFromManifestAndChunks6;
		public IntPtr BGetChunkCounts7;
		public IntPtr GetManifestGIDs8;
		public IntPtr RebaseAndBuildDepot9;
		public IntPtr SetAppBuildLive10;
		private IntPtr DTorIClientDepotBuilder11;
	};
	
	[InteropHelp.InterfaceVersion("CLIENTDEPOTBUILDER_INTERFACE_VERSION001")]
	public class IClientDepotBuilder : InteropHelp.NativeWrapper<IClientDepotBuilderVTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeRegisterAppBuildUS( IntPtr thisptr, UInt32 nAppID, string cszDescription );
		public UInt32 RegisterAppBuild( UInt32 nAppID, string cszDescription ) 
		{
			return this.GetFunction<NativeRegisterAppBuildUS>( this.Functions.RegisterAppBuild0 )( this.ObjectAddress, nAppID, cszDescription ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetRegisteredBuildIDU( IntPtr thisptr, UInt32 arg0 );
		public UInt32 GetRegisteredBuildID( UInt32 arg0 ) 
		{
			return this.GetFunction<NativeGetRegisteredBuildIDU>( this.Functions.GetRegisteredBuildID1 )( this.ObjectAddress, arg0 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeInitializeDepotBuildForConfigFileS( IntPtr thisptr, string pchConfigFile );
		public UInt32 InitializeDepotBuildForConfigFile( string pchConfigFile ) 
		{
			return this.GetFunction<NativeInitializeDepotBuildForConfigFileS>( this.Functions.InitializeDepotBuildForConfigFile2 )( this.ObjectAddress, pchConfigFile ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeStartBuildUUSSSU( IntPtr thisptr, UInt32 hDepotBuild, UInt32 uFlags, string cszBetaKey, string cszBetaPassword, string cszChunksPath, UInt32 arg5 );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool StartBuild( UInt32 hDepotBuild, UInt32 uFlags, string cszBetaKey, string cszBetaPassword, string cszChunksPath, UInt32 arg5 ) 
		{
			return this.GetFunction<NativeStartBuildUUSSSU>( this.Functions.StartBuild3 )( this.ObjectAddress, hDepotBuild, uFlags, cszBetaKey, cszBetaPassword, cszChunksPath, arg5 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBGetDepotBuildStatusUEU( IntPtr thisptr, UInt32 hDepotBuild, ref EDepotBuildStatus pStatusOut, ref UInt32 pPercentDone );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool BGetDepotBuildStatus( UInt32 hDepotBuild, ref EDepotBuildStatus pStatusOut, ref UInt32 pPercentDone ) 
		{
			return this.GetFunction<NativeBGetDepotBuildStatusUEU>( this.Functions.BGetDepotBuildStatus4 )( this.ObjectAddress, hDepotBuild, ref pStatusOut, ref pPercentDone ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeCloseDepotBuildHandleU( IntPtr thisptr, UInt32 hDepotBuild );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool CloseDepotBuildHandle( UInt32 hDepotBuild ) 
		{
			return this.GetFunction<NativeCloseDepotBuildHandleU>( this.Functions.CloseDepotBuildHandle5 )( this.ObjectAddress, hDepotBuild ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeReconstructDepotFromManifestAndChunksSSS( IntPtr thisptr, string pchLocalManifestPath, string pchLocalChunkPath, string pchRestorePath );
		public UInt32 ReconstructDepotFromManifestAndChunks( string pchLocalManifestPath, string pchLocalChunkPath, string pchRestorePath ) 
		{
			return this.GetFunction<NativeReconstructDepotFromManifestAndChunksSSS>( this.Functions.ReconstructDepotFromManifestAndChunks6 )( this.ObjectAddress, pchLocalManifestPath, pchLocalChunkPath, pchRestorePath ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBGetChunkCountsUUU( IntPtr thisptr, UInt32 hDepotBuild, ref UInt32 unTotalChunksInNewBuild, ref UInt32 unChunksAlsoInOldBuild );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool BGetChunkCounts( UInt32 hDepotBuild, ref UInt32 unTotalChunksInNewBuild, ref UInt32 unChunksAlsoInOldBuild ) 
		{
			return this.GetFunction<NativeBGetChunkCountsUUU>( this.Functions.BGetChunkCounts7 )( this.ObjectAddress, hDepotBuild, ref unTotalChunksInNewBuild, ref unChunksAlsoInOldBuild ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetManifestGIDsUUU( IntPtr thisptr, UInt32 hDepotBuild, ref UInt64 pBaselineGID, ref UInt64 pNewGID );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetManifestGIDs( UInt32 hDepotBuild, ref UInt64 pBaselineGID, ref UInt64 pNewGID ) 
		{
			return this.GetFunction<NativeGetManifestGIDsUUU>( this.Functions.GetManifestGIDs8 )( this.ObjectAddress, hDepotBuild, ref pBaselineGID, ref pNewGID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeRebaseAndBuildDepotUU( IntPtr thisptr, UInt64 arg0, UInt64 arg1 );
		public UInt32 RebaseAndBuildDepot( UInt64 arg0, UInt64 arg1 ) 
		{
			return this.GetFunction<NativeRebaseAndBuildDepotUU>( this.Functions.RebaseAndBuildDepot9 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeSetAppBuildLiveUUSS( IntPtr thisptr, UInt32 arg0, UInt32 arg1, string pchBetaKey, string cszBetaPassword );
		public UInt32 SetAppBuildLive( UInt32 arg0, UInt32 arg1, string pchBetaKey, string cszBetaPassword ) 
		{
			return this.GetFunction<NativeSetAppBuildLiveUUSS>( this.Functions.SetAppBuildLive10 )( this.ObjectAddress, arg0, arg1, pchBetaKey, cszBetaPassword ); 
		}
		
	};
}
