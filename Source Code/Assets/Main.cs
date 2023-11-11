using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour {

    //public Dropdown myDropdown;
    
    // 1 = haverford, 2 = brywn mawr, 3 = swat
    public int college;
    public GameObject majors;
	// Use this for initialization
	void Start () {
        college = 1;

	}
	
	// Update is called once per frame
	void Update () {
        //int selectedValue = myDropdown.value;
        //string selectedText = myDropdown.options[selectedValue].text;
        //Debug.Log("Selected Text: " + selectedText);
    }

    public void inMajor()
    {
        majors.SetActive(false);
    }
}
