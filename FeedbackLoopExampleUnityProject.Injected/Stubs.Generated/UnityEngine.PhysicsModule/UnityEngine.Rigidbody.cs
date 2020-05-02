//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;

//namespace FL_UnityEngine
//{
//	public unsafe partial class Rigidbody : FL_UnityEngine.Component {
//		//public Rigidbody() { }
//		public void AddExplosionForce(float explosionForce, UnityEngine.Vector3 explosionPosition, float explosionRadius, float upwardsModifier, UnityEngine.ForceMode mode) => throw new NotImplementedException();
//		public void AddExplosionForce(float explosionForce, UnityEngine.Vector3 explosionPosition, float explosionRadius, float upwardsModifier) => throw new NotImplementedException();
//		public void AddExplosionForce(float explosionForce, UnityEngine.Vector3 explosionPosition, float explosionRadius) => throw new NotImplementedException();
//		public void AddForce(UnityEngine.Vector3 force, UnityEngine.ForceMode mode) => throw new NotImplementedException();
//		public void AddForce(UnityEngine.Vector3 force) => throw new NotImplementedException();
//		public void AddForce(float x, float y, float z, UnityEngine.ForceMode mode) => throw new NotImplementedException();
//		public void AddForce(float x, float y, float z) => throw new NotImplementedException();
//		public void AddForceAtPosition(UnityEngine.Vector3 force, UnityEngine.Vector3 position, UnityEngine.ForceMode mode) => throw new NotImplementedException();
//		public void AddForceAtPosition(UnityEngine.Vector3 force, UnityEngine.Vector3 position) => throw new NotImplementedException();
//		public void AddRelativeForce(UnityEngine.Vector3 force) => throw new NotImplementedException();
//		public void AddRelativeForce(float x, float y, float z, UnityEngine.ForceMode mode) => throw new NotImplementedException();
//		public void AddRelativeForce(float x, float y, float z) => throw new NotImplementedException();
//		public void AddRelativeForce(UnityEngine.Vector3 force, UnityEngine.ForceMode mode) => throw new NotImplementedException();
//		public void AddRelativeTorque(UnityEngine.Vector3 torque, UnityEngine.ForceMode mode) => throw new NotImplementedException();
//		public void AddRelativeTorque(UnityEngine.Vector3 torque) => throw new NotImplementedException();
//		public void AddRelativeTorque(float x, float y, float z, UnityEngine.ForceMode mode) => throw new NotImplementedException();
//		public void AddRelativeTorque(float x, float y, float z) => throw new NotImplementedException();
//		public void AddTorque(UnityEngine.Vector3 torque, UnityEngine.ForceMode mode) => throw new NotImplementedException();
//		public void AddTorque(UnityEngine.Vector3 torque) => throw new NotImplementedException();
//		public void AddTorque(float x, float y, float z, UnityEngine.ForceMode mode) => throw new NotImplementedException();
//		public void AddTorque(float x, float y, float z) => throw new NotImplementedException();
//		public UnityEngine.Vector3 ClosestPointOnBounds(UnityEngine.Vector3 position) => throw new NotImplementedException();
//		public UnityEngine.Vector3 GetPointVelocity(UnityEngine.Vector3 worldPoint) => throw new NotImplementedException();
//		public UnityEngine.Vector3 GetRelativePointVelocity(UnityEngine.Vector3 relativePoint) => throw new NotImplementedException();
//		public bool IsSleeping() => throw new NotImplementedException();
//		public void MovePosition(UnityEngine.Vector3 position) => throw new NotImplementedException();
//		public void MoveRotation(UnityEngine.Quaternion rot) => throw new NotImplementedException();
//		public void ResetCenterOfMass() => throw new NotImplementedException();
//		public void ResetInertiaTensor() => throw new NotImplementedException();
//		public void SetDensity(float density) => throw new NotImplementedException();
//		public void Sleep() => throw new NotImplementedException();
//		public bool SweepTest(UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
//		public bool SweepTest(UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance) => throw new NotImplementedException();
//		public bool SweepTest(UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo) => throw new NotImplementedException();
//		public UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction, float maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
//		public UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction, float maxDistance) => throw new NotImplementedException();
//		public UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction) => throw new NotImplementedException();
//		public void WakeUp() => throw new NotImplementedException();
//		public float angularDrag { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public UnityEngine.Vector3 angularVelocity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public UnityEngine.Vector3 centerOfMass { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public UnityEngine.CollisionDetectionMode collisionDetectionMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public UnityEngine.RigidbodyConstraints constraints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public bool detectCollisions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public float drag { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public bool freezeRotation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public UnityEngine.Vector3 inertiaTensor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public UnityEngine.Quaternion inertiaTensorRotation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public UnityEngine.RigidbodyInterpolation interpolation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public bool isKinematic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public float mass { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public float maxAngularVelocity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public float maxDepenetrationVelocity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public UnityEngine.Vector3 position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public UnityEngine.Quaternion rotation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public float sleepThreshold { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public int solverIterations { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public int solverVelocityIterations { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public bool useGravity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public UnityEngine.Vector3 velocity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//		public UnityEngine.Vector3 worldCenterOfMass => throw new NotImplementedException();
//	}
//}
