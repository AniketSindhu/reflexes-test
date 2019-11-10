using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLAG_NAMES : MonoBehaviour
{
   public float speed;
    void Update()
    {
        transform.Translate(Vector2.right*speed*Time.deltaTime);
    }
}
