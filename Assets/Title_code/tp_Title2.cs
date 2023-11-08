using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tp_Title2 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Joystick2Button8))
        {
            SceneManager.LoadScene("SampleScene");
        }
        
        if (Input.GetKey(KeyCode.Joystick2Button9))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
