using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class StateMachineBehaviour : FL_UnityEngine.ScriptableObject {
		public virtual void OnStateEnter(FL_UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex) => throw new NotImplementedException();
		public virtual void OnStateEnter(FL_UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller) => throw new NotImplementedException();
		public virtual void OnStateExit(FL_UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex) => throw new NotImplementedException();
		public virtual void OnStateExit(FL_UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller) => throw new NotImplementedException();
		public virtual void OnStateIK(FL_UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex) => throw new NotImplementedException();
		public virtual void OnStateIK(FL_UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller) => throw new NotImplementedException();
		public virtual void OnStateMachineEnter(FL_UnityEngine.Animator animator, int stateMachinePathHash) => throw new NotImplementedException();
		public virtual void OnStateMachineEnter(FL_UnityEngine.Animator animator, int stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller) => throw new NotImplementedException();
		public virtual void OnStateMachineExit(FL_UnityEngine.Animator animator, int stateMachinePathHash) => throw new NotImplementedException();
		public virtual void OnStateMachineExit(FL_UnityEngine.Animator animator, int stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller) => throw new NotImplementedException();
		public virtual void OnStateMove(FL_UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex) => throw new NotImplementedException();
		public virtual void OnStateMove(FL_UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller) => throw new NotImplementedException();
		public virtual void OnStateUpdate(FL_UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex) => throw new NotImplementedException();
		public virtual void OnStateUpdate(FL_UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller) => throw new NotImplementedException();
	}
}
