using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMovements : MonoBehaviour
{
    [SerializeField] private List<Transform> possible_cible;

    private int cible;
    // Start is called before the first frame update
    void Start()
    {
        cible = Random.Range(0, possible_cible.Count);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=Vector2.MoveTowards(transform.position, possible_cible[cible].position, 0.005f);
    }
}
