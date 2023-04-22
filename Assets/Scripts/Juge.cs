using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WINNER
{
	PYALER_1,
	PYALER_2,
	DRAW
}

public class Juge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	struct Float2
	{
		public float x;
		public float y; 
  };
	
	short Judgement(Float2 PlA, Float2 PlB, Float2 CenP)
	{
		float PlALen = (PlA.x - CenP.x) * (PlA.x - CenP.x) + (PlA.y - CenP.y) * (PlA.y - CenP.y);
		float PlBLen = (PlB.x - CenP.x) * (PlB.x - CenP.x) + (PlB.y - CenP.y) * (PlB.y - CenP.y);
		

		GameObject.Find
		if (PlALen > PlBLen)
		{
			return 1;
		}
		else if (PlALen < PlBLen)
		{
			return -1;
		}
		else
		{
			return 0;
		}
	}
	//END of Judge

}
