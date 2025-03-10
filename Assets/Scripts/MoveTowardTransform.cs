using UnityEngine;

public class MoveTowardTransform : MonoBehaviour
{

	public Transform m_tMoveToTransform;
	public float m_fMoveSpeed = 2.0f;
	public float m_fTurnSpeed = 1.0f;


	void Update()
	{
		Vector3 vTraj = m_tMoveToTransform.position - transform.position;
		vTraj.Normalize();
		
		Vector3 vRot = Vector3.Slerp(transform.forward, vTraj, m_fMoveSpeed * Time.deltaTime);
		transform.position += vRot * (m_fMoveSpeed * Time.deltaTime);
		transform.forward = vRot;

		// Vector3 vTraj = m_tMoveToTransform.position - transform.position;
		// Quaternion qTargetRotation = Quaternion.LookRotation(vTraj, Vector3.up);
		// Quaternion qLimitedRotation = Quaternion.Lerp(transform.rotation, qTargetRotation, m_fTurnSpeed * Time.deltaTime);
		// transform.rotation = qLimitedRotation;
		// transform.position += transform.forward * m_fMoveSpeed * Time.deltaTime;

			
			// Vector3 vTraj = m_tMoveToTransform.position - transform.position;
			// vTraj.Normalize();
			//
			// transform.position += vTraj * m_fMoveSpeed * Time.deltaTime;
			// transform.forward = vTraj;
	}
}