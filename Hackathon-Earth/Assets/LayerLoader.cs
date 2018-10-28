using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class LayerLoader : MonoBehaviour {

    public GameObject LayerPrefab;
    public GameObject LayerParent;
    public Canvas LayerToggle;
    public List<Toggle> ToggleFilters = new List<Toggle>();
    public GameObject ToggleFilterPrefab;

    List<Texture2D> filters = new List<Texture2D>();
    //For every 
	void Start () {
        string [] files = Directory.GetFiles(Application.dataPath + "/Resources/Filters/Scaled and stuff");
        int i = 0;
        foreach(string file in files)
        {
            if (file.Contains("png") && !file.Contains("meta"))
            {
                print(file);
                filters.Add(Resources.Load<Texture2D>(file));
                GameObject filter = GameObject.Instantiate(ToggleFilterPrefab, LayerToggle.transform);
                ToggleFilters.Add(filter.GetComponent<Toggle>());
                filter.GetComponent<Toggle>().onValueChanged.AddListener(x => print(i));
                GameObject newFilter = GameObject.Instantiate(LayerPrefab, LayerParent.transform);
                newFilter.GetComponent<MeshRenderer>().material.mainTexture = Resources.Load<Texture2D>(file);

                i++;
            }
        }
        print(filters.Count);
		//
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
