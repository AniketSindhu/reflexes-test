using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class flags : MonoBehaviour
{
   public float speed;
     int score;
    void Update()
    {
        transform.Translate(Vector2.left*speed*Time.deltaTime);
    }
         private void OnTriggerEnter2D(Collider2D other) 
        {    
         if (other.CompareTag("Player"))
        {Debug.Log(score);
        SceneManager.LoadScene(2);
        }
        else if(other.tag==gameObject.tag)
        {       
            Destroy(other.gameObject);
            Destroy (gameObject);
            score=score+1;
        }

        else{
            Debug.Log(score);
            SceneManager.LoadScene(2);
        }
        
    
    }
}

