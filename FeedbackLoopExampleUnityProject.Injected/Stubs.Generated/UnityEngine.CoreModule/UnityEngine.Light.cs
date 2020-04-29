using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Light : FL_UnityEngine.Behaviour {
		//public Light() { }
		public void AddCommandBuffer(UnityEngine.Rendering.LightEvent evt, FL_UnityEngine.Rendering.CommandBuffer buffer) => throw new NotImplementedException();
		public void AddCommandBuffer(UnityEngine.Rendering.LightEvent evt, FL_UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask) => throw new NotImplementedException();
		public void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent evt, FL_UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType) => throw new NotImplementedException();
		public void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent evt, FL_UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask, UnityEngine.Rendering.ComputeQueueType queueType) => throw new NotImplementedException();
		public FL_UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(UnityEngine.Rendering.LightEvent evt) => throw new NotImplementedException();
		public static FL_UnityEngine.Light[] GetLights(UnityEngine.LightType type, int layer) => throw new NotImplementedException();
		public void RemoveAllCommandBuffers() => throw new NotImplementedException();
		public void RemoveCommandBuffer(UnityEngine.Rendering.LightEvent evt, FL_UnityEngine.Rendering.CommandBuffer buffer) => throw new NotImplementedException();
		public void RemoveCommandBuffers(UnityEngine.Rendering.LightEvent evt) => throw new NotImplementedException();
		public void Reset() => throw new NotImplementedException();
		public void SetLightDirty() => throw new NotImplementedException();
		public UnityEngine.Vector2 areaSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.LightBakingOutput bakingOutput { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float bounceIntensity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Color color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float colorTemperature { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int commandBufferCount => throw new NotImplementedException();
		public FL_UnityEngine.Texture cookie { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float cookieSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int cullingMask { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.Flare flare { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float intensity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float[] layerShadowCullDistances { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.LightmapBakeType lightmapBakeType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.LightShadowCasterMode lightShadowCasterMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float range { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.LightRenderMode renderMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float shadowAngle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float shadowBias { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int shadowCustomResolution { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float shadowNearPlane { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float shadowNormalBias { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float shadowRadius { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Rendering.LightShadowResolution shadowResolution { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.LightShadows shadows { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float shadowStrength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float spotAngle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.LightType type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
