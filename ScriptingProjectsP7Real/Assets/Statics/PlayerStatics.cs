using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatics : MonoBehaviour
{
    public static int playerCount = 0;

    void Start()
    {
        playerCount++;
    }
}
