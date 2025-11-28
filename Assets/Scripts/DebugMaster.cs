using UnityEngine;

public class DebugMaster : MonoBehaviour
{
    Renderer rend;
    Material m_Material;
    Material m_NoTextureMaterial;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponent<Renderer>();
        m_Material = rend.material;
        m_NoTextureMaterial = Resources.Load<Material>("NoTexture");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ToggleTextures()
    {
        
    }

    void CycleLUT()
    {
        
    }
}
