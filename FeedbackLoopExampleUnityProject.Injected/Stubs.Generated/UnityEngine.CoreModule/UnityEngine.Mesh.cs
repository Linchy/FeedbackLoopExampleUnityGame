using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Mesh : FL_UnityEngine.Object {
		//public Mesh() { }
		public void AddBlendShapeFrame(string shapeName, float frameWeight, UnityEngine.Vector3[] deltaVertices, UnityEngine.Vector3[] deltaNormals, UnityEngine.Vector3[] deltaTangents) => throw new NotImplementedException();
		public void Clear(bool keepVertexLayout) => throw new NotImplementedException();
		public void Clear() => throw new NotImplementedException();
		public void ClearBlendShapes() => throw new NotImplementedException();
		public void CombineMeshes(UnityEngine.CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) => throw new NotImplementedException();
		public void CombineMeshes(UnityEngine.CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices) => throw new NotImplementedException();
		public void CombineMeshes(UnityEngine.CombineInstance[] combine, bool mergeSubMeshes) => throw new NotImplementedException();
		public void CombineMeshes(UnityEngine.CombineInstance[] combine) => throw new NotImplementedException();
		public System.UInt32 GetBaseVertex(int submesh) => throw new NotImplementedException();
		public void GetBindposes(System.Collections.Generic.List<UnityEngine.Matrix4x4> bindposes) => throw new NotImplementedException();
		public int GetBlendShapeFrameCount(int shapeIndex) => throw new NotImplementedException();
		public void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, UnityEngine.Vector3[] deltaVertices, UnityEngine.Vector3[] deltaNormals, UnityEngine.Vector3[] deltaTangents) => throw new NotImplementedException();
		public float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex) => throw new NotImplementedException();
		public int GetBlendShapeIndex(string blendShapeName) => throw new NotImplementedException();
		public string GetBlendShapeName(int shapeIndex) => throw new NotImplementedException();
		public void GetBoneWeights(System.Collections.Generic.List<UnityEngine.BoneWeight> boneWeights) => throw new NotImplementedException();
		public void GetColors(System.Collections.Generic.List<UnityEngine.Color> colors) => throw new NotImplementedException();
		public void GetColors(System.Collections.Generic.List<UnityEngine.Color32> colors) => throw new NotImplementedException();
		public System.UInt32 GetIndexCount(int submesh) => throw new NotImplementedException();
		public System.UInt32 GetIndexStart(int submesh) => throw new NotImplementedException();
		public int[] GetIndices(int submesh) => throw new NotImplementedException();
		public int[] GetIndices(int submesh, bool applyBaseVertex) => throw new NotImplementedException();
		public void GetIndices(System.Collections.Generic.List<int> indices, int submesh) => throw new NotImplementedException();
		public void GetIndices(System.Collections.Generic.List<int> indices, int submesh, bool applyBaseVertex) => throw new NotImplementedException();
		public System.IntPtr GetNativeIndexBufferPtr() => throw new NotImplementedException();
		public System.IntPtr GetNativeVertexBufferPtr(int index) => throw new NotImplementedException();
		public void GetNormals(System.Collections.Generic.List<UnityEngine.Vector3> normals) => throw new NotImplementedException();
		public void GetTangents(System.Collections.Generic.List<UnityEngine.Vector4> tangents) => throw new NotImplementedException();
		public UnityEngine.MeshTopology GetTopology(int submesh) => throw new NotImplementedException();
		public int[] GetTriangles(int submesh) => throw new NotImplementedException();
		public int[] GetTriangles(int submesh, bool applyBaseVertex) => throw new NotImplementedException();
		public void GetTriangles(System.Collections.Generic.List<int> triangles, int submesh) => throw new NotImplementedException();
		public void GetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool applyBaseVertex) => throw new NotImplementedException();
		public float GetUVDistributionMetric(int uvSetIndex) => throw new NotImplementedException();
		public void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs) => throw new NotImplementedException();
		public void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs) => throw new NotImplementedException();
		public void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs) => throw new NotImplementedException();
		public void GetVertices(System.Collections.Generic.List<UnityEngine.Vector3> vertices) => throw new NotImplementedException();
		public void MarkDynamic() => throw new NotImplementedException();
		public void RecalculateBounds() => throw new NotImplementedException();
		public void RecalculateNormals() => throw new NotImplementedException();
		public void RecalculateTangents() => throw new NotImplementedException();
		public void SetColors(System.Collections.Generic.List<UnityEngine.Color> inColors) => throw new NotImplementedException();
		public void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors) => throw new NotImplementedException();
		public void SetIndices(int[] indices, UnityEngine.MeshTopology topology, int submesh) => throw new NotImplementedException();
		public void SetIndices(int[] indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds) => throw new NotImplementedException();
		public void SetIndices(int[] indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) => throw new NotImplementedException();
		public void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals) => throw new NotImplementedException();
		public void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents) => throw new NotImplementedException();
		public void SetTriangles(int[] triangles, int submesh) => throw new NotImplementedException();
		public void SetTriangles(int[] triangles, int submesh, bool calculateBounds) => throw new NotImplementedException();
		public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) => throw new NotImplementedException();
		public void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh) => throw new NotImplementedException();
		public void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool calculateBounds) => throw new NotImplementedException();
		public void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool calculateBounds, int baseVertex) => throw new NotImplementedException();
		public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs) => throw new NotImplementedException();
		public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs) => throw new NotImplementedException();
		public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs) => throw new NotImplementedException();
		public void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices) => throw new NotImplementedException();
		public void UploadMeshData(bool markNoLongerReadable) => throw new NotImplementedException();
		public UnityEngine.Matrix4x4[] bindposes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int blendShapeCount => throw new NotImplementedException();
		public UnityEngine.BoneWeight[] boneWeights { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Bounds bounds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Color[] colors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Color32[] colors32 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Rendering.IndexFormat indexFormat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool isReadable => throw new NotImplementedException();
		public UnityEngine.Vector3[] normals { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int subMeshCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector4[] tangents { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int[] triangles { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector2[] uv { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector2[] uv2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector2[] uv3 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector2[] uv4 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector2[] uv5 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector2[] uv6 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector2[] uv7 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector2[] uv8 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int vertexBufferCount => throw new NotImplementedException();
		public int vertexCount => throw new NotImplementedException();
		public UnityEngine.Vector3[] vertices { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
