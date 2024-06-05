using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class PopupRanking : DGPopup
{
	public CustomListAdapter m_scoreList;

	public List<int> m_scoreItems;

	public CustomListAdapter m_archiveList;

	public List<int> m_archiveItems;

	public Image m_imgMyScoreRank;

	public TMP_Text m_txtMyScoreRank;

	public Text m_txtMyScoreName;

	public TMP_Text m_txtMyScoreScore;

	public Image m_imgMyArchiveRank;

	public TMP_Text m_txtMyArchiveRank;

	public Text m_txtMyArchiveName;

	public TMP_Text m_txtMyArchiveScore;

	private bool isScoreScrolling;

	private bool isArchiveScrolling;

	public override void Start()
	{
	}

	public void InitScore()
	{
	}

	private void ScoreListPositionChanged(double pos)
	{
	}

	public void ScoreScrollPositionChanged(float pos)
	{
	}

	private void UpdateScoreList(int idx, MyListItemViewsHolder viewsHolder)
	{
	}

	public void GetScoreData()
	{
	}

	private void InitArchive()
	{
	}

	private void ArchiveListPositionChanged(double pos)
	{
	}

	public void ArchiveScrollPositionChanged(float pos)
	{
	}

	private void UpdateArchiveList(int idx, MyListItemViewsHolder viewsHolder)
	{
	}

	public void GetArchiveData()
	{
	}

	public void OnClickMyScore()
	{
	}

	public void OnClickMyArchive()
	{
	}

	public void OnClickResume()
	{
	}

	public override void OnBackButtonPressed()
	{
	}
}
