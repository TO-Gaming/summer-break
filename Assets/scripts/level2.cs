using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2 : MonoBehaviour
{
	public GameObject platformPrefab1;
	public GameObject platformPrefab2;
	public GameObject platformPrefab3;
	public GameObject nextlevel;

	public int numberOfPlatforms = 200;
	//float easyWidth = 4f;
	float hardWidth = 6f;
	float minY = 2f;
	float maxY = 3f;



	// Use this for initialization
	void Start()
	{

		Vector3 spawnPosition = new Vector3();
		
		for (int i = 0; i < numberOfPlatforms; i++)
		{	
			int chance = Random.Range(1, 10);
			if (chance == 5 || chance == 8)
			{
				spawnPosition.y += Random.Range(minY, maxY);
				spawnPosition.x = Random.Range(-hardWidth, hardWidth);
				Instantiate(platformPrefab2, spawnPosition, Quaternion.Euler(0, 0, -30));
			}
			else if (chance == 2)
			{
					spawnPosition.y += Random.Range(minY, maxY);
					spawnPosition.x = Random.Range(-hardWidth, hardWidth);
					Instantiate(platformPrefab3, spawnPosition, Quaternion.Euler(0, 0, -30));
			}
			else
			{
				spawnPosition.y += Random.Range(minY, maxY);
				spawnPosition.x = Random.Range(-hardWidth, hardWidth);
				Instantiate(platformPrefab1, spawnPosition, Quaternion.Euler(0, 0, -30));
			}

		}
		spawnPosition.y += 3;
		Instantiate(nextlevel, spawnPosition, Quaternion.Euler(0, 0, -30));
	}
}
