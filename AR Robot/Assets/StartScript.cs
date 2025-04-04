using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class StartScript : MonoBehaviour
{
    public VideoPlayer mPlayer;
    
    // Start is called before the first frame update
    public void OnClickedButton()
    {
        mPlayer.time = 16f;
        mPlayer.Play();
    }
}
