using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class CoinCollectable : Collectable
{
    public UnityEvent spendEvent;

    public override void Use()
    {
        spendEvent.Invoke();
    }
}
