using UnityEngine;

public class ScoreService : IScoreService
{
    public void RequestScore(string url)
    {
        Debug.Log("Request Score From URL : " + url);
    }

    public void OnReceiveScore()
    {
        var score = Random.Range(0, 100);
    }

    public void UpdateScore(string url, int score)
    {
        Debug.Log("Update Score:[" + score + "] To URL : " + url);
    }
}