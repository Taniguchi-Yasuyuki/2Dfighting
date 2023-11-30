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
        //右へ進む
        Move(Vector2.right);

        //画面外の位置まで進んだら消える
        if (transform.position.x >= 2.0f)
        {
            Destroy(this.gameObject);
        }
    }

    private void Move(Vector3 moveDirection)
    {
        // 弾の座標を取得
        var pos = transform.position;

        // 移動速度。けっこう速い
        var moveSpeed = 10;

        // 移動速度と方向から移動値を現在値に加える
        pos += moveDirection * moveSpeed * Time.deltaTime;

        // 弾の位置の更新
        transform.position = pos;
    }

}
