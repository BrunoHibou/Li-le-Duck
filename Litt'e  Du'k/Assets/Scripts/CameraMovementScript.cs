using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;

    private void Start()
    {
        _player = GameObject.Find("Player");
    }

    private void LateUpdate()
    {
        if (_player)
        {
            Vector3 newPosition = _player.transform.position;
            transform.position = new Vector3(Mathf.Clamp(newPosition.x, -2.5f, 2.5f), 0, -10);

        }
    }
}
