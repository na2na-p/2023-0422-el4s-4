using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldImpact : MonoBehaviour
{
	[SerializeField]
	Transform[] FieldTransforms;

	[SerializeField]
	float DefaultImpactVolume;


	Rigidbody Rigidbody;


	// 距離を10で区切って　-10　して距離が近ければ大きくする
	const float LIMIT_LENGTH = 10;

	void Start()
	{


		Rigidbody = GetComponent<Rigidbody>();


	}


	void Update()
	{
		// 左奥
		KeyEvent(KeyCode.Q, KeyCode.U, 0, new Vector3( 1.0f, 0.0f, -1.0f));
		// 右奥
		KeyEvent(KeyCode.W, KeyCode.I, 1, new Vector3(-1.0f, 0.0f, -1.0f));
		// 左手前
		KeyEvent(KeyCode.X, KeyCode.M, 2, new Vector3(-1.0f, 0.0f,  1.0f));
		// 右手前
		KeyEvent(KeyCode.Z, KeyCode.N, 3, new Vector3( 1.0f, 0.0f,  1.0f));




	}


	void KeyEvent(KeyCode keyCode1, KeyCode keyCode2, int fieldPointIndex, Vector3 impactVector)
  {
		if (Input.GetKeyDown(keyCode1) || Input.GetKeyDown(keyCode2))
		{
			float lengthVolume = 0.0f;



			// 入力fieldからの自分との距離
			lengthVolume = Vector2.Distance(
				new Vector2(transform.position.x, transform.position.z),
				new Vector2(FieldTransforms[fieldPointIndex].position.x, FieldTransforms[fieldPointIndex].position.z)
				);

			// 距離制限
			lengthVolume = Mathf.Clamp(lengthVolume, 0.0f, LIMIT_LENGTH);

			// 距離が近ければ、値を大きくする
			lengthVolume = Mathf.Abs(LIMIT_LENGTH - lengthVolume);

			Rigidbody.AddForce(impactVector * DefaultImpactVolume * lengthVolume);

			Debug.Log("キーダウン");
			Debug.Log("impactVector" + impactVector);
			
		}
	}


}
