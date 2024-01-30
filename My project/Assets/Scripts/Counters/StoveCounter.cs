using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveCounter : BaseCounter {
    
    [SerializeField] private FryingRecipeSO[] fryingRecipeSOArray;

    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            //there is no kitchenObject here
            if (player.HasKitchenObject())
            {
                // player is caring something
                if (HasRecipeWithInput(player.GetKitchenObject().GetKitchenObjectSO()))
                {
                    //player carrying sonething that can be Fried
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
                }
                else
                {
                    //player is not carrying anything
                    GetKitchenObject().SetKitchenObjectParent(player);
                }
            }
        }
    }
        private bool HasRecipeWithInput(KitchenObjectSO inputKitchenObjectSO)
        {
            FryingRecipeSO fryingRecipeSO = GetFryingRecipeSOWithInput(inputKitchenObjectSO);
            return fryingRecipeSO != null;

        }

        private KitchenObjectSO GetOutputForInput(KitchenObjectSO inputKitchenObjectSO)
        {
            FryingRecipeSO fryingRecipeSO = GetFryingRecipeSOWithInput(inputKitchenObjectSO);
            if (fryingRecipeSO != null)
            {
                return fryingRecipeSO.output;
            }
            else { return null; }

        }

        private FryingRecipeSO GetFryingRecipeSOWithInput(KitchenObjectSO inputKitchenObjectSO)
        {
            foreach (FryingRecipeSO fryingRecipeSO in fryingRecipeSOArray)
            {
                if (fryingRecipeSO.input == inputKitchenObjectSO)
                {
                    return fryingRecipeSO;
                }
            }
            return null;
        }
}
