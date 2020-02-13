using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform[] spwanPonts;
    public GameObject[] Ememy;
    int randomSpawn, randomEnemy;
    public static bool spawnAllowed;
	// Use this for initialization
	void Start ()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnAEnemy", 0, 1);
	}
	
	// Update is called once per frame
    void SpawnAEnemy()
    {
        if(spawnAllowed)
        {
            randomSpawn = Random.Range(0, spwanPonts.Length);
            randomEnemy = Random.Range(0, Ememy.Length);
            Instantiate(Ememy[randomEnemy], spwanPonts[randomSpawn].position, Quaternion.identity);
        }
    }

    void Update ()
    {
		
	}
}
