using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum TypeItem
{
    Ball,
    HinhTron,
    HinhChuNhat,
    HinhVuong,
    Mai,

}

public class ItemColection : MonoBehaviour
{
    [Header("REFERENCE")]
    [SerializeField] SpriteRenderer _ava;
    [SerializeField] Sprite _hiddenAva;

    public PolygonCollider2D _boxColider;
    [Header("VALUE")]
    [SerializeField] float _jumPower;
    [SerializeField] float _duration;

    [SerializeField] CircleCollider2D _circleColider;

    Rigidbody2D _rb;

    private bool _isFirst;

    public TypeItem Type;

    private void Awake()
    {
        _rb = this.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Destroy"))
        {
            this.gameObject.SetActive(false);
            GameController.Instance.isLose = true;
            _boxColider.isTrigger = false;
            SetLose();
        }
        if (collision.CompareTag("ostable"))
        {
            _circleColider.isTrigger = false;
            SetLose();
        }
    }

    public void SetLose()
    {
        this._ava.color = Color.black;
        GameController.Instance.isLose = true;
        FunctionCommon.DelayTime(1f, () =>
        {
            SceneManager.LoadScene(Const.SCENE_GAME);
        });
    }

    private void OnMouseDown()
    {
        if (!IsOverlapped(this))
        {
            Debug.Log("Khong bi de len nay");
            GameController.Instance.OnClick(this);
        }
        else
        {
            Debug.Log("Bi de len roi an cai con ca'");
        }
    }

    bool IsOverlapped(ItemColection obj)
    {
        foreach (ItemColection otherObj in GameController.Instance.itemDicts.Keys)
        {
            if (otherObj != obj)
            {
                if (obj._ava.bounds.Intersects(otherObj._ava.bounds))
                {
                    return true;
                }
            }
        }

        return false;
    }

    public void Movement()
    {
        SetLayer("ball");
        _rb.bodyType = RigidbodyType2D.Dynamic;
    }

    public void SetLayer(string name)
    {
        this.gameObject.layer = LayerMask.NameToLayer(name);
    }
}
