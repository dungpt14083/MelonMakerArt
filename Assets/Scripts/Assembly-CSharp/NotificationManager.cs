using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Firebase.Messaging;

public class NotificationManager : DGSingleton<NotificationManager>
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSetNotification_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NotificationManager _003C_003E4__this;

		public bool isOn;

		public Action done;

		private TaskAwaiter<string> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private bool m_isWorking;

	public bool IsWorking => false;

	public void Init()
	{
	}

	[AsyncStateMachine(typeof(_003CSetNotification_003Ed__4))]
	public Task SetNotification(bool isOn, Action done)
	{
		return null;
	}

	public void OnTokenReceived(object sender, TokenReceivedEventArgs token)
	{
	}

	public void OnMessageReceived(object sender, MessageReceivedEventArgs e)
	{
	}
}
