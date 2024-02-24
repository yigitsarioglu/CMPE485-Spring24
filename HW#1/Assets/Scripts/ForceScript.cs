using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceScript : MonoBehaviour
{
    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Cmpe 485 force rigidbody");
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(2,0,0);
    }
}
