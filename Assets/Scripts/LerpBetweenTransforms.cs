using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpBetweenTransforms : MonoBehaviour
{

	public Transform m_tLerp1;
	public Transform m_tLerp2;

	public float m_fLerpDurationSeconds = 1.5f;
	private float m_fEventTime;

	void Start()
	{
		m_fEventTime = Time.time;
	}
	
	void Update()
	{
		float fRatio = (Time.time - m_fEventTime) / m_fLerpDurationSeconds;
		
		transform.position = Vector3.Lerp(m_tLerp1.position, m_tLerp2.position, fRatio);

		if (fRatio >= 1.0f)
		{
			(m_tLerp1, m_tLerp2) = (m_tLerp2, m_tLerp1);
			m_fEventTime = Time.time;
		}
	}
}
