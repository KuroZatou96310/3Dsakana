using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tp_Main2 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Joystick2Button8))
        {
            SceneManager.LoadScene("Title_Scene");
        }

        if (Input.GetKey(KeyCode.Joystick2Button9))
        {
            SceneManager.LoadScene("Title_Scene");
        }
    }
}
