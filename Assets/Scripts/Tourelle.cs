using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tourelle : MonoBehaviour
{
    [SerializeField] private float cd;
    [SerializeField] private float range;
    [SerializeField] private int damage;
    [SerializeField] private float timeEllapsed ;
    // Start is called before the first frame update
    void Start()
    {
        cd = 5f;
        damage = 1;
        timeEllapsed = 0;
        range = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        timeEllapsed += Time.deltaTime;
        Update_target();
    }

    private void Update_target()
    {
        GameObject[] ennemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject nearestEnemy = null;
        float nearestDist = Mathf.Infinity;
        foreach (GameObject enemy in ennemies)
        {
            float dist = Vector3.Distance(transform.position, enemy.transform.position);
            if (dist < nearestDist)
            {
                nearestDist = dist;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && nearestDist < range && timeEllapsed > cd)
        {
            nearestEnemy.gameObject.GetComponent<Ennemi>().TakeDamage(damage);
            timeEllapsed = 0;
        }
    }
}