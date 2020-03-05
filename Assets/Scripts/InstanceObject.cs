using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

[CreateAssetMenu(menuName = "Instancing/Instance Object")]
public class InstanceObject : ScriptableObject
{
    public int instanceAmount = 4;
    public Vector3 instanceAtLocation;
    public GameAction gameActionObj;
    public GameObject instanceObj;
    public Transform instanceHere;
    
    public void CreateInstance(GameObject instance)
    {
        for (int i = 0; i < instanceAmount; i++)
        {
           InstanceSomething(instanceHere);
           instanceAtLocation = Vector3.one;
        }
    }

    public void InstanceSomething(Transform location)
    {
        //var newObj = Instantiate(obj, instanceAtLocation, Quaternion.identity);
        //gameActionObj.transformAction(newObj.transform);

        Instantiate(instanceObj, instanceAtLocation, location.rotation);
    }
}

