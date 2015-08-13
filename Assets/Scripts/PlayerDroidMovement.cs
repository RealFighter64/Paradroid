using UnityEngine;
using System.Collections;

[System.Serializable]
public class PlayerDroidMovement : DroidMovement
{
	public PlayerDroidMovement (Droid droid) : base(droid) { }

	public override void Move() {
		if(Input.GetKeyDown(KeyCode.F)) {
			Debug.Log ("Shot! Attack: " + droid.attack);
		}

		LookAtMouse();
		Vector3 mousePos = Input.mousePosition;
		mousePos.x -= Screen.width/2;
		mousePos.y -= Screen.height/2;

		float distance = Mathf.Sqrt(Mathf.Pow ((mousePos.x), 2) + Mathf.Pow ((mousePos.y), 2)) / 200;
		Debug.Log (distance);
		droid.GetComponent<CharacterController>().Move(droid.transform.forward * Time.deltaTime * droid.moveSpeed * distance);
	}
}
