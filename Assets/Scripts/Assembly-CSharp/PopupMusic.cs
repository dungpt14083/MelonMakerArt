using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopupMusic : DGPopup
{
	public TMP_Text m_txtMusicPoint;

	public List<MusicScript> m_areaMusics;

	public GameObject m_areaSelect;

	public GameObject m_areaBuy;

	public GameObject m_btnBuy;

	public GameObject m_btnGray;

	public GameObject m_btnAds;

	public Transform m_pointTarget;

	private int m_curMusic;

	public override void Start()
	{
	}

	public void OnClickPointAds()
	{
	}

	public void CheckItems()
	{
	}

	public void OnClickMusic(MusicScript music)
	{
	}

	public void OnClickSelect()
	{
	}

	public void OnClickBuy()
	{
	}

	public void OnClickClose()
	{
	}

	public override void OnBackButtonPressed()
	{
	}
}
