using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticCameraMovEntry : MonoBehaviour
{
    Vector3 move = new Vector3(1.0f, 0.0f, 0.0f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += move * Time.deltaTime;
    }
}
