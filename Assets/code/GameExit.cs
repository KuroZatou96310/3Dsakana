using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExit : MonoBehaviour
{
    void Update()
    {
        // ESC�L�[�������ꂽ��Q�[�����I��
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}

