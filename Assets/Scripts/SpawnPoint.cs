using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    // Hadouken（弾）のプレハブを呼び出す
    public GameObject HadoukenPrefab;

    // HadoukenPrefab に Rigidbody2D がアタッチされている前提
    public float hadoukenSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        // Vが押されたらHadouken（弾）のプレハブが出現する
        if (Input.GetKeyDown(KeyCode.V))
        {
            GameObject hadouken = Instantiate(HadoukenPrefab, transform.position, Quaternion.identity);

            // プレイヤーの向きを取得
            float playerDirection = transform.localScale.x;

            // 弾の初期速度を設定
            Rigidbody2D hadoukenRB = hadouken.GetComponent<Rigidbody2D>();
            if (hadoukenRB != null)
            {
                // プレイヤーの向きに応じて初期速度を設定
                hadoukenRB.velocity = new Vector2(hadoukenSpeed * playerDirection, 0f);
            }
        }
    }
}