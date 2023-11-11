using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class dropdown : MonoBehaviour {
    public Dropdown myDropdown;
    //public GameObject sprout;
    public GameObject apple;
    public GameObject blue;
    public GameObject tree;
    //public Button yourButton;

    // Use this for initialization
    void Start () {
 
    }
    public void ToggleGameObject()
    {
        int selectedValue = myDropdown.value;
        string selectedText = myDropdown.options[selectedValue].text;

        if (selectedText == "Social Science")
        {
            tree.SetActive(!blue.activeSelf);
        }
        if (selectedText == "Natural Science")
        {
            blue.SetActive(!tree.activeSelf);
        }
        if (selectedText == "Humanities")
        {
            apple.SetActive(!apple.activeSelf);
        }

    }
    // Update is called once per frame
    void Update () {
        
        
        // Debug.Log("Selected Text: " + selectedText);
    }
}
