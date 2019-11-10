 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OBSTACLE_Spawn : MonoBehaviour
{
    public float First_Spawn;
    public float timebtSpawn;

    public GameObject[] Obstacles;
    
void Start () 
{ Scene currentscene=SceneManager.GetActiveScene();
  string m=currentscene.name;              
    if(m=="game")
     InvokeRepeating ("spawn", First_Spawn,timebtSpawn);
 }
     void spawn()
    {
        int rand=Random.Range(0,Obstacles.Length);
        Instantiate(Obstacles[rand],transform.position,Quaternion.identity);
            
         }
      
    }

