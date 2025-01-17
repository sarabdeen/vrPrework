using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingDummyInteraction : MonoBehaviour
{
    
    public void OnMouseDown()
    {
        Debug.Log("Dummy Clicked");
       Destroy(gameObject); 
    }

  
    public void FaceToFace(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sword") && collision.gameObject.layer == LayerMask.NameToLayer("Interactable")){
            Destroy(gameObject);
        }

    }
}
