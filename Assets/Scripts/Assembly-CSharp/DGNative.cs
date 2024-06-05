using System;
using UnityEngine;

public class DGNative : DGSingleton<DGNative>
{
	public string UserLocaleCountryCode => null;

	public override void Awake()
	{
	}

	public Texture2D Capture(Camera camera)
	{
		return null;
	}

	public string SaveImage(Texture2D texture, string name)
	{
		return null;
	}

	public void ShareTextNative(string text, Action<NativeShare.ShareResult, string> callback)
	{
	}

	public void ShareImageNative(string text, Texture2D texture, Action<NativeShare.ShareResult, string> callback)
	{
	}

	public void ShareImageNative(string text, string path, Action<NativeShare.ShareResult, string> callback)
	{
	}
}
