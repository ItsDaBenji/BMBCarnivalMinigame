using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMBPlayerController : MonoBehaviour
{

    [SerializeField] float mouseSensitivity;

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        transform.Rotate(mouseY, mouseX, 0f);
    }

}
