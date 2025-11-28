using UnityEngine;

public class DebugMaster : MonoBehaviour
{
    Renderer rend;
    Material m_Material;
    Material m_TempMaterial;
    Material m_NoTexMaterial;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponent<Renderer>();
        m_Material = GetComponent<Renderer>().material;
        m_TempMaterial = rend.material;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            ToggleTextures();
        }
    }

    void ToggleTextures()
    {
        if (rend.material == m_NoTexMaterial)
        {
            
            rend.material = m_Material;
        }
        else
        {
            
            rend.material = m_NoTexMaterial;
        }
    }
    
}
