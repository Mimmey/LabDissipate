using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phys : MonoBehaviour
{ 
   //This script never use
   /*
    public Rigidbody2D Ball;
    public Transform BallTr;
    float r0 = 0.003f, R = 0;
    float g = 9.82f, Pp = 2700f, Pf = 997f, u = 0.001f;
    float Vs = 10;
    Vector2 test = new Vector2(0, 0);
    float Geff = 0;
    float Alpha = 0;
    float time = 0;
    float V0 = 0;
    bool flag = true;
    float NewY = 0;
  
    void Start()
    {
        
        Ball = gameObject.GetComponent<Rigidbody2D>();
        BallTr = gameObject.GetComponent<Transform>();
        //Vs = (((float)2 / 9) * (r0 * r0 * g * (Pp - Pf)) / u);
        //print(Vs);
        Geff = 9.82f * (1 - (Pf / Pp)); print("Geff is" + Geff);
        Alpha = ((float)9 / 2) * u / Pp / r0/ r0; print("Alpha is" + Alpha);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        
        if (BallTr.transform.position.y < -0.1f && BallTr.transform.position.y > -0.9f)
        {
            
            if (flag) { V0 = Ball.velocity.y; flag = false;  }
            //Ball.velocity = new Vector2(0, -Vs);
            time += Time.deltaTime;
            float ExpDone = Mathf.Exp((-1) * Alpha * time); 
            NewY = (V0 * ExpDone) - (Geff / Alpha) * (1 - ExpDone); ;
            Ball.velocity = new Vector2(0, NewY);
        }
        if (BallTr.transform.position.y <= -0.96f) { Ball.simulated = false; }
        
    }
    */
    
}
