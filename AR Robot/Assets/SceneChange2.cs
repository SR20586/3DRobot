using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange2 : MonoBehaviour
{
   public string sceneName;
    public void OnPushedButton()
    {
        SceneManager.LoadScene(sceneName);
    }
}
