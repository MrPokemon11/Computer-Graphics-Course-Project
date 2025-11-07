Shader "Custom/MaterialVertexFragment"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _ScaleUVX ("Scale X", Range(1,10)) = 1
        _ScaleUVY ("Scale Y", Range(1,10)) = 1
    }
    SubShader
    {
        Tags {"RenderPipeline" = "UniversalRenderPipeline"}
        
        Pass
        {
            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            // Include URP core functions
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            struct appdata {
                float3 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
            float2 uv : TEXCOORD0; // UV coordinates passed to fragment shader
            float4 pos : SV_POSITION; // Clip space position
            };
            
            TEXTURE2D(_MainTex); // Main texture
            SAMPLER(sampler_MainTex); // Sampler for the texture
            float _ScaleUVX;
            float _ScaleUVY;

            v2f vert(appdata v)
            {
                v2f o;
                // Transform object space vertex to clip space
                o.pos = TransformObjectToHClip(v.vertex.xyz);
                // Scale UVs and apply sine transformation
                o.uv = v.uv;
                o.uv.x = sin(o.uv.x * _ScaleUVX); // Scale and apply sine on X
                o.uv.y = tan(o.uv.y * _ScaleUVY); // Scale and apply sine on Y
                return o;
            }

            // Fragment Shader
            half4 frag(v2f i) : SV_Target
            {
                // Sample the main texture with transformed UV coordinates
                half4 col = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, i.uv);
                return col;
            }            

            ENDHLSL
        }
    }
}
