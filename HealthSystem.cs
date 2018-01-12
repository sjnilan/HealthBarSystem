using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSystem : MonoBehaviour
{
    public Color BackColor;
    public Color HealthBarColor;
    public int HealthBarHeight = 2;
    public float healthBarLenght = 20f;//Length for Healthbar;
    
    private Texture2D colBack;
    private Texture2D colFront;
    
    public float CurrectHealth = 100f;
    float MaxHealth = 100f;

    public float FadeOuttimer = 5;
    float FadeOuttimer_temp = 0;
    public bool ShowHealth = false;

    void Start()
    {
        colBack = Colors(BackColor);//Black color bar
        colFront = Colors(HealthBarColor);//Green color bar - Health indicator

        FadeOuttimer_temp = FadeOuttimer;
    }

    void Update()
    {
       
        if(FadeOuttimer>0)
        {
            FadeOuttimer -= Time.deltaTime;
            if (FadeOuttimer < 0)
            {
                FadeOuttimer = 0;
                ShowHealth = false;
            } 
        }     
    }

    public void Hit()
    {
        FadeOuttimer = FadeOuttimer_temp;
        ShowHealth = true;
    }

    public void SetMaxHelthValue(float value)
    {
        MaxHealth = value;
    }

    public void SetHelthValue(float value)
    {
        CurrectHealth = value;
    }

    void OnGUI()
    {
        if (ShowHealth == true)
        {
            Set_HealthBar(transform, HealthBarHeight, CurrectHealth, MaxHealth, colBack, colFront);
        }
    }


    public void Set_HealthBar(Transform transform, int HealthBarHeight, float CurrentHealth, float MaxHealth, Texture2D BackBar, Texture2D FrontBar)
    {
        Vector3 screenPosition;

        GUIStyle style1 = new GUIStyle();
        GUIStyle style2 = new GUIStyle();
        float HPDrop = (CurrentHealth / MaxHealth) * healthBarLenght;

        screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        screenPosition.y = Screen.height - screenPosition.y;

        style1.normal.background = BackBar;
        GUI.Box(new Rect(screenPosition.x - (healthBarLenght / 2), screenPosition.y - 20, healthBarLenght, HealthBarHeight), "", style1);

        style2.normal.background = FrontBar;
        GUI.Box(new Rect(screenPosition.x - (healthBarLenght / 2), screenPosition.y - 20, HPDrop, HealthBarHeight), "", style2);
    }


    public Texture2D Colors(Color ThisColor)
    {
        float r = ThisColor.r;
        float g = ThisColor.g;
        float b = ThisColor.b;
        float a = ThisColor.a;

        Texture2D texture = new Texture2D(2, 2);
        for (int y = 0; y < texture.height; ++y)
        {
            for (int x = 0; x < texture.width; ++x)
            {
                Color color = new Color(r, g, b,a);
                texture.SetPixel(x, y, color);
            }
        }
        texture.Apply();
        return texture;
    }

   
}
