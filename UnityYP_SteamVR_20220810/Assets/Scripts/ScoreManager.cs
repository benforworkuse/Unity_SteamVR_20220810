using TMPro;
using UnityEngine;

namespace Ben
{
    public class ScoreManager : MonoBehaviour
    {
        private string nameBasketball="Äx²y";
        private TextMeshProUGUI textScore;
        public static int addScore = 2;
        private int totalScore=0;
        private void Awake()
        {
            textScore = GameObject.Find("¤À¼Æ").GetComponent<TextMeshProUGUI>();
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameBasketball))
            {
                AddScore();
            }
        }
        private void AddScore()
        {
            totalScore += addScore;
            textScore.text = "SCORE: " + totalScore;
        }
        private void ChangeScore(int scoreToChange)
        {
            addScore = scoreToChange;
        }
    }
}

