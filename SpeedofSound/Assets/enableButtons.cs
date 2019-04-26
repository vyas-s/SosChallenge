using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enableButtons : MonoBehaviour
{
	public GameObject button1, button2;
	public string t1 = "", t2 = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void enable_Buttons(){
    	button1.SetActive(true);
    	button1.GetComponentInChildren<Text>().text = t1.ToUpper();
        button2.SetActive(true);
        button2.GetComponentInChildren<Text>().text = t2.ToUpper();
    }

    public void disable_Buttons(){
    	button1.SetActive(false);
        button2.SetActive(false);
    }
}
