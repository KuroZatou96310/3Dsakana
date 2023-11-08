using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tp_Title3 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Joystick3Button8))
        {
            SceneManager.LoadScene("SampleScene");
        }
        
        if (Input.GetKey(KeyCode.Joystick3Button9))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
