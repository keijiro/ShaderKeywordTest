Shader "Color By Keyword"
{
    SubShader
    {
        Pass
        {
            CGPROGRAM

            #pragma multi_compile _ RED BLUE

            #pragma vertex Vertex
            #pragma fragment Fragment
            
            #include "UnityCG.cginc"

            float4 Vertex(float4 position : POSITION) : SV_Position
            {
                return UnityObjectToClipPos(position);
            }

            half4 Fragment(float4 sv_position : SV_Position) : SV_Target
            {
            #if RED
                return half4(1, 0, 0, 1);
            #elif BLUE
                return half4(0, 0, 1, 1);
            #else
                return half4(1, 1, 1, 1);
            #endif
            }

            ENDCG
        }
    }
}
