public interface IScoreService
{
    void RequestScore(string url);

    void OnReceiveScore();

    void UpdateScore(string url, int score);
}