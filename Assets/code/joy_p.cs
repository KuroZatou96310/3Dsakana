using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joy_p : MonoBehaviour
{
    public float moveSpeed = 5.0f; // 移動速度
    public int player_No = 1;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal "+player_No);

        float verticalInput = Input.GetAxis("Vertical "+ player_No);
        float depthInput = Input.GetAxis("Vertical "+ player_No); // Z軸方向の入力

        // 世界座標のX軸方向の移動ベクトルを計算
        Vector3 movement = new Vector3(-horizontalInput, 0.0f, 0.0f);

        // 物体に世界座標のX軸方向に力を加える
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);


        // 世界座標のX軸、Y軸、およびZ軸方向の移動ベクトルを計算
        Vector3 movement2 = new Vector3(0.0f, 0.0f, -depthInput);

        // 物体に世界座標のX軸、Y軸、およびZ軸方向に力を加える
         transform.Translate(movement2 * moveSpeed * Time.deltaTime, Space.World);
    }
}
