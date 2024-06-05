using System.Collections.Generic;
using UnityEngine;

public class SpritePool : DGSingleton<SpritePool>
{
	public Sprite m_buttonOn;

	public Sprite m_buttonOff;

	public Sprite m_iconSoundOn;

	public Sprite m_iconSoundOff;

	public Sprite m_iconMusicOn;

	public Sprite m_iconMusicOff;

	public Sprite m_iconHapticOn;

	public Sprite m_iconHapticOff;

	public Sprite m_rankGold;

	public Sprite m_rankSilver;

	public Sprite m_rankBronze;

	public Sprite m_rankOther;

	public Sprite m_rankScoreMine;

	public Sprite m_rankArchiveMine;

	public Sprite m_rankScoreLog;

	public List<Sprite> m_normalFruits;

	public List<Sprite> m_winterFruits;
}
