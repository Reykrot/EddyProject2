using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcolateTotal : MonoBehaviour
{
    ComponentLocator componentLocator;

    // Start is called before the first frame update
    private void Start()
    {
        componentLocator = this.gameObject.GetComponentLocator();
    }
    public void CalculateTotalResult()
    {
        double.TryParse(overrideVirgola(componentLocator.number5.text), out double cheked5);
        double.TryParse(overrideVirgola(componentLocator.number50.text), out double cheked50);
        double.TryParse(overrideVirgola(componentLocator.number500.text), out double cheked500);
        double.TryParse(overrideVirgola(componentLocator.number10.text), out double cheked10);
        double.TryParse(overrideVirgola(componentLocator.number100.text), out double cheked100);
        double.TryParse(overrideVirgola(componentLocator.number200.text), out double cheked200);
        double.TryParse(overrideVirgola(componentLocator.number20.text), out double cheked20);

        List<double> parsedValue = new List<double>();
        parsedValue.Add(cheked5*5);
        parsedValue.Add(cheked50*50);
        parsedValue.Add(cheked500*500);
        parsedValue.Add(cheked10*10);
        parsedValue.Add(cheked100*100);
        parsedValue.Add(cheked200*200);
        parsedValue.Add(cheked20*20);

        double result = 0;
        foreach (var item in parsedValue)
        {
            if(item == default)
                result +=0 ;
            else
                result += item;
        }
         
            componentLocator.result.text = $"{result} €" ;
    }

    private string overrideVirgola(string toOverride)
    {
        if (toOverride.Contains('.'))
            return toOverride.Replace('.', ',');

        return toOverride;
    }

}
