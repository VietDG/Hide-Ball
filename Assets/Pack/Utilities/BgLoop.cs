using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgLoop : MonoBehaviour
{
    private RectTransform _currentRectTrans;
    [SerializeField] private Vector2 _target;
    [SerializeField] float _duration = 10f;

    private void Awake()
    {
        _currentRectTrans = this.GetComponent<RectTransform>();
    }

    private void OnDestroy()
    {
        _currentRectTrans.DOKill();
    }

    // Start is called before the first frame update
    void Start()
    {
        LoopBG();
    }

    private void LoopBG()
    {
        _currentRectTrans.DOAnchorPos(_target, _duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
    }
}
