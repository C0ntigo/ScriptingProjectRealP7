using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColor : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.OnClicked += TurnColorScript;
    }


    void OnDisable()
    {
        EventManager.OnClicked -= TurnColorScript;
    }


    void TurnColorScript()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = col;
    }
}
