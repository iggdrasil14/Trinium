using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamepadTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button0))         // ������� �  
        {
            Debug.Log("������� �");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button1))         // ������� B
        {
            Debug.Log("������� B");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button2))         // ������� X
        {
            Debug.Log("������� X");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button3))         // ������� Y
        {
            Debug.Log("������� Y");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button4))         // ������� LB
        {
            Debug.Log("������� Left Bumper");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button5))         // ������� RB
        {
            Debug.Log("������� Right Bumper");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button6))         // ������� Back
        {
            Debug.Log("������� Back");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button7))         // ������� Start
        {
            Debug.Log("������� Start");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button8))         // ������� LSC
        {
            Debug.Log("������� Left Stick click");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button9))         // ������� RSC
        {
            Debug.Log("������� Right Stick click");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button10))
        {
            Debug.Log("������� 10");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button11))
        {
            Debug.Log("������� 11");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button12))
        {
            Debug.Log("������� 12");
        }
    }
}
