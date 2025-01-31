using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player; // 追いかけるターゲット（カメラ）
    public float speed = 3.0f; // 移動速度
    public float rotationSpeed = 5.0f; // 回転速度

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
        transform.LookAt(player);
    }
    private void OnTriggerEnter(Collider other) //ぶつかったら消える命令文開始
    {
        GameObject BulletObject = GameObject.Find("Cube(Clone)");

        if (other.gameObject.CompareTag("Destroy2"))//さっきつけたTagutukeruというタグがあるオブジェクト限定で～という条件の下
        {
            Destroy(BulletObject);//このゲームオブジェクトを消滅させる
        }
    }
}
