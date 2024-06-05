using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupPause : DGPopup
{
	public Image m_btnSound;

	public Image m_iconSound;

	public Image m_btnMusic;

	public Image m_iconMusic;

	public Image m_btnHaptic;

	public Image m_iconHaptic;

	public Dropdown m_dropLang;

	public GameObject m_youtubeMusicPoint;

	public GameObject m_facebookMusicPoint;

	public TMP_Text m_txtVersion;

	public override void Start()
	{
	}

	private void CheckSound(bool init = false)
	{
	}

	private void CheckMusic(bool init = false)
	{
	}

	private void CheckHaptic(bool init = false)
	{
	}

	private void CheckLang()
	{
	}

	public void OnToggleMusic()
	{
	}

	public void OnToggleSound()
	{
	}

	public void OnToggleHaptic()
	{
	}

	public void OnChangeLang(int idx)
	{
	}

	public void OnClickExit()
	{
	}

	public void OnClickReplay()
	{
	}

	public void OnClickResume()
	{
	}

	public void OnClickYoutube()
	{
	}

	public void OnClickFacebook()
	{
	}

	public override void OnBackButtonPressed()
	{
	}
}
