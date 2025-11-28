using System.Collections.Generic;
using UnityEngine;
//toggles textures
public class DebugMaster : MonoBehaviour
{
    Renderer rend;

    private Material mat;
    
    string BaseShader;

    private bool isShaded = true;

    private KeyValuePair<string, string> baseShaderVals;
    
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

    // toggles between untextured and textured
    void ToggleTextures()
    {
        if (isShaded)
        {
            rend.material.shader = Shader.Find("Universal Render Pipeline/Lit");
        }
        else
        {
            rend.material.shader = Shader.Find(BaseShader); // doesn't work properly; it sets the shader correctly,
                                                            // and sometimes carries some things over, but doesn't fully
                                                            // work
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
            string type = rend.material.shader.GetPropertyType(i).ToString();

            //var propertyValue;
            
        }
    }
}
