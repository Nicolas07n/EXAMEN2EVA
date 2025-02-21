using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lakitu : MonoBehaviour
{

    public float speed = 1.0f;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = FindAnyObjectByType<MarioScript>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = Vector2.MoveTowards(transform.position,target.transform.position,speed * Time.deltaTime);
    }
}
