using UnityEngine;

public class DGSafeAreaUI : MonoBehaviour
{
	public bool top;

	public bool bottom;

	public Rect m_screen;

	public bool m_setScreen;

	public static Rect GetSafeArea()
	{
		return default(Rect);
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetSafeArea()
	{
	}
}
