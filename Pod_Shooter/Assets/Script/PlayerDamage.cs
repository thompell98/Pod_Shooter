using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour, Damagable {

    PlayerLife playerLife;
	// Use this for initialization
	void Start () {
        playerLife = GetComponent<PlayerLife>();
	}
	
    public void DealDamage(int damage)
    {
        playerLife.TakeDamage(damage);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
