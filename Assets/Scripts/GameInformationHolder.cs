using UnityEngine;
using System.Collections;

public class GameInformationHolder : MonoBehaviour
{
    [HideInInspector]
    public static GameInformation gameInformation;

    void Start () {
        gameInformation = new GameInformation ();
    }
}