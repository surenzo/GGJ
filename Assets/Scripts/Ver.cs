using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using Unity.VisualScripting;
using UnityEngine;

public class Ver : MonoBehaviour
{
    [SerializeField] GameObject tete;
    private float speed;// Start is called before the first frame update
    void Start()
    {
        speed = tete.GetComponent<AIPath>().maxSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, tete.transform.position, speed);
    }
}
