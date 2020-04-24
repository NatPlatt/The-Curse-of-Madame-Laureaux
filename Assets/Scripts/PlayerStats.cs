
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : CharStats
{
    public Color deadColor = Color.black;
    public GameObject killScreen;

    public override void Die()
    {
        base.Die();
        killScreen.SetActive(true);
        //SceneManager.LoadScene("KillScreen");
        gameObject.GetComponent<Renderer>().material.color = deadColor;
        PlayerManager.instance.KillPlayer();
    }


}
