using UnityEngine;
using System.Collections;

public abstract class DroidMovement {
	public Droid droid;

	public DroidMovement(Droid droid) {
		this.droid = droid;
	}

	public abstract void Move();
}
