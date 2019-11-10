using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlSelect : MonoBehaviour
{
   public void lvl_1()
        { 
            SceneManager.LoadScene(1);
        }
    public void lvl_2()
        { 
            SceneManager.LoadScene(2);
        }

}

