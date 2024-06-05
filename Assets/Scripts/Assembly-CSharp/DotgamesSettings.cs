using System.Collections.Generic;
using UnityEngine;

public class DotgamesSettings : ScriptableObject
{
	public delegate void OnChangeCallback();

	public const string SettingsAssetName = "DotgamesSettings";

	public const string SettingsPath = "Dotgames/Resources";

	public const string SettingsAssetExtension = ".asset";

	private static List<OnChangeCallback> onChangeCallbacks;

	private static DotgamesSettings instance;

	[SerializeField]
	private string rijndaelKey;

	[SerializeField]
	private string rijndaelIV;

	[SerializeField]
	private string xorKey;

	public static string RijndaelKey
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string RijndaelIV
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string XorKey
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static DotgamesSettings Instance => null;

	public static DotgamesSettings NullableInstance => null;

	public static void RegisterChangeEventCallback(OnChangeCallback callback)
	{
	}

	public static void UnregisterChangeEventCallback(OnChangeCallback callback)
	{
	}

	private static void SettingsChanged()
	{
	}
}
