using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WINNER
{
	PYALER = 1,
	ENEMY
	//DRAW
}

public class Juge : MonoBehaviour
{
	[SerializeField] CountDown CountDown;
	[SerializeField] ResultButton ResultButton;
	public bool IsOnce { get; set; }

	// Start is called before the first frame update
	void Start()
	{
		IsOnce = false;
	}

	// Update is called once per frame
	void Update()
	{
		if (IsOnce) return;
		if (MyGameManager.GameState == GameState.Finish)
		{
			ResultButton.SetResult((int)Judgement());
			IsOnce = true;
		}
	}



	public WINNER Judgement()
	{
		Vector3 PlA = GameObject.FindGameObjectWithTag("Player").transform.position;
		Vector3 PlB = GameObject.FindGameObjectWithTag("Enemy").transform.position;
		Vector3 CenP = GameObject.FindGameObjectWithTag("Field").transform.position;

		float PlALen = (PlA.x - CenP.x) * (PlA.x - CenP.x) + (PlA.y - CenP.y) * (PlA.y - CenP.y);
		float PlBLen = (PlB.x - CenP.x) * (PlB.x - CenP.x) + (PlB.y - CenP.y) * (PlB.y - CenP.y);



		if (PlALen < PlBLen)
		{
			return WINNER.PYALER;
		}
		else
		{
			return WINNER.ENEMY;
		}
		//引き分け無し
	}
	//END of Judge

}
