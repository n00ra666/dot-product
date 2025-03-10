using UnityEngine;

public class DotProduct : MonoBehaviour
{

    public Transform m_tOtherObject;
    
    void Update()
    {
        Vector3 vTraj = Vector3.Normalize(m_tOtherObject.position - transform.position);
        float fDot = Vector3.Dot(transform.forward, vTraj);

        GetComponent<Renderer>().material.color = fDot >= 0.0f ? Color.green : Color.red;
    }
}
