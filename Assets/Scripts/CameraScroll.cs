using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{

	private float _amountChange = 150;
	private void Update()
	{
		if (Input.GetAxis("Mouse ScrollWheel") > 0)
		{
			Camera.main.fieldOfView -= _amountChange * Time.deltaTime;
		}

		if (Input.GetAxis("Mouse ScrollWheel") < 0)
		{
			Camera.main.fieldOfView += _amountChange * Time.deltaTime;
		}
	}
}
