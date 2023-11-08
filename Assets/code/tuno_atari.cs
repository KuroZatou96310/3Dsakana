using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuno_atari : MonoBehaviour
{
    public int player_Noo = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        // 衝突したコライダーのゲームオブジェクトの名前が "tuno + player_Noo" であるかを確認
        if (other.gameObject.name == "tunoP" + player_Noo)
        {
            // 現在のプレイヤーオブジェクトの位置を取得
            Vector3 currentPosition = transform.position;

            // Y軸方向に-100ユニット移動
            currentPosition.y -= 100f;

            // プレイヤーオブジェクトの位置を更新
            transform.position = currentPosition;
        }
    }
}