using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class CrossPromotion : MonoBehaviour
{
	public CanvasGroup m_canvasGroup;

	public VideoPlayer m_videoPlayer;

	public Button m_videoButton;

	public string m_placement;

	public static bool isLoaded;

	private void Awake()
	{
	}

	public void OnEnable()
	{
	}

	public void OnApplicationFocus(bool focus)
	{
	}

	public void CallPromotion()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void PlayVideo(ApiManager.PromoData promoData)
	{
	}
}
