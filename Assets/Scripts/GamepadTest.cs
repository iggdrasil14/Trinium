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
        if (Input.GetKeyDown(KeyCode.Joystick1Button0))         // Клавиша А  
        {
            Debug.Log("Клавиша А");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button1))         // Клавиша B
        {
            Debug.Log("Клавиша B");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button2))         // Клавиша X
        {
            Debug.Log("Клавиша X");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button3))         // Клавиша Y
        {
            Debug.Log("Клавиша Y");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button4))         // Клавиша LB
        {
            Debug.Log("Клавиша Left Bumper");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button5))         // Клавиша RB
        {
            Debug.Log("Клавиша Right Bumper");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button6))         // Клавиша Back
        {
            Debug.Log("Клавиша Back");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button7))         // Клавиша Start
        {
            Debug.Log("Клавиша Start");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button8))         // Клавиша LSC
        {
            Debug.Log("Клавиша Left Stick click");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button9))         // Клавиша RSC
        {
            Debug.Log("Клавиша Right Stick click");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button10))
        {
            Debug.Log("Клавиша 10");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button11))
        {
            Debug.Log("Клавиша 11");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button12))
        {
            Debug.Log("Клавиша 12");
        }
    }
}
