using UnityEngine;

public class Coin : PowerUP
{
    // Start is called before the first frame update
    public Inventory playerInventory;

    // Start is called before the first frame update
    private void Start()
    {
        powerupSignal.Raise();
    }



    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            playerInventory.coins += 1;
            powerupSignal.Raise();
            Destroy(this.gameObject);
        }
    }
}