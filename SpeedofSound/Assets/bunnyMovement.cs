using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunnyMovement : MonoBehaviour
{
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void jump()
    {
    	GetComponent<Rigidbody2D>().AddForce(new Vector2(0,6.5f), ForceMode2D.Impulse);
    }
}
