using UnityEngine;

public class ColourCycleMaterial : MonoBehaviour
{
    private float m_fAngleR, m_fAngleG, m_fAngleB;

    // Update is called once per frame
    void Update()
    {
        m_fAngleR += 0.25f * Time.deltaTime;
        m_fAngleG += 1.25f * Time.deltaTime;
        m_fAngleB += 0.45f * Time.deltaTime;
        
        GetComponent<MeshRenderer>().material.color = 
            new Color(
                Mathf.Sin(m_fAngleR), 
                Mathf.Sin(m_fAngleG), 
                Mathf.Sin(m_fAngleB));
    }
}
