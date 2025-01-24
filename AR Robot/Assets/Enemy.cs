using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform target; // 追いかけるターゲット（カメラ）
    public float speed = 3.0f; // 移動速度
    public float rotationSpeed = 5.0f; // 回転速度

    void Update()
    {
        if (target == null) return;

        // ターゲットの方向を計算
        Vector3 direction = (target.position - transform.position).normalized;

        // 敵の向きをゆっくりとターゲットに向ける
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        // ターゲットに向かって移動
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision) //ぶつかったら消える命令文開始
    {
        if (collision.gameObject.CompareTag("Destroy1"))//さっきつけたTagutukeruというタグがあるオブジェクト限定で～という条件の下
        {
            Destroy(gameObject);//このゲームオブジェクトを消滅させる
        }
    }
}
