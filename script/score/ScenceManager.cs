using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenceManager : MonoBehaviour {


    float restartTime;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (playermovement.currentHealth <= 0)
        {
            restartTime += Time.deltaTime;
        }

    }
}
