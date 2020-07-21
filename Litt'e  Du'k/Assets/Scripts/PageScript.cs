using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageScript : MonoBehaviour
{
    private Boolean pickable;
    [SerializeField]
    private RawImage _imagem;

    private void Start()
    {
        _imagem.enabled = false;
        
    }
    private void Update()
    {
        if (pickable == true && Input.GetKeyDown(KeyCode.E))
        {
            ShowPage();
        }
        if (_imagem.enabled && Input.anyKey)
        {
            _imagem.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            pickable = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            pickable = false;
        }
    }


    private void ShowPage()
    {
        _imagem.enabled = true;
        print("mostrando imagem");
    }
}
