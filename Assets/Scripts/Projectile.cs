using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float speed;
    [SerializeField] private int damage;
    private bool zone;

    public void Seek(GameObject cible, int dmg, bool z)
    {
        target = cible;
        damage = dmg;
        zone = z;
    }
    // Start is called before the first frame update
    void Start()
    {
        speed = 7f;
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 direction = target.transform.position - transform.position;
        float distFrame = speed * Time.deltaTime;
        if (direction.magnitude <= distFrame)
        {
            if(zone)
            {
                GameObject[] ennemies = GameObject.FindGameObjectsWithTag("Enemy");
                foreach (GameObject enemy in (ennemies))
                {
                    if ((enemy.transform.position.x - transform.position.x) *
                        (enemy.transform.position.x - transform.position.x) +
                        (enemy.transform.position.y - transform.position.y) *
                        (enemy.transform.position.y - transform.position.y) < 2)
                    {
                        enemy.gameObject.GetComponent<Ennemi>().TakeDamage(damage);
                    }
                }
            }
            else
            {
                target.gameObject.GetComponent<Ennemi>().TakeDamage(damage);
            }
            Destroy(gameObject);
        }
        transform.Translate(direction.normalized*distFrame, Space.World);
    }
}
