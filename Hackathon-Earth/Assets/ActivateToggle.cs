using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRTK;

public class ActivateToggle : MonoBehaviour {

    public VRTK_ControllerEvents vrtk;
	// Use this for initialization
	void Start () {
        /*vrtk.TouchpadPressed += delegate {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit info;
            print("PRESSED");
            if (Physics.Raycast(ray, out info))
            {
                print("FOUND");
                info.collider.gameObject.GetComponent<Toggle>().isOn = !info.collider.gameObject.GetComponent<Toggle>().isOn;
            }
        };*/

    }
	
	// Update is called once per frame
	void Update () {
        print(vrtk.AnyButtonPressed());
        print(Input.anyKey);
        if (Input.GetButton("Toggle"))
        {
            //print(Input.)
            print("pressed");
        }
	}
}
