using UnityEngine;
using System.Collections;

[System.Serializable]
public class Droid : MonoBehaviour
{
	public int level;
	[HideInInspector]
	public bool dead;
	public int moveSpeed;
	public int armour;
	public int attack;
	public int time;
	public bool player;
	public DroidMovement droidMovement;

	void Start ()
	{
		if (player) {
			droidMovement = new PlayerDroidMovement (this);
		} else {
			droidMovement = new AIDroidMovement (this);
		}
	}

	void Update ()
	{
		droidMovement.Move();
	}
}
