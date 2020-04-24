
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : CharStats
{
    public Color deadColor = Color.black;
    
    public HeartData heartData;

    public override void Die()
    {
        base.Die();
        
        heartData.LoseHeart();
        
        gameObject.GetComponent<Renderer>().material.color = deadColor;
        
        PlayerManager.instance.KillPlayer();
    }

    public void DieForReal()
    {
        SceneManager.LoadScene("KillScreen");
    }


}
