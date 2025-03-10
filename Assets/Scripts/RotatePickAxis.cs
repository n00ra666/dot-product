using System;
using UnityEngine;

public class RotatePickAxis : MonoBehaviour
{

	public enum EAxis 
	{
		_UP,
		_FORWARD,
		_RIGHT,
	};
	
		
	public EAxis m_iAxis = EAxis._UP;
	public float m_fRotSpeed = 1.0f;

	void Update()
	{
		switch (m_iAxis)
		{
			case EAxis._UP:
				Vector3 vRot = transform.eulerAngles;
				vRot.y += m_fRotSpeed * Time.deltaTime;
				transform.eulerAngles = vRot;
				break;
			
			
			case EAxis._FORWARD:
				transform.Rotate(Vector3.forward, m_fRotSpeed * Time.deltaTime);
				break;
			
			
			case EAxis._RIGHT:
				transform.Rotate(Vector3.right, m_fRotSpeed * Time.deltaTime);
				break;
		}
	}
}
