using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvFruitSaladClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        OvAppleClass myOvApple = new OvAppleClass();
        myOvApple.SayHello();
        myOvApple.Chop();

        OvFruitClass myOvFruit = new OvFruitClass();
        myOvFruit.SayHello();
        myOvFruit.Chop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
