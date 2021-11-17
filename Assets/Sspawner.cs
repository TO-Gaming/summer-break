using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sspawner : MonoBehaviour
{
	public GameObject ShwarmaPrefab;


	public int numberOfShwarmas = 200;
	float move = 4.5f;

	float minY = 5f;
	float maxY = 10f;



	// Use this for initialization
	void Start()
	{

		Vector3 spawnPosition = new Vector3();

		for (int i = 0; i < numberOfShwarmas; i++)
		{
			int chance = Random.Range(1, 3);
			if (i < 100)
			{
				if (chance == 1) spawnPosition.x = -move;
				else spawnPosition.x = move;
				spawnPosition.y += Random.Range(minY, maxY);
				Instantiate(ShwarmaPrefab, spawnPosition, Quaternion.Euler(0, 0, 0));


			}
			else
			{
				minY = 4f;
				maxY = 8f;
				if (chance == 1) spawnPosition.x = -move;
				else spawnPosition.x = move;
				spawnPosition.y += Random.Range(minY, maxY);
				Instantiate(ShwarmaPrefab, spawnPosition, Quaternion.Euler(0, 0, 0));
			}

		}
	}
}
