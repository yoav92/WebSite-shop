using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Cart
/// </summary>
public class Cart
{
    public Item[] ArrItem;//un tableau d'article
    public int Size;
    public Cart()
    {
        ArrItem = new Item[100];
        Size = 0;
    }
    public void AddtoCart(Item tmp)
    {
        ArrItem[Size] = tmp;
        Size++;
    }
  
    public void EmptyCart()
    {
        Size = 0;
    }
    public void RemoveFromCart(int pid)
    {
        for(int i=0;i<Size;i++)
        {
            if(ArrItem[i].Pid==pid)
            {
                for(int j=i;j<Size-1;j++)
                {
                    ArrItem[j] = ArrItem[j + 1];//on decale les produits dans le panier,le j+1 devient j
                }
                Size--;//on diiminue la taille du panier
            }
        }
    }
}