using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter {

    [SerializeField] private KitchenObjectSO kitchenObjectSO;


    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            //there is no kitchenObject here
            if (player.HasKitchenObject())
            {
                // player is caring something
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {
                //player not carrying anything
            }
        }
        else
        {
            //there is a kitchenObject here
            if (player.HasKitchenObject())
            {
                //player is carrying something
            } else
            {
                //player is not carrying anything
                GetKitchenObject().SetKitchenObjectParent(player);
            }
            
        }
    }
}