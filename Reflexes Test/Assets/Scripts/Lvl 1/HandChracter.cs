using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandChracter : MonoBehaviour
{
    public GameObject [] gestures;
        void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(gestures[0],transform.position, Quaternion.identity);
        }else if(Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(gestures[1],transform.position, Quaternion.identity);
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(gestures[2],transform.position, Quaternion.identity);
        }
    }
}
