using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    public void OnTriggerEnter(Collider other) //ぶつかったら消える命令文開始
    {
        SceneManager.LoadScene("GameOver");
    }
}
