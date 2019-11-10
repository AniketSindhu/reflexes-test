using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class flags : MonoBehaviour
{   
    public static int score=0;
   public float initialspeed=3.5f;
   public float speed=0f;
   float multiplier=0.1f;
    void Update()
    {   speed=initialspeed+score*multiplier;
        transform.Translate(Vector2.left*speed*Time.deltaTime);
    }
         public void OnTriggerEnter2D(Collider2D other) 
        {    
         if (other.CompareTag("Player"))
        {Debug.Log(score);
        SceneManager.LoadScene(2);
        speed=0f;
        }
        else if(other.tag==gameObject.tag)
        {       
            Destroy(other.gameObject);
            Destroy (gameObject);
            score++;
            
        }

        else
        {
            Debug.Log(score);           
            SceneManager.LoadScene("Gameover");
            speed=0f;
        }
        
    
    }
}

