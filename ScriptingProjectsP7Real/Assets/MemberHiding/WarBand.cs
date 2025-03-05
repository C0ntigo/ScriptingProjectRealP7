using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Humanoid human = new Humanoid();

        Humanoid enemy = new EnemyMH();

        Orc orc = new Orc();

        human.Yell();
        enemy.Yell();
        orc.Yell();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
