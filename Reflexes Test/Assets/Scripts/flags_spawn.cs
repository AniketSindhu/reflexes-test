using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class flags_spawn : MonoBehaviour

{
    public float First_Spawn;
    public float timebtSpawn;

    public GameObject[] flags;
    
void Start () 
{ Scene currentscene=SceneManager.GetActiveScene();
  string m=currentscene.name;              
    if(m=="Level 2")
     InvokeRepeating ("spawn", First_Spawn,timebtSpawn);
}
     void spawn()
    {
        int rand=Random.Range(0,flags.Length);
        Instantiate(flags[rand],transform.position,Quaternion.identity);
            
    }
      
    }

