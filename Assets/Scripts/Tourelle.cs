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
    [SerializeField] private GameObject projectile;
    [SerializeField] private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        cd = 5f;
        damage = 1;
        timeEllapsed = cd;
        range = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        timeEllapsed += Time.deltaTime;
        if (timeEllapsed > cd)
        {
            Update_target();
        }
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

        if (nearestEnemy != null && nearestDist < range)
        {
            target = nearestEnemy;
            Shoot();
            timeEllapsed = 0;
        }
    }

    private void Shoot()
    {
        GameObject projectileGenere = Instantiate(projectile);
        projectileGenere.gameObject.GetComponent<Projectile>().Seek(target, damage);
    }
}