using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.Networking;

public class NetworkHelper : DGSingleton<NetworkHelper>
{
	public enum LogType
	{
		Log = 0,
		Warn = 1,
		Error = 2
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CPOST_COROUTINE_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<DownloadHandler> _003C_003Et__builder;

		public string url;

		public Dictionary<string, string> form;

		private UnityWebRequestAsyncOperation _003Cao_003E5__2;

		private UnityWebRequestAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CPOST_HTTP_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Action<string> callback;

		public NetworkHelper _003C_003E4__this;

		public string url;

		public JSONObject form;

		private Task<DownloadHandler> _003Crequest_003E5__2;

		private TaskAwaiter<DownloadHandler> _003C_003Eu__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public const bool debugLog = true;

	private void LogIf(string log, LogType logType = LogType.Log)
	{
	}

	[AsyncStateMachine(typeof(_003CPOST_HTTP_003Ed__3))]
	public void POST_HTTP(string url, JSONObject form, Action<string> callback)
	{
	}

	[AsyncStateMachine(typeof(_003CPOST_COROUTINE_003Ed__4))]
	public Task<DownloadHandler> POST_COROUTINE(string url, Dictionary<string, string> form)
	{
		return null;
	}
}
