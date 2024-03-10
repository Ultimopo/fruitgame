using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public int fruitRank;
    public int count;
    public List<GameObject> fruits;
    public GameObject fruitMerge;

    void OnCollisionEnter2D(Collision2D other)
    { 
        if (other.gameObject.tag == gameObject.tag)
        {
           
            fruitRank++;
            fruitMerge = fruits[fruitRank];
            Destroy(other.gameObject);

            Merge();
           
            
        }
    }
    void Merge()
    {
        Instantiate(fruitMerge, gameObject.transform.position, transform.rotation);
    }
}
