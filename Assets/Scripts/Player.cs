

using UnityEngine;

public class Player : Interactable
{
    public GameObject enemy;
    public Color dangerColor = Color.magenta;
    
    public override void Interact()
    {
        base.Interact();
        if (enemy == null)
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
    }
    
     private void OnTriggerEnter(Collider other)
       {
           gameObject.GetComponent<Renderer>().material.color = dangerColor;
           Debug.Log("You are in the danger/attack zone Player");
       }
    
       private void OnTriggerExit(Collider other)
       {
           gameObject.GetComponent<Renderer>().material.color = Color.white;
       }
}
