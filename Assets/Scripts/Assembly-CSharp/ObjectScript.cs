using UnityEngine;
using UnityEngine.UI;

public class ObjectScript : MonoBehaviour
{
	public Image m_image;

	public Rigidbody2D m_rigidbody;

	public RectTransform m_transform;

	public int m_level;

	public bool forceActivate;

	[HideInInspector]
	public bool isActive;

	[HideInInspector]
	public bool isPlaced;

	private bool isLose;

	private void Awake()
	{
	}

	public void DropObject()
	{
	}

	public void ActivateObject(float delay = 0.04f)
	{
	}

	public void DeactivateObject()
	{
	}

	public void SetPlaceObject()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnDestroy()
	{
	}

	private void CheckNextState(Collision2D collision)
	{
	}

	private void CheckAngular(Collision2D collision)
	{
	}

	private void CheckMerge(Collision2D collision)
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void OnCollisionStay2D(Collision2D collision)
	{
	}
}
