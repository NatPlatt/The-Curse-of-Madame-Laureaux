
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerStats : CharStats
{
    public Color deadColor = Color.black;
    
    public HeartData heartData;

    public UnityEvent deathEvent;

    public override void Die()
    {
        base.Die();
        
        deathEvent.Invoke();

        gameObject.GetComponent<Renderer>().material.color = deadColor;
        
        PlayerManager.instance.KillPlayer();
    }

    public void DieForReal()
    {
        SceneManager.LoadScene("KillScreen");
    }


}
