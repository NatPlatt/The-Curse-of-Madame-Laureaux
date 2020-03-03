using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.Serialization;

public class MatchID : MonoBehaviour
{
    
    [Serializable]
    public struct possibleWork
    {
        public NameId nameIdObj;
        public UnityEvent enterEvent, exitEvent;
    }
    
    public NameId id;
    public UnityEvent onMatch;
    public UnityEvent noMatch;
    private IdBehavior otherIdBehaviorObj;
    private NameId otherIdObj;
    public List<possibleWork> workIdList;
    public bool MatchMade { private get; set; }
    
    private void OnTriggerEnter(Collider other)
    {
        var otherId = other.GetComponent<MatchID>();
        if (otherId == null) return;

        if (otherId.id == id || otherId.MatchMade)
        {
            onMatch.Invoke();
        }
        else
        {
            noMatch.Invoke();
        }
    }
}
