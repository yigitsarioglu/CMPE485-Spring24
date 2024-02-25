using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public int rotationSpeed = 4;
    public float speeds = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.UpArrow) ){
            this.transform.Translate(speeds,0f,0f);
        }

        if (Input.GetKey (KeyCode.DownArrow) ){
            this.transform.Translate(-speeds,0f,0f);
        }

        if (Input.GetKey (KeyCode.LeftArrow) ){
            this.transform.Rotate(Vector3.up,rotationSpeed);
        }

        if (Input.GetKey (KeyCode.RightArrow) ){
            this.transform.Rotate(Vector3.up,-rotationSpeed);
        }
        
        
    }
}
