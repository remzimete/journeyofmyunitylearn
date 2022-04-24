using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class basicmarket : MonoBehaviour
{
   
   public GameObject CreditForDisplay;
   private int price = 5;
    public int credit; 
    public void BuyInMarket()
    {
        if(credit != 0) {
        credit = credit - price;
            CreditForDisplay.GetComponent<Text>().text = "Kredin&Credit :   " + credit;

        }
        else if(credit == 0)
        {
            Debug.Log("money is done");
            CreditForDisplay.GetComponent<Text>().text = "Kredin&Credit : DONE!   " + credit;

        }

        Debug.Log("" + " kredi :  " + credit);


    }

}
