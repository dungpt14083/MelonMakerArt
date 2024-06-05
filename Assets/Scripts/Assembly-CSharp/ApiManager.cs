using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;

public class ApiManager : DGSingleton<ApiManager>
{
	public struct PromoData
	{
		public string prCode;

		public string prVersion;

		public string prId;

		public string prType;

		public string prPackage;

		public string storeLink;

		public string oneLink;

		public string contentCode;

		public string imgLink;

		public Sprite imgData;

		public string videoLink;

		public string videoData;

		public string abLink;

		public GameObject abData;

		public UnityAction<MonoBehaviour> onClick;

		public PromoData(string pc, string pv, string pt, string pi, string sl, string ol, string cc, string pack, string il, string vl, string al)
		{
			prCode = null;
			prVersion = null;
			prId = null;
			prType = null;
			prPackage = null;
			storeLink = null;
			oneLink = null;
			contentCode = null;
			imgLink = null;
			imgData = null;
			videoLink = null;
			videoData = null;
			abLink = null;
			abData = null;
			onClick = null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CLoadPromotionResource_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action onLoadStart;

		public PromoData promoData;

		public byte loadType;

		public ApiManager _003C_003E4__this;

		public Action<PromoData> onLoadSuccess;

		public Action onLoadEnd;

		private bool _003CisLoadSuccess_003E5__2;

		private UnityWebRequest _003Crequest_003E5__3;

		private AssetBundleRequest _003CabRequest_003E5__4;

		private string _003CfilePath_003E5__5;

		private DownloadHandlerTexture _003CtexDl_003E5__6;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CLoadPromotionResource_003Ed__16(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public const byte TYPE_BUNDLE = 1;

	public const byte TYPE_SPRITE = 2;

	public const byte TYPE_VIDEO = 4;

	private const string PromotionUrl = "http://superbox.kr/JSON/GetCPI";

	private const string PromotionLog = "http://superbox.kr/JSON/PrLog";

	private string prCode;

	private string prVersion;

	private List<PromoData> promoDatas;

	public string TYPE_TO_STRING(byte type)
	{
		return null;
	}

	public override void Awake()
	{
	}

	public List<PromoData> GetPromoDatas()
	{
		return null;
	}

	public void SendClickLog(string to)
	{
	}

	public void SendStartLog()
	{
	}

	public void LoadPromotion(byte loadType = 1, Action onLoadStart = null, Action<PromoData> onLoadSuccess = null, Action onLoadEnd = null, Action onLoadFailed = null)
	{
	}

	public void OnDestroy()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadPromotionResource_003Ed__16))]
	private IEnumerator LoadPromotionResource(byte loadType, Action onLoadStart, Action<PromoData> onLoadSuccess, Action onLoadEnd, PromoData promoData)
	{
		return null;
	}
}
