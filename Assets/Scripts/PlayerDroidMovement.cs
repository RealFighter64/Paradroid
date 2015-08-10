using UnityEngine;
using System.Collections;

public class PlayerDroidMovement : DroidMovement
{
	public PlayerDroidMovement (Droid droid) : base(droid) { }

	public override void Move() {
		if(Input.GetKeyDown(KeyCode.F)) {
			Debug.Log ("Shot! Attack: " + droid.attack);
		}
	}
}
