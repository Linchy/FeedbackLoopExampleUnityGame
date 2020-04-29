using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Material : FL_UnityEngine.Object {
		//public Material(FL_UnityEngine.Shader shader) { }
		//public Material(FL_UnityEngine.Material source) { }
		public void CopyPropertiesFromMaterial(FL_UnityEngine.Material mat) => throw new NotImplementedException();
		public void DisableKeyword(string keyword) => throw new NotImplementedException();
		public void EnableKeyword(string keyword) => throw new NotImplementedException();
		public int FindPass(string passName) => throw new NotImplementedException();
		public UnityEngine.Color GetColor(string name) => throw new NotImplementedException();
		public UnityEngine.Color GetColor(int nameID) => throw new NotImplementedException();
		public UnityEngine.Color[] GetColorArray(string name) => throw new NotImplementedException();
		public UnityEngine.Color[] GetColorArray(int nameID) => throw new NotImplementedException();
		public void GetColorArray(string name, System.Collections.Generic.List<UnityEngine.Color> values) => throw new NotImplementedException();
		public void GetColorArray(int nameID, System.Collections.Generic.List<UnityEngine.Color> values) => throw new NotImplementedException();
		public float GetFloat(string name) => throw new NotImplementedException();
		public float GetFloat(int nameID) => throw new NotImplementedException();
		public float[] GetFloatArray(string name) => throw new NotImplementedException();
		public float[] GetFloatArray(int nameID) => throw new NotImplementedException();
		public void GetFloatArray(string name, System.Collections.Generic.List<float> values) => throw new NotImplementedException();
		public void GetFloatArray(int nameID, System.Collections.Generic.List<float> values) => throw new NotImplementedException();
		public int GetInt(string name) => throw new NotImplementedException();
		public int GetInt(int nameID) => throw new NotImplementedException();
		public UnityEngine.Matrix4x4 GetMatrix(string name) => throw new NotImplementedException();
		public UnityEngine.Matrix4x4 GetMatrix(int nameID) => throw new NotImplementedException();
		public UnityEngine.Matrix4x4[] GetMatrixArray(string name) => throw new NotImplementedException();
		public UnityEngine.Matrix4x4[] GetMatrixArray(int nameID) => throw new NotImplementedException();
		public void GetMatrixArray(string name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values) => throw new NotImplementedException();
		public void GetMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values) => throw new NotImplementedException();
		public string GetPassName(int pass) => throw new NotImplementedException();
		public bool GetShaderPassEnabled(string passName) => throw new NotImplementedException();
		public string GetTag(string tag, bool searchFallbacks, string defaultValue) => throw new NotImplementedException();
		public string GetTag(string tag, bool searchFallbacks) => throw new NotImplementedException();
		public FL_UnityEngine.Texture GetTexture(string name) => throw new NotImplementedException();
		public FL_UnityEngine.Texture GetTexture(int nameID) => throw new NotImplementedException();
		public UnityEngine.Vector2 GetTextureOffset(string name) => throw new NotImplementedException();
		public UnityEngine.Vector2 GetTextureOffset(int nameID) => throw new NotImplementedException();
		public int[] GetTexturePropertyNameIDs() => throw new NotImplementedException();
		public void GetTexturePropertyNameIDs(System.Collections.Generic.List<int> outNames) => throw new NotImplementedException();
		public string[] GetTexturePropertyNames() => throw new NotImplementedException();
		public void GetTexturePropertyNames(System.Collections.Generic.List<string> outNames) => throw new NotImplementedException();
		public UnityEngine.Vector2 GetTextureScale(string name) => throw new NotImplementedException();
		public UnityEngine.Vector2 GetTextureScale(int nameID) => throw new NotImplementedException();
		public UnityEngine.Vector4 GetVector(string name) => throw new NotImplementedException();
		public UnityEngine.Vector4 GetVector(int nameID) => throw new NotImplementedException();
		public UnityEngine.Vector4[] GetVectorArray(string name) => throw new NotImplementedException();
		public UnityEngine.Vector4[] GetVectorArray(int nameID) => throw new NotImplementedException();
		public void GetVectorArray(string name, System.Collections.Generic.List<UnityEngine.Vector4> values) => throw new NotImplementedException();
		public void GetVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values) => throw new NotImplementedException();
		public bool HasProperty(int nameID) => throw new NotImplementedException();
		public bool HasProperty(string name) => throw new NotImplementedException();
		public bool IsKeywordEnabled(string keyword) => throw new NotImplementedException();
		public void Lerp(FL_UnityEngine.Material start, FL_UnityEngine.Material end, float t) => throw new NotImplementedException();
		public void SetBuffer(string name, FL_UnityEngine.ComputeBuffer value) => throw new NotImplementedException();
		public void SetBuffer(int nameID, FL_UnityEngine.ComputeBuffer value) => throw new NotImplementedException();
		public void SetColor(string name, UnityEngine.Color value) => throw new NotImplementedException();
		public void SetColor(int nameID, UnityEngine.Color value) => throw new NotImplementedException();
		public void SetColorArray(string name, System.Collections.Generic.List<UnityEngine.Color> values) => throw new NotImplementedException();
		public void SetColorArray(int nameID, System.Collections.Generic.List<UnityEngine.Color> values) => throw new NotImplementedException();
		public void SetColorArray(string name, UnityEngine.Color[] values) => throw new NotImplementedException();
		public void SetColorArray(int nameID, UnityEngine.Color[] values) => throw new NotImplementedException();
		public void SetFloat(string name, float value) => throw new NotImplementedException();
		public void SetFloat(int nameID, float value) => throw new NotImplementedException();
		public void SetFloatArray(string name, System.Collections.Generic.List<float> values) => throw new NotImplementedException();
		public void SetFloatArray(int nameID, System.Collections.Generic.List<float> values) => throw new NotImplementedException();
		public void SetFloatArray(string name, float[] values) => throw new NotImplementedException();
		public void SetFloatArray(int nameID, float[] values) => throw new NotImplementedException();
		public void SetInt(string name, int value) => throw new NotImplementedException();
		public void SetInt(int nameID, int value) => throw new NotImplementedException();
		public void SetMatrix(string name, UnityEngine.Matrix4x4 value) => throw new NotImplementedException();
		public void SetMatrix(int nameID, UnityEngine.Matrix4x4 value) => throw new NotImplementedException();
		public void SetMatrixArray(string name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values) => throw new NotImplementedException();
		public void SetMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values) => throw new NotImplementedException();
		public void SetMatrixArray(string name, UnityEngine.Matrix4x4[] values) => throw new NotImplementedException();
		public void SetMatrixArray(int nameID, UnityEngine.Matrix4x4[] values) => throw new NotImplementedException();
		public void SetOverrideTag(string tag, string val) => throw new NotImplementedException();
		public bool SetPass(int pass) => throw new NotImplementedException();
		public void SetShaderPassEnabled(string passName, bool enabled) => throw new NotImplementedException();
		public void SetTexture(string name, FL_UnityEngine.Texture value) => throw new NotImplementedException();
		public void SetTexture(int nameID, FL_UnityEngine.Texture value) => throw new NotImplementedException();
		public void SetTextureOffset(string name, UnityEngine.Vector2 value) => throw new NotImplementedException();
		public void SetTextureOffset(int nameID, UnityEngine.Vector2 value) => throw new NotImplementedException();
		public void SetTextureScale(string name, UnityEngine.Vector2 value) => throw new NotImplementedException();
		public void SetTextureScale(int nameID, UnityEngine.Vector2 value) => throw new NotImplementedException();
		public void SetVector(string name, UnityEngine.Vector4 value) => throw new NotImplementedException();
		public void SetVector(int nameID, UnityEngine.Vector4 value) => throw new NotImplementedException();
		public void SetVectorArray(string name, System.Collections.Generic.List<UnityEngine.Vector4> values) => throw new NotImplementedException();
		public void SetVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values) => throw new NotImplementedException();
		public void SetVectorArray(string name, UnityEngine.Vector4[] values) => throw new NotImplementedException();
		public void SetVectorArray(int nameID, UnityEngine.Vector4[] values) => throw new NotImplementedException();
		public UnityEngine.Color color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool doubleSidedGI { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool enableInstancing { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.MaterialGlobalIlluminationFlags globalIlluminationFlags { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.Texture mainTexture { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector2 mainTextureOffset { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector2 mainTextureScale { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int passCount => throw new NotImplementedException();
		public int renderQueue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.Shader shader { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public string[] shaderKeywords { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
