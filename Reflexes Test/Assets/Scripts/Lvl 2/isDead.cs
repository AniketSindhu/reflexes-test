using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isDead : MonoBehaviour
{    public GameObject RESTART_BUTTON;
    // Start is called before the first frame update
    void Start()
    {
         RESTART_BUTTON.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {    
         if (flags.isdead == true)
        {
            RESTART_BUTTON.gameObject.SetActive(true);
        }
    }
}
