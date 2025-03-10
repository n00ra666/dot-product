using UnityEngine;

public class CustomCurve : MonoBehaviour
{
	public AnimationCurve m_gcCurve;
	public float m_fLerpDuration;
	public Transform m_tLerpTarget1;
	public Transform m_tLerpTarget2;

	private float m_fEventTime;

	void Start()
	{
		m_fEventTime = Time.time;
	}


	void Update()
	{
		float fRatio = (Time.time - m_fEventTime) / m_fLerpDuration;
		transform.position = Vector3.Lerp(m_tLerpTarget1.position, m_tLerpTarget2.position, m_gcCurve.Evaluate(fRatio));

		if (fRatio >= 1.0f)
		{
			(m_tLerpTarget1, m_tLerpTarget2) = (m_tLerpTarget2, m_tLerpTarget1);
			m_fEventTime = Time.time;
		}
	}
}
