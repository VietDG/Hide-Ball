using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    void Awake()
    {
#if !UNITY_EDITOR
                Application.targetFrameRate = 60;
#endif
        DontDestroyOnLoad(this);
    }
}
