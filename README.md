# HealthBarSystem
Health bar system  for Unity3d 5+

Add example cs file to any object that you want to use health bar.

In Start function <br>
Code: HealthBar = GetComponent&gt;HealthBarSystem>();
<br>

When damage is taken<br>
Code: HealthBar.Hit();<br>
Code:HealthBar.SetHelthValue ( HealthNeedToDisplay);

