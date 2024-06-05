using UnityEngine;

public abstract class DGSingleton<T> : MonoBehaviour where T : DGSingleton<T>
{
	private static T _instance;

	public static T Instance => null;

	public virtual void Awake()
	{
	}

	private void OnApplicationQuit()
	{
	}
}
