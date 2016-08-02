// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:Unlit/Texture,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:False,igpj:True,qofs:0,qpre:4,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5441177,fgcg:0.4627208,fgcb:0.4440961,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3133,x:33712,y:32976,varname:node_3133,prsc:2|alpha-5903-OUT,refract-5406-OUT;n:type:ShaderForge.SFN_Tex2d,id:751,x:32045,y:32715,varname:node_751,prsc:2,tex:40a59d660a527ee4cbad46b701a4d2cd,ntxv:3,isnm:True|UVIN-6155-UVOUT,TEX-6875-TEX;n:type:ShaderForge.SFN_ValueProperty,id:2353,x:32374,y:33080,ptovrint:False,ptlb:Intensity,ptin:_Intensity,varname:node_2353,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_ValueProperty,id:4043,x:31265,y:33400,ptovrint:False,ptlb:Speed,ptin:_Speed,varname:node_4043,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.7;n:type:ShaderForge.SFN_Time,id:6750,x:31265,y:33453,varname:node_6750,prsc:2;n:type:ShaderForge.SFN_Tex2dAsset,id:6875,x:31583,y:32673,ptovrint:False,ptlb:Distortion,ptin:_Distortion,varname:node_6875,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:40a59d660a527ee4cbad46b701a4d2cd,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Tex2d,id:6741,x:32112,y:32881,varname:node_6741,prsc:2,tex:40a59d660a527ee4cbad46b701a4d2cd,ntxv:0,isnm:False|UVIN-6391-UVOUT,TEX-6875-TEX;n:type:ShaderForge.SFN_TexCoord,id:5080,x:31263,y:32867,varname:node_5080,prsc:2,uv:0;n:type:ShaderForge.SFN_Multiply,id:61,x:31845,y:33298,varname:node_61,prsc:2|A-4043-OUT,B-6750-TSL;n:type:ShaderForge.SFN_Add,id:4467,x:31612,y:33047,varname:node_4467,prsc:2|A-44-OUT,B-2345-OUT;n:type:ShaderForge.SFN_Vector2,id:2345,x:31612,y:33183,varname:node_2345,prsc:2,v1:0.5,v2:0.5;n:type:ShaderForge.SFN_Panner,id:6391,x:31845,y:33080,varname:node_6391,prsc:2,spu:-1,spv:1|UVIN-4467-OUT,DIST-61-OUT;n:type:ShaderForge.SFN_Panner,id:6155,x:31850,y:32922,varname:node_6155,prsc:2,spu:1,spv:-1|UVIN-44-OUT,DIST-61-OUT;n:type:ShaderForge.SFN_Add,id:1254,x:32291,y:32680,varname:node_1254,prsc:2|A-751-R,B-6741-R;n:type:ShaderForge.SFN_Add,id:507,x:32291,y:32813,varname:node_507,prsc:2|A-751-G,B-6741-G;n:type:ShaderForge.SFN_Append,id:2851,x:32482,y:32711,varname:node_2851,prsc:2|A-1254-OUT,B-507-OUT,C-4945-OUT;n:type:ShaderForge.SFN_Multiply,id:44,x:31340,y:33078,varname:node_44,prsc:2|A-5080-UVOUT,B-1136-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1136,x:31152,y:33204,ptovrint:False,ptlb:Scale,ptin:_Scale,varname:node_1136,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:13;n:type:ShaderForge.SFN_Lerp,id:3971,x:32880,y:32730,varname:node_3971,prsc:2|A-2894-OUT,B-2851-OUT,T-2353-OUT;n:type:ShaderForge.SFN_Vector1,id:4945,x:32390,y:32944,varname:node_4945,prsc:2,v1:1;n:type:ShaderForge.SFN_Vector3,id:2894,x:32887,y:32586,varname:node_2894,prsc:2,v1:0,v2:0,v3:1;n:type:ShaderForge.SFN_ComponentMask,id:5406,x:32880,y:32899,varname:node_5406,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-3971-OUT;n:type:ShaderForge.SFN_Vector1,id:5903,x:32880,y:33087,varname:node_5903,prsc:2,v1:0;proporder:6875-1136-2353-4043;pass:END;sub:END;*/

Shader "DCG/Water Shader/Underwater Distortion" {
    Properties {
        _Distortion ("Distortion", 2D) = "bump" {}
        _Scale ("Scale", Float ) = 13
        _Intensity ("Intensity", Float ) = 0.1
        _Speed ("Speed", Float ) = 0.7
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Overlay"
            "RenderType"="Transparent"
        }
        GrabPass{ }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform float4 _TimeEditor;
            uniform float _Intensity;
            uniform float _Speed;
            uniform sampler2D _Distortion; uniform float4 _Distortion_ST;
            uniform float _Scale;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 screenPos : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                o.screenPos = o.pos;
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                #if UNITY_UV_STARTS_AT_TOP
                    float grabSign = -_ProjectionParams.x;
                #else
                    float grabSign = _ProjectionParams.x;
                #endif
                i.screenPos = float4( i.screenPos.xy / i.screenPos.w, 0, 0 );
                i.screenPos.y *= _ProjectionParams.x;
                float4 node_6750 = _Time + _TimeEditor;
                float node_61 = (_Speed*node_6750.r);
                float2 node_44 = (i.uv0*_Scale);
                float2 node_6155 = (node_44+node_61*float2(1,-1));
                float3 node_751 = UnpackNormal(tex2D(_Distortion,TRANSFORM_TEX(node_6155, _Distortion)));
                float2 node_6391 = ((node_44+float2(0.5,0.5))+node_61*float2(-1,1));
                float3 node_6741 = UnpackNormal(tex2D(_Distortion,TRANSFORM_TEX(node_6391, _Distortion)));
                float3 node_2851 = float3((node_751.r+node_6741.r),(node_751.g+node_6741.g),1.0);
                float2 sceneUVs = float2(1,grabSign)*i.screenPos.xy*0.5+0.5 + lerp(float3(0,0,1),node_2851,_Intensity).rg;
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
////// Lighting:
                float3 finalColor = 0;
                return fixed4(lerp(sceneColor.rgb, finalColor,0.0),1);
            }
            ENDCG
        }
    }
    FallBack "Unlit/Texture"
    CustomEditor "ShaderForgeMaterialInspector"
}
