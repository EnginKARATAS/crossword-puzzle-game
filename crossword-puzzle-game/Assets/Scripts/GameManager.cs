using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject simpleLetterGrid;
    // Start is called before the first frame update
    void Start()
    {//5x9 grid
        for(int i = -2; i<3; i++) //5
        {
            for(int j = -4; j<5; j++)//9
            {
                Instantiate(simpleLetterGrid, new Vector2(i,j), Quaternion.identity);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
