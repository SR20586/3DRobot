using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEmergency : MonoBehaviour
{
    public Transform[] enemies; // ロボット（敵）の Transform をリストで管理
    public float displayDistance = 5f; // 画像を表示する距離
    public GameObject imageObject; // 表示する UI Image オブジェクト

    void Update()
    {
        if (enemies == null || imageObject == null) return;

        // 全ての敵との距離をチェック
        foreach (Transform enemy in enemies)
        {
            if (enemy == null) continue;

            // 敵との距離を計算
            float distance = Vector3.Distance(transform.position, enemy.position);

            // 近づいた場合に画像を表示
            if (distance <= displayDistance)
            {
                imageObject.SetActive(true); // 画像を表示
                return; // 一つの敵が条件を満たしたら処理を終了
            }
        }

        // どの敵も距離内にいない場合は画像を非表示
        imageObject.SetActive(false);
    }
}
