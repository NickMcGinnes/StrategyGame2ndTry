using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{

	private float _amountChange = 150;

	private float _max = 65.0f;
	private float _min = 7.5f;
	private void Update()
	{
		if (Input.GetAxis("Mouse ScrollWheel") > 0)
		{
			if (Camera.main.fieldOfView > _min)
				Camera.main.fieldOfView -= _amountChange * Time.deltaTime;
			
			if (Camera.main.fieldOfView < _min)
				Camera.main.fieldOfView = _min;
		}

		if (Input.GetAxis("Mouse ScrollWheel") < 0)
		{
			
			if (Camera.main.fieldOfView < _max)
				Camera.main.fieldOfView += _amountChange * Time.deltaTime;
			
			if (Camera.main.fieldOfView > _max)
				Camera.main.fieldOfView = _max;
			
		}
	}
}
