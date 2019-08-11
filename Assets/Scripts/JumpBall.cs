using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBall : MonoBehaviour
{
    public float speed;
    [SerializeField]
    private bool isTop;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            if (isTop){
                Physics.gravity = new Vector3(0, -3f * speed, 0);
                isTop = false;
            }
            else if (!isTop){
                    Physics.gravity = new Vector3(0, 3f * speed, 0);
                    isTop = true;
            }
        }
    }
}
