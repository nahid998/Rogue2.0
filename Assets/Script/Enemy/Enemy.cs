using System.Collections;
using UnityEngine;

public enum EnemyState
{
    idle,
    walk,
    attack,
    stagger
}

public class Enemy : MonoBehaviour
{
    [Header("State Machine")]
    public EnemyState currentState;

    [Header("Enemy Stats")]
    public FloatValue maxHealth;
    public float health;
    public string enemyName;
    public int baseAttack;
    public float moveSpeed;
    public Vector2 homePosition;

    [Header("Death Effects")]
    public GameObject deathEffect;
    private float deathEffectDelay = 1f;


    //private float deathEffectDelay = 1f;
    // public LootTable thisLoot;

    //[Header("Death Signals")]
    // public Signal roomSignal;
    private void Awake()
    {
        health = maxHealth.initialValue;
    }
    private void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            DeathEffect();
            //MakeLoot();
            //if (roomSignal != null)
            //{
            //    roomSignal.Raise();
            //}
            Destroy(this.gameObject);
        }
    }
    public void Knock(Rigidbody2D myRigidbody, float knockTime, float damage)
    {
        StartCoroutine(KnockCo(myRigidbody, knockTime,damage));
        TakeDamage(damage);
    }

    private IEnumerator KnockCo(Rigidbody2D myRigidbody, float knockTime, float damage)
    {
        if (myRigidbody != null)
        {
            yield return new WaitForSeconds(knockTime);
            myRigidbody.velocity = Vector2.zero;
            currentState = EnemyState.idle;
            myRigidbody.velocity = Vector2.zero;
        }
    }

    private void OnEnable()
    {
        transform.position = homePosition;
        // health = maxHealth.initialValue;
        currentState = EnemyState.idle;
    }



    //private void MakeLoot()
    //{
    //    if (thisLoot != null)
    //    {
    //        Powerup current = thisLoot.LootPowerup();
    //        if (current != null)
    //        {
    //            Instantiate(current.gameObject, transform.position, Quaternion.identity);
    //        }
    //    }
    //}

    private void DeathEffect()
    {
        if (deathEffect != null)
        {
            GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(effect, deathEffectDelay);
        }
    }
}