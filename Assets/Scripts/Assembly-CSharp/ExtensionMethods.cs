using UnityEngine.Networking;

public static class ExtensionMethods
{
	public static UnityWebRequestAwaiter GetAwaiter(this UnityWebRequestAsyncOperation asyncOp)
	{
		return default(UnityWebRequestAwaiter);
	}
}
