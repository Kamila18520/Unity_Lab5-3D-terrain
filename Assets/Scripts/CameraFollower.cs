using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public float rotationSpeed = 5.0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {

        //transform.Rotate(-Input.GetAxis("Mouse Y") * rotationSpeed, Input.GetAxis("Mouse X") * rotationSpeed, 0);
        transform.eulerAngles += rotationSpeed * new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);

    }
}
