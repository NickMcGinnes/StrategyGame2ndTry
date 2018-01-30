using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class HorribleAnnihilationSphere : MonoBehaviour
{
	public string[] AnnihilationTags;
	public float Damage = 2.0f;
	
	private void OnCollisionEnter(Collision other)
	{
		foreach (string eachTag in AnnihilationTags)
		{
			if (other.collider.CompareTag(eachTag))
			{
				other.gameObject.GetComponent<ShipHealth>().Hit(Damage);
				Destroy(gameObject);
				return;
			}
		}	
	}
}
