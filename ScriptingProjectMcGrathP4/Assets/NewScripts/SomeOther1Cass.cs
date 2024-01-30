using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOther1Cass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Some1Class myClass = new Some1Class();
        myClass.GenericMethod<int>(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
