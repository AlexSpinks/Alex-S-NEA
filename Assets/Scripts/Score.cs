using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI score;
    private int sum = 0;

    private void Start()
    {
        score.text = "Gold: " + sum;
    }

    public void ScoreUP(int total)
    {
        sum += total;
        score.text = "Gold: " + sum.ToString();
    }
}
