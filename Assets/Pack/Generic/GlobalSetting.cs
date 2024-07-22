using UnityEngine;

public class GlobalSetting : MonoBehaviour
{
    private void Awake()
    {
#if !UNITY_EDITOR
        Application.targetFrameRate = 60;

        Input.multiTouchEnabled = false;
#endif
        DontDestroyOnLoad(gameObject);
    }

    public static bool NetWorkRequirements()
    {
        return Application.internetReachability != NetworkReachability.NotReachable;
    }

    public static AudioClip GetSFX(string audioName)
    {
        //  Debug.Log(Resources.Load<AudioClip>("SFX/" + audioName));
        return Resources.Load<AudioClip>("SFX/" + audioName);
    }

    public bool CheckConnectNetwork()
    {
        if (!NetWorkRequirements())
        {
            //  PopupErrorNetwork.Instance.Show();
            return false;
        }
        else
        {
            return true;
        }
    }
}