using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SFXManager : DGSingleton<SFXManager>
{
	[CompilerGenerated]
	private sealed class _003C_playEffect_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public SFXManager _003C_003E4__this;

		public string name;

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
		public _003C_playEffect_003Ed__10(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003C_playEffectLoops_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public SFXManager _003C_003E4__this;

		public string name;

		public int loops;

		public float interval;

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
		public _003C_playEffectLoops_003Ed__13(int _003C_003E1__state)
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

	public AudioSource musicSource;

	public AudioClip[] musicClips;

	public AudioSource soundSource;

	[SerializeField]
	public Dictionary<string, AudioClip> audioClips;

	public override void Awake()
	{
	}

	public void TestBackground(int idx)
	{
	}

	public void SetBackground(int idx)
	{
	}

	public void PlayBackground()
	{
	}

	public void StopBackground()
	{
	}

	public void PlayEffect(string name, float delay = 0f)
	{
	}

	[IteratorStateMachine(typeof(_003C_playEffect_003Ed__10))]
	private IEnumerator _playEffect(string name, float delay)
	{
		return null;
	}

	public void PlayEffectFadeBGM(string name)
	{
	}

	public void PlayEffectLoops(string name, int loops, float interval, float delay = 0f)
	{
	}

	[IteratorStateMachine(typeof(_003C_playEffectLoops_003Ed__13))]
	private IEnumerator _playEffectLoops(string name, int loops, float interval, float delay)
	{
		return null;
	}

	public void PlayButtonEffect()
	{
	}

	public void SetMusicVolumn(int value)
	{
	}

	public void SetSoundVolumn(int value)
	{
	}
}
