using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAudio : MonoBehaviour
{
    public AudioSource audioSource; // オーディオソース
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // オーディオソースを取得
    }

    // Update is called once per frame
    public void OnButonPushed()
    {
        audioSource.Play(); // オーディオを再生
    }
}
