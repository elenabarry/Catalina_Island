using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Make a Third Person Camera and Movement Controller in 7 Minutes | Unity Tutorial (or Download), by Stephen Barr
    //(https://www.youtube.com/watch?v=7nxpDwnU0uU)
    //full script used and adapted to my game


    public float RotationSpeed = 1;
    public Transform Target, Player;
    float mouseX, mouseY;

    void Start()
    {

    }
    private void LateUpdate()
    {
   //     CamControl(); 
    }

    void CamControl()
    {
     //   mouseX += Input.GetAxis("Mouse X") * RotationSpeed;
     //   mouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;
     //   mouseY = Mathf.Clamp(mouseY, -15, 60);

        transform.LookAt(Target);

     //   Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
      //  Player.rotation = Quaternion.Euler(0, mouseX, 0);

    }


}
