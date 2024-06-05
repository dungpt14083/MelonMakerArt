using UnityEngine;

public class TimeLimitedObject : MonoBehaviour
{
	public Period start;

	public Period end;

	private bool isStart;

	private void Start()
	{
	}

	public void OnApplicationFocus(bool focus)
	{
	}
}
