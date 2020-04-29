using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Camera : FL_UnityEngine.Behaviour {
		//public Camera() { }
		public static UnityEngine.Camera.CameraCallback onPostRender;
		public static UnityEngine.Camera.CameraCallback onPreCull;
		public static UnityEngine.Camera.CameraCallback onPreRender;
		public void AddCommandBuffer(UnityEngine.Rendering.CameraEvent evt, FL_UnityEngine.Rendering.CommandBuffer buffer) => throw new NotImplementedException();
		public void AddCommandBufferAsync(UnityEngine.Rendering.CameraEvent evt, FL_UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType) => throw new NotImplementedException();
		public void CalculateFrustumCorners(UnityEngine.Rect viewport, float z, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3[] outCorners) => throw new NotImplementedException();
		public UnityEngine.Matrix4x4 CalculateObliqueMatrix(UnityEngine.Vector4 clipPlane) => throw new NotImplementedException();
		public static void CalculateProjectionMatrixFromPhysicalProperties(ref UnityEngine.Matrix4x4 output, float focalLength, UnityEngine.Vector2 sensorSize, UnityEngine.Vector2 lensShift, float nearClip, float farClip, UnityEngine.Camera.GateFitParameters gateFitParameters) => throw new NotImplementedException();
		public void CopyFrom(FL_UnityEngine.Camera other) => throw new NotImplementedException();
		public void CopyStereoDeviceProjectionMatrixToNonJittered(UnityEngine.Camera.StereoscopicEye eye) => throw new NotImplementedException();
		public static float FocalLengthToFOV(float focalLength, float sensorSize) => throw new NotImplementedException();
		public static float FOVToFocalLength(float fov, float sensorSize) => throw new NotImplementedException();
		public static int GetAllCameras(FL_UnityEngine.Camera[] cameras) => throw new NotImplementedException();
		public FL_UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(UnityEngine.Rendering.CameraEvent evt) => throw new NotImplementedException();
		public UnityEngine.Matrix4x4 GetStereoNonJitteredProjectionMatrix(UnityEngine.Camera.StereoscopicEye eye) => throw new NotImplementedException();
		public UnityEngine.Matrix4x4 GetStereoProjectionMatrix(UnityEngine.Camera.StereoscopicEye eye) => throw new NotImplementedException();
		public UnityEngine.Matrix4x4 GetStereoViewMatrix(UnityEngine.Camera.StereoscopicEye eye) => throw new NotImplementedException();
		public void RemoveAllCommandBuffers() => throw new NotImplementedException();
		public void RemoveCommandBuffer(UnityEngine.Rendering.CameraEvent evt, FL_UnityEngine.Rendering.CommandBuffer buffer) => throw new NotImplementedException();
		public void RemoveCommandBuffers(UnityEngine.Rendering.CameraEvent evt) => throw new NotImplementedException();
		public void Render() => throw new NotImplementedException();
		public void RenderDontRestore() => throw new NotImplementedException();
		public bool RenderToCubemap(FL_UnityEngine.Cubemap cubemap, int faceMask) => throw new NotImplementedException();
		public bool RenderToCubemap(FL_UnityEngine.Cubemap cubemap) => throw new NotImplementedException();
		public bool RenderToCubemap(FL_UnityEngine.RenderTexture cubemap, int faceMask) => throw new NotImplementedException();
		public bool RenderToCubemap(FL_UnityEngine.RenderTexture cubemap) => throw new NotImplementedException();
		public bool RenderToCubemap(FL_UnityEngine.RenderTexture cubemap, int faceMask, UnityEngine.Camera.MonoOrStereoscopicEye stereoEye) => throw new NotImplementedException();
		public void RenderWithShader(FL_UnityEngine.Shader shader, string replacementTag) => throw new NotImplementedException();
		public void Reset() => throw new NotImplementedException();
		public void ResetAspect() => throw new NotImplementedException();
		public void ResetCullingMatrix() => throw new NotImplementedException();
		public void ResetProjectionMatrix() => throw new NotImplementedException();
		public void ResetReplacementShader() => throw new NotImplementedException();
		public void ResetStereoProjectionMatrices() => throw new NotImplementedException();
		public void ResetStereoViewMatrices() => throw new NotImplementedException();
		public void ResetTransparencySortSettings() => throw new NotImplementedException();
		public void ResetWorldToCameraMatrix() => throw new NotImplementedException();
		public UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye) => throw new NotImplementedException();
		public UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3 pos) => throw new NotImplementedException();
		public UnityEngine.Vector3 ScreenToViewportPoint(UnityEngine.Vector3 position) => throw new NotImplementedException();
		public UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye) => throw new NotImplementedException();
		public UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3 position) => throw new NotImplementedException();
		public void SetReplacementShader(FL_UnityEngine.Shader shader, string replacementTag) => throw new NotImplementedException();
		public void SetStereoProjectionMatrix(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4 matrix) => throw new NotImplementedException();
		public void SetStereoViewMatrix(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4 matrix) => throw new NotImplementedException();
		public void SetTargetBuffers(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer) => throw new NotImplementedException();
		public void SetTargetBuffers(UnityEngine.RenderBuffer[] colorBuffer, UnityEngine.RenderBuffer depthBuffer) => throw new NotImplementedException();
		public static void SetupCurrent(FL_UnityEngine.Camera cur) => throw new NotImplementedException();
		public UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector3 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye) => throw new NotImplementedException();
		public UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector3 pos) => throw new NotImplementedException();
		public UnityEngine.Vector3 ViewportToScreenPoint(UnityEngine.Vector3 position) => throw new NotImplementedException();
		public UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye) => throw new NotImplementedException();
		public UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3 position) => throw new NotImplementedException();
		public UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye) => throw new NotImplementedException();
		public UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3 position) => throw new NotImplementedException();
		public UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye) => throw new NotImplementedException();
		public UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3 position) => throw new NotImplementedException();
		public FL_UnityEngine.RenderTexture activeTexture => throw new NotImplementedException();
		public UnityEngine.RenderingPath actualRenderingPath => throw new NotImplementedException();
		public static FL_UnityEngine.Camera[] allCameras => throw new NotImplementedException();
		public static int allCamerasCount => throw new NotImplementedException();
		public bool allowDynamicResolution { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool allowHDR { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool allowMSAA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool areVRStereoViewMatricesWithinSingleCullTolerance => throw new NotImplementedException();
		public float aspect { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Color backgroundColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Matrix4x4 cameraToWorldMatrix => throw new NotImplementedException();
		public UnityEngine.CameraType cameraType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.CameraClearFlags clearFlags { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool clearStencilAfterLightingPass { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int commandBufferCount => throw new NotImplementedException();
		public int cullingMask { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Matrix4x4 cullingMatrix { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static FL_UnityEngine.Camera current => throw new NotImplementedException();
		public float depth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.DepthTextureMode depthTextureMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int eventMask { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float farClipPlane { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float fieldOfView { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float focalLength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool forceIntoRenderTexture { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Camera.GateFitMode gateFit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float[] layerCullDistances { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool layerCullSpherical { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector2 lensShift { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static FL_UnityEngine.Camera main => throw new NotImplementedException();
		public float nearClipPlane { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Matrix4x4 nonJitteredProjectionMatrix { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Rendering.OpaqueSortMode opaqueSortMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool orthographic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float orthographicSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int pixelHeight => throw new NotImplementedException();
		public UnityEngine.Rect pixelRect { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int pixelWidth => throw new NotImplementedException();
		public UnityEngine.Matrix4x4 previousViewProjectionMatrix => throw new NotImplementedException();
		public UnityEngine.Matrix4x4 projectionMatrix { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Rect rect { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.RenderingPath renderingPath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int scaledPixelHeight => throw new NotImplementedException();
		public int scaledPixelWidth => throw new NotImplementedException();
		public UnityEngine.SceneManagement.Scene scene { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector2 sensorSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Camera.MonoOrStereoscopicEye stereoActiveEye => throw new NotImplementedException();
		public float stereoConvergence { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool stereoEnabled => throw new NotImplementedException();
		public float stereoSeparation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.StereoTargetEyeMask stereoTargetEye { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int targetDisplay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.RenderTexture targetTexture { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector3 transparencySortAxis { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.TransparencySortMode transparencySortMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool useJitteredProjectionMatrixForTransparentRendering { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool useOcclusionCulling { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool usePhysicalProperties { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector3 velocity => throw new NotImplementedException();
		public UnityEngine.Matrix4x4 worldToCameraMatrix { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
