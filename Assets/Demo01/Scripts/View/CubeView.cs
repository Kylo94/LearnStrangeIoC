using strange.extensions.mediation.impl;
using UnityEngine;
using UnityEngine.UI;

public class CubeView : View
{
    public Text scoreText;
    public float speed = 5;
    private float timer = 0.3f;
    public float time = 0.3f;
    public void Init()
    {
        timer = time;
    }

    public void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = time;
            transform.Translate(
                new Vector3(
                    Random.Range(-2, 3)*Time.deltaTime*speed,
                    Random.Range(-2, 3)*Time.deltaTime*speed,
                    Random.Range(-2, 3)*Time.deltaTime*speed));
        }
    }
    private void OnMouseDown()
    {
        Debug.Log("On Mouse Down");
    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }
}