using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.U2D
{
	public unsafe partial class SpriteAtlasManager {
		//public SpriteAtlasManager() { }
		public static event System.Action<FL_UnityEngine.U2D.SpriteAtlas> atlasRegistered;
		public static event System.Action<string, System.Action<FL_UnityEngine.U2D.SpriteAtlas>> atlasRequested;
	}
}
