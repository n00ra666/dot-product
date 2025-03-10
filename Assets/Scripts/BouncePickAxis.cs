using System;
using UnityEngine;

public class BouncePickAxis : MonoBehaviour
{
    
    
    public enum EAxis 
    {
        _UP,
        _FORWARD,
        _RIGHT,
    };
	
		
    public EAxis m_iAxis = EAxis._UP;
    public Vector3 m_vOrigin;
    public float m_fBounceSpeed;
    public float m_fBounceHeight;
    public float m_fAngle;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_vOrigin = transform.position;
    }

    
    // Update is called once per frame
    void Update()
    {
        m_fAngle += m_fBounceSpeed * Time.deltaTime;
        float fSine = Mathf.Sin(m_fAngle) * m_fBounceHeight;

        switch (m_iAxis)
        {
            case EAxis._UP:
                transform.position = m_vOrigin + new Vector3(0.0f, fSine, 0.0f);
                break;
            case EAxis._FORWARD:
                transform.position = m_vOrigin + new Vector3(0.0f, 0.0f, fSine);
                break;
            case EAxis._RIGHT:
                transform.position = m_vOrigin + new Vector3(fSine, 0.0f, 0.0f);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
