using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCameraOnCanvasRenderCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Canvas canvas = gameObject.GetComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceCamera;
        canvas.worldCamera = GameObject.FindGameObjectWithTag("CameraUI").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
