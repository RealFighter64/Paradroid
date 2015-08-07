using UnityEngine;
using System.Collections;

public class PlayerDroid : MonoBehaviour
{
	public Droid inhabitedDroid;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.F)) {
			Debug.Log ("Shot! Attack: " + inhabitedDroid.attack);
		}
	}

	public void InhabitDroid (Droid toInhabit)
	{
		inhabitedDroid = toInhabit;
	}
}

