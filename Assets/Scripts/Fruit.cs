using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Fruit : MonoBehaviour
{
    public int fruitRank;
    public int count;
    public List<GameObject> fruits;
    public GameObject fruitMerge;
    ScoreManager scoremanager;
    MultiplierCalculator multicalc;


    public UnityEvent onMerge;

    void Awake()
    {
        if (!scoremanager) scoremanager = GameObject.FindWithTag("ScoreManagement").GetComponent<ScoreManager>();
        if (!multicalc) multicalc = GameObject.FindWithTag("ScoreManagement").GetComponent<MultiplierCalculator>();
    }

    void OnCollisionEnter2D(Collision2D other)
    { 
        if (other.gameObject.tag == gameObject.tag)
        {
            int otherID = other.gameObject.GetInstanceID();
            int thisID = gameObject.GetInstanceID();
            Destroy(other.gameObject);
            Destroy(gameObject);
            fruitRank++;
            fruitMerge = fruits[fruitRank];
            if (thisID > otherID && fruitRank != 8) Merge();

            
        }
    }
    void Merge()
    {
        
        Instantiate(fruitMerge, gameObject.transform.position, transform.rotation);
        onMerge.Invoke();
        scoremanager.updateScore();
        multicalc.SaveMultiplier();
    }
}
