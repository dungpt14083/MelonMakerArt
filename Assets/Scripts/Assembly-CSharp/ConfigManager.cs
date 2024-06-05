using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Firebase.RemoteConfig;

public class ConfigManager : DGSingleton<ConfigManager>
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CInitAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ConfigManager _003C_003E4__this;

		private Task _003Ctask_003E5__2;

		private ConfigInfo _003Cinfo_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public int ADS_PLAY_COUNT_LIMIT;

	public int ADS_TIME_LIMIT;

	public int ADS_LAUNCH_TIME_LIMIT;

	public bool ADS_BANNER_ENABLED;

	public bool ADS_GAME_INTERSTITIAL_ENABLED;

	public bool ADS_PAUSE_INTERSTITIAL_ENABLED;

	public int MAX_HAMMER_USE;

	public bool ANIMAL_SPRITE_SET;

	[AsyncStateMachine(typeof(_003CInitAsync_003Ed__8))]
	public Task InitAsync()
	{
		return null;
	}

	private void FetchValues()
	{
	}
}
