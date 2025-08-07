using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattaryCrg : MonoBehaviour
{
    public Slider slider;
    public double voltage;
    public TMP_Text value;
    public GameObject battery;
    public static BattaryCrg instance;

    void Awake()
    {
        instance = this;
    }
    void Update()
    {
        voltage = slider.value;
        value.text = voltage.ToString("F2"); // Shows 2 decimal places
        if (voltage < 0)
        {
            battery.transform.rotation = Quaternion.Euler(0, -180, 0);
        }
        else
        {
            battery.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
