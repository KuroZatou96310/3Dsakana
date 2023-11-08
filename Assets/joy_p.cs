using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joy_p : MonoBehaviour
{
    public float moveSpeed = 5.0f; // �ړ����x
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
        float depthInput = Input.GetAxis("Vertical "+ player_No); // Z�������̓���

        // ���E���W��X�������̈ړ��x�N�g�����v�Z
        Vector3 movement = new Vector3(-horizontalInput, 0.0f, 0.0f);

        // ���̂ɐ��E���W��X�������ɗ͂�������
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);


        // ���E���W��X���AY���A�����Z�������̈ړ��x�N�g�����v�Z
        Vector3 movement2 = new Vector3(0.0f, 0.0f, -depthInput);

        // ���̂ɐ��E���W��X���AY���A�����Z�������ɗ͂�������
         transform.Translate(movement2 * moveSpeed * Time.deltaTime, Space.World);
    }
}
