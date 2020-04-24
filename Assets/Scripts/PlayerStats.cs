
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : CharStats
{
    public Color deadColor = Color.black;
    //public GameObject killScreen;
    public HeartData heartData;

    public override void Die()
    {
        base.Die();
        //killScreen.SetActive(true);
        
        gameObject.GetComponent<Renderer>().material.color = deadColor;
        if (heartData.currentHearts <= 0)
        {
            SceneManager.LoadScene("KillScreen");
        }
        PlayerManager.instance.KillPlayer();
    }


}
