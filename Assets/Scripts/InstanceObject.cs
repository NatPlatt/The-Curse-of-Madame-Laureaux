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
    
    public void CreateInstance(GameObject instance)
    {
        for (int i = 0; i < instanceAmount; i++)
        {
           InstanceSomething(instanceObj);
           instanceAtLocation = new Vector3(Random.Range( -10f, 10f),0f, Random.Range(-10f, 10f));
        }
    }

    public void InstanceSomething(GameObject obj)
    {
        //var newObj = Instantiate(obj, instanceAtLocation, Quaternion.identity);
        //gameActionObj.transformAction(newObj.transform);

        Instantiate(instanceObj, instanceAtLocation, Quaternion.identity);
    }
}

