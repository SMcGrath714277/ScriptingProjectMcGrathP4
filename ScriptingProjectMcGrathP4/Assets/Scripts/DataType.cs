using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Value type variable
        Vector3 pos = transform.position;
        pos = new Vector3(0, -2, -0);

        //Reference type variable
        Transform tran = transform;
        tran.position = new Vector3(-10, -20, 70);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
