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
	private bool IsFinish;
	private bool IsStart;

	// Start is called before the first frame update
	void Start()
	{
		CountDownTime = CountDownTimeMax;
		IsFinish = false;
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

		if (CountDownTime <= 0.0F)
		{
			CountDownTime = 0.0F;
			IsFinish = true;
			// if ()
			{

			}
		}
	}

	public bool GetIsFinish() { return IsFinish; }

	public void StartCountDown(float time)
	{
		IsStart = true;
		CountDownTime = time;
	}
}
