using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Nav : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("deces");
                GameObject nearestTarget = null;
                float nearestDist = Mathf.Infinity;
                foreach (GameObject cible in targets)
                {
                    float dist = Vector3.Distance(transform.position, cible.transform.position);
                    if (dist < nearestDist)
                    {
                        nearestDist = dist;
                        nearestTarget = cible;
                    }
                }

                agent.SetDestination(nearestTarget.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
