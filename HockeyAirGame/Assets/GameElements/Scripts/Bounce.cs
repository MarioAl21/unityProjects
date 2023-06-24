using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float speed = 4f;
    public AudioSource audioSource;
    public float volume = 4f;
    private void OnCollisionEnter(Collision collision)
    {
        Item item = collision.gameObject.GetComponent<Item>();


        if (item != null)
        {
            item.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(speed * 30, speed * 30, 0f), ForceMode.Force);
            audioSource.Play();
        }
    }
}
