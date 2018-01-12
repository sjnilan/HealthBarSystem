# HealthBarSystem
Health bar system  for Unity3d 5+

Add example cs file to any object that you want to use health bar.

Define HealthSystem instance 
       HealthSystem  HealthBar;

In Start function 
	   HealthBar = GetComponent<HealthBarSystem>();


When damage is taken
	HealthBar.Hit();
	HealthBar.SetHelthValue ( HealthNeedToDisplay);
}

