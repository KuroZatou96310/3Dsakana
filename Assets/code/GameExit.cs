using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExit : MonoBehaviour
{
    void Update()
    {
        // ESCキーが押されたらゲームを終了
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}

