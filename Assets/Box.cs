using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour
{
    public Text scoretext;
    int score = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Vegetable.Type typeA = GetComponent<Vegetable>().type;
        Vegetable.Type typeB = other.GetComponent<Vegetable>().type;
        if(typeA == typeB)
        {
            score++;
            scoretext.text = score.ToString();
            Destroy(other.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
