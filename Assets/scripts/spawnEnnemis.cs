using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class spawnEnnemis : MonoBehaviour
{
    [SerializeField] private List<Transform> parent;

    [SerializeField] private List<GameObject> ennemis;
    
    public int number_ennemis = 0;
    private int nombre_diff_ennemis;
    private int nombre_diff_parent;
    bool rentrer = false;
    
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!rentrer)
        {
            nombre_diff_ennemis = ennemis.Count;
            nombre_diff_parent = parent.Count;
            rentrer = true;
            StartCoroutine(spawn(2));
        }
    }
    
    IEnumerator spawn(int sec)
    {
        for (int i = 0; i < number_ennemis; i++)
        {
            GameObject prefab = ennemis[Random.Range(0, nombre_diff_ennemis)];
            Transform pere = parent[Random.Range(0, nombre_diff_parent)];
            //a changé pour chaque niveau ???
            GameObject cible = Instantiate(prefab, pere, false);
            cible.transform.position = pere.position;
            cible.SetActive(true);
            yield return new WaitForSeconds(2);
        }
        number_ennemis = 0;
        rentrer = false;
    }

}
/* a faire : créé des vitesse pour chaque ennemis / vie / etc , le pathfinding ? changer le timer du wait / changer les ennemis par niveau (creer une pile avec un peu de math pour mettre des ennemis dedans*/
// pour instancier les tourelle on peut reutilisé le script, juste a rajouter dans celui ci le changement de tag 
// rajouter les huds ++ storytelling + bob