using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P4_kasoku : MonoBehaviour
{
    public float accelerationAmount = 10.0f;  // ������
    private Rigidbody rb;
    private float lastAccelerationTime;      // �Ō�̉����̎���

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        lastAccelerationTime = -10.0f; // �Q�[���J�n����10�b�ԉ����ł��Ȃ��悤�ɂ��邽�߂ɁA�ŏ��̎��Ԃ�ݒ�
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
        // �Ō�̉�������10�b�ȏ�o���Ă��邩���m�F
        return (Time.time - lastAccelerationTime) >= 10.0f;
    }

    private void Accelerate()
    {
        // �����������s��
        rb.AddForce(transform.forward * accelerationAmount, ForceMode.VelocityChange);

        // �Ō�̉����̎��Ԃ��X�V
        lastAccelerationTime = Time.time;
    }
}
