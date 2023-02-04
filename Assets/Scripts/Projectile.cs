using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float speed;
    [SerializeField] private int damage;

    public void Seek(GameObject cible, int dmg)
    {
        target = cible;
        damage = dmg;
    }
    // Start is called before the first frame update
    void Start()
    {
        speed = 3f;
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
            target.gameObject.GetComponent<Ennemi>().TakeDamage(damage);
            Destroy(gameObject);
        }
        transform.Translate(direction.normalized*distFrame, Space.World);
    }
}
