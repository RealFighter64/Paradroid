using UnityEngine;
using System.Collections;

public class AIDroidMovement : DroidMovement {
	public AIDroidMovement(Droid droid) : base(droid) { }

	public override void Move() {
		int rand = Random.Range (0, 100);
		if(rand == 1) {
			Debug.Log ("Shot! Attack: " + droid.attack);
		}
	}
}
