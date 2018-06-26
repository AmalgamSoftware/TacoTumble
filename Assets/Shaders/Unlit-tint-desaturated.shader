

Shader "Mobile/Unlit-Tint-Desaturated"
{
	Properties
	{
		_MainTex ("Diffuse Texture", 2D) = "white" {}
		_Color ("Tint",Color) = (1,1,1,1)
		_ReductionFactor("Reduction",Range(0,1)) = 1
		_ReductionFactorR("ReductionR",Range(0,1)) = 1
		_ReductionFactorG("ReductionB",Range(0,1)) = 1
		_ReductionFactorB("ReductionG",Range(0,1)) = 1
	}
	SubShader
	{
		Tags { "RenderType"="Opaque" }
		LOD 100

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;
			float _ReductionFactor;
			float _ReductionFactorR;
			float _ReductionFactorG;
			float _ReductionFactorB;
			
			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				return o;
			}
			fixed4 _Color;
			fixed4 frag (v2f i) : SV_Target
			{
				// sample the texture
				fixed4 col = tex2D(_MainTex, i.uv);
				float avg = (col.r + col.g + col.b) * 0.333;
				//float re = 1 - _ReductionFactor;
				//col.rgb = col.rgb * _ReductionFactor + re * avg;
				col.r = col.r * _ReductionFactorR;
				col.g = col.g * _ReductionFactorG;
				col.b = col.b * _ReductionFactorB;
				col.a = 1;
				return col * _Color;
			}
			ENDCG
		}
	}
}
