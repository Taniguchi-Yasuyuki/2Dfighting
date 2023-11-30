using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hadouken : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�E�֐i��
        Move(Vector2.right);

        //��ʊO�̈ʒu�܂Ői�񂾂������
        if (transform.position.x >= 2.0f)
        {
            Destroy(this.gameObject);
        }
    }

    private void Move(Vector3 moveDirection)
    {
        // �e�̍��W���擾
        var pos = transform.position;

        // �ړ����x�B������������
        var moveSpeed = 10;

        // �ړ����x�ƕ�������ړ��l�����ݒl�ɉ�����
        pos += moveDirection * moveSpeed * Time.deltaTime;

        // �e�̈ʒu�̍X�V
        transform.position = pos;
    }

}
