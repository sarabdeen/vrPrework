using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playMovement : MonoBehaviour
{
  public float speed = 5f;
   public void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(x,0,z) * speed * Time.deltaTime;

        transform.Translate(move, Space.World);

        //transform.Translate(x * speed * Time.deltaTime, 0, z * Time.deltaTime);
        
    }

   
}
