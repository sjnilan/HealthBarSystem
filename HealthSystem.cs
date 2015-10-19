using UnityEngine;
using System.Collections;

public class HealthSystem : MonoBehaviour {
float healthBarLenght=20f;//Length for Healthbar;

public static void Set_HealthBar(Transform transform,int HealthBarHeight,	float CurrentHealth,float MaxHealth,Texture2D BackBar, Texture2D FrontBar)
		{
		Vector3 screenPosition;
  
		GUIStyle style1 = new GUIStyle();
		GUIStyle style2 = new GUIStyle();
		float HPDrop = (CurrentHealth / MaxHealth) * healthBarLenght;

		screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		screenPosition.y = Screen.height - screenPosition.y;

		style1.normal.background = BackBar;
		GUI.Box(new Rect(screenPosition.x-(healthBarLenght/2),screenPosition.y-20, healthBarLenght,HealthBarHeight),"",style1);

		style2.normal.background = FrontBar;
		GUI.Box(new Rect(screenPosition.x-(healthBarLenght/2),screenPosition.y-20, HPDrop,HealthBarHeight),"",style2);
}
		
		
	public static Texture2D Colors(int r,int g, int b)
	{
		Texture2D texture = new Texture2D(2, 2);
		for (int y = 0; y < texture.height; ++y)
		{
			for (int x = 0; x < texture.width; ++x)
			{				
				Color color = new Color(r, g, b);
				texture.SetPixel(x, y, color);
			}
		}
		texture.Apply();
		return texture;
	}
}
