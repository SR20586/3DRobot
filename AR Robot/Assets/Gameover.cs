using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    public void OnTriggerEnter(Collider other) //ぶつかったら消える命令文開始
    {
        if (other.gameObject.CompareTag("Destroy2"))//さっきつけたTagutukeruというタグがあるオブジェクト限定で～という条件の下
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
