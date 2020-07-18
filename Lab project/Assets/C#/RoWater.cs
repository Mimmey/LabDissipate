using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoWater : MonoBehaviour
{

    public Dropdown dropdown;
    public int pLiqid;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (dropdown.value)
        {
            case 0:
                text.text = "Жидкость, ρ=1220 кг/m^3";
                pLiqid = 1220;
                break;
            case 1:
                text.text = "Жидкость, ρ=1260 кг/m^3";
                pLiqid = 1260;
                break;
            /*case 2:
                text.text = "Жидкость, ρ=876 кг/m^3";
                pLiqid = 876;
                break;
            case 3:
                text.text = "Жидкость, ρ=997 кг/m^3";
                pLiqid = 997;
                break;
            */
        }
    }
}
