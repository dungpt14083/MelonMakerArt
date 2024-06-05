using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Firebase;
using UnityEngine;

public class SplashScene : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCheckFirebaseAnalytics_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private string _003CstrLanguage_003E5__2;

		private string _003CstrLocale_003E5__3;

		private TaskAwaiter<DependencyStatus> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CStart_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SplashScene _003C_003E4__this;

		private Task _003Ctask_003E5__2;

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
		public _003CStart_003Ed__3(int _003C_003E1__state)
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

	public AudioSource audioSuperbox;

	public Animator aniSuperbox;

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__3))]
	private IEnumerator Start()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CCheckFirebaseAnalytics_003Ed__4))]
	private Task CheckFirebaseAnalytics()
	{
		return null;
	}
}
