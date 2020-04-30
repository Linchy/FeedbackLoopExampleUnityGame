using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Physics {
		//public Physics() { }
		public static int AllLayers;
		public static int DefaultRaycastLayers;
		public static int IgnoreRaycastLayer;
		public static bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance) => throw new NotImplementedException();
		public static bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation) => throw new NotImplementedException();
		public static bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction) => throw new NotImplementedException();
		public static bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, UnityEngine.Quaternion orientation, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, UnityEngine.Quaternion orientation, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, UnityEngine.Quaternion orientation, float maxDistance) => throw new NotImplementedException();
		public static bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, UnityEngine.Quaternion orientation) => throw new NotImplementedException();
		public static bool BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, float maxDistance) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] BoxCastAll(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction) => throw new NotImplementedException();
		public static int BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static int BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation) => throw new NotImplementedException();
		public static int BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, float maxDistance) => throw new NotImplementedException();
		public static int BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, UnityEngine.Quaternion orientation, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static int BoxCastNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results) => throw new NotImplementedException();
		public static bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float maxDistance) => throw new NotImplementedException();
		public static bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction) => throw new NotImplementedException();
		public static bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance) => throw new NotImplementedException();
		public static bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float maxDistance) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction) => throw new NotImplementedException();
		public static int CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static int CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static int CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance) => throw new NotImplementedException();
		public static int CapsuleCastNonAlloc(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results) => throw new NotImplementedException();
		public static bool CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, int layermask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static bool CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, int layerMask) => throw new NotImplementedException();
		public static bool CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation) => throw new NotImplementedException();
		public static bool CheckBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents) => throw new NotImplementedException();
		public static bool CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static bool CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float radius, int layerMask) => throw new NotImplementedException();
		public static bool CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float radius) => throw new NotImplementedException();
		public static bool CheckSphere(UnityEngine.Vector3 position, float radius, int layerMask) => throw new NotImplementedException();
		public static bool CheckSphere(UnityEngine.Vector3 position, float radius) => throw new NotImplementedException();
		public static bool CheckSphere(UnityEngine.Vector3 position, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 point, FL_UnityEngine.Collider collider, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) => throw new NotImplementedException();
		public static bool ComputePenetration(FL_UnityEngine.Collider colliderA, UnityEngine.Vector3 positionA, UnityEngine.Quaternion rotationA, FL_UnityEngine.Collider colliderB, UnityEngine.Vector3 positionB, UnityEngine.Quaternion rotationB, out UnityEngine.Vector3 direction, out float distance) => throw new NotImplementedException();
		public static bool GetIgnoreLayerCollision(int layer1, int layer2) => throw new NotImplementedException();
		public static void IgnoreCollision(FL_UnityEngine.Collider collider1, FL_UnityEngine.Collider collider2, bool ignore) => throw new NotImplementedException();
		public static void IgnoreCollision(FL_UnityEngine.Collider collider1, FL_UnityEngine.Collider collider2) => throw new NotImplementedException();
		public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore) => throw new NotImplementedException();
		public static void IgnoreLayerCollision(int layer1, int layer2) => throw new NotImplementedException();
		public static bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, int layerMask) => throw new NotImplementedException();
		public static bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end) => throw new NotImplementedException();
		public static bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, out UnityEngine.RaycastHit hitInfo, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, out UnityEngine.RaycastHit hitInfo, int layerMask) => throw new NotImplementedException();
		public static bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, out UnityEngine.RaycastHit hitInfo) => throw new NotImplementedException();
		public static FL_UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static FL_UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, int layerMask) => throw new NotImplementedException();
		public static FL_UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation) => throw new NotImplementedException();
		public static FL_UnityEngine.Collider[] OverlapBox(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents) => throw new NotImplementedException();
		public static int OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, FL_UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, int mask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static int OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, FL_UnityEngine.Collider[] results, UnityEngine.Quaternion orientation, int mask) => throw new NotImplementedException();
		public static int OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, FL_UnityEngine.Collider[] results, UnityEngine.Quaternion orientation) => throw new NotImplementedException();
		public static int OverlapBoxNonAlloc(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, FL_UnityEngine.Collider[] results) => throw new NotImplementedException();
		public static FL_UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static FL_UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, int layerMask) => throw new NotImplementedException();
		public static FL_UnityEngine.Collider[] OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius) => throw new NotImplementedException();
		public static int OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, FL_UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static int OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, FL_UnityEngine.Collider[] results, int layerMask) => throw new NotImplementedException();
		public static int OverlapCapsuleNonAlloc(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, float radius, FL_UnityEngine.Collider[] results) => throw new NotImplementedException();
		public static FL_UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, float radius, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static FL_UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, float radius, int layerMask) => throw new NotImplementedException();
		public static FL_UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, float radius) => throw new NotImplementedException();
		public static int OverlapSphereNonAlloc(UnityEngine.Vector3 position, float radius, FL_UnityEngine.Collider[] results, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static int OverlapSphereNonAlloc(UnityEngine.Vector3 position, float radius, FL_UnityEngine.Collider[] results, int layerMask) => throw new NotImplementedException();
		public static int OverlapSphereNonAlloc(UnityEngine.Vector3 position, float radius, FL_UnityEngine.Collider[] results) => throw new NotImplementedException();
		public static bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance) => throw new NotImplementedException();
		public static bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction) => throw new NotImplementedException();
		public static bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance) => throw new NotImplementedException();
		public static bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo) => throw new NotImplementedException();
		public static bool Raycast(UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static bool Raycast(UnityEngine.Ray ray, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static bool Raycast(UnityEngine.Ray ray, float maxDistance) => throw new NotImplementedException();
		public static bool Raycast(UnityEngine.Ray ray) => throw new NotImplementedException();
		public static bool Raycast(UnityEngine.Ray ray, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static bool Raycast(UnityEngine.Ray ray, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static bool Raycast(UnityEngine.Ray ray, out UnityEngine.RaycastHit hitInfo, float maxDistance) => throw new NotImplementedException();
		public static bool Raycast(UnityEngine.Ray ray, out UnityEngine.RaycastHit hitInfo) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float maxDistance) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float maxDistance) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray) => throw new NotImplementedException();
		public static int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, float maxDistance) => throw new NotImplementedException();
		public static int RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results) => throw new NotImplementedException();
		public static int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance) => throw new NotImplementedException();
		public static int RaycastNonAlloc(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results) => throw new NotImplementedException();
		public static void RebuildBroadphaseRegions(UnityEngine.Bounds worldBounds, int subdivisions) => throw new NotImplementedException();
		public static void Simulate(float step) => throw new NotImplementedException();
		public static bool SphereCast(UnityEngine.Ray ray, float radius) => throw new NotImplementedException();
		public static bool SphereCast(UnityEngine.Ray ray, float radius, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static bool SphereCast(UnityEngine.Ray ray, float radius, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static bool SphereCast(UnityEngine.Ray ray, float radius, out UnityEngine.RaycastHit hitInfo, float maxDistance) => throw new NotImplementedException();
		public static bool SphereCast(UnityEngine.Ray ray, float radius, out UnityEngine.RaycastHit hitInfo) => throw new NotImplementedException();
		public static bool SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static bool SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static bool SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance) => throw new NotImplementedException();
		public static bool SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo) => throw new NotImplementedException();
		public static bool SphereCast(UnityEngine.Ray ray, float radius, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static bool SphereCast(UnityEngine.Ray ray, float radius, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static bool SphereCast(UnityEngine.Ray ray, float radius, float maxDistance) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, float maxDistance) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, float radius, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, float radius, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, float radius, float maxDistance) => throw new NotImplementedException();
		public static UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, float radius) => throw new NotImplementedException();
		public static int SphereCastNonAlloc(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static int SphereCastNonAlloc(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static int SphereCastNonAlloc(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, float maxDistance) => throw new NotImplementedException();
		public static int SphereCastNonAlloc(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results) => throw new NotImplementedException();
		public static int SphereCastNonAlloc(UnityEngine.Ray ray, float radius, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public static int SphereCastNonAlloc(UnityEngine.Ray ray, float radius, UnityEngine.RaycastHit[] results, float maxDistance, int layerMask) => throw new NotImplementedException();
		public static int SphereCastNonAlloc(UnityEngine.Ray ray, float radius, UnityEngine.RaycastHit[] results, float maxDistance) => throw new NotImplementedException();
		public static int SphereCastNonAlloc(UnityEngine.Ray ray, float radius, UnityEngine.RaycastHit[] results) => throw new NotImplementedException();
		public static void SyncTransforms() => throw new NotImplementedException();
		public static bool autoSimulation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static bool autoSyncTransforms { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static float bounceThreshold { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static float defaultContactOffset { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static UnityEngine.PhysicsScene defaultPhysicsScene => throw new NotImplementedException();
		public static int defaultSolverIterations { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static int defaultSolverVelocityIterations { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static UnityEngine.Vector3 gravity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static float interCollisionDistance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static bool interCollisionSettingsToggle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static float interCollisionStiffness { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static bool queriesHitBackfaces { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static bool queriesHitTriggers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static bool reuseCollisionCallbacks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public static float sleepThreshold { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
