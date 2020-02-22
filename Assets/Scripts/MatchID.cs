using System.Collections;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.Serialization;

public class MatchID : MonoBehaviour
{
    public NameId id;
    public UnityEvent onMatch;
    public UnityEvent noMatch;
    public bool MatchMade { private get; set; }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
