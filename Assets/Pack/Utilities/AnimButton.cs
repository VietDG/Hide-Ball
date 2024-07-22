using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public enum AnimButtonType
{
    Scale,
    Move,
    None
}

public class AnimButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler, IPointerClickHandler
{
    [SerializeField] AnimButtonType _typeButton;
    [SerializeField] RectTransform _currenRect;
    [SerializeField] float _duration = 0.1f;
    [SerializeField] Vector2 _target;
    [HideInInspector][SerializeField] UnityEvent _onPointerDown;
    [HideInInspector][SerializeField] UnityEvent _onPointerUp;
    [SerializeField] UnityEvent _onPointerClick;
    [HideInInspector][SerializeField] UnityEvent _onPointerExit;
    private Vector2 _originalPos;
    private bool _canClick = true;
    private bool _isPointDown = false;

    private void Awake()
    {
        if (_typeButton.Equals(AnimButtonType.None)) return;
        _originalPos = _currenRect.anchoredPosition;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!_canClick) return;
        _canClick = false;
        ShowButton();
        _onPointerDown?.Invoke();
        _isPointDown = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (!_isPointDown) return;
        HideButton();
        _onPointerExit?.Invoke();
        _isPointDown = false;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        HideButton();
        _onPointerUp?.Invoke();
        _isPointDown = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _onPointerClick?.Invoke();
        _isPointDown = false;
    }

    private void ShowButton()
    {
        switch (_typeButton)
        {
            case AnimButtonType.Scale:
                _currenRect.DOScale(new Vector3(_target.x, _target.y, 1), _duration).SetEase(Ease.OutQuad);
                break;
            case AnimButtonType.Move:
                _currenRect.DOAnchorPos(_target, _duration).SetEase(Ease.OutQuad);
                break;
        }
    }

    private void HideButton()
    {
        switch (_typeButton)
        {
            case AnimButtonType.Scale:
                _currenRect.DOScale(1, _duration).SetEase(Ease.InQuad).OnComplete(() =>
                {
                    _canClick = true;
                });
                break;
            case AnimButtonType.Move:
                _currenRect.DOAnchorPos(_originalPos, _duration).SetEase(Ease.InQuad).OnComplete(() =>
                {
                    _canClick = true;
                });
                break;
        }
    }
}