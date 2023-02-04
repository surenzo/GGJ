using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class Ennemi : MonoBehaviour
{
    public int pv = 4;
    private int damage = 1;
    private GameObject hud;

    private Transform t;
    // Start is called before the first frame update
    void Start()
    {
        DetectTarget();
        InvokeRepeating("DetectTarget",1,0.5f);
        hud=GameObject.FindWithTag("HUD");
    }

    // Update is called once per frame
    void Update()
    {

        if ((t.position.x-transform.position.x)*(t.position.x-transform.position.x) + (t.position.y-transform.position.y)*(t.position.y-transform.position.y) <0.5)
        {
            hud.gameObject.GetComponent<HUD>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
    public void TakeDamage(int dmg)
    {
        pv -= dmg;
        if (pv <= 0)
        {
            Destroy(gameObject);
        }
    }

    void DetectTarget()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("deces");
        GameObject nearestTarget = null;
        float nearestDist = Mathf.Infinity;
        foreach (GameObject target in targets)
        {
            float dist = Vector3.Distance(transform.position, target.transform.position);
            if (dist < nearestDist)
            {
                nearestDist = dist;
                nearestTarget = target;
            }
        }

        gameObject.GetComponent<AIDestinationSetter>().target = nearestTarget.transform;
        t = nearestTarget.transform;
    }
}
