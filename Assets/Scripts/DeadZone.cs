using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DeadZone : MonoBehaviour {

    public Transform ball;
    public Text scorePlayer;
    public Text scoreEnemy;
    int scorePlayerQty = 0;
    int scoreEnemyQty = 0;
    // Use this for initialization
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == "Izquierdo")
        {
            scoreEnemyQty++;
            updateScoreLabel(scoreEnemy, scoreEnemyQty);
        }
        else if (gameObject.tag == "Derecho")
        {
            scorePlayerQty++;
            updateScoreLabel(scorePlayer, scorePlayerQty);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
    void updateScoreLabel(Text label, int score) {
        label.text = score.ToString();
    }
}
