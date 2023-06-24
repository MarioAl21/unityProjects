using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveScore : MonoBehaviour
{
    public PlayerBorder score;

    private void HoldScore()
    {
        if (score.score.scorePlayerLeft >= 1 && score.score.scorePlayerLeft <= 8 || score.score.scorePlayerRight >= 1 && score.score.scorePlayerRight <= 8)
        {
            DontDestroyOnLoad(this);
        }
        else
            score.score.scorePlayerLeft = score.score.scorePlayerRight = 0;
    }
}
