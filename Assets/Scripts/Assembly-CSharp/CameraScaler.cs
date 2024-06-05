using UnityEngine;

[ExecuteAlways]
[DisallowMultipleComponent]
[RequireComponent(typeof(Camera))]
public class CameraScaler : MonoBehaviour
{
	private Camera TargetCamera;

	[Range(0.01f, 100f)]
	public float ScaleRatio;

	public Vector2 ReferenceResolution;

	[Range(0f, 1f)]
	public float MatchWidthOrHeight;

	private float PrevScaleRatio;

	private float PrevScaleFactor;

	private const float kLogBase = 2f;

	private void Update()
	{
	}
}
