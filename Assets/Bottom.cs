using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottom : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
    // Start is called before the first frame update

}
