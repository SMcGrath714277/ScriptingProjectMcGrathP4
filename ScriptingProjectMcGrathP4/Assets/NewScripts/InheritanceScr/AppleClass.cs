using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Fruit
{

    public Apple()
    {
        color = "red";
        Debug.Log("1st Apple Constrcutor Called");
    }

    public Apple(string newColor) : base(newColor)
    {
        Debug.Log("2nd Apple Constructor Called");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
