using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tourelle : MonoBehaviour
{
    [SerializeField] private float cd = 5f;
    [SerializeField] private float range = 7f;
    [SerializeField] private int damage = 1;
    [SerializeField] private float timeEllapsed;
    [SerializeField] private GameObject projectile;
    [SerializeField] private GameObject target;

    [SerializeField] private bool zone;
    // Start is called before the first frame update
    void Start()
    {
        timeEllapsed = cd;
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
        Transform t = transform;
        GameObject projectileGenere = Instantiate(projectile, t.position, t.rotation);
        projectileGenere.gameObject.GetComponent<Projectile>().Seek(target, damage, zone);
    }
}