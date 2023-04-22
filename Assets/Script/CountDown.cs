using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDown : MonoBehaviour
{
	public static float CountDownTime;
	public TextMeshProUGUI TextCountDown;
	[SerializeField] float CountDownTimeMax = 60;
	private bool IsStart;

	// Start is called before the first frame update
	void Start()
	{
		CountDownTime = CountDownTimeMax;		
		IsStart = false;

		StartCountDown(3.0f);
	}

	// Update is called once per frame
	void Update()
	{
		// カウントダウンタイムを整形して表示
		TextCountDown.text = string.Format("{0:00.00}", CountDownTime);

		// 経過時刻を弾いていく
		CountDownTime -= Time.deltaTime;

		switch(MyGameManager.GameState)
	{
			case GameState.StartWait:
				Debug.Log("wait");
				break;
			case GameState.NowGame:
				Debug.Log("now");
				break;
			case GameState.Finish:
				Debug.Log("finish");
				break;
		}
		

		if (CountDownTime <= 0.0F)
		{
			CountDownTime = 0.0F;			
			if (MyGameManager.GameState == GameState.StartWait)
			{
				MyGameManager.GameState = GameState.NowGame;
				StartCountDown(CountDownTimeMax);
				return;
			}

			if (MyGameManager.GameState == GameState.NowGame)
			{
				MyGameManager.GameState = GameState.Finish;
				return;
			}
		}
	}


	public void StartCountDown(float time)
	{
		IsStart = true;
		CountDownTime = time;
	}
}
