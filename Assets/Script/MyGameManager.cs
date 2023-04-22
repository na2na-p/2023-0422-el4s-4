using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
	StartWait,
	NowGame,
	Finish,
}


public class MyGameManager : MonoBehaviour
{
	static public GameState GameState { get; set; }
}
