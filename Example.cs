using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
public float Health=100f;
float temp_Health;
HealthSystem  HealthBar;

void Start () {
	HealthBar = GetComponent<HealthBarSystem>();
	temp_Health=Health;
}

public void TakeDamage(float  _Damage){
	HealthBar.Hit();
	temp_Health = temp_Health - _Damage;
	HealthBar.SetHelthValue ( temp_Health);
}

}
