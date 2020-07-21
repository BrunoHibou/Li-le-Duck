using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1f;

    private void Update()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");

        if (inputHorizontal != 0)
        {
            transform.Translate(inputHorizontal*Vector3.right * _speed * Time.deltaTime);
        }
    }
}
