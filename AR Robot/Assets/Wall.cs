using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject imageObject; // 表示する UI Image オブジェクト
    // Start is called before the first frame update
    void Start()
    {
        imageObject.SetActive(false); // 画像を非表示
    }

    // Update is called once per frame
    public void  OnTriggerStay(Collider collision)
    {
        if (collision.CompareTag("Destroy2")) //ぶつかった相手がDestroy2だったら
        {
            imageObject.SetActive(true); // 画像を表示
        }
        else
        {
            imageObject.SetActive(false); // 画像を非表示
        }
    }
}
