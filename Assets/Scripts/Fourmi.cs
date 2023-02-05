using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Fourmi : MonoBehaviour
{
    [SerializeField] private List<Sprite> sprites;
    private int frame;
    private int nbFrame;
    private SpriteRenderer spriteR;
    private float timeEllapsed;// Start is called before the first frame update
    void Start()
    {
        frame = 0;
        nbFrame = sprites.Count;
        spriteR = GetComponent<SpriteRenderer>();
        spriteR.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeEllapsed > 0.1)
        {
            spriteR.sprite = sprites[frame];
            frame = (frame + 1) % nbFrame;
            timeEllapsed = 0;
        }
        else
        {
            timeEllapsed += Time.deltaTime;
        }
    }
}
