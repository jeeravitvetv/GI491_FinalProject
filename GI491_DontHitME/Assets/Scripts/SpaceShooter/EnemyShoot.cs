using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
	public GameObject projectile; //reference to the gameobject the enemy will shoot

	public Transform projectileSpawn; //reference to where the projectile will spawn...

	public float nextFire = 1.0f;
	public float currentTime = 0.0f;

	public GameManager gm;

	// Use this for initialization
	void Start()
	{
		projectileSpawn = this.gameObject.transform;
	}

	// Update is called once per frame
	void Update()
	{
        if (gm.gameOver)
        {
			return;
        }
		enemyShoot();
	}

	public void enemyShoot()
	{
		currentTime += Time.deltaTime;
		if (currentTime > nextFire)
		{
			nextFire += currentTime;

			Instantiate(projectile, projectileSpawn.position, Quaternion.identity); //FIRE!

			nextFire -= currentTime;
			currentTime = 0.0f;
		}
	}
}
