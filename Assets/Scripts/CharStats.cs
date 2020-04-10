
using UnityEngine;

public class CharStats : MonoBehaviour
{
    public int maxHP = 100;
    private int currentHP { get; set; }
    
    public Stats damage;

    public HealthBar healthbar;

    //public int mistDamage;

    //public FloatData damage;
    
    public Color hitColor = Color.red;
    public Color restColor;

    private void Awake()
    {
        currentHP = maxHP;
    }
    private void Start()
    {
        if (healthbar != null) healthbar.SetMaxHealth(maxHP);
    }

    private void FixedUpdate()
    {
        GetComponent<Renderer>().material.color = restColor;
    }

    public void TakeDamage(int damage)
    {
        damage = Mathf.Clamp(damage, 0, int.MaxValue); //damage can never go below 0
        
        currentHP -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage.");

        GetComponent<Renderer>().material.color = hitColor;

        if (currentHP <= 0)
        {
            Die();
        }
        healthbar.SetHealth(currentHP);
    }
    
    public virtual void Die()
    {
        //die in some way, run animation, start back at starting position, etc.
        //this will later be changed depending on who is dying
        Debug.Log(transform.name + " died.");
    }

    /*public virtual void MistDamageAttack()
    {
        currentHP -= mistDamage;
        healthbar.SetHealth(currentHP);
        Debug.Log("the mist is attacking");
    }*/
}
