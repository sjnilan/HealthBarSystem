# HealthBarSystem
Health bar system  for Unity3d 5+

Add example cs file to any object that you want to use health bar.

Define HealthSystem instance<br>
Code:HealthSystem  HealthBar;
<br>

In Start function <br>
Code: HealthBar = GetComponent<HealthBarSystem>();
<br>

When damage is taken<br>
Code: HealthBar.Hit();<br>
Code:HealthBar.SetHelthValue ( HealthNeedToDisplay);

