using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    
    public Animator anim;
    public AudioSource doorOpen;
    public AudioSource doorClose;
    public bool doorIsOpen;
    public bool doorIsClosed ;

	// Use this for initialization
	void Start () {
        doorIsOpen = false;
        doorIsClosed = true;
	}
	
	// Update is called once per frame
	void Update () {
		
    }
    private void OnTriggerStay(Collider player)
    {
        if (player.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            if (doorIsClosed)
            {
                anim.Play("DoorOpen");
                doorOpen.Play();
                doorIsOpen = true;
                doorIsClosed = false;
                
            }
            if (doorIsOpen)
            {
                anim.Play("DoorClose");
                doorClose.Play();
                doorIsClosed = true;
                doorIsOpen = false;
            }
            
        }
       
    }
}
