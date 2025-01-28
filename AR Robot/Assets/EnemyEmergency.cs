using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEmergency : MonoBehaviour
{
    public GameObject imageObject; // 表示する UI Image オブジェクト
    public string targetObjectName;//ターゲットの名前

    void Start()
    {
        imageObject.SetActive(false); // 画像を非表示
    }
    
    public void  OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            imageObject.SetActive(true); // 画像を表示
        }
    }
}
