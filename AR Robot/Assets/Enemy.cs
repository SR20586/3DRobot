using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player; // 追いかけるターゲット（カメラ）
    public float speed = 3.0f; // 移動速度
    public float rotationSpeed = 5.0f; // 回転速度
    public float fireInterval = 2f;   // ビーム発射間隔
    public GameObject beamPrefab;     // ビームのプレハブ
    public Transform firePoint;       // 発射位置

    void Start()
    {
        // 一定間隔でビームを発射する
        StartCoroutine(FireBeam());
    }
    void Update()
    {

        if (player == null)
        {
            Debug.LogWarning("Player not assigned!");
            return;
        }

        // プレイヤーの方向を計算
        Vector3 direction = (player.position - transform.position).normalized;

        // 敵をプレイヤーの方向に移動させる
        transform.position += direction * speed * Time.deltaTime;

        // 敵をプレイヤーの方向に向ける（オプション）
        Vector3 directionToPlayer = transform.position - player.position; // プレイヤーから離れる方向
        transform.rotation = Quaternion.LookRotation(directionToPlayer);
    }
    private void OnTriggerEnter(Collider other) //ぶつかったら消える命令文開始
    {
        GameObject BulletObject = GameObject.Find("Cube(Clone)");

        if (other.gameObject.CompareTag("Destroy2"))//さっきつけたTagutukeruというタグがあるオブジェクト限定で～という条件の下
        {
            Destroy(BulletObject);//このゲームオブジェクトを消滅させる
        }
    }
    IEnumerator FireBeam()
    {
        while (true)
        {
            yield return new WaitForSeconds(fireInterval);

            if (beamPrefab != null && firePoint != null)
            {
                // ビームを生成し、前方に発射
                GameObject beam = Instantiate(beamPrefab, firePoint.position, firePoint.rotation);
                beam.transform.rotation = firePoint.rotation * Quaternion.Euler(0, 180f, 0);
                // ビームのRigidbodyを取得して前方に移動させる
                Rigidbody rb = beam.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.velocity = beam.transform.forward * 10f; // speedは好きな値
                }
                Destroy(beam, 1f); // 1秒後にビームを消す
            }
        }
    }
}
