using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldImpact : MonoBehaviour
{
	[SerializeField]
	FieldButton[] FieldButton;

	[SerializeField]
	float DefaultImpactVolume;


	Rigidbody Rigidbody;


	// 距離を10で区切って　- 10　して距離が近ければ大きくする
	const float MIN_POWER = 1.0f;
	const float MAX_LENGTH = 7.0f;

	void Start()
	{


		Rigidbody = GetComponent<Rigidbody>();


	}


	void Update()
	{
	if (MyGameManager.GameState != GameState.NowGame)
	{
			return;
	}


		// 左奥
		KeyEvent(KeyCode.Q, KeyCode.U, 0, new Vector3( 1.0f, 0.0f, -1.0f));
		// 右奥
		KeyEvent(KeyCode.W, KeyCode.I, 1, new Vector3(-1.0f, 0.0f, -1.0f));
		// 右手前
		KeyEvent(KeyCode.Z, KeyCode.N, 2, new Vector3( 1.0f, 0.0f,  1.0f));
		// 左手前
		KeyEvent(KeyCode.X, KeyCode.M, 3, new Vector3(-1.0f, 0.0f,  1.0f));




	}


	void KeyEvent(KeyCode keyCode1, KeyCode keyCode2, int fieldPointIndex, Vector3 impactVector)
  {
		if (Input.GetKeyDown(keyCode1) || Input.GetKeyDown(keyCode2))
		{
			float lengthVolume = 0.0f;

			// 入力fieldからの自分との距離
			lengthVolume = Vector2.Distance(
				new Vector2(transform.position.x, transform.position.z),
				new Vector2(FieldButton[fieldPointIndex].GetComponent<Transform>().position.x, FieldButton[fieldPointIndex].GetComponent<Transform>().position.z)
				);

			// 距離制限
			lengthVolume = Mathf.Clamp(lengthVolume, 0.0f, MAX_LENGTH);

			// 距離が近ければ、値を大きくする
			lengthVolume = Mathf.Abs(lengthVolume - MAX_LENGTH);

			// 威力距離制限
			lengthVolume = Mathf.Clamp(lengthVolume, MIN_POWER, MAX_LENGTH);


			Rigidbody.AddForce(impactVector * DefaultImpactVolume * lengthVolume);

			Debug.Log("lengthVolume" + lengthVolume);
			
		}

		if (Input.GetKeyDown(keyCode1))
		{
			// fieldのイベント
			FieldButton[fieldPointIndex].OnPushButtonEvent(Type.Player);
		}
		if (Input.GetKeyDown(keyCode2))
		{
			// fieldのイベント
			FieldButton[fieldPointIndex].OnPushButtonEvent(Type.Enemy);
		}


	}


}
