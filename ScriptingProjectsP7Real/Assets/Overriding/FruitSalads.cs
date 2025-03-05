using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalads : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Apples myApples = new Apples();

        myApples.SayHello();
        myApples.Chop();

        Fruit myFruit = new Apples();
        myFruit.SayHello();
        myFruit.Chop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
