// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("Steam006")]
	public interface ISteam006
	{
		[VTableSlot(1)]
		UInt32 ChangePassword(string cszCurrentPassphrase, string cszNewPassphrase, ref TSteamError pError);
		[VTableSlot(2)]
		Int32 GetCurrentEmailAddress(StringBuilder szEmailaddress, UInt32 uBufSize, ref UInt32 puEmailaddressChars, ref TSteamError pError);
		[VTableSlot(3)]
		UInt32 ChangePersonalQA(string cszCurrentPassphrase, string cszNewPersonalQuestion, string cszNewAnswerToQuestion, ref TSteamError pError);
		[VTableSlot(4)]
		UInt32 ChangeEmailAddress(string cszNewEmailAddress, ref TSteamError pError);
		[VTableSlot(5)]
		UInt32 VerifyEmailAddress(string cszEmailAddress, ref TSteamError pError);
		[VTableSlot(6)]
		UInt32 RequestEmailAddressVerificationEmail(ref TSteamError pError);
		[VTableSlot(7)]
		UInt32 ChangeAccountName(string cszCurrentPassphrase, string cszNewAccountName, ref TSteamError pError);
		[VTableSlot(8)]
		Int32 MountAppFilesystem(ref TSteamError pError);
		[VTableSlot(9)]
		Int32 UnmountAppFilesystem(ref TSteamError pError);
		[VTableSlot(10)]
		UInt32 MountFilesystem(UInt32 uAppId, string szMountPath, ref TSteamError pError);
		[VTableSlot(11)]
		Int32 UnmountFilesystem(UInt32 hFile, ref TSteamError pError);
		[VTableSlot(12)]
		Int32 Stat(string cszName, ref TSteamElemInfo pInfo, ref TSteamError pError);
		[VTableSlot(13)]
		Int32 SetvBuf(UInt32 hFile, Byte[] pBuf, ESteamBufferMethod eMethod, UInt32 uBytes, ref TSteamError pError);
		[VTableSlot(14)]
		Int32 FlushFile(UInt32 hFile, ref TSteamError pError);
		[VTableSlot(15)]
		UInt32 OpenFile(string cszName, string cszMode, ref TSteamError pError);
		[VTableSlot(16)]
		UInt32 OpenFileEx(string cszFileName, string cszMode, Int32 nFlags, ref UInt32 puFileSize, ref Int32 pnLocal, ref TSteamError pError);
		[VTableSlot(17)]
		UInt32 OpenTmpFile(ref TSteamError pError);
		[VTableSlot(18)]
		void ClearError(ref TSteamError pError);
		[VTableSlot(19)]
		Int32 GetVersion(StringBuilder szVersion, UInt32 uVersionBufSize);
		[VTableSlot(20)]
		Int32 GetOfflineStatus(ref TSteamOfflineStatus pSteamOfflineStatus, ref TSteamError pError);
		[VTableSlot(21)]
		Int32 ChangeOfflineStatus(ref TSteamOfflineStatus pSteamOfflineStatus, ref TSteamError pError);
		[VTableSlot(22)]
		Int32 ProcessCall(UInt32 handle, ref TSteamProgress pProgress, ref TSteamError pError);
		[VTableSlot(23)]
		Int32 AbortCall(UInt32 handle, ref TSteamError pError);
		[VTableSlot(24)]
		Int32 BlockingCall(UInt32 handle, UInt32 uiProcessTickMS, ref TSteamError pError);
		[VTableSlot(25)]
		Int32 SetMaxStallCount(UInt32 uNumStalls, ref TSteamError pError);
		[VTableSlot(26)]
		Int32 CloseFile(UInt32 hFile, ref TSteamError pError);
		[VTableSlot(27)]
		UInt32 ReadFile(Byte[] pBuf, UInt32 uSize, UInt32 uCount, UInt32 hFile, ref TSteamError pError);
		[VTableSlot(28)]
		UInt32 WriteFile(Byte[] pBuf, UInt32 uSize, UInt32 uCount, UInt32 hFile, ref TSteamError pError);
		[VTableSlot(29)]
		Int32 Getc(UInt32 hFile, ref TSteamError pError);
		[VTableSlot(30)]
		Int32 Putc(Int32 cChar, UInt32 hFile, ref TSteamError pError);
		[VTableSlot(31)]
		Int32 SeekFile(UInt32 hFile, Int32 lOffset, ESteamSeekMethod eMethod, ref TSteamError pError);
		[VTableSlot(32)]
		Int32 TellFile(UInt32 hFile, ref TSteamError pError);
		[VTableSlot(33)]
		Int32 SizeFile(UInt32 hFile, ref TSteamError pError);
		[VTableSlot(34)]
		UInt32 FindFirst(string cszPattern, ESteamFindFilter eFilter, ref TSteamElemInfo pFindInfo, ref TSteamError pError);
		[VTableSlot(35)]
		Int32 FindNext(UInt32 hFind, ref TSteamElemInfo pFindInfo, ref TSteamError pError);
		[VTableSlot(36)]
		Int32 FindClose(UInt32 hFind, ref TSteamError pError);
		[VTableSlot(37)]
		Int32 GetLocalFileCopy(string cszName, ref TSteamError pError);
		[VTableSlot(38)]
		Int32 IsFileImmediatelyAvailable(string cszName, ref TSteamError pError);
		[VTableSlot(39)]
		Int32 HintResourceNeed(string cszMasterList, Int32 bForgetEverything, ref TSteamError pError);
		[VTableSlot(40)]
		Int32 ForgetAllHints(ref TSteamError pError);
		[VTableSlot(41)]
		Int32 PauseCachePreloading(ref TSteamError pError);
		[VTableSlot(42)]
		Int32 ResumeCachePreloading(ref TSteamError pError);
		[VTableSlot(43)]
		UInt32 WaitForResources(string cszMasterList, ref TSteamError pError);
		[VTableSlot(44)]
		Int32 StartEngine(ref TSteamError pError);
		[VTableSlot(45)]
		Int32 ShutdownEngine(ref TSteamError pError);
		[VTableSlot(46)]
		Int32 Startup(UInt32 uUsingMask, ref TSteamError pError);
		[VTableSlot(47)]
		Int32 Cleanup(ref TSteamError pError);
		[VTableSlot(48)]
		UInt32 NumAppsRunning(ref TSteamError pError);
		[VTableSlot(49)]
		UInt32 CreateAccount(string cszUser, string cszEmailAddress, string cszPassphrase, string cszCreationKey, string cszPersonalQuestion, string cszAnswerToQuestion, ref Int32 pbCreated, ref TSteamError pError);
		[VTableSlot(50)]
		UInt32 GenerateSuggestedAccountNames(string cszAccountNameToSelectMasterAS, string cszGenerateNamesLikeAccountName, StringBuilder pSuggestedNamesBuf, UInt32 uBufSize, ref UInt32 puNumSuggestedChars, ref TSteamError pError);
		[VTableSlot(51)]
		Int32 IsLoggedIn(ref Int32 pbIsLoggedIn, ref TSteamError pError);
		[VTableSlot(52)]
		UInt32 Logout(ref TSteamError pError);
		[VTableSlot(53)]
		Int32 IsSecureComputer(ref Int32 pbIsSecureComputer, ref TSteamError pError);
		[VTableSlot(54)]
		UInt32 CreateLogContext(string cszName);
		[VTableSlot(55)]
		Int32 Log(UInt32 hContext, string cszMsg);
		[VTableSlot(56)]
		void LogResourceLoadStarted(string cszMsg);
		[VTableSlot(57)]
		void LogResourceLoadFinished(string cszMsg);
		[VTableSlot(58)]
		UInt32 RefreshLogin(string cszPassphrase, Int32 bIsSecureComputer, ref TSteamError pError);
		[VTableSlot(59)]
		Int32 VerifyPassword(string cszPassphrase, ref Int32 pbCorrect, ref TSteamError pError);
		[VTableSlot(60)]
		Int32 GetUserType(ref UInt32 puUserTypeFlags, ref TSteamError pError);
		[VTableSlot(61)]
		Int32 GetAppStats(ref TSteamAppStats pAppStats, ref TSteamError pError);
		[VTableSlot(62)]
		UInt32 IsAccountNameInUse(string cszAccountName, ref Int32 pbIsUsed, ref TSteamError pError);
		[VTableSlot(63)]
		Int32 GetAppIds(ref UInt32 puIds, UInt32 uMaxIds, ref TSteamError pError);
		[VTableSlot(64)]
		Int32 GetSubscriptionStats(ref TSteamSubscriptionStats pSubscriptionStats, ref TSteamError pError);
		[VTableSlot(65)]
		UInt32 RefreshAccountInfo(Int32 bContentDescriptionOnly, ref TSteamError pError);
		[VTableSlot(66)]
		UInt32 Subscribe(UInt32 uSubscriptionId, ref TSteamSubscriptionBillingInfo pSubscriptionBillingInfo, ref TSteamError pError);
		[VTableSlot(67)]
		UInt32 Unsubscribe(UInt32 uSubscriptionId, ref TSteamError pError);
		[VTableSlot(68)]
		Int32 GetSubscriptionReceipt(UInt32 uSubscriptionId, ref TSteamSubscriptionReceipt pSteamSubscriptionReceipt, ref TSteamError pError);
		[VTableSlot(69)]
		Int32 GetAccountStatus(ref UInt32 puAccountStatusFlags, ref TSteamError pError);
		[VTableSlot(70)]
		UInt32 SetUser(string cszUser, ref Int32 pbUserSet, ref TSteamError pError);
		[VTableSlot(71)]
		Int32 GetUser(StringBuilder szUser, UInt32 uBufSize, ref UInt32 puUserChars, ref TSteamGlobalUserID pOptionalReceiveUserID, ref TSteamError pError);
		[VTableSlot(72)]
		UInt32 Login(string cszUser, string cszPassphrase, Int32 bIsSecureComputer, ref TSteamError pError);
		[VTableSlot(73)]
		UInt32 AckSubscriptionReceipt(UInt32 uSubscriptionId, ref TSteamError pError);
		[VTableSlot(74)]
		Int32 IsAppSubscribed(UInt32 uAppId, ref Int32 pbIsAppSubscribed, ref Int32 pbIsSubscriptionPending, ref TSteamError pError);
		[VTableSlot(75)]
		Int32 GetSubscriptionIds(ref UInt32 puIds, UInt32 uMaxIds, ref TSteamError pError);
		[VTableSlot(76)]
		Int32 EnumerateSubscription(UInt32 uSubscriptionId, ref TSteamSubscription pSubscription, ref TSteamError pError);
		[VTableSlot(77)]
		Int32 EnumerateSubscriptionDiscount(UInt32 uSubscriptionId, UInt32 uDiscountIndex, ref TSteamSubscriptionDiscount pSteamSubscriptionDiscount, ref TSteamError pError);
		[VTableSlot(78)]
		Int32 EnumerateSubscriptionDiscountQualifier(UInt32 uSubscriptionId, UInt32 uDiscountIndex, UInt32 uQualifierIndex, ref TSteamDiscountQualifier pSteamDiscountQualifier, ref TSteamError pError);
		[VTableSlot(79)]
		Int32 EnumerateApp(UInt32 uAppId, ref TSteamApp pApp, ref TSteamError pError);
		[VTableSlot(80)]
		Int32 EnumerateAppLaunchOption(UInt32 uAppId, UInt32 uLaunchOptionIndex, ref TSteamAppLaunchOption pLaunchOption, ref TSteamError pError);
		[VTableSlot(81)]
		UInt32 DeleteAccount(ref TSteamError pError);
		[VTableSlot(82)]
		Int32 EnumerateAppIcon(UInt32 uAppId, UInt32 uIconIndex, Byte[] pIconData, UInt32 uIconDataBufSize, ref UInt32 puSizeOfIconData, ref TSteamError pError);
		[VTableSlot(83)]
		UInt32 LaunchApp(UInt32 uAppId, UInt32 uLaunchOption, string cszArgs, ref TSteamError pError);
		[VTableSlot(84)]
		Int32 GetCacheFilePath(UInt32 uAppId, StringBuilder szFilePath, UInt32 uBufferLength, ref UInt32 puRecievedLength, ref TSteamError pError);
		[VTableSlot(85)]
		Int32 EnumerateAppVersion(UInt32 uAppId, UInt32 uVersionIndex, ref TSteamAppVersion pAppVersion, ref TSteamError pError);
		[VTableSlot(86)]
		Int32 EnumerateAppDependency(UInt32 uAppId, UInt32 uIndex, ref TSteamAppDependencyInfo pDependencyInfo, ref TSteamError pError);
		[VTableSlot(87)]
		UInt32 StartLoadingCache(UInt32 uAppId, ref TSteamError pError);
		[VTableSlot(88)]
		Int32 InsertAppDependency(UInt32 uAppId, UInt32 uFileSystemIndex, ref TSteamAppDependencyInfo pDependencyInfo, ref TSteamError pError);
		[VTableSlot(89)]
		Int32 RemoveAppDependency(UInt32 uAppId, UInt32 uFileSystemIndex, ref TSteamError pError);
		[VTableSlot(90)]
		Int32 FindApp(string cszAppName, ref UInt32 puAppId, ref TSteamError pError);
		[VTableSlot(91)]
		Int32 GetAppDependencies(UInt32 uAppId, ref UInt32 puCacheIds, UInt32 uMaxIds, ref TSteamError pError);
		[VTableSlot(92)]
		Int32 IsSubscribed(UInt32 uSubscriptionId, ref Int32 pbIsSubscribed, ref Int32 pbIsSubscriptionPending, ref TSteamError pError);
		[VTableSlot(93)]
		Int32 GetAppUserDefinedInfo(UInt32 uAppId, string cszPropertyName, StringBuilder szPropertyValue, UInt32 uBufSize, ref UInt32 puPropertyValueLength, ref TSteamError pError);
		[VTableSlot(94)]
		UInt32 WaitForAppReadyToLaunch(UInt32 uAppId, ref TSteamError pError);
		[VTableSlot(95)]
		Int32 IsCacheLoadingEnabled(UInt32 uAppId, ref Int32 pbIsLoading, ref TSteamError pError);
		[VTableSlot(96)]
		UInt32 StopLoadingCache(UInt32 uAppId, ref TSteamError pError);
		[VTableSlot(97)]
		ESteamError GetEncryptedUserIDTicket(Byte[] pEncryptionKeyReceivedFromAppServer, UInt32 uEncryptionKeyLength, Byte[] pOutputBuffer, UInt32 uSizeOfOutputBuffer, ref UInt32 pReceiveSizeOfEncryptedTicket, ref TSteamError pError);
		[VTableSlot(98)]
		UInt32 FlushCache(UInt32 uAppId, ref TSteamError pError);
		[VTableSlot(99)]
		UInt32 RepairOrDecryptCaches(UInt32 uAppId, Int32 bForceValidation, ref TSteamError pError);
		[VTableSlot(100)]
		UInt32 LoadCacheFromDir(UInt32 uAppId, string cszPath, ref TSteamError pError);
		[VTableSlot(101)]
		Int32 GetCacheDefaultDirectory(StringBuilder szPath, ref TSteamError pError);
		[VTableSlot(102)]
		Int32 SetCacheDefaultDirectory(string cszPath, ref TSteamError pError);
		[VTableSlot(103)]
		Int32 GetAppDir(UInt32 uAppId, StringBuilder szAppDir, ref TSteamError pError);
		[VTableSlot(104)]
		UInt32 MoveApp(UInt32 uAppId, string szPath, ref TSteamError pError);
		[VTableSlot(105)]
		UInt32 GetAppCacheSize(UInt32 uAppId, ref UInt32 puCacheSizeInMb, ref TSteamError pError);
		[VTableSlot(106)]
		UInt32 SetAppCacheSize(UInt32 uAppId, UInt32 uCacheSizeInMb, ref TSteamError pError);
		[VTableSlot(107)]
		UInt32 SetAppVersion(UInt32 uAppId, UInt32 uAppVersionId, ref TSteamError pError);
		[VTableSlot(108)]
		UInt32 Uninstall(ref TSteamError pError);
		[VTableSlot(109)]
		Int32 SetNotificationCallback(ref IntPtr pCallbackFunction, ref TSteamError pError);
		[VTableSlot(110)]
		UInt32 ChangeForgottenPassword(string cszUser, string cszAnswerToQuestion, string cszEmailVerificationKey, string cszNewPassphrase, ref Int32 pbChanged, ref TSteamError pError);
		[VTableSlot(111)]
		UInt32 RequestForgottenPasswordEmail(string cszUser, StringBuilder ReceivePersonalQuestion, ref TSteamError pError);
		[VTableSlot(112)]
		UInt32 RequestAccountsByEmailAddressEmail(string cszEmailAddress, ref TSteamError pError);
		[VTableSlot(113)]
		UInt32 RequestAccountsByCdKeyEmail(string cszCdKey, ref TSteamError pError);
		[VTableSlot(114)]
		UInt32 GetNumAccountsWithEmailAddress(string cszEmailAddress, ref UInt32 puNumAccounts, ref TSteamError pError);
		[VTableSlot(115)]
		UInt32 UpdateAccountBillingInfo(ref TSteamPaymentCardInfo pPaymentCardInfo, ref TSteamError pError);
		[VTableSlot(116)]
		UInt32 UpdateSubscriptionBillingInfo(UInt32 uSubscriptionId, ref TSteamSubscriptionBillingInfo pSubscriptionBillingInfo, ref TSteamError pError);
		[VTableSlot(117)]
		Int32 GetSponsorUrl(UInt32 uAppId, StringBuilder szUrl, UInt32 uBufSize, ref UInt32 pUrlChars, ref TSteamError pError);
		[VTableSlot(118)]
		Int32 GetContentServerInfo(UInt32 uAppId, ref UInt32 puServerId, ref UInt32 puServerIpAddress, ref TSteamError pError);
		[VTableSlot(119)]
		UInt32 GetAppUpdateStats(UInt32 uAppOrCacheId, ESteamAppUpdateStatsQueryType eQueryType, ref TSteamUpdateStats pUpdateStats, ref TSteamError pError);
		[VTableSlot(120)]
		Int32 GetTotalUpdateStats(ref TSteamUpdateStats pUpdateStats, ref TSteamError pError);
		[VTableSlot(121)]
		UInt32 CreateCachePreloaders(ref TSteamError pError);
		[VTableSlot(122)]
		void Win32SetMiniDumpComment(string cszComment);
		[VTableSlot(123)]
		void Win32SetMiniDumpSourceControlId(UInt32 uSourceControlId);
		[VTableSlot(124)]
		void Win32SetMiniDumpEnableFullMemory();
		[VTableSlot(125)]
		void Win32WriteMiniDump(string szErrorOrAssertType, string szDescriptionOrAssertName, string szAssertExpr, string szAssertFilename, UInt32 uAssertLineNumber);
		[VTableSlot(126)]
		Int32 GetCurrentAppId(ref UInt32 puAppId, ref TSteamError pError);
		[VTableSlot(127)]
		Int32 GetAppPurchaseCountry(UInt32 uAppId, StringBuilder szCountryCode, UInt32 uBufferLength, ref Int32 piRecievedLength, ref TSteamError pError);
		[VTableSlot(128)]
		Int32 GetLocalClientVersion(ref UInt32 puBootStrapperVersionNum, ref UInt32 puClientAppVersionNum, ref TSteamError pError);
		[VTableSlot(129)]
		Int32 IsFileNeededByCache(UInt32 uCacheId, string cszFileName, UInt32 uFileSize, ref TSteamError pError);
		[VTableSlot(130)]
		Int32 LoadFileToCache(UInt32 uCacheId, string pchFileName, Byte[] pubDataChunk, UInt32 cubDataChunk, UInt32 cubDataOffset, ref TSteamError pError);
		[VTableSlot(131)]
		Int32 GetCacheDecryptionKey(UInt32 uAppId, StringBuilder szCacheDecryptionKey, UInt32 uBufferLength, ref UInt32 puRecievedLength, ref TSteamError pError);
		[VTableSlot(132)]
		Int32 GetSubscriptionExtendedInfo(UInt32 uSubscriptionId, string cszKeyName, StringBuilder szKeyValue, UInt32 uBufferLength, ref UInt32 puRecievedLength, ref TSteamError pError);
		[VTableSlot(133)]
		Int32 GetSubscriptionPurchaseCountry(UInt32 uSubscriptionId, StringBuilder szCountry, UInt32 uBufSize, ref Int32 pPurchaseTime, ref TSteamError pError);
		[VTableSlot(134)]
		Int32 GetAppUserDefinedRecord(UInt32 uAppId, ref IntPtr AddEntryToKeyValueFunc, Byte[] pvCKeyValue, ref TSteamError pError);
		[VTableSlot(135)]
		Int32 FindServersNumServers(ESteamServerType eSteamServerType);
		[VTableSlot(136)]
		Int32 FindServersIterateServer(ESteamServerType eSteamServerType, UInt32 uIndex, StringBuilder szServerAddress, Int32 iServerAddressChars);
		[VTableSlot(137)]
		string FindServersGetErrorString();
		[VTableSlot(138)]
		Int32 CheckAppOwnership(UInt32 uAppId, ref Int32 pbOwned, ref TSteamGlobalUserID pSteamGlobalUserID, ref TSteamError pError);
		[VTableSlot(139)]
		UInt32 GetCachePercentFragmentation(UInt32 uAppId, ref UInt32 puPercentFragmented, ref TSteamError pError);
		[VTableSlot(140)]
		UInt32 DefragCaches(UInt32 uAppId, ref TSteamError pError);
		[VTableSlot(141)]
		Int32 IsFileNeededByApp(UInt32 uAppId, string cszFileName, UInt32 uFileSize, ref UInt32 puCacheId, ref TSteamError pError);
		[VTableSlot(142)]
		UInt32 WaitForAppResources(UInt32 uAppId, string cszMasterList, ref TSteamError pError);
		[VTableSlot(143)]
		Int32 ForceCellId(UInt32 uCellId, ref TSteamError pError);
		[VTableSlot(144)]
		Int32 GetAppDLCStatus(UInt32 uAppId, UInt32 uDLCCacheId, ref Int32 pbDownloaded, ref TSteamError pError);
		[VTableSlot(145)]
		Int32 StartEngineEx(ref TSteamError pError, bool bStartOffline, bool bDetectOnlineOfflineState);
		[VTableSlot(146)]
		Int32 IsUsingSdkContentServer(ref Int32 pbUsingSdkCS, ref TSteamError pError);
		[VTableSlot(147)]
		Int32 GetDepotParent(UInt32 uDepotId, ref UInt32 puParentId, ref TSteamError pError);
		[VTableSlot(148)]
		Int32 GetCurrentCellID(ref UInt32 puCellID, ref UInt32 puPing, ref TSteamError pError);
		[VTableSlot(149)]
		Int32 ForceProcessLocalEngine();
		[VTableSlot(150)]
		UInt32 SetUser2(string cszUser, ref TSteamError pError);
	};
}