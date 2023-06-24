using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Vector3 initialImpulse;
    public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(initialImpulse, ForceMode.Impulse);
    }

}
