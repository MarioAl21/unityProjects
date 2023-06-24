using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBorder : MonoBehaviour
{
    public ePlayer player;

    public float speed = 4f;
    public ScoreUI score;
    public AudioSource audioSource;
    public float volume = 0.2f;

    private void OnCollisionEnter(Collision collision)
    {
        Item item = collision.gameObject.GetComponent<Item>();

        float top = Random.Range(0, 2) == 0 ? 7f : 3f;
        float bottom = Random.Range(0, 2) == 0 ? 3f : 7f;

        Light myLight = GetComponent<Light>();

        if (item != null)
        {
            if (player == ePlayer.Right)
            {
                score.scorePlayerRight++;
                item.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(speed * top, 0f, speed * top), ForceMode.Force);
                myLight.intensity = Mathf.PingPong(Time.time , 8);
                audioSource.Play();
            }
            else if (player == ePlayer.Left)
            {
                score.scorePlayerLeft++;
                item.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(speed * bottom, 0f, speed * bottom), ForceMode.Force);
                myLight.intensity = Mathf.PingPong(Time.time, 8);
                audioSource.Play();
            }
        }
    }
}
