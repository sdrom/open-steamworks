// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	public enum EP2PSend : int
	{
		k_EP2PSendUnreliable = 0,
		k_EP2PSendUnreliableNoDelay = 1,
		k_EP2PSendReliable = 2,
		k_EP2PSendReliableWithBuffering = 3,
	};
	
	public enum EP2PSessionError : int
	{
		k_EP2PSessionErrorNone = 0,
		k_EP2PSessionErrorNotRunningApp = 1,
		k_EP2PSessionErrorNoRightsToApp = 2,
		k_EP2PSessionErrorDestinationNotLoggedIn = 3,
		k_EP2PSessionErrorTimeout = 4,
		k_EP2PSessionErrorMax = 5,
	};
	
	public enum ESNetSocketConnectionType : int
	{
		k_ESNetSocketConnectionTypeNotConnected = 0,
		k_ESNetSocketConnectionTypeUDP = 1,
		k_ESNetSocketConnectionTypeUDPRelay = 2,
	};
	
	public enum ESNetSocketState : int
	{
		k_ESNetSocketStateInvalid = 0,
		k_ESNetSocketStateConnected = 1,
		k_ESNetSocketStateInitiated = 10,
		k_ESNetSocketStateLocalCandidatesFound = 11,
		k_ESNetSocketStateReceivedRemoteCandidates = 12,
		k_ESNetSocketStateChallengeHandshake = 15,
		k_ESNetSocketStateDisconnecting = 21,
		k_ESNetSocketStateLocalDisconnect = 22,
		k_ESNetSocketStateTimeoutDuringConnect = 23,
		k_ESNetSocketStateRemoteEndDisconnected = 24,
		k_ESNetSocketStateConnectionBroken = 25,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct P2PSessionState_t
	{
		public Byte m_bConnectionActive;
		public Byte m_bConnecting;
		public Byte m_eP2PSessionError;
		public Byte m_bUsingRelay;
		public Int32 m_nBytesQueuedForSend;
		public Int32 m_nPacketsQueuedForSend;
		public UInt32 m_nRemoteIP;
		public UInt16 m_nRemotePort;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(1201)]
	public struct SocketStatusCallback_t
	{
		public const int k_iCallback = 1201;
		public UInt32 m_hSocket;
		public UInt32 m_hListenSocket;
		public SteamID_t m_steamIDRemote;
		public Int32 m_eSNetSocketState;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(1202)]
	public struct P2PSessionRequest_t
	{
		public const int k_iCallback = 1202;
		public SteamID_t m_steamIDRemote;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[InteropHelp.CallbackIdentity(1203)]
	public struct P2PSessionConnectFail_t
	{
		public const int k_iCallback = 1203;
		public SteamID_t m_steamIDRemote;
		public Byte m_eP2PSessionError;
	};
	
}
