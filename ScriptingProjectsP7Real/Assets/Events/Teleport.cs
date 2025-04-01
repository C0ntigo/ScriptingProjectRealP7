using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.OnClicked += TeleportScript;
    }


    void OnDisable()
    {
        EventManager.OnClicked -= TeleportScript;
    }


    void TeleportScript()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(1.0f, 3.0f);
        transform.position = pos;
    }
}
