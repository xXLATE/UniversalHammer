using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private const string SCORE = "Score";

    private int _score;
    private TMP_Text _scoreText;

    private int Score
    {
        get { return _score; }
        set
        {
            _score = value;
            _scoreText.text = _score.ToString();
            PlayerPrefs.SetInt(SCORE, _score);
        }
    }

    private void Awake()
    {
        _scoreText = GetComponent<TMP_Text>();

        Score = PlayerPrefs.GetInt(SCORE);
        Actions.Instance.OnHitMiddle += AddScore;
    }

    private void AddScore()
    {
        Score++;
    }
}
