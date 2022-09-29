using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // PASSION LAB SCRIPT (BY REDCOAT)
    
    public float speed = 1f;
    public int infection_stage = 1; // The stages of your infection from 1 to 5
    public float infection_progress = 0f; // The overall infection
    public float infection_regress = 1f; // How quickly your infection decreases 
    public float infection_kill_bonus = 80f; // How many points you get for a kill
    public float infection_infect_bonus = 30f; // How many points you get for an infection

    Rigidbody2D playerObject; 

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        playerObject.AddForce(new Vector2(Input.mousePosition[0],Input.mousePosition[1]));

    }

}
