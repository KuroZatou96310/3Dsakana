using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tp_Title1 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Joystick1Button8))
        {
            SceneManager.LoadScene("SampleScene");
        }
        
        if (Input.GetKey(KeyCode.Joystick1Button9))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
