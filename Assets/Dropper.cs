using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var MovementPosition = Vector3.MoveTowards(transform.position, MousePoint, 100f);
        MovementPosition.y = 4;
        GetComponent<Rigidbody2D>().MovePosition(MovementPosition);
    }
}
