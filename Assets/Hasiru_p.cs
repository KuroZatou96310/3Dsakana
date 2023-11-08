using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hasiru_p : MonoBehaviour
{
    public float HasiruSpeed = 10f;
    private Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            rigidBody.AddForce(transform.forward * HasiruSpeed / Time.deltaTime, ForceMode.Force);
    }
}
