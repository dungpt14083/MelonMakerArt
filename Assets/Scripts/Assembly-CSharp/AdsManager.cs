using System;
using AmazonAds;

public class AdsManager : DGSingleton<AdsManager>
{
	public enum Placement
	{
		None = 0,
		Pause = 1,
		Game = 2
	}

	private Action<bool> interstitialCallback;

	private Action onRewardAdsRewarded;

	private Action onRewardAdsClosed;

	private DateTime launchTime;

	private DateTime lastAdsTime;

	private Placement placement;

	public int requestCount;

	public int totalRequestCount;

	public bool isBannerShow;

	private bool isFullscreenAdsShowing;

	private int interstitialVideoRetryCount;

	private int rewardedAdsRetryCount;

	public bool isPauseAdsProtected;

	private DateTime pausedTime;

	private APSBannerAdRequest bannerAdRequest;

	private APSVideoAdRequest interstitialVideoAdRequest;

	private APSVideoAdRequest rewardedVideoAdRequest;

	private bool isFirstLoadIV;

	private bool isFirstLoadRV;

	public int interstitialCredit;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo impressionData)
	{
	}

	private void CheckCallPausePopup(double sec)
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}

	private void OnSdkInitializedEvent(MaxSdkBase.SdkConfiguration sdkConfiguration)
	{
	}

	public void ShowMediationDebugger()
	{
	}

	public bool IsTablet()
	{
		return false;
	}

	private void LoadInterstitialVideoMax()
	{
	}

	public bool ShowInterstitialAds(Placement _placement, Action<bool> callback, string placementName)
	{
		return false;
	}

	private void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
	{
	}

	private void OnInterstitialAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void LoadBanner()
	{
	}

	private void CreateMaxBannerAd()
	{
	}

	public void ShowBanner()
	{
	}

	public void HideBanner()
	{
	}

	public void ResetBanner()
	{
	}

	public void DestroyBanner()
	{
	}

	private void OnBannerAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnBannerAdLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
	{
	}

	private void OnBannerAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void LoadRewardVideo()
	{
	}

	public bool IsRewardVideoLoaded()
	{
		return false;
	}

	public void ShowRewardVideo(Action onSuccess, Action onClose, string placementName)
	{
	}

	private void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
	{
	}

	private void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdkBase.Reward reward, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}
}
