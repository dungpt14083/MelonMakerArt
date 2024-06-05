using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public enum GameState
	{
		WaitForStart = 0,
		WaitForMouseDown = 1,
		WaitForMouseUp = 2,
		WaitForDrop = 3,
		WaitForNext = 4,
		WaitForRevive = 5,
		Revive = 6,
		WaitForHammer = 7,
		Lose = 8
	}

	private static GameManager _instance;

	public Camera m_mainCam;

	public CameraScaler m_camScaler;

	public CanvasScaler m_gameScaler;

	public CanvasScaler m_popupScaler;

	public Transform m_parentPopup;

	public GameObject m_maskBlack;

	public Transform m_maskArea;

	public Transform m_gameArea;

	public GameObject m_skinNormal;

	public GameObject m_skinWinter;

	public RectTransform m_skinHandle;

	public RectTransform m_dropLine;

	public GameObject m_guideLine;

	public RectTransform m_topLine;

	public ObjectScript m_curObject;

	public ObjectScript m_nxtObject;

	public RectTransform m_parentNext;

	public Transform m_parentObjects;

	public Transform m_parentParticles;

	public TMP_Text m_nowScore;

	public TMP_Text m_topScoreGame;

	public RectTransform m_areaMenu;

	public CanvasGroup m_cgMenu;

	public Transform m_musicTarget;

	public GameObject m_shareMusicPoint;

	public GameState m_gameState;

	public int m_maxLv;

	public List<GameObject> m_levelObj;

	public List<GameObject> m_levelLight;

	private float SAVE_DELAY;

	private bool m_saveReady;

	private const float MOVE_LIMIT = 368f;

	private float m_hammerProtect;

	private List<List<int>> chancesList;

	private Vector2 m_menuOpenSize;

	private Vector2 m_menuCloseSize;

	public static GameManager Instance
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void ResetMaxLevel()
	{
	}

	public void SetMaxLevel()
	{
	}

	public void SaveData()
	{
	}

	public void ResetGame()
	{
	}

	public void InitGame()
	{
	}

	public void LoadGame()
	{
	}

	private void Update_WaitForMouseDown()
	{
	}

	private void Update_WaitForMouseUp()
	{
	}

	private void Update_WaitForDrop()
	{
	}

	private void Update_Revive()
	{
	}

	public void Update()
	{
	}

	public void SetNextState()
	{
	}

	public void SetLose()
	{
	}

	public void SetRevive()
	{
	}

	public void AddScore(int score)
	{
	}

	public void OnClickMenuClose()
	{
	}

	public void OnClickMenuOpen()
	{
	}

	public void OnClickRank()
	{
	}

	public void OnClickPause()
	{
	}

	public void OnClickMusic()
	{
	}

	public void OnClickArchive()
	{
	}

	public void OnClickShare()
	{
	}

	public void OnClickSkin()
	{
	}

	public void GetMusicPoint(int point = 250, Transform target = null)
	{
	}
}
