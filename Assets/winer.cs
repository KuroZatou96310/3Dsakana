using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winer : MonoBehaviour
{
    public string playerTag = "Player"; // プレイヤータグの名前
    private int playerCount = 0; // プレイヤーの数を格納する変数

    public Transform player2;

    private Transform kingTransform;
    private int TF = 0;

    private void Start()
    {
    }

    private void Update()
    {
        // シーン内のすべてのゲームオブジェクトを取得
        GameObject[] allGameObjects = GameObject.FindObjectsOfType<GameObject>();

        // プレイヤータグがついており、Y軸が0以上にいるゲームオブジェクトをカウント
        foreach (GameObject obj in allGameObjects)
        {
            if (obj.CompareTag(playerTag) && obj.transform.position.y >= 0)
            {
                playerCount++;
            }
        }

        // プレイヤーの数を表示
        if (playerCount == 1)
        {
            GameObject[] playerObjects = GameObject.FindGameObjectsWithTag("Player");
            foreach (GameObject playerObject in playerObjects)
            {
                if (playerObject.transform.position.y >= 0)
                {
                    // y座標が0以上のオブジェクトの名前を取得して表示
                    string playerName = playerObject.name;
                    Debug.Log("Playerの名前: " + playerName);

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


                // カウントをリセット
                playerCount = 0;
    }
}

