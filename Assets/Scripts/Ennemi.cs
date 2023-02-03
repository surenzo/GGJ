using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemi : MonoBehaviour
{
    public int PV = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        PV -= damage;
        Debug.Log("degats infligé");
        if (PV <= 0)
        {
            Destroy(gameObject);
        }
    }
}
