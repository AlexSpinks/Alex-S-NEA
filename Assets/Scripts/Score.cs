using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI score;
    private int sum = 0;
    private string sum1;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "Gold: " + sum;
    }
    public void ScoreUP(int total)
    {
        sum += total;
        Debug.Log(sum);
        score.text = "Gold: " + sum.ToString();

    }
    private void Update()
    {
    }

    // Update is called once per frame

}
