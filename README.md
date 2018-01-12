# HealthBarSystem
Health bar system  for Unity3d 5+

Add example cs file to any object that you want to use health bar.

Define HealthSystem instance 
Code:HealthSystem  HealthBar;

In Start function 
Code: HealthBar = GetComponent<HealthBarSystem>();


When damage is taken
Code: HealthBar.Hit();
Code:HealthBar.SetHelthValue ( HealthNeedToDisplay);

