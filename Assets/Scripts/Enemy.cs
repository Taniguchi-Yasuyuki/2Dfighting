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
        //衝突する相手のレイヤー名を取得
        var layerName = LayerMask.LayerToName(collision.gameObject.layer);

        //RYUというレイヤー名のオブジェクトとの当たり判定を処理
        if (layerName == "RYU")
        {

            //ボスのHPを１ずつ減らす
            HP -= 1;

            //ボスのHPが０になったらオブジェクトを消す
            if (HP == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

}
