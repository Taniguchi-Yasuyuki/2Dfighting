using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int HP = 20;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�Փ˂��鑊��̃��C���[�����擾
        var layerName = LayerMask.LayerToName(collision.gameObject.layer);

        //RYU�Ƃ������C���[���̃I�u�W�F�N�g�Ƃ̓����蔻�������
        if (layerName == "RYU")
        {

            //�{�X��HP���P�����炷
            HP -= 1;

            //�{�X��HP���O�ɂȂ�����I�u�W�F�N�g������
            if (HP == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

}
