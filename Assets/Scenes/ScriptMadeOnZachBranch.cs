using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMadeOnZachBranch : MonoBehaviour
{
    // Start is called before the first frame update
    public string Message; 
    void Start()
    {
        Debug.Log("Test debug");

        print("I exist only to cause merge conflicts and chaos" + Message);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
