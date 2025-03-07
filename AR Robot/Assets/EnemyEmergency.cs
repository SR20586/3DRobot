using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEmergency : MonoBehaviour
{
    public AudioSource audioSource; // オーディオソース

    

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // オーディオソースを取得
    }

    void OnTriggerEnter(Collider collision) //ぶつかったら消える命令文開始
    {
        if (collision.CompareTag("Destroy2")) //ぶつかった相手がDestroy2だったら
        {
            audioSource.Play(); // オーディオを再生
        }
    }
}
