using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHealth : MonoBehaviour
{

	public float Health;

	public float Maxhealth;

	private void Start()
	{
		Health = Maxhealth;
	}

	public void Hit(float damage)
	{
		Health -= damage;

		if (Health < 0)
		{
			Destroy(gameObject);
		}
	}
}
