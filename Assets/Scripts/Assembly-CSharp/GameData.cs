using System;
using System.Collections.Generic;
using UnityEngine;

public class GameData : DGSingleton<GameData>
{
	[Serializable]
	public class SaveData
	{
		[SerializeField]
		public List<int> lv;

		[SerializeField]
		public List<Vector2> pos;

		[SerializeField]
		public List<Vector2> vel;

		public int nxtLv;

		public int curLv;

		public int maxLv;

		public int score;

		public bool useItem;

		public int hammerUsed;
	}

	[Serializable]
	public struct DailyLog
	{
		[SerializeField]
		public string date;

		[SerializeField]
		public int score;

		public DailyLog(string d, int s)
		{
			date = null;
			score = 0;
		}
	}

	public struct RankObject
	{
		public int rank;

		public string name;

		public int score;

		public RankObject(int r, string n, int s)
		{
			rank = 0;
			name = null;
			score = 0;
		}
	}

	[HideInInspector]
	public float screenRate;

	public DateTime launchTime;

	[SerializeField]
	private SaveData m_saveData;

	public DateTime RecentRankTime;

	public DateTime RecentArchiveTime;

	private SList<int> _ownedMusic;

	public bool isAuthFailed;

	private int _nowScore;

	private SList<DailyLog> _dailyLogs;

	public List<RankObject> m_globalScoreRanks;

	public RankObject m_myScoreRank;

	public List<RankObject> m_globalArchiveRanks;

	public RankObject m_myArchiveRank;

	public int hammerUsed;

	[HideInInspector]
	public float minCameraSize => 0f;

	public int TurnCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MusicPoint
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsNotificationOn
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int MusicVolumn
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int CurrentMusic
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public List<int> OwnedMusic
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int SoundFxVolumn
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsHapticOn
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsAdsFree
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int InviteCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsInviteReset
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int PointAdsCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsPointAdsReset
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int isReviewLater
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool isReview
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isYoutubeClicked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isFacebookClicked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string UserName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int NowScore
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public List<DailyLog> DailyLogs
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int Highscore
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override void Awake()
	{
	}

	public void DeleteSave()
	{
	}

	public SaveData Load()
	{
		return null;
	}

	public void Save()
	{
	}

	public void CheckLogin(Action callback = null)
	{
	}

	public void AddDailyLog(int score)
	{
	}

	public void GetMergeCount(int i, Action<int> callback)
	{
	}

	public void AddMergeCount(int i, int add)
	{
	}

	public static string DecodeEncodedNonAsciiCharacters(string value)
	{
		return null;
	}
}
