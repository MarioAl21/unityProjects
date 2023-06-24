using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemy : MonoBehaviour
{
    public GameObject item;
    public GameObject AI;
    public float speed = 2f;
    // Update is called once per frame
    void Update()
    {
        item = GameObject.FindWithTag("Puck");
        AI = GameObject.FindWithTag("AI");

        if (item.transform.position.y > 0 || item.transform.position.y < 0)
        {
            AI.transform.position = Vector3.MoveTowards(transform.position, new Vector3(item.transform.position.x, 1.715f, -2.646f), Time.deltaTime * speed);
        }
    }
}
