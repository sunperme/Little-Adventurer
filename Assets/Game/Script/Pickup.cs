using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public enum PickupType
    {
        Heal, Coin
    }


    public PickupType Type;
    public int Value = 20;
    public ParticleSystem CollectedVFX;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<Character>().PickUpItem(this);
            if (CollectedVFX != null)
                Instantiate(CollectedVFX, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
