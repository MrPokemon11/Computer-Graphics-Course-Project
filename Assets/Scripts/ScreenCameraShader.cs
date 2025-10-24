using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenCameraShader : MonoBehaviour
{
    //public Shader shader = null;
    public Material LUT_Material;

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (LUT_Material != null)
        {
            Graphics.Blit(source, destination, LUT_Material);
        }
        else
        {
            Graphics.Blit(source, destination);
        }
    }
}
