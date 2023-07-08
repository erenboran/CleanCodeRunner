// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Seventy Sevian/Pixelated"
{
	Properties 
	{
		_MainTex ("Base (RGB) Trans (A)", 2D) = "white" {}
		_Color ("Color", Color) = (1, 1, 1, 1)
		_PixelCountU ("Pixel Count U", float) = 100
		_PixelCountV ("Pixel Count V", float) = 100
	    _NoiseTex ("Noise Texture", 2D) = "white" {}
	    _DistortionAmount ("Distortion Amount", Range(0, 1)) = 0.1

	}

	SubShader 
	{
		Tags {"Queue"="Transparent" "RenderType"="Transparent"}
		LOD 100
		
		Lighting Off
		Blend SrcAlpha OneMinusSrcAlpha 
		
        	Pass 
        	{            
			CGPROGRAM 
			#pragma vertex vert
			#pragma fragment frag
							
			#include "UnityCG.cginc"
			        sampler2D _NoiseTex;

			sampler2D _MainTex;	
			float4 _Color;
			float _PixelCountU;
			float _PixelCountV;
            float _DistortionAmount;
					
			struct v2f 
			{
			    float4 pos : SV_POSITION;
			    float2 uv : TEXCOORD1;
			};
			
			v2f vert(appdata_base v)
			{
			    v2f o;			    
			    o.uv = v.texcoord.xy;
			    o.pos = UnityObjectToClipPos(v.vertex);
			                float4 noise = tex2Dlod(_NoiseTex, float4(v.texcoord.xy * 0.1, 0, 0));
            v.vertex.xy += noise.xy * _DistortionAmount;
			    return o;
			}
			
			half4 frag(v2f i) : COLOR
			{   
				float pixelWidth = 1.0f / _PixelCountU;
				float pixelHeight = 1.0f / _PixelCountV;
				
				half2 uv = half2((int)(i.uv.x / pixelWidth) * pixelWidth, (int)(i.uv.y / pixelHeight) * pixelHeight);			
				half4 col = tex2D(_MainTex, uv);
			
			    return col * _Color;
			}
			ENDCG
	  	}
	}
}