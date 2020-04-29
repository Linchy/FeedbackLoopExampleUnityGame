using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class ReflectionProbe : FL_UnityEngine.Behaviour {
		//public ReflectionProbe() { }
		public static event System.Action<FL_UnityEngine.Cubemap> defaultReflectionSet;
		public static event System.Action<FL_UnityEngine.ReflectionProbe, UnityEngine.ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged;
		public static bool BlendCubemap(FL_UnityEngine.Texture src, FL_UnityEngine.Texture dst, float blend, FL_UnityEngine.RenderTexture target) => throw new NotImplementedException();
		public bool IsFinishedRendering(int renderId) => throw new NotImplementedException();
		public int RenderProbe() => throw new NotImplementedException();
		public int RenderProbe(FL_UnityEngine.RenderTexture targetTexture) => throw new NotImplementedException();
		public void Reset() => throw new NotImplementedException();
		public UnityEngine.Color backgroundColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.Texture bakedTexture { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float blendDistance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Bounds bounds => throw new NotImplementedException();
		public bool boxProjection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector3 center { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Rendering.ReflectionProbeClearFlags clearFlags { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int cullingMask { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.Texture customBakedTexture { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static FL_UnityEngine.Texture defaultTexture => throw new NotImplementedException();
		public static UnityEngine.Vector4 defaultTextureHDRDecodeValues => throw new NotImplementedException();
		public float farClipPlane { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool hdr { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int importance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float intensity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static int maxBakedCubemapResolution => throw new NotImplementedException();
		public static int minBakedCubemapResolution => throw new NotImplementedException();
		public UnityEngine.Rendering.ReflectionProbeMode mode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float nearClipPlane { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.RenderTexture realtimeTexture { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Rendering.ReflectionProbeRefreshMode refreshMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int resolution { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float shadowDistance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector3 size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.Texture texture => throw new NotImplementedException();
		public UnityEngine.Vector4 textureHDRDecodeValues => throw new NotImplementedException();
		public UnityEngine.Rendering.ReflectionProbeTimeSlicingMode timeSlicingMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
