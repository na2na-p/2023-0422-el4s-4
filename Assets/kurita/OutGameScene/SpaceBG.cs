using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceBG : MonoBehaviour
{
	float theta;
	// Start is called before the first frame update
	void Start()
	{
		theta = 0.0f;
	}

	// Update is called once per frame
	void Update()
	{
		Vector3 pos = this.transform.position;
		theta += 0.002f;
		pos.x = Mathf.Cos(theta * 0.2f)*60+450.0f;
		pos.y = Mathf.Sin(theta*3f*0.2f)*80+450.0f; 
		this.transform.position = pos;
	}
}
