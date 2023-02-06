using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class user : MonoBehaviour
{
    public string userName;
    public int userScore;
    public int userTime;

    public user(){
        userName = PlayerMetrics.playerName;
        userScore = PlayerMetrics.playerScore;
        userTime = PlayerMetrics.playerTime;
    }

}
