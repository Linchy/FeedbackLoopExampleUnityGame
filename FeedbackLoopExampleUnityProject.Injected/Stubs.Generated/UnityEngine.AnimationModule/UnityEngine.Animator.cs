using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class Animator : FL_UnityEngine.Behaviour {
		//public Animator() { }
		public void ApplyBuiltinRootMotion() => throw new NotImplementedException();
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) => throw new NotImplementedException();
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) => throw new NotImplementedException();
		public void CrossFade(int stateHashName, float normalizedTransitionDuration) => throw new NotImplementedException();
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) => throw new NotImplementedException();
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) => throw new NotImplementedException();
		public void CrossFade(string stateName, float normalizedTransitionDuration) => throw new NotImplementedException();
		public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) => throw new NotImplementedException();
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) => throw new NotImplementedException();
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration) => throw new NotImplementedException();
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer) => throw new NotImplementedException();
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset) => throw new NotImplementedException();
		public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) => throw new NotImplementedException();
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset) => throw new NotImplementedException();
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer) => throw new NotImplementedException();
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration) => throw new NotImplementedException();
		public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) => throw new NotImplementedException();
		public UnityEngine.AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) => throw new NotImplementedException();
		public T GetBehaviour<T>() where T : FL_UnityEngine.StateMachineBehaviour => throw new NotImplementedException();
		public T[] GetBehaviours<T>() where T : FL_UnityEngine.StateMachineBehaviour => throw new NotImplementedException();
		public FL_UnityEngine.StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex) => throw new NotImplementedException();
		public FL_UnityEngine.Transform GetBoneTransform(UnityEngine.HumanBodyBones humanBoneId) => throw new NotImplementedException();
		public bool GetBool(string name) => throw new NotImplementedException();
		public bool GetBool(int id) => throw new NotImplementedException();
		public UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) => throw new NotImplementedException();
		public void GetCurrentAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips) => throw new NotImplementedException();
		public int GetCurrentAnimatorClipInfoCount(int layerIndex) => throw new NotImplementedException();
		public UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) => throw new NotImplementedException();
		public float GetFloat(string name) => throw new NotImplementedException();
		public float GetFloat(int id) => throw new NotImplementedException();
		public UnityEngine.Vector3 GetIKHintPosition(UnityEngine.AvatarIKHint hint) => throw new NotImplementedException();
		public float GetIKHintPositionWeight(UnityEngine.AvatarIKHint hint) => throw new NotImplementedException();
		public UnityEngine.Vector3 GetIKPosition(UnityEngine.AvatarIKGoal goal) => throw new NotImplementedException();
		public float GetIKPositionWeight(UnityEngine.AvatarIKGoal goal) => throw new NotImplementedException();
		public UnityEngine.Quaternion GetIKRotation(UnityEngine.AvatarIKGoal goal) => throw new NotImplementedException();
		public float GetIKRotationWeight(UnityEngine.AvatarIKGoal goal) => throw new NotImplementedException();
		public int GetInteger(string name) => throw new NotImplementedException();
		public int GetInteger(int id) => throw new NotImplementedException();
		public int GetLayerIndex(string layerName) => throw new NotImplementedException();
		public string GetLayerName(int layerIndex) => throw new NotImplementedException();
		public float GetLayerWeight(int layerIndex) => throw new NotImplementedException();
		public UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) => throw new NotImplementedException();
		public void GetNextAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips) => throw new NotImplementedException();
		public int GetNextAnimatorClipInfoCount(int layerIndex) => throw new NotImplementedException();
		public UnityEngine.AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) => throw new NotImplementedException();
		public FL_UnityEngine.AnimatorControllerParameter GetParameter(int index) => throw new NotImplementedException();
		public bool HasState(int layerIndex, int stateID) => throw new NotImplementedException();
		public void InterruptMatchTarget() => throw new NotImplementedException();
		public void InterruptMatchTarget(bool completeMatch) => throw new NotImplementedException();
		public bool IsInTransition(int layerIndex) => throw new NotImplementedException();
		public bool IsParameterControlledByCurve(string name) => throw new NotImplementedException();
		public bool IsParameterControlledByCurve(int id) => throw new NotImplementedException();
		public void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime) => throw new NotImplementedException();
		public void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime) => throw new NotImplementedException();
		public void Play(string stateName, int layer) => throw new NotImplementedException();
		public void Play(string stateName) => throw new NotImplementedException();
		public void Play(string stateName, int layer, float normalizedTime) => throw new NotImplementedException();
		public void Play(int stateNameHash, int layer, float normalizedTime) => throw new NotImplementedException();
		public void Play(int stateNameHash, int layer) => throw new NotImplementedException();
		public void Play(int stateNameHash) => throw new NotImplementedException();
		public void PlayInFixedTime(string stateName, int layer) => throw new NotImplementedException();
		public void PlayInFixedTime(string stateName) => throw new NotImplementedException();
		public void PlayInFixedTime(string stateName, int layer, float fixedTime) => throw new NotImplementedException();
		public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime) => throw new NotImplementedException();
		public void PlayInFixedTime(int stateNameHash, int layer) => throw new NotImplementedException();
		public void PlayInFixedTime(int stateNameHash) => throw new NotImplementedException();
		public void Rebind() => throw new NotImplementedException();
		public void ResetTrigger(string name) => throw new NotImplementedException();
		public void ResetTrigger(int id) => throw new NotImplementedException();
		public void SetBoneLocalRotation(UnityEngine.HumanBodyBones humanBoneId, UnityEngine.Quaternion rotation) => throw new NotImplementedException();
		public void SetBool(string name, bool value) => throw new NotImplementedException();
		public void SetBool(int id, bool value) => throw new NotImplementedException();
		public void SetFloat(string name, float value) => throw new NotImplementedException();
		public void SetFloat(string name, float value, float dampTime, float deltaTime) => throw new NotImplementedException();
		public void SetFloat(int id, float value) => throw new NotImplementedException();
		public void SetFloat(int id, float value, float dampTime, float deltaTime) => throw new NotImplementedException();
		public void SetIKHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition) => throw new NotImplementedException();
		public void SetIKHintPositionWeight(UnityEngine.AvatarIKHint hint, float value) => throw new NotImplementedException();
		public void SetIKPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition) => throw new NotImplementedException();
		public void SetIKPositionWeight(UnityEngine.AvatarIKGoal goal, float value) => throw new NotImplementedException();
		public void SetIKRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation) => throw new NotImplementedException();
		public void SetIKRotationWeight(UnityEngine.AvatarIKGoal goal, float value) => throw new NotImplementedException();
		public void SetInteger(string name, int value) => throw new NotImplementedException();
		public void SetInteger(int id, int value) => throw new NotImplementedException();
		public void SetLayerWeight(int layerIndex, float weight) => throw new NotImplementedException();
		public void SetLookAtPosition(UnityEngine.Vector3 lookAtPosition) => throw new NotImplementedException();
		public void SetLookAtWeight(float weight) => throw new NotImplementedException();
		public void SetLookAtWeight(float weight, float bodyWeight) => throw new NotImplementedException();
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) => throw new NotImplementedException();
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) => throw new NotImplementedException();
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) => throw new NotImplementedException();
		public void SetTarget(UnityEngine.AvatarTarget targetIndex, float targetNormalizedTime) => throw new NotImplementedException();
		public void SetTrigger(string name) => throw new NotImplementedException();
		public void SetTrigger(int id) => throw new NotImplementedException();
		public void StartPlayback() => throw new NotImplementedException();
		public void StartRecording(int frameCount) => throw new NotImplementedException();
		public void StopPlayback() => throw new NotImplementedException();
		public void StopRecording() => throw new NotImplementedException();
		public static int StringToHash(string name) => throw new NotImplementedException();
		public void Update(float deltaTime) => throw new NotImplementedException();
		public void WriteDefaultValues() => throw new NotImplementedException();
		public UnityEngine.Vector3 angularVelocity => throw new NotImplementedException();
		public bool applyRootMotion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.Avatar avatar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector3 bodyPosition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Quaternion bodyRotation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.AnimatorCullingMode cullingMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector3 deltaPosition => throw new NotImplementedException();
		public UnityEngine.Quaternion deltaRotation => throw new NotImplementedException();
		public float feetPivotActive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool fireEvents { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float gravityWeight => throw new NotImplementedException();
		public bool hasBoundPlayables => throw new NotImplementedException();
		public bool hasRootMotion => throw new NotImplementedException();
		public bool hasTransformHierarchy => throw new NotImplementedException();
		public float humanScale => throw new NotImplementedException();
		public bool isHuman => throw new NotImplementedException();
		public bool isInitialized => throw new NotImplementedException();
		public bool isMatchingTarget => throw new NotImplementedException();
		public bool isOptimizable => throw new NotImplementedException();
		public bool keepAnimatorControllerStateOnDisable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int layerCount => throw new NotImplementedException();
		public bool layersAffectMassCenter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float leftFeetBottomHeight => throw new NotImplementedException();
		public bool logWarnings { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int parameterCount => throw new NotImplementedException();
		public FL_UnityEngine.AnimatorControllerParameter[] parameters => throw new NotImplementedException();
		public UnityEngine.Vector3 pivotPosition => throw new NotImplementedException();
		public float pivotWeight => throw new NotImplementedException();
		public UnityEngine.Playables.PlayableGraph playableGraph => throw new NotImplementedException();
		public float playbackTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.AnimatorRecorderMode recorderMode => throw new NotImplementedException();
		public float recorderStartTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float recorderStopTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float rightFeetBottomHeight => throw new NotImplementedException();
		public UnityEngine.Vector3 rootPosition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Quaternion rootRotation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.RuntimeAnimatorController runtimeAnimatorController { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public float speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool stabilizeFeet { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector3 targetPosition => throw new NotImplementedException();
		public UnityEngine.Quaternion targetRotation => throw new NotImplementedException();
		public UnityEngine.AnimatorUpdateMode updateMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector3 velocity => throw new NotImplementedException();
	}
}
