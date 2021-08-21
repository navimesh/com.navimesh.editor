using System.Collections;
using System;
using System.Collections.Generic;
using UnityEditor;

[InitializeOnLoad]
public class AutoSetJAVA_HOME : Editor
{
    static AutoSetJAVA_HOME()
    {
        string newJDKPath = EditorApplication.applicationPath.Replace("Unity.exe", "Data/PlaybackEngines/AndroidPlayer/OpenJDK");

        if (Environment.GetEnvironmentVariable("JAVA_HOME") != newJDKPath)
        {
            Environment.SetEnvironmentVariable("JAVA_HOME", newJDKPath);
        }
    }
}