using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneController
{
    public static void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        // Debug.Log("Load Scene:" + sceneName);
    }
}
