using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
#if UNITY_EDITOR
    public const string path = "Assets/Game/Data/JsonText/PlayerData";
#else
    public static string path = Application.persistentDataPath;
#endif
    public static UserData userData = new UserData();

    private void Start()
    {

    }

    public void Load()
    {

    }

    public void Save()
    {

    }
}
