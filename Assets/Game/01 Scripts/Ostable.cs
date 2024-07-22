using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ostable : MonoBehaviour
{
    Rigidbody2D _rb;

    private void Start()
    {
        _rb = this.GetComponent<Rigidbody2D>();
    }

    public void Movement()
    {
        _rb.bodyType = RigidbodyType2D.Dynamic;
    }

    public void Stop()
    {
        _rb.bodyType = RigidbodyType2D.Static;
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Destroy"))
    //    {
    //        this.gameObject.SetActive(false);
    //    }
    //}
}
