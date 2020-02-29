using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform[] spwanPonts; //สร้างตัวแปรจุดspawnpoint แและกำหนดจุดตำแหน่งบนinspaecter
    public GameObject[] Ememy;  // สร้างgameobject enemy เก็บไว้
    int randomSpawn, randomEnemy; // เก็บตัวแปรrandom enemyและspawn
    public static bool spawnAllowed; //ตัวแปรควบคุม bool
	// Use this for initialization
	void Start ()
    {
        spawnAllowed = true; //bool เป็น true
        InvokeRepeating("SpawnAEnemy", 0, 1); //ทำซ้ำเมื่อstart 
	}
	
	// Update is called once per frame
    void SpawnAEnemy()  
    {
        if(spawnAllowed) //  spawnAllowed เป็นจริง random จุด spwanที่ตั้งไว้แล้วandom enemy 
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
