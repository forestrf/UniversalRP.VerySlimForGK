using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine.Scripting.APIUpdating;

using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Experimental.Rendering;
using Lightmapping = UnityEngine.Experimental.GlobalIllumination.Lightmapping;

namespace UnityEngine.Rendering.Universal
{
    internal static class ShaderPropertyId
    {
        public static readonly int glossyEnvironmentColor = Shader.PropertyToID("_GlossyEnvironmentColor");
        public static readonly int subtractiveShadowColor = Shader.PropertyToID("_SubtractiveShadowColor");

        public static readonly int ambientSkyColor = Shader.PropertyToID("unity_AmbientSky");
        public static readonly int ambientEquatorColor = Shader.PropertyToID("unity_AmbientEquator");
        public static readonly int ambientGroundColor = Shader.PropertyToID("unity_AmbientGround");

        public static readonly int time = Shader.PropertyToID("_Time");
        public static readonly int sinTime = Shader.PropertyToID("_SinTime");
        public static readonly int cosTime = Shader.PropertyToID("_CosTime");
        public static readonly int deltaTime = Shader.PropertyToID("unity_DeltaTime");
        public static readonly int timeParameters = Shader.PropertyToID("_TimeParameters");

        public static readonly int scaledScreenParams = Shader.PropertyToID("_ScaledScreenParams");
        public static readonly int worldSpaceCameraPos = Shader.PropertyToID("_WorldSpaceCameraPos");
        public static readonly int screenParams = Shader.PropertyToID("_ScreenParams");
        public static readonly int projectionParams = Shader.PropertyToID("_ProjectionParams");
        public static readonly int zBufferParams = Shader.PropertyToID("_ZBufferParams");
        public static readonly int orthoParams = Shader.PropertyToID("unity_OrthoParams");

        public static readonly int viewMatrix = Shader.PropertyToID("unity_MatrixV");
        public static readonly int projectionMatrix = Shader.PropertyToID("glstate_matrix_projection");
        public static readonly int viewAndProjectionMatrix = Shader.PropertyToID("unity_MatrixVP");

        public static readonly int inverseViewMatrix = Shader.PropertyToID("unity_MatrixInvV");
        public static readonly int inverseProjectionMatrix = Shader.PropertyToID("unity_MatrixInvP");
        public static readonly int inverseViewAndProjectionMatrix = Shader.PropertyToID("unity_MatrixInvVP");

        public static readonly int cameraProjectionMatrix = Shader.PropertyToID("unity_CameraProjection");
        public static readonly int inverseCameraProjectionMatrix = Shader.PropertyToID("unity_CameraInvProjection");
        public static readonly int worldToCameraMatrix = Shader.PropertyToID("unity_WorldToCamera");
        public static readonly int cameraToWorldMatrix = Shader.PropertyToID("unity_CameraToWorld");

        public static readonly int sourceTex = Shader.PropertyToID("_SourceTex");
        public static readonly int scaleBias = Shader.PropertyToID("_ScaleBias");
        public static readonly int scaleBiasRt = Shader.PropertyToID("_ScaleBiasRt");

        // Required for 2D Unlit Shadergraph master node as it doesn't currently support hidden properties.
        public static readonly int rendererColor = Shader.PropertyToID("_RendererColor");
    }

    public static class ShaderKeywordStrings
    {
        public static readonly string MainLightShadows = "_MAIN_LIGHT_SHADOWS";
        public static readonly string MainLightShadowCascades = "_MAIN_LIGHT_SHADOWS_CASCADE";
        public static readonly string AdditionalLightsVertex = "_ADDITIONAL_LIGHTS_VERTEX";
        public static readonly string AdditionalLightsPixel = "_ADDITIONAL_LIGHTS";
        public static readonly string AdditionalLightShadows = "_ADDITIONAL_LIGHT_SHADOWS";
        public static readonly string SoftShadows = "_SHADOWS_SOFT";
        public static readonly string MixedLightingSubtractive = "_MIXED_LIGHTING_SUBTRACTIVE"; // Backward compatibility
        public static readonly string LightmapShadowMixing = "LIGHTMAP_SHADOW_MIXING";
        public static readonly string ShadowsShadowMask = "SHADOWS_SHADOWMASK";

        public static readonly string DepthNoMsaa = "_DEPTH_NO_MSAA";
        public static readonly string DepthMsaa2 = "_DEPTH_MSAA_2";
        public static readonly string DepthMsaa4 = "_DEPTH_MSAA_4";
        public static readonly string DepthMsaa8 = "_DEPTH_MSAA_8";

        public static readonly string LinearToSRGBConversion = "_LINEAR_TO_SRGB_CONVERSION";

        public static readonly string SmaaLow = "_SMAA_PRESET_LOW";
        public static readonly string SmaaMedium = "_SMAA_PRESET_MEDIUM";
        public static readonly string SmaaHigh = "_SMAA_PRESET_HIGH";
        public static readonly string PaniniGeneric = "_GENERIC";
        public static readonly string PaniniUnitDistance = "_UNIT_DISTANCE";
        public static readonly string BloomLQ = "_BLOOM_LQ";
        public static readonly string BloomHQ = "_BLOOM_HQ";
        public static readonly string BloomLQDirt = "_BLOOM_LQ_DIRT";
        public static readonly string BloomHQDirt = "_BLOOM_HQ_DIRT";
        public static readonly string UseRGBM = "_USE_RGBM";
        public static readonly string Distortion = "_DISTORTION";
        public static readonly string ChromaticAberration = "_CHROMATIC_ABERRATION";
        public static readonly string HDRGrading = "_HDR_GRADING";
        public static readonly string TonemapACES = "_TONEMAP_ACES";
        public static readonly string TonemapNeutral = "_TONEMAP_NEUTRAL";
        public static readonly string FilmGrain = "_FILM_GRAIN";
        public static readonly string Fxaa = "_FXAA";
        public static readonly string Dithering = "_DITHERING";
        public static readonly string ScreenSpaceOcclusion = "_SCREEN_SPACE_OCCLUSION";

        public static readonly string HighQualitySampling = "_HIGH_QUALITY_SAMPLING";

        public static readonly string DOWNSAMPLING_SIZE_2 = "DOWNSAMPLING_SIZE_2";
        public static readonly string DOWNSAMPLING_SIZE_4 = "DOWNSAMPLING_SIZE_4";
        public static readonly string DOWNSAMPLING_SIZE_8 = "DOWNSAMPLING_SIZE_8";
        public static readonly string DOWNSAMPLING_SIZE_16 = "DOWNSAMPLING_SIZE_16";
        public static readonly string _SPOT = "_SPOT";
        public static readonly string _DIRECTIONAL = "_DIRECTIONAL";
        public static readonly string _POINT = "_POINT";
        public static readonly string _DEFERRED_ADDITIONAL_LIGHT_SHADOWS = "_DEFERRED_ADDITIONAL_LIGHT_SHADOWS";
        public static readonly string _GBUFFER_NORMALS_OCT = "_GBUFFER_NORMALS_OCT";
        public static readonly string _DEFERRED_SUBTRACTIVE_LIGHTING = "_DEFERRED_SUBTRACTIVE_LIGHTING";
        public static readonly string LIGHTMAP_ON = "LIGHTMAP_ON";
        public static readonly string _ALPHATEST_ON = "_ALPHATEST_ON";
        public static readonly string DIRLIGHTMAP_COMBINED = "DIRLIGHTMAP_COMBINED";
        public static readonly string _DETAIL_MULX2 = "_DETAIL_MULX2";
        public static readonly string _DETAIL_SCALED = "_DETAIL_SCALED";
        public static readonly string _CLEARCOAT = "_CLEARCOAT";
        public static readonly string _CLEARCOATMAP = "_CLEARCOATMAP";

        // XR
        public static readonly string UseDrawProcedural = "_USE_DRAW_PROCEDURAL";
    }
}
