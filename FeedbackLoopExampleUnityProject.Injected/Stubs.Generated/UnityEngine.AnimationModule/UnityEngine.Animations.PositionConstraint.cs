using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Animations
{
	public unsafe partial class PositionConstraint : FL_UnityEngine.Behaviour {
		public virtual int AddSource(UnityEngine.Animations.ConstraintSource source) => throw new NotImplementedException();
		public virtual UnityEngine.Animations.ConstraintSource GetSource(int index) => throw new NotImplementedException();
		public virtual void GetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources) => throw new NotImplementedException();
		public virtual void RemoveSource(int index) => throw new NotImplementedException();
		public virtual void SetSource(int index, UnityEngine.Animations.ConstraintSource source) => throw new NotImplementedException();
		public virtual void SetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources) => throw new NotImplementedException();
		public virtual bool constraintActive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public virtual bool locked { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public virtual int sourceCount => throw new NotImplementedException();
		public UnityEngine.Vector3 translationAtRest { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Animations.Axis translationAxis { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public UnityEngine.Vector3 translationOffset { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public virtual float weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
