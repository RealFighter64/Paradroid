using UnityEngine;
using System.Collections;

public class Droid : MonoBehaviour
{
	public int level;
	[HideInInspector]
	public bool dead;
	public int moveSpeed;
	public int armour;
	public int attack;
	public int time;

	public Droid (int level, int moveSpeed, int armour, int attack, int time)
	{
		this.level = level;
		this.dead = false;
		this.moveSpeed = moveSpeed;
		this.armour = armour;
		this.attack = attack;
		this.time = time;
	}
}
