using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyTracker : MonoBehaviour
{
    public string enemyName; // 追尾する敵の名前
    public Image trackingImage; // ロックオンUI（画像）
    public BoxCollider detectionArea; // 3Dの判定エリア

    private Transform enemy;
    private bool isTracking = false;

    private void Start()
    {
        // 画像を最初は非表示
        trackingImage.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (enemy != null && other.transform == enemy)
        {
            Debug.Log("Image True");
            isTracking = true;
            trackingImage.enabled = true; // 敵が範囲に入ったら表示
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (enemy != null && other.transform == enemy)
        {
            isTracking = false;
            trackingImage.enabled = false; // 範囲外なら非表示
        }
    }

    private void Update()
    {
        GameObject enemyObject = GameObject.Find(enemyName);
        if (enemyObject != null)
        {
            enemy = enemyObject.transform;
        }

        if (isTracking && enemy != null)
        {
            UpdateTrackingUI();
        }
    }

    private void UpdateTrackingUI()
    {
        // 敵の位置にUIを移動
        Vector3 screenPos = Camera.main.WorldToScreenPoint(enemy.position);
        trackingImage.rectTransform.position = screenPos;

        // 敵の方向を計算し回転（3D対応）
        Vector3 direction = enemy.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        trackingImage.rectTransform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
