using System.Collections.Generic;
using UnityEngine;

public abstract class DGPopup : MonoBehaviour
{
	public static List<DGPopup> listPopup;

	[HideInInspector]
	public bool isClosing;

	[HideInInspector]
	public bool isClosed;

	public static T Create<T>(GameObject original, Transform parent) where T : Object
	{
		return null;
	}

	public static int GetPopupCount()
	{
		return 0;
	}

	public static void BackButtonPressed()
	{
	}

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void OnDestroy()
	{
	}

	public virtual void Close()
	{
	}

	public static bool ExistsPopup<T>() where T : Object
	{
		return false;
	}

	public static T FindPopup<T>() where T : Object
	{
		return null;
	}

	public abstract void OnBackButtonPressed();
}
