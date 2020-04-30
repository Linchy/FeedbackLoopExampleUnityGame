using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine
{
	public unsafe partial class AnimatorOverrideController : FL_UnityEngine.RuntimeAnimatorController {
		//public AnimatorOverrideController() { }
		//public AnimatorOverrideController(FL_UnityEngine.RuntimeAnimatorController controller) { }
		public void ApplyOverrides(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<FL_UnityEngine.AnimationClip, FL_UnityEngine.AnimationClip>> overrides) => throw new NotImplementedException();
		public void GetOverrides(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<FL_UnityEngine.AnimationClip, FL_UnityEngine.AnimationClip>> overrides) => throw new NotImplementedException();
		public FL_UnityEngine.AnimationClip this[string name] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public FL_UnityEngine.AnimationClip this[FL_UnityEngine.AnimationClip clip] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int overridesCount => throw new NotImplementedException();
		public FL_UnityEngine.RuntimeAnimatorController runtimeAnimatorController { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
