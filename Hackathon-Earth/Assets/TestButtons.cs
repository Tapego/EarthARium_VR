using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButtons : MonoBehaviour {

    public List<GameObject> filters;
    int count = 0;
    public bool autoScroll;
    float time;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (autoScroll)
        {
            if (Time.time - time > 3)
            {
                print("swapping");
                time = Time.time;
                count++;
                if (count > filters.Count - 1)
                {
                    count = 0;
                }
                for (int a = 0; a < filters.Count; a++)
                {
                    if (a == count)
                    {
                        filters[a].SetActive(true);
                    }
                    else
                    {
                        filters[a].SetActive(false);
                    }
                }
            }
        }
        if (Input.GetKeyDown("b"))
        {
            count++; 
            if (count > filters.Count - 1)
            {
                count = 0;
            }
            for (int a = 0; a < filters.Count; a++)
            {
                if (a == count)
                {
                    filters[a].SetActive(true);
                }
                else
                {
                    filters[a].SetActive(false);
                }
            }
            
        }
	}
}
