using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawn : MonoBehaviour
{
    public GameObject enemyPrefab; // 敵のプレハブ
    public float spawnInterval = 7f; // スポーン間隔
    public Vector3 spawnAreaSize = new Vector3(10f, 0f, 10f); // スポーンエリアのサイズ
    public Transform spawnCenter; // スポーンエリアの中心

    private float timer; // スポーンタイマー

    void Update()
    {
        // タイマーを更新
        timer += Time.deltaTime;

        // スポーン間隔を超えた場合、敵をスポーン
        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f; // タイマーをリセット
        }
    }

    void SpawnEnemy()
    {
        // スポーン範囲内のランダムな位置を計算
        Vector3 randomPosition = GetRandomPosition();

        // 敵をランダム位置に生成
        GameObject enemy = Instantiate(enemyPrefab, randomPosition, Quaternion.identity);

        // クローンのスクリプトを有効化
        var enemyFollowScript = enemy.GetComponent<BossProgram>();
        if (enemyFollowScript != null)
        {
            enemyFollowScript.enabled = true; // クローンのスクリプトを有効化
        }
    }

    Vector3 GetRandomPosition()
    {
        Vector3 randomOffset = new Vector3(
            Random.Range(-spawnAreaSize.x / 2, spawnAreaSize.x / 2),
            Random.Range(-spawnAreaSize.y / 2, spawnAreaSize.y / 2),
            Random.Range(-spawnAreaSize.z / 2, spawnAreaSize.z / 2)
        );
        return spawnCenter.position + randomOffset;
    }

    void OnDrawGizmosSelected()
    {
        // スポーン範囲を視覚的に確認できるようにする
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(spawnCenter.position, spawnAreaSize);
    }
}
