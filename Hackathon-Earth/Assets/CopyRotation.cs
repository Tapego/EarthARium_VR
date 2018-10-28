using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyRotation : MonoBehaviour {

    public GameObject target;
    public float scaleVal;
    Vector3 offset;
    Vector3 scale;
    // Use this for initialization
    void Start () {
        offset = new Vector3(0, 88.811f, 0);//target.transform.rotation.eulerAngles - transform.rotation.eulerAngles;
        scale = new Vector3(scaleVal, scaleVal, scaleVal);
    }
	
	// Update is called once per frame
	void Update () {
        transform.eulerAngles = target.transform.rotation.eulerAngles - offset;
        transform.localScale = scale;
	}
}
