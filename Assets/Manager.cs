using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject wallpfb;
    // Start is called before the first frame update
    void Start()
    {
        for(int x = 0; x < 5; x++)
        {
            for(int y = 0; y < 4; y++)
            {
                Vector3 pos = new Vector3();
                pos.x = x * 1.2f - 2.4f;
                pos.y = 2.5f - y;
                GameObject obj = Instantiate(wallpfb, pos, Quaternion.identity);
                Wall wall = obj.GetComponent<Wall>();
                if(y % 2 == 0)
                {
                    wall.clockwise = true;
                }
                else
                {
                    wall.clockwise = false;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
