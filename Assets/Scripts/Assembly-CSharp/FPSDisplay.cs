using UnityEngine;

public class FPSDisplay : MonoBehaviour
{
	private float deltaTime;

	public float refreshTime;

	private float refreshRemain;

	private float deltaTimeGUI;

	private float averageTime;

	private float averageRemain;

	private float averageFps;

	private float warningFps;

	private Color textColor;

	public Vector2 v2Pos;

	private void Update()
	{
	}

	private void OnGUI()
	{
	}

	public float GetFPS()
	{
		return 0f;
	}
}
