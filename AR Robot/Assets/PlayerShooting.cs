using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // 弾のプレハブ
    public Transform firePoint; // 発射位置
    public float bulletSpeed = 20f; // 弾の速度

    public void Shooting()
    {
        Shoot();
    }

    void Shoot()
    {
        // 弾を発射位置に生成
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // 弾の Rigidbody に力を加えて発射
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = firePoint.forward * bulletSpeed;
        }

        // 必要であれば一定時間後に弾を削除
        Destroy(bullet, 3f);
    }
    private void OnCollisionEnter(Collision collision) //ぶつかったら消える命令文開始
    {
        if (collision.gameObject.CompareTag("Destroy2"))//さっきつけたTagutukeruというタグがあるオブジェクト限定で～という条件の下
        {
            Destroy(gameObject);//このゲームオブジェクトを消滅させる
        }
    }
}
