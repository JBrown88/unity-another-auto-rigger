﻿using UnityEngine;
using UnityEditor;
using AnotherAutoRigger;

[CustomEditor(typeof(RuntimeMuscle))]
public class RuntimeMuscleEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        // get script
        RuntimeMuscle script = (RuntimeMuscle)target;

        // populate transforms
        if (script.originTransform == null)
            script.originTransform = script.GetComponentInGameObjectFromString<Transform>(script.origin);
        if (script.insertionTransform == null)
            script.insertionTransform = script.GetComponentInGameObjectFromString<Transform>(script.insertion);
    }
}