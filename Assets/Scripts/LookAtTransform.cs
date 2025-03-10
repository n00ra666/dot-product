using UnityEngine;

public class LookAtTransform : MonoBehaviour
{
	public Transform m_tLookAtTarget;
	public float m_fTurnSpeed;

	void Update()
	{
		Vector3 vTraj = m_tLookAtTarget.position - transform.position;
		vTraj.Normalize();
		
		Quaternion qTargetRotation = Quaternion.LookRotation(vTraj, Vector3.up);
		Quaternion qLimitedRotation = Quaternion.Slerp(transform.rotation, qTargetRotation, m_fTurnSpeed * Time.deltaTime);
		transform.rotation = qLimitedRotation;
	}

}
