using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int experince;

    public int Experience
    {
        get
        {
            return experince;
        }
        set
        {
            experince = value;
        }
    }

    public int Level
    {
        get
        {
            return experince / 1000;
        }
        set
        {
            experince = value * 1000;
        }
    }

    public int Healt{get; set;}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
