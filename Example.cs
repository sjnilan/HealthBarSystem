using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour {

private Texture2D colBack;
private Texture2D colFront;
public float Health=90f;
public float MaxHealth=100f;
public float HealthBarHeight=2;
HealthSystem  HS =New HealthSystem ();

void Start () {
	colBack=HS.Colors(0,0,0);//Black color bar
	colFront=HS.Colors(0,255,0);//Green color bar - Health indicator
}

void OnGUI(){
	HS.Set_HealthBar(
		transform,
		HealthBarHeight,
		Health,
		MaxHealth,
		colBack,
		colFront);
}


}
