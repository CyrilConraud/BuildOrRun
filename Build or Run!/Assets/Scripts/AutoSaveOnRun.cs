#if UNITY_EDITOR

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AutoSaveOnRun : MonoBehaviour
{

    static AutoSaveOnRun()
    {
        EditorApplication.playmodeStateChanged = () =>
        {
            if (EditorApplication.isPlayingOrWillChangePlaymode && !EditorApplication.isPlaying)
            {
                //Debug.Log("Auto-Saving scene before entering Play mode: " + EditorApplication.currentScene);

                EditorApplication.SaveScene();
                AssetDatabase.SaveAssets();
            }
        };
    }
}

#endif