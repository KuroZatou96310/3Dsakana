using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winer : MonoBehaviour
{
    public string playerTag = "Player"; // �v���C���[�^�O�̖��O
    private int playerCount = 0; // �v���C���[�̐����i�[����ϐ�

    public Transform player2;

    private Transform kingTransform;
    private int TF = 0;

    private void Start()
    {
    }

    private void Update()
    {
        // �V�[�����̂��ׂẴQ�[���I�u�W�F�N�g���擾
        GameObject[] allGameObjects = GameObject.FindObjectsOfType<GameObject>();

        // �v���C���[�^�O�����Ă���AY����0�ȏ�ɂ���Q�[���I�u�W�F�N�g���J�E���g
        foreach (GameObject obj in allGameObjects)
        {
            if (obj.CompareTag(playerTag) && obj.transform.position.y >= 0)
            {
                playerCount++;
            }
        }

        // �v���C���[�̐���\��
        if (playerCount == 1)
        {
            GameObject[] playerObjects = GameObject.FindGameObjectsWithTag("Player");
            foreach (GameObject playerObject in playerObjects)
            {
                if (playerObject.transform.position.y >= 0)
                {
                    // y���W��0�ȏ�̃I�u�W�F�N�g�̖��O���擾���ĕ\��
                    string playerName = playerObject.name;
                    Debug.Log("Player�̖��O: " + playerName);

                    if (playerName == "Player1" && TF == 0)
                    {
                        kingTransform = GameObject.Find("king1").transform;

                        Vector3 newPosition = kingTransform.position;
                        newPosition.y = 0.3f;
                        kingTransform.position = newPosition;

                        TF = 1;
                    }

                    if (playerName == "Player2" && TF == 0)
                    {
                        kingTransform = GameObject.Find("king2").transform;

                        Vector3 newPosition = kingTransform.position;
                        newPosition.y = 0.3f;
                        kingTransform.position = newPosition;

                        TF = 1;
                    }

                    if (playerName == "Player3" && TF == 0)
                    {
                        kingTransform = GameObject.Find("king3").transform;
                        Vector3 newPosition = kingTransform.position;
                        newPosition.y = 0.3f;
                        kingTransform.position = newPosition;

                        TF = 1;
                    }

                    if (playerName == "Player4" && TF == 0)
                    {
                        kingTransform = GameObject.Find("king4").transform;
                        Vector3 newPosition = kingTransform.position;
                        newPosition.y = 0.3f;
                        kingTransform.position = newPosition;

                        TF = 1;
                    }
                }
            }
        }


                // �J�E���g�����Z�b�g
                playerCount = 0;
    }
}

