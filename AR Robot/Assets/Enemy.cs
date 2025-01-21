using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform target; // 追いかけるターゲット（カメラやプレイヤー）
    public float speed = 3.0f; // 移動速度

    void Update()
    {
        if (target == null) return;

        // ターゲットへの方向を計算
        Vector3 direction = (target.position - transform.position).normalized;

        // 敵の向きをターゲットに向ける
        transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));

        // ターゲットに向かって移動
        transform.position += direction * speed * Time.deltaTime;
    }
}
