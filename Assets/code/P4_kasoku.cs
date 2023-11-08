using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P4_kasoku : MonoBehaviour
{
    public float accelerationAmount = 10.0f;  // 加速量
    private Rigidbody rb;
    private float lastAccelerationTime;      // 最後の加速の時間

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        lastAccelerationTime = -10.0f; // ゲーム開始から10秒間加速できないようにするために、最初の時間を設定
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Joystick4Button0) && CanAccelerate())
        {
            Accelerate();
        }
    }

    private bool CanAccelerate()
    {
        // 最後の加速から10秒以上経っているかを確認
        return (Time.time - lastAccelerationTime) >= 10.0f;
    }

    private void Accelerate()
    {
        // 加速処理を行う
        rb.AddForce(transform.forward * accelerationAmount, ForceMode.VelocityChange);

        // 最後の加速の時間を更新
        lastAccelerationTime = Time.time;
    }
}
