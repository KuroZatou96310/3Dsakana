using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tp_Title4 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Joystick4Button8))
        {
            SceneManager.LoadScene("SampleScene");
        }
        
        if (Input.GetKey(KeyCode.Joystick4Button9))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
