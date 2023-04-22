using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Type
{
	Player,
	Enemy,
}

public class FieldButton : MonoBehaviour
{


	[SerializeField]
	GameObject[] ParticleSystemObject;


	Transform SpoawTransform;

  private void Start()
  {
		SpoawTransform = gameObject.transform.GetChild(0);
	}

	public void OnPushButtonEvent(Type type)
  {
		Instantiate(ParticleSystemObject[(int)type], SpoawTransform);
	}
}
