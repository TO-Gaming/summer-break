using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformdist : MonoBehaviour
{
	public float jump = 12f;
	//float timeBetweenSpawns = 2f;

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.relativeVelocity.y <= 0f)
		{
			Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
			if (rb != null)
			{
				Vector2 velocity = rb.velocity;
				velocity.y = jump;
				rb.velocity = velocity;
				//yield new WaitForSeconds(timeBetweenSpawns);
				Destroy(this.gameObject);
			}

		}
	}
}
