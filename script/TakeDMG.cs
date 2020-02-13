using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDMG : MonoBehaviour
{
    public int MaxHp = 100;
    public int currentHp; /// Hp ปัจจัน
	// Use this for initialization
	void Start ()
    {
        currentHp = MaxHp;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public void PlayerTakeDMG(int Damage)
    {
        currentHp -= Damage;
    }
}
