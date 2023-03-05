using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public enum ItemType
    {
        ExtraBomb,
        BlastRadius,
        Speed
    }

    public ItemType type;

    private void OnItemPickUp(GameObject player)
    {
        switch (type)
        {
            case ItemType.ExtraBomb:
                //logic extraBomb here


                break;
            case ItemType.BlastRadius:
                //logic blastRadius here

                break;

            case ItemType.Speed:
                //logic speed here
                player.GetComponent<MovementController>().speed++;
                break;
        }

        //destroy item pickup
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnItemPickUp(collision.gameObject);
        }
    }
}

