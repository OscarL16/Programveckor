using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rörelse : MonoBehaviour
{

    [SerializeField]
    KeyCode A;
    [SerializeField]
    KeyCode D;
    [SerializeField]
    KeyCode W;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(D))
        {
            transform.position += new Vector3(5, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(A))
        {
            transform.position -= new Vector3(5, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(W))
        {
            transform.position += new Vector3(0, 10, 0) * Time.deltaTime;
        }
    }
}
