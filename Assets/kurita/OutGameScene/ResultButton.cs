using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultButton: MonoBehaviour
{
	[SerializeField] TMPro.TextMeshProUGUI g_1PWin,g_2PWin;
	[SerializeField] TMPro.TextMeshProUGUI g_Next;
	List<TMPro.TextMeshProUGUI> g_TextList;

	bool isDisplayingResult;//現在リザルト表示中か
	float aloha;
	int g_Winner;

	// Start is called before the first frame update
	void Start()
	{
		g_Winner = 0;

		//画像非表示
		Color col = g_1PWin.color;
		aloha = 0.0f;
		col.a = 0.0f;
		g_1PWin.color = g_2PWin.color = g_Next.color = col; 

		//リザルト表示中の判定
		isDisplayingResult = false;


	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.A))
			SetResult(1);


		//リザルト中
		if (isDisplayingResult)
		{
			//タイトルへ戻る
			if (Input.GetKeyDown(KeyCode.Space))
			{
				SceneManager.LoadScene("Title");
				return;
			}

			//勝者テキスト表示
			Color col = g_1PWin.color;
			aloha += 0.01f;
			col.a = aloha;

			if (g_Winner == 1) 
				g_1PWin.color = col;

			if (g_Winner == 2)
				g_2PWin.color = col;
			
				g_Next.color = col;
		}
	}

	public void SetResult(int winner)
  {
		g_Winner = winner;
		isDisplayingResult = true;
	}
}


//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.UI;

//public class ResultButton : MonoBehaviour
//{
//  [SerializeField] TMPro.TextMeshProUGUI g_1PWin, g_2PWin;
//  [SerializeField] TMPro.TextMeshProUGUI g_Next;
//  List<TMPro.TextMeshProUGUI> g_TextList;

//  bool isDisplayingResult;//現在リザルト表示中か

//  // Start is called before the first frame update
//  void Start()
//  {
//	//画像非表示
//	g_TextList.Add(g_1PWin);
//	g_TextList.Add(g_2PWin);
//	g_TextList.Add(g_Next);
//	Color col;
//	foreach (TMPro.TextMeshProUGUI TextList in g_TextList)
//	{
//	  col = TextList.color;
//	  col.a = 0.0f;
//	  TextList.color = col;
//	}
//	g_TextList.Clear();

//	//リザルト表示中の判定
//	isDisplayingResult = false;


//	SetResult(1);
//  }

//  // Update is called once per frame
//  void Update()
//  {
//	//リザルト中
//	if (isDisplayingResult)
//	{
//	  //タイトルへ戻る
//	  if (Input.GetKeyDown(KeyCode.Space))
//	  {
//		SceneManager.LoadScene("Title");
//		return;
//	  }

//	  //勝者テキスト表示
//	  Color col;
//	  foreach (TMPro.TextMeshProUGUI TextList in g_TextList)
//	  {
//		col = TextList.color;
//		col.a = 1.0f;
//		TextList.color = col;
//	  }
//	}
//  }

//  public void SetResult(int winner)
//  {
//	if (winner == 1)
//	  g_TextList.Add(g_1PWin);
//	if (winner == 2)
//	  g_TextList.Add(g_2PWin);
//	g_TextList.Add(g_Next);
//  }
//}
