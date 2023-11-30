using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // �e�̃v���n�u
    public Transform firePoint;     // ���ˈʒu
    public float bulletSpeed = 10f; // �e�̑���

    void Update()
    {
        // �X�y�[�X�L�[�������ꂽ��e�𔭎�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootBullet();
        }
    }

    void ShootBullet()
    {
        // �e�̐���
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // �e�ɑ�����^����i���E�ɔ��ˁj
        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();
        if (bulletRb != null)
        {
            bulletRb.velocity = transform.right * bulletSpeed; // �E�����ɔ���
        }
    }
}
