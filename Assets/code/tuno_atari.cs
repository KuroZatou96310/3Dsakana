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
        // �Փ˂����R���C�_�[�̃Q�[���I�u�W�F�N�g�̖��O�� "tuno + player_Noo" �ł��邩���m�F
        if (other.gameObject.name == "tunoP" + player_Noo)
        {
            // ���݂̃v���C���[�I�u�W�F�N�g�̈ʒu���擾
            Vector3 currentPosition = transform.position;

            // Y��������-100���j�b�g�ړ�
            currentPosition.y -= 100f;

            // �v���C���[�I�u�W�F�N�g�̈ʒu���X�V
            transform.position = currentPosition;
        }
    }
}