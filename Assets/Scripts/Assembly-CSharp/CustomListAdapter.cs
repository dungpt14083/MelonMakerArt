using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using UnityEngine;

public class CustomListAdapter : OSA<BaseParamsWithPrefab, MyListItemViewsHolder>
{
	[CompilerGenerated]
	private sealed class _003CFetchMoreItemsFromDataSourceAndUpdate_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CustomListAdapter _003C_003E4__this;

		public List<MyListItemModel> list;

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
		public _003CFetchMoreItemsFromDataSourceAndUpdate_003Ed__23(int _003C_003E1__state)
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

	public Action actionInitial;

	public Action<int, MyListItemViewsHolder> actionUpdateList;

	public SimpleDataHelper<MyListItemModel> Data { get; private set; }

	protected override void Start()
	{
	}

	public void StartAdapter(List<int> list)
	{
	}

	public void StartAdapter(List<MyListItemModel> list)
	{
	}

	public void RefreshAdapter(List<int> list)
	{
	}

	public void RefreshAdapter(List<MyListItemModel> list)
	{
	}

	public List<GameObject> GetVisibleList()
	{
		return null;
	}

	protected override MyListItemViewsHolder CreateViewsHolder(int itemIndex)
	{
		return null;
	}

	protected override void OnItemHeightChangedPreTwinPass(MyListItemViewsHolder vh)
	{
	}

	protected override void UpdateViewsHolder(MyListItemViewsHolder newOrRecycled)
	{
	}

	protected override void OnBeforeRecycleOrDisableViewsHolder(MyListItemViewsHolder inRecycleBinOrVisible, int newItemIndex)
	{
	}

	protected override void RebuildLayoutDueToScrollViewSizeChange()
	{
	}

	public override void ChangeItemsCount(ItemCountChangeMode changeMode, int itemsCount, int indexIfInsertingOrRemoving = -1, bool contentPanelEndEdgeStationary = false, bool keepVelocity = false)
	{
	}

	private void SetAllModelsHavePendingSizeChange()
	{
	}

	public void AddItemsAt(int index, IList<MyListItemModel> items)
	{
	}

	public void RemoveItemsFrom(int index, int count)
	{
	}

	public void SetItems(IList<MyListItemModel> items)
	{
	}

	private void RetrieveDataAndUpdate(List<MyListItemModel> list)
	{
	}

	[IteratorStateMachine(typeof(_003CFetchMoreItemsFromDataSourceAndUpdate_003Ed__23))]
	private IEnumerator FetchMoreItemsFromDataSourceAndUpdate(List<MyListItemModel> list)
	{
		return null;
	}

	private void OnDataRetrieved(MyListItemModel[] newItems)
	{
	}
}
