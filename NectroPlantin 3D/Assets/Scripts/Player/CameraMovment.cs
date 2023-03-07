using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    Transform player;
    public float mouseSens;


    private void Awake()
    {
        Cursor.visible = false;
        player = transform;
    }

    void Update()
    {
        checkForInput();
    }

    void checkForInput()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        player.Rotate(Vector3.up,mouseX);
    }
}
