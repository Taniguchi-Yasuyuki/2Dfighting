using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    // Hadouken�i�e�j�̃v���n�u���Ăяo��
    public GameObject HadoukenPrefab;

    // HadoukenPrefab �� Rigidbody2D ���A�^�b�`����Ă���O��
    public float hadoukenSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        // V�������ꂽ��Hadouken�i�e�j�̃v���n�u���o������
        if (Input.GetKeyDown(KeyCode.V))
        {
            GameObject hadouken = Instantiate(HadoukenPrefab, transform.position, Quaternion.identity);

            // �e�̏������x��ݒ�
            Rigidbody2D hadoukenRB = hadouken.GetComponent<Rigidbody2D>();
            if (hadoukenRB != null)
            {
                hadoukenRB.velocity = new Vector2(-hadoukenSpeed, 0f);
            }
        }
    }
}