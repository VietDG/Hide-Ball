using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    void Awake()
    {
        Application.targetFrameRate = 60;
        DontDestroyOnLoad(this);
    }
}
