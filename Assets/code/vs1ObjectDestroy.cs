using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vs1ObjectDestroy : MonoBehaviour
{

    public int NeedDestroyLv;
    public int AddScore = 10;
    /// <summary>
    /// �Փ˂�����
    /// </summary>
    /// <param name="collision"></param>
    void OnCollisionEnter(Collision collision)
    {
        PlayerLv playerLv;
        GameObject obj = GameObject.Find("Player1");
        playerLv = obj.GetComponent<PlayerLv>();


        // �Փ˂��������Player�^�O���t���Ă���Ƃ�
        if (collision.gameObject.tag == "Player" )
        {
            Vector3 currentPosition = transform.position;

            // Y���W��100����������
            currentPosition.y -= 100f;
            transform.position = currentPosition;

            playerLv.score += AddScore;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            PlayerLv playerLv;
            GameObject obj = GameObject.Find("Player1");
            playerLv = obj.GetComponent<PlayerLv>();

            // �Փ˂��������Player�^�O���t���Ă���Ƃ�
            if (col.gameObject.tag == "Player")
            {
                Vector3 currentPosition = transform.position;
                // Y���W��100����������
                currentPosition.y -= 100f;
                transform.position = currentPosition;

                playerLv.score += AddScore;
            }
        }
    }
}