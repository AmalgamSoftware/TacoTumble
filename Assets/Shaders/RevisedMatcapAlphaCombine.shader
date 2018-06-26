

Shader "Unlit/matcapAlphaCombine"
{
	Properties
	{
		_Color ("Main Color", Color) = (0.5,0.5,0.5,1)
		_MainTex ("Diffuse Texture (RGB)", 2D) = "gray" {}
		_cTexture ("Cap Texture (RGB)", 2D) = "gray" {}
	}
	
	Subshader
	{
		Tags { "RenderType"="Opaque" }
		LOD 100
		Pass
		{
			//Tags { "LightMode" = "Always" }
			
			CGPROGRAM
				#pragma vertex vert
				#pragma fragment frag
				//#pragma fragmentoption ARB_precision_hint_fastest
				#include "UnityCG.cginc"

				struct appdata {
					float4 vertex : POSITION;
					float2 uv : TEXCOORD;
					float4 normal : NORMAL;
				};
				struct v2f
				{
					float4 pos	: SV_POSITION;
					float2 uv	: TEXCOORD1;
					float2 cap	: TEXCOORD0;
				};
				
				v2f vert (appdata v)
				{
					v2f o;
					o.pos = UnityObjectToClipPos (v.vertex);
					o.uv = v.uv;
					float3 worldNorm = normalize(unity_WorldToObject[0].xyz * v.normal.x + unity_WorldToObject[1].xyz * v.normal.y + unity_WorldToObject[2].xyz * v.normal.z);
					worldNorm = mul((float3x3)UNITY_MATRIX_V, worldNorm);
					o.cap.xy = worldNorm.xy * 0.5 + 0.5;
					
					return o;
				}
				
				uniform float4 _Color;
				uniform sampler2D _MainTex;
				uniform sampler2D _cTexture;
				
				float4 frag (v2f i) : COLOR
				{
					float4 mc = tex2D(_cTexture, i.cap);
					float4 nmc = tex2D(_MainTex, i.uv);
					//return  mc * nmc * 4 * _Color;
					return (mc * mc.a + nmc * (1-mc.a))  * 2 * _Color;
				}
			ENDCG
		}
	}
	
	Fallback "VertexLit"
}