using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;
using TMPro;

public class PlayerMetrics : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TMP_InputField nameText;
    public TextMeshProUGUI timeText;

    private System.Random random = new System.Random();

    public static int playerScore;
    public static int playerTime;
    public static string playerName;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = random.Next(0,101);
        playerTime = random.Next(0, 501);
        scoreText.text = "Score: "+ playerScore;
        timeText.text = "Time: "+ playerTime;
    }
    public void onSubmit(){
        playerName = nameText.text;
        postToDatabase();

    }
    private void postToDatabase(){
        user userObj = new user();
        RestClient.Post("https://demodemo-96d74-default-rtdb.firebaseio.com/.json", userObj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
