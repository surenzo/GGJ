using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class Ennemi : MonoBehaviour
{
    [SerializeField] private Money thune;
    public int money_du_mob = 500;
    public int pv = 4;
    [SerializeField] private int damage = 1;
    GameObject nearestTarget;
    [SerializeField] private HUD hud;
    

    private Transform t;
    // Start is called before the first frame update
    void Start()
    {
        thune=transform.parent.transform.parent.transform.Find("Vie Canvas").gameObject
            .GetComponent<Money>();
        hud = transform.parent.transform.parent.transform.Find("Vie Canvas").gameObject
            .GetComponent<HUD>();
        nearestTarget = null;
        DetectTarget();
        InvokeRepeating("DetectTarget",1,0.5f);
        
    }

    // Update is called once per frame
    void Update()
    {

        if ((t.position.x-transform.position.x)*(t.position.x-transform.position.x) + (t.position.y-transform.position.y)*(t.position.y-transform.position.y) <0.5)
        {
            hud.TakeDamage(damage);
            spawnEnnemis.number_ennemis--;
            Destroy(gameObject);
        }
    }
    public void TakeDamage(int dmg)
    {
        pv -= dmg;
        if (pv <= 0)
        {
            thune.gain(money_du_mob);
            Destroy(gameObject);
            spawnEnnemis.number_ennemis--;
        }
    }

    void DetectTarget()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("deces");
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
