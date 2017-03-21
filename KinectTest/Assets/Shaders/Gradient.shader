Shader "Custom/Gradient" {
	Properties
	{
		_MainTex("Texture", 3D) = "white" {}
	}
		SubShader
	{

			Pass
		{
			CGPROGRAM
	#pragma vertex vert
	#pragma fragment frag

	#include "UnityCG.cginc"

			struct appdata // defines what data we get from each vertex on the mesh
		{
			float4 vertex : POSITION;
			float3 uv : TEXCOORD0;
		};

		struct v2f // defines what information we are passing into the fragment function
		{
			float4 vertex : SV_POSITION;
			float3 uv : TEXCOORD0;
		};

		v2f vert(appdata v)
		{
			v2f o;
			o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);
			o.uv = v.uv;
			return o;
		}

		float4 frag(v2f i) : SV_Target
		{
			float4 color = float4(i.uv.x, i.uv.y, 0, 1);
			return color;
		}
			ENDCG
		}
	}
}
