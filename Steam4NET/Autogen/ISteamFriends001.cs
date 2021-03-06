// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("SteamFriends001")]
	public interface ISteamFriends001
	{
		[VTableSlot(0)]
		string GetPersonaName();
		[VTableSlot(1)]
		void SetPersonaName(string pchPersonaName);
		[VTableSlot(2)]
		EPersonaState GetPersonaState();
		[VTableSlot(3)]
		void SetPersonaState(EPersonaState ePersonaState);
		[VTableSlot(4)]
		bool AddFriend(CSteamID steamIDFriend);
		[VTableSlot(5)]
		bool RemoveFriend(CSteamID steamIDFriend);
		[VTableSlot(6)]
		bool HasFriend(CSteamID steamIDFriend);
		[VTableSlot(7)]
		EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend);
		[VTableSlot(8)]
		EPersonaState GetFriendPersonaState(CSteamID steamIDFriend);
		[VTableSlot(9)]
		bool Deprecated_GetFriendGamePlayed(CSteamID steamIDFriend, ref Int32 pnGameID, ref UInt32 punGameIP, ref UInt16 pusGamePort);
		[VTableSlot(10)]
		string GetFriendPersonaName(CSteamID steamIDFriend);
		[VTableSlot(11)]
		Int32 AddFriendByName(string pchEmailOrAccountName);
		[VTableSlot(12)]
		Int32 GetFriendCount();
		[VTableSlot(13)]
		CSteamID GetFriendByIndex(Int32 iFriend);
		[VTableSlot(14)]
		void SendMsgToFriend(CSteamID steamIDFriend, EChatEntryType eFriendMsgType, string pchMsgBody);
		[VTableSlot(15)]
		void SetFriendRegValue(CSteamID steamIDFriend, string pchKey, string pchValue);
		[VTableSlot(16)]
		string GetFriendRegValue(CSteamID steamIDFriend, string pchKey);
		[VTableSlot(17)]
		string GetFriendPersonaNameHistory(CSteamID steamIDFriend, Int32 iPersonaName);
		[VTableSlot(18)]
		Int32 GetChatMessage(CSteamID steamIDFriend, Int32 iChatID, Byte[] pvData, Int32 cubData, ref EChatEntryType peFriendMsgType);
		[VTableSlot(19)]
		bool SendMsgToFriend(CSteamID steamIDFriend, EChatEntryType eFriendMsgType, Byte[] pvMsgBody, Int32 cubMsgBody);
		[VTableSlot(20)]
		Int32 GetChatIDOfChatHistoryStart(CSteamID steamIDFriend);
		[VTableSlot(21)]
		void SetChatHistoryStart(CSteamID steamIDFriend, Int32 iChatID);
		[VTableSlot(22)]
		void ClearChatHistory(CSteamID steamIDFriend);
		[VTableSlot(23)]
		Int32 InviteFriendByEmail(string pchEmailOrAccountName);
		[VTableSlot(24)]
		UInt32 GetBlockedFriendCount();
		[VTableSlot(25)]
		bool GetFriendGamePlayed(CSteamID steamIDFriend, ref UInt64 pulGameID, ref UInt32 punGameIP, ref UInt16 pusGamePort);
		[VTableSlot(26)]
		bool GetFriendGamePlayed2(CSteamID steamDIFriend, ref UInt64 pulGameID, ref UInt32 punGameIP, ref UInt16 pusGamePort, ref UInt16 pusQueryPort);
	};
}
