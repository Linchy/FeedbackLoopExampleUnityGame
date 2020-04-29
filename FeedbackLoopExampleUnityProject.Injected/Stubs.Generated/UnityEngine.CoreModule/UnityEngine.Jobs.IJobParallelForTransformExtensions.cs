using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.Jobs
{
	public unsafe partial class IJobParallelForTransformExtensions {
		public static Unity.Jobs.JobHandle Schedule<T>(T jobData, UnityEngine.Jobs.TransformAccessArray transforms, Unity.Jobs.JobHandle dependsOn) where T : struct,UnityEngine.Jobs.IJobParallelForTransform => throw new NotImplementedException();
	}
}
