using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class obstacles : MonoBehaviour
{
   public float speed;

   private void Update()
    {
        transform.Translate(Vector2.left*speed*Time.deltaTime);
    }
        private void OnTriggerEnter2D(Collider2D other) 
    {    
         if (other.CompareTag("Player"))
        {
        SceneManager.LoadScene(2);
        }
        else if(other.tag==gameObject.tag)
        {
            Destroy(other.gameObject);
            Destroy (gameObject);
        }

        else{
            SceneManager.LoadScene("Gameover");
        }
        
    }
    
}
