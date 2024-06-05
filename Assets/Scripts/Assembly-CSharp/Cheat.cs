using UnityEngine;

public class Cheat : MonoBehaviour
{
	[Range(-10000f, 10000f)]
	public int Value;

	public bool ResetInviteMusicPoint;

	public bool ResetAdsMusicPoint;

	public bool AddMusicPoint;

	public bool AddDailyLog;

	private void Update()
	{
	}
}
