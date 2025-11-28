using System.Collections.Generic;
using UnityEngine;

public class DebugMaster : MonoBehaviour
{
    Renderer rend;

    private Material mat;
    
    string BaseShader;

    private bool isShaded = true;

    private KeyValuePair<string, var> baseShaderVals;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponent<Renderer>();
        BaseShader = rend.material.shader.name;
        print(BaseShader);
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
        if (isShaded)
        {
            rend.material.shader = Shader.Find("Universal Render Pipeline/Lit");
        }
        else
        {
            rend.material.shader = Shader.Find(BaseShader);
        }
        isShaded = !isShaded;
    }

    void StoreShaderValues()
    {
        /* I need to:
         * - get the values from the shader
         * - store them
         * - restore them when the shader returns
         */

        for (int i = 0; i < rend.material.shader.GetPropertyCount(); i++)
        {
            string propertyName = rend.material.shader.GetPropertyName(i);
            
        }
    }
}
