using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitDisplayer : MonoBehaviour
{
    public List<GameObject> droppableFruits;
 
    public GameObject availableFruit;

    public bool displayingFruit = false;

    public Transform dropper;
    public Transform display;

    public Fruit fruit;

    public int counter;

    public float tossingCD;

    void Update()
    {
        ShowFruit();
        tossingCD -= Time.deltaTime;
    }

    void ShowFruit()
    {
        if (!availableFruit && !displayingFruit)
        {
            availableFruit = droppableFruits[Random.Range(0, droppableFruits.Count)];

            displayingFruit = true;

        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && tossingCD < 0)
        {
            Spawn();
        }
    }

    void Spawn()
    {
        Instantiate(availableFruit, dropper.position, dropper.rotation);
        availableFruit = droppableFruits[Random.Range(0, droppableFruits.Count)];
        tossingCD = 1.5f;
    }
}
