using System.Collections.Generic;
using UnityEngine;

public class PrefabPool : DGSingleton<PrefabPool>
{
	public List<GameObject> m_particles;

	public List<ObjectScript> m_fruits;

	public GameObject m_hammer;

	public PointScript m_musicPoint;

	public GameObject m_musicParticle;

	public GameObject m_popupLose;

	public GameObject m_popupPause;

	public GameObject m_popupMusic;

	public GameObject m_popupReview;

	public GameObject m_popupHammer;

	public GameObject m_popupRanking;

	public GameObject m_popupArchive;
}
