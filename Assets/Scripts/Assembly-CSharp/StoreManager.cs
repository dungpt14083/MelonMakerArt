using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

public class StoreManager : DGSingleton<StoreManager>, IDetailedStoreListener, IStoreListener
{
	public enum Mode
	{
		NotSet = 0,
		Purchase = 1,
		Restore = 2
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CStart_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public StoreManager _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public IStoreController iapController;

	public IExtensionProvider iapExtensions;

	private IAppleExtensions appleExtensions;

	private Mode performMode;

	private Action<bool, string> _callback;

	private Action<bool> onInitCallback;

	private string _googleApiKey;

	private List<string> _consumable;

	private List<string> _nonConsumable;

	private List<string> _subscription;

	private List<Product> pendings;

	public bool isActivate;

	private bool isCheckPending;

	public string environment;

	[AsyncStateMachine(typeof(_003CStart_003Ed__15))]
	private void Start()
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}

	public void PendingCallback(bool isOK, string response)
	{
	}

	public void SetupIap(string googleApiKey, List<string> consumable, List<string> nonConsumable, List<string> subscription, Action<bool> onInit)
	{
	}

	public void PerformIAP(string productId, Action<bool, string> callback)
	{
	}

	public void CheckPending(Action<bool, string> callback)
	{
	}

	public void SimpleRestoreIAP(string productId, Action<bool, string> callback)
	{
	}

	public void RestoreIAP(Action<bool, string> callback)
	{
	}

	public string GetLocalizedPrice(string productId)
	{
		return null;
	}

	private void ValidatePurchaseReceipt(Product p)
	{
	}

	private void OnReceiptValidate(bool isOK, Product p)
	{
	}

	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
	}

	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
	{
		return default(PurchaseProcessingResult);
	}

	public void OnInitializeFailed(InitializationFailureReason r)
	{
	}

	public void OnPurchaseFailed(Product p, PurchaseFailureReason r)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason r, string message)
	{
	}

	public void OnPurchaseFailed(Product p, PurchaseFailureDescription failureDescription)
	{
	}
}
