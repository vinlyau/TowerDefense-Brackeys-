using UnityEngine;

public class Enemy : MonoBehaviour {

    public float health = 100f;
    public int worth = 50;
    public float startSpeed = 30f;
    [HideInInspector]
    public float speed;

    public GameObject deathEffect;

    private void Start()
    {
        speed = startSpeed;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        PlayerStats.Money += worth;
        GameObject effect = (GameObject) Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
        Destroy(gameObject);
    }

    public void Slow(float pct)
    {
        speed = (1f - pct) * startSpeed;
    }
}
