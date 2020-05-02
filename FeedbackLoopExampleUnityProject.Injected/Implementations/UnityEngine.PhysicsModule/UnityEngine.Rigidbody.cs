using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Rigidbody : FL_UnityEngine.Component {
		//public Rigidbody() { }
		public void AddExplosionForce(float explosionForce, UnityEngine.Vector3 explosionPosition, float explosionRadius, float upwardsModifier, UnityEngine.ForceMode mode) { }
		public void AddExplosionForce(float explosionForce, UnityEngine.Vector3 explosionPosition, float explosionRadius, float upwardsModifier) { }
		public void AddExplosionForce(float explosionForce, UnityEngine.Vector3 explosionPosition, float explosionRadius) { }
		public void AddForce(UnityEngine.Vector3 force, UnityEngine.ForceMode mode) { }
		public void AddForce(UnityEngine.Vector3 force) { }
		public void AddForce(float x, float y, float z, UnityEngine.ForceMode mode) { }
		public void AddForce(float x, float y, float z) { }
		public void AddForceAtPosition(UnityEngine.Vector3 force, UnityEngine.Vector3 position, UnityEngine.ForceMode mode) { }
		public void AddForceAtPosition(UnityEngine.Vector3 force, UnityEngine.Vector3 position) { }
		public void AddRelativeForce(UnityEngine.Vector3 force) { }
		public void AddRelativeForce(float x, float y, float z, UnityEngine.ForceMode mode) { }
		public void AddRelativeForce(float x, float y, float z) { }
		public void AddRelativeForce(UnityEngine.Vector3 force, UnityEngine.ForceMode mode) { }
		public void AddRelativeTorque(UnityEngine.Vector3 torque, UnityEngine.ForceMode mode) { }
		public void AddRelativeTorque(UnityEngine.Vector3 torque) { }
		public void AddRelativeTorque(float x, float y, float z, UnityEngine.ForceMode mode) { }
		public void AddRelativeTorque(float x, float y, float z) { }
		public void AddTorque(UnityEngine.Vector3 torque, UnityEngine.ForceMode mode) { }
		public void AddTorque(UnityEngine.Vector3 torque) { }
		public void AddTorque(float x, float y, float z, UnityEngine.ForceMode mode) { }
		public void AddTorque(float x, float y, float z) { }
		public UnityEngine.Vector3 ClosestPointOnBounds(UnityEngine.Vector3 position) => throw new NotImplementedException();
		public UnityEngine.Vector3 GetPointVelocity(UnityEngine.Vector3 worldPoint) => throw new NotImplementedException();
		public UnityEngine.Vector3 GetRelativePointVelocity(UnityEngine.Vector3 relativePoint) => throw new NotImplementedException();
		public bool IsSleeping() => throw new NotImplementedException();
		public void MovePosition(UnityEngine.Vector3 position) { }
		public void MoveRotation(UnityEngine.Quaternion rot) { }
		public void ResetCenterOfMass() { }
		public void ResetInertiaTensor() { }
		public void SetDensity(float density) { }
		public void Sleep() { }
		public bool SweepTest(UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public bool SweepTest(UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float maxDistance) => throw new NotImplementedException();
		public bool SweepTest(UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo) => throw new NotImplementedException();
		public UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction, float maxDistance, UnityEngine.QueryTriggerInteraction queryTriggerInteraction) => throw new NotImplementedException();
		public UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction, float maxDistance) => throw new NotImplementedException();
		public UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3 direction) => throw new NotImplementedException();
		public void WakeUp() { }
		public float angularDrag { get; set; }
		public UnityEngine.Vector3 angularVelocity { get; set; }
		public UnityEngine.Vector3 centerOfMass { get; set; }
		public UnityEngine.CollisionDetectionMode collisionDetectionMode { get; set; }
		public UnityEngine.RigidbodyConstraints constraints { get; set; }
		public bool detectCollisions { get; set; }
		public float drag { get; set; }
		public bool freezeRotation { get; set; }
		public UnityEngine.Vector3 inertiaTensor { get; set; }
		public UnityEngine.Quaternion inertiaTensorRotation { get; set; }
		public UnityEngine.RigidbodyInterpolation interpolation { get; set; }
		public bool isKinematic { get; set; }
		public float mass { get; set; }
		public float maxAngularVelocity { get; set; }
		public float maxDepenetrationVelocity { get; set; }
		public UnityEngine.Vector3 position { get; set; }
		public UnityEngine.Quaternion rotation { get; set; }
		public float sleepThreshold { get; set; }
		public int solverIterations { get; set; }
		public int solverVelocityIterations { get; set; }
		public bool useGravity { get; set; }
		public UnityEngine.Vector3 velocity { get; set; }
		public UnityEngine.Vector3 worldCenterOfMass { get; }
	}
}
