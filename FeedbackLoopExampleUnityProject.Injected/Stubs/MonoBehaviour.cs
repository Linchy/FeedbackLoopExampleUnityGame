﻿using System;
using System.Collections;

/// <summary>
/// This file is provided so that unity engine classes can be swapped out
/// during running in a reloadable context, enabling runninf of game code
/// outside of the unity engine. The classes are generated by using the
/// 'Go to Definition' in VS, and copying out the definition into this file.
/// All methods and getters and then set to return <see cref="NotImplementedException"/>,
/// and only methods used by the scenario are made to work (such as Input,
/// and Scene Traversal mechanisms)
/// </summary>
namespace FL
{
    /// <summary>
    /// Replacement Class for <see cref="UnityEngine.MonoBehaviour" />
    /// </summary>
    public partial class MonoBehaviour : Behaviour
    {
        //
        // Summary:
        //     Disabling this lets you skip the GUI layout phase.
        public bool useGUILayout { get; set; }
        //
        // Summary:
        //     Allow a specific instance of a MonoBehaviour to run in edit mode (only available
        //     in the editor).
        public bool runInEditMode { get; set; }

        //
        // Summary:
        //     Logs message to the Unity Console (identical to Debug.Log).
        //
        // Parameters:
        //   message:
        public static void print(object message) => throw new NotImplementedException();
        //
        // Summary:
        //     Cancels all Invoke calls with name methodName on this behaviour.
        //
        // Parameters:
        //   methodName:
        public void CancelInvoke(string methodName) => throw new NotImplementedException();
        //
        // Summary:
        //     Cancels all Invoke calls on this MonoBehaviour.
        public void CancelInvoke() => throw new NotImplementedException();
        //
        // Summary:
        //     Invokes the method methodName in time seconds, then repeatedly every repeatRate
        //     seconds.
        //
        // Parameters:
        //   methodName:
        //
        //   time:
        //
        //   repeatRate:
        public void InvokeRepeating(string methodName, float time, float repeatRate) => throw new NotImplementedException();
        //
        // Summary:
        //     Is any invoke on methodName pending?
        //
        // Parameters:
        //   methodName:
        public bool IsInvoking(string methodName) => throw new NotImplementedException();
        //
        // Summary:
        //     Is any invoke pending on this MonoBehaviour?
        public bool IsInvoking() => throw new NotImplementedException();
        //
        // Summary:
        //     Starts a coroutine named methodName.
        //
        // Parameters:
        //   methodName:
        //
        //   value:
        public UnityEngine.Coroutine StartCoroutine(string methodName) => throw new NotImplementedException();
        //
        // Summary:
        //     Starts a coroutine.
        //
        // Parameters:
        //   routine:
        public UnityEngine.Coroutine StartCoroutine(IEnumerator routine) => throw new NotImplementedException();
        //
        // Summary:
        //     Starts a coroutine named methodName.
        //
        // Parameters:
        //   methodName:
        //
        //   value:
        public UnityEngine.Coroutine StartCoroutine(string methodName, object value) => throw new NotImplementedException();
        //
        // Summary:
        //     Stops all coroutines running on this behaviour.
        public void StopAllCoroutines() => throw new NotImplementedException();
        //
        // Summary:
        //     Stops the first coroutine named methodName, or the coroutine stored in routine
        //     running on this behaviour.
        //
        // Parameters:
        //   methodName:
        //     Name of coroutine.
        //
        //   routine:
        //     Name of the function in code, including coroutines.
        public void StopCoroutine(IEnumerator routine) => throw new NotImplementedException();
        //
        // Summary:
        //     Stops the first coroutine named methodName, or the coroutine stored in routine
        //     running on this behaviour.
        //
        // Parameters:
        //   methodName:
        //     Name of coroutine.
        //
        //   routine:
        //     Name of the function in code, including coroutines.
        public void StopCoroutine(UnityEngine.Coroutine routine) => throw new NotImplementedException();
        //
        // Summary:
        //     Stops the first coroutine named methodName, or the coroutine stored in routine
        //     running on this behaviour.
        //
        // Parameters:
        //   methodName:
        //     Name of coroutine.
        //
        //   routine:
        //     Name of the function in code, including coroutines.
        public void StopCoroutine(string methodName) => throw new NotImplementedException();
    }
}