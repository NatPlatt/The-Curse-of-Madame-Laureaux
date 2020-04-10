
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : CharStats
{
    public EnemyStats enemyStat;
    public Color deadColor = Color.black;

    public override void Die()
    {
        base.Die();
        SceneManager.LoadScene("KillScreen");
        gameObject.GetComponent<Renderer>().material.color = deadColor;
        PlayerManager.instance.KillPlayer();
    }


}
