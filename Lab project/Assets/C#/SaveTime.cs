using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveTime : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public time Tm;
    Button click;
    short howmuch = 1;
    void Start()
    {
        click = gameObject.GetComponent<Button>();
        click.onClick.AddListener(WasClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void WasClicked()
    {
        if (howmuch < 4)
        {
            text.text += howmuch+") t = "+Tm.Tme + '\n';
            howmuch++;
        }
    }
}
