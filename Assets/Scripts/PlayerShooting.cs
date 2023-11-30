using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // 弾のプレハブ
    public Transform firePoint;     // 発射位置
    public float bulletSpeed = 10f; // 弾の速さ

    void Update()
    {
        // スペースキーが押されたら弾を発射
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootBullet();
        }
    }

    void ShootBullet()
    {
        // 弾の生成
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // 弾に速さを与える（左右に発射）
        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();
        if (bulletRb != null)
        {
            bulletRb.velocity = transform.right * bulletSpeed; // 右方向に発射
        }
    }
}
