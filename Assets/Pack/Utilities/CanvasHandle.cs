using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CanvasHandle : MonoBehaviour
{
    private Canvas canvas;
    private GraphicRaycaster raycaster;
    private const string _layerName = "UI";

    //#if UNITY_EDITOR
    //    private void OnValidate()
    //    {
    //        canvas = this.AddComponent<Canvas>();
    //        raycaster = this.AddComponent<GraphicRaycaster>();
    //        Display();
    //    }
    //#endif

    // Start is called before the first frame update
    void Start()
    {
        canvas = this.AddComponent<Canvas>();
        raycaster = this.AddComponent<GraphicRaycaster>();
        Display();
    }

    public void Display()
    {
        canvas.overrideSorting = true;
        canvas.sortingLayerName = _layerName;
    }
}
