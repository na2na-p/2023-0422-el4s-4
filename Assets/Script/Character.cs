using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
	[SerializeField]
	Juge Juge;

	[SerializeField]
	WINNER TargetWinner;

	[SerializeField]
	ResultButton ResultButton;

	

	private void OnCollisionExit(Collision collision)
  {
	if (collision.gameObject.CompareTag("Field"))
	{
			ResultButton.SetResult((int)TargetWinner);
			Juge.IsOnce = true;
	}
  }

}
