using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public struct UnityWebRequestAwaiter : INotifyCompletion
{
	private UnityWebRequestAsyncOperation asyncOp;

	private Action continuation;

	public bool IsCompleted => false;

	public UnityWebRequestAwaiter(UnityWebRequestAsyncOperation asyncOp)
	{
		this.asyncOp = null;
		continuation = null;
	}

	public void GetResult()
	{
	}

	public void OnCompleted(Action continuation)
	{
	}

	private void OnRequestCompleted(AsyncOperation obj)
	{
	}
}
