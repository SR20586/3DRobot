using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneChange : MonoBehaviour
{
    public string sceneName;
    public void OnPushedButton()
    {
        SceneManager.LoadScene(sceneName);
    }
    void Start()
    {
        this.gameObject.SetActive(false);
        Invoke("ActivateGameObject", 11.5f);
    }
    
        void ActivateGameObject()
        {
            this.gameObject.SetActive(true);
    }
}
