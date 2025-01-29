using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEmergency : MonoBehaviour
{
    public GameObject imageObject; // 表示する UI Image オブジェクト
    public GameObject imageObject2; // 敵のプレハブ
    

    void Start()
    {
        imageObject.SetActive(false); // 画像を非表示
        imageObject2.SetActive(false); // 敵のプレハブを非表示
    }
    
    public void  OnTriggerStay(Collider collision)
    {
        if (collision.CompareTag("Destroy2")) //ぶつかった相手がDestroy2だったら
        {
            imageObject.SetActive(true); // 画像を表示
            imageObject2.SetActive(true); // 敵のプレハブを表示
        }
    }
}
