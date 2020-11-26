using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class BehaviourRotary : MonoBehaviour
{
    SerialPort stream = new SerialPort("COM3", 9600);
    public string x;
    public GameObject ob;

    // Start is called before the first frame update
    void Start()
    {    
        stream.Open();
        stream.ReadTimeout = 100; 
    }

    // Update is called once per frame
    void Update()
    {     
        x = stream.ReadLine();
        ob.transform.eulerAngles = new Vector3(float.Parse(x), 0.0f, 0.0f);

    }
}
