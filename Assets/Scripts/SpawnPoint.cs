using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class SpawnPoint : MonoBehaviour
{
    // Hadouken�i�e�j�̃v���n�u���Ăяo��
    public GameObject HadoukenPrefab;

    // HadoukenPrefab �� Rigidbody2D ���A�^�b�`����Ă���O��
    public float hadoukenSpeed = 10f;

    public Transform spawnPoint;

    // Update is called once per frame
    void Update()
    {
        // V�������ꂽ��Hadouken�i�e�j�̃v���n�u���o������
        if (Input.GetKeyDown(KeyCode.V))
        {
            GameObject hadouken = Instantiate(HadoukenPrefab, spawnPoint.transform.position, Quaternion.identity);

            // �v���C���[�̌������擾
            float playerDirection = transform.localScale.x;
            Debug.Log(playerDirection);

            // �e�̏������x��ݒ�
            Rigidbody2D hadoukenRB = hadouken.GetComponent<Rigidbody2D>();
            if (hadoukenRB != null)
            {
                Debug.Log(hadoukenSpeed * playerDirection);

                // �v���C���[�̌����ɉ����ď������x��ݒ�
                hadoukenRB.velocity = new Vector2(hadoukenSpeed * playerDirection, 0f);

                //�@�摜�̌������L�����ɍ��킹��
                Vector3 temp = hadouken.transform.localScale;
                temp.x = transform.localScale.x;
                hadouken.transform.localScale = temp;
            }
        }
    }
}