using Com.TheFallenGames.OSA.Core;
using UnityEngine;
using UnityEngine.UI;

public class MyListItemViewsHolder : BaseItemViewsHolder
{
	public GameObject item;

	private ContentSizeFitter ContentSizeFitter { get; set; }

	public override void CollectViews()
	{
	}

	public override void MarkForRebuild()
	{
	}

	public override void UnmarkForRebuild()
	{
	}
}
