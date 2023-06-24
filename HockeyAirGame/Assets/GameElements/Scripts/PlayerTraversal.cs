using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTraversal : MonoBehaviour
{
    public ePlayer player;
    public AudioSource audioSource;
    public float volume = 2f;
    public float speed = 4f;

    private void OnCollisionEnter(Collision collision)
    {
        Item item = collision.gameObject.GetComponent<Item>();

        float top = Random.Range(0, 2) == 0 ? 10 : 1;
        float bottom = Random.Range(0, 2) == 0 ? 10 : 5;

        if(item != null)
        {
            if(player == ePlayer.Right)
            {
                item.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(speed * bottom, speed * top, 0f), ForceMode.Force);
                audioSource.Play();
            } else if(player == ePlayer.Left)
            {
                item.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(speed * bottom, speed * top, 0f), ForceMode.Force);
                audioSource.Play();
            }
        }

    }

}
