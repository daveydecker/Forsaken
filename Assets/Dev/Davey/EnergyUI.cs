using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class EnergyUI : MonoBehaviour
{
    public UnityEngine.UI.Image energyImage;
    public float currentEnergy = 100f;
    public float maxEnergy = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Update()
    {
       //energyImage.fillAmount = currentEnergy / maxEnergy; 
    }

    public void updateEnergy(float amount)
    {
        currentEnergy += amount;
        energyImage.fillAmount = currentEnergy / maxEnergy;
    }

}
