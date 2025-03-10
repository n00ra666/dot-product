using UnityEngine;

public class OrbitTransform : MonoBehaviour
{
	public Transform m_tTarget;
	public float m_fDistanceFromTarget;
	public float m_fOrbitSpeed;

	private float m_fAngle;

	void Update()
	{
		Vector3 vOrbitPos = m_tTarget.position +
			new Vector3(
				Mathf.Sin(m_fAngle) * m_fDistanceFromTarget,
				Mathf.Cos(m_fAngle) * m_fDistanceFromTarget,
				0.0f);
		
		transform.position = vOrbitPos;
		m_fAngle += m_fOrbitSpeed * Time.deltaTime;
	}
}
