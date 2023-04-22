using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookField : MonoBehaviour
{
	[SerializeField]
	GameObject LookTarget;


	void Update()
	{
		if (LookTarget)
		{
			var direction = LookTarget.transform.position - transform.position;
			direction.y = 0;

			var lookRotation = Quaternion.LookRotation(direction, Vector3.up);
			transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, 0.1f);
		}
	}
}
