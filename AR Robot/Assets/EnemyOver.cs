using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyOver : MonoBehaviour
{
    
        public void OnTriggerEnter(Collider other) //ぶつかったら消える命令文開始
        {
            if (other.gameObject.CompareTag("Player"))//さっきつけたTagutukeruというタグがあるオブジェクト限定で～という条件の下
            {
                SceneManager.LoadScene("GameOver");
            }
            if (other.gameObject.CompareTag("Destroy1"))//さっきつけたTagutukeruというタグがあるオブジェクト限定で～という条件の下
            {
                Destroy(other.gameObject); //ぶつかったら消える命令文
            }
        }
}
