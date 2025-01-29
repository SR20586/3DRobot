using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public string targetObjectName;//ターゲットの名前
    
        public void OnTriggerEnter(Collider other) //ぶつかったら消える命令文開始
    {
        if (other.gameObject.name == "robot2(Clone)") //ぶつかった相手がrobot2(Clone)だったら
        {
            GameObject targetObject = GameObject.Find(targetObjectName);
            if (targetObject != null)
            {
                Destroy(targetObject); //robot2(Clone)を消す
            }
        }
    }
}
