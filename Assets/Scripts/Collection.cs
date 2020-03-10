using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Collection : ScriptableObject
{
    public List<Collectable> collectablesList;

    //could use in an ontriggerenter
    public void AddToCollection(Collectable collectableObj)
    {
        collectablesList.Add(collectableObj);
    }

    public void RemoveFromCollection(Collectable collectableObj)
    {
        for (var index = 0; index < collectablesList.Count; index++)
        {
            var obj = collectablesList[index];
            if (obj == collectableObj)
            {
                collectablesList.Remove(collectableObj);
            }
        }
    }
}
