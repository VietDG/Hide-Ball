using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxTap : MonoBehaviour
{
    public void OnClickButtonUI()
    {
        SoundManager.Instance.PlayUIButtonClick();
    }
}
