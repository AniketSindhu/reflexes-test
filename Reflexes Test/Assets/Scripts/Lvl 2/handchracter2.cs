using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handchracter2 : MonoBehaviour
{
    public GameObject [] flag_names;
        void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(flag_names[0],new Vector2(-6f,0.237f), Quaternion.identity);
        }else if(Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(flag_names[1],new Vector2(-6f,0.237f), Quaternion.identity);
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(flag_names[2],new Vector2(-6f,0.237f), Quaternion.identity);
        }
    }
}
