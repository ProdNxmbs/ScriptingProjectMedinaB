using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEditor;
using UnityEngine;

public class UsingInstantiate : MonoBehaviour
{
    public Rigidbody rocketPrefab;
    public Transform barrelEnd;
    public float speed;
    public float turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody rocketInstance;
            rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            rocketInstance.AddForce(barrelEnd.forward * 5000);
        }
        Movement();
    void Movement ()
        {
            float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

            transform.Translate(Vector3.forward * forwardMovement);
            transform.Rotate(Vector3.up * turnMovement);
        }
    }
}
