Shader "Unlit/Meia"
{
	Properties{
		_MainTex("Texture", 2D) = "white" {}
		//_Amount("Extrusion Amount", Range(-1, 1)) = 0.5
		_Value1("Value 1", Float) = 0
		_Value2("Value 2", Float) = 0
		_Value3("Value 3", Float) = 0
	}
		SubShader
		{
			//Tags { "RenderType"="Opaque" }
			//LOD 100
			Pass
			{
				CGPROGRAM
				#pragma vertex vert // declaring functions				
				#pragma fragment frag			
				#include "UnityCG.cginc"

				struct v2f
				{
					float4 vertex : SV_POSITION; // SV_POSITION expands to just POSITION on all other platforms, and SV_Position on DX11.
					float3 normal : NORMAL;
					float4 texcoord : TEXCOORD0;
					fixed3 color : COLOR0;
				};

				v2f vert(appdata_base v) // vertex to fragment
				{
					v2f o;
					o.vertex = UnityObjectToClipPos(v.vertex); // = mul(UNITY_MATRIX_MVP, v.vertex);
					o.color = v.normal * 0.5 + 0.5;
					return o;
				}

				fixed4 frag(v2f i) : SV_Target
				{
					return fixed4(i.color, 1);
				}
				ENDCG
			}
		}
}
