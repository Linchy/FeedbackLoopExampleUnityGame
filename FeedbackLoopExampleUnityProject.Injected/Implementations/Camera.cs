﻿/// <summary>
/// This file is provided so that unity engine classes can be swapped out
/// during running in a reloadable context, enabling runninf of game code
/// outside of the unity engine. The classes are generated by using the
/// 'Go to Definition' in VS, and copying out the definition into this file.
/// All methods and getters and then set to return <see cref="NotImplementedException"/>,
/// and only methods used by the scenario are made to work (such as Input,
/// and Scene Traversal mechanisms)
/// </summary>
namespace FL_UnityEngine
{
    public partial class Camera
    {
        //
        // Summary:
        //     The first enabled camera tagged "MainCamera" (Read Only).
        public static Camera main => null;
    }
}