using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HockeyPads : MonoBehaviour
{
    public bool isPaddle1;
    public float speed = 4f;
    // Update is called once per frame
    void Update()
    {
        if (isPaddle1)
            PlayerMove("Player1", -0.066f, 1.409f, 1.837f);
        else
            PlayerMove("Player2", -0.043f, 1.412f, -2.646f);
    }
    void PlayerMove(string player, float min, float max, float z)
    {
        transform.Translate(Input.GetAxis(player) * speed * Time.deltaTime, 0f, 0f);
        Vector3 pos = transform.position;

        pos.z = Mathf.Clamp(pos.z, z, z);
        pos.x = Mathf.Clamp(pos.x, min, max);

        transform.position = pos;
    }
}
