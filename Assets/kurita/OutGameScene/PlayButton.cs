using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
	// Start is called before the first frame update
	[SerializeField] TMPro.TextMeshProUGUI nextText;
	float theta;
	void Start()
    {

		theta = 0.0f;
		}

    // Update is called once per frame
    void Update()
    {

		Color col = nextText.color;
		col.a = Mathf.Sin(theta)*0.5f+0.5f;
		nextText.color = col;
		theta += 0.005f; 
		}
}
