using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class LightProbes : FL_UnityEngine.Object {
		public static void CalculateInterpolatedLightAndOcclusionProbes(UnityEngine.Vector3[] positions, UnityEngine.Rendering.SphericalHarmonicsL2[] lightProbes, UnityEngine.Vector4[] occlusionProbes) => throw new NotImplementedException();
		public static void CalculateInterpolatedLightAndOcclusionProbes(System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, System.Collections.Generic.List<UnityEngine.Vector4> occlusionProbes) => throw new NotImplementedException();
		public static void GetInterpolatedProbe(UnityEngine.Vector3 position, FL_UnityEngine.Renderer renderer, out UnityEngine.Rendering.SphericalHarmonicsL2 probe) => throw new NotImplementedException();
		public UnityEngine.Rendering.SphericalHarmonicsL2[] bakedProbes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int cellCount => throw new NotImplementedException();
		public int count => throw new NotImplementedException();
		public UnityEngine.Vector3[] positions => throw new NotImplementedException();
	}
}
