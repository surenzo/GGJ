using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Animations;
using Random = UnityEngine.Random;

public class spawnEnnemis : MonoBehaviour
{
    [SerializeField] private List<Transform> parent;

    [SerializeField] private List<GameObject> ennemis;
    
    public static int number_ennemis ;
    private int nombre_diff_ennemis;
    private int nombre_diff_parent;
    static public bool Rentrer=true;
    private int ennemi_max;
    
    [SerializeField] List<int> niveau;

        
        
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 1000; i++)
        {
            niveau[i] = 0;
            for (int k = 1; k < ennemis.Count; k++)
            {
                if ( i % (k*k) ==0)
                    niveau[i] = k;
            }
        }
        // ennemi_max = 5;
        // number_ennemis = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Rentrer)
        {
            // nombre_diff_ennemis = ennemis.Count;
            nombre_diff_parent = parent.Count;
            Rentrer = true;
            StartCoroutine(spawn(1f));
        }
    }
    
    IEnumerator spawn(float sec)
    {
        int i = VagueHUD.Vague + 1;
        for (int k = 0; k< i*i*math.log(i*i);k+=i){
            GameObject prefab = ennemis[niveau[k]];
            Transform pere = parent[Random.Range(0, nombre_diff_parent)];
            GameObject cible = Instantiate(prefab, pere, false);
            cible.transform.position = pere.position;
            cible.SetActive(true);
            number_ennemis += 1;
            yield return new WaitForSeconds(sec);
        }
    //     for (number_ennemis= 1; number_ennemis < 1+ ennemi_max; number_ennemis++)
    //     {
    //         GameObject prefab = ennemis[Random.Range(0, nombre_diff_ennemis)];
    //         Transform pere = parent[Random.Range(0, nombre_diff_parent)];
    //         GameObject cible = Instantiate(prefab, pere, false);
    //         cible.transform.position = pere.position;
    //         cible.SetActive(true);
    //         yield return new WaitForSeconds(sec);
    //     }
    //     number_ennemis -= 1;
    }

}
/* a faire : créé des vitesse pour chaque ennemis / vie / etc , le pathfinding ? changer le timer du wait / changer les ennemis par niveau (creer une pile avec un peu de math pour mettre des ennemis dedans*/
// pour instancier les tourelle on peut reutilisé le script, juste a rajouter dans celui ci le changement de tag 
// rajouter les huds ++ storytelling + bob

