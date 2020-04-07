using UnityEngine.Events;

public class CoinCollectable : Collectable
{
    public UnityEvent spendEvent;

    public override void Use()
    {
        spendEvent.Invoke();
    }
}
