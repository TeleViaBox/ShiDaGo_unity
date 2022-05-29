using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class move : MonoBehaviour
{
    public Camera camera_left;
    public Camera camera_right;
   
    // [SerializedField] float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        camera_left.enabled = true;
        camera_right.enabled = false;
    }
        
    

    // Update is called once per frame
    void Update()
    {
        // [SerializedField] int state;
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f,0,0);   
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f,0,0);   
        }
        else if(Input.GetKey(KeyCode.UpArrow))
        {
            // transform.Translate(0,0,0.1f);   
            transform.eulerAngles = new Vector3(0,0,0);
            transform.position = transform.position + transform.forward * Time.deltaTime* 100;
            // Debug.Log(Time.deltaTime);
            

        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0,0,-0.1f);   
        }        
        // else if(Input.GetKey("vbKeySpace"))
        // {
        //     transform.Translate(0,0.03f,0);   
        // }
        else if(Input.GetKey("a")) //&&state == 1)
        {
            // transform.rotation = Quaternion.Euler(new Vector3(0,0,0));  
            camera_left.enabled = true;
            camera_right.enabled = false;
            // state == 0;
            Debug.Log("GetKey A");
        }         
        else if(Input.GetKey("d")) //&&state == 0)
        {
            // transform.rotation = Quaternion.Euler(new Vector3(-90,0,0));  
            camera_left.enabled = false;
            camera_right.enabled = true;
            // state == 1;
            Debug.Log("GetKey D");            
        }  
        else if(Input.GetKey("w")) //&&state == 1)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0,180,0));  
            // state == 0;
        }         
        else if(Input.GetKey("s")) //&&state == 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0,0,0));  
            // state == 1;
        }                                 
        // transform.Translate(0,0.1f,0);
        //if(Input.GetKey("x")) //Input.GetKeyDown(KeyCode.Alpha1))  
        // {
        //     camera_one.enabled = false;
        //     camera_two.enabled = true;
        // }
        // if(Input.GetKey("y")) //Input.GetKeyDown(KeyCode.Alpha2))
        // {
        //     camera_one.enabled = true;
        //     camera_two.enabled = false;
        // }

    }
}
