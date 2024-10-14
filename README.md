# P3: Movimiento - Físicas
## Hoja 1 - Experimentando con la física desde el editor
1. **El plano no es un objeto físico. El cubo es un objeto físico y la esfera no. En este caso, el plano y la esfera sólo tendrán collider, mientras que el cubo debe tener Rigidbody.**
  ![Situacion1](img/1.gif)
Observamos que el cubo se mantiene quieto ya que aunque se le aplica la física, y por tanto la gravedad, está apoyado sobre el collider del plano. La esfera y el plano están quietos ya que no se les aplica la física.
2. **El plano no es un objeto físico. El cubo es un objeto físico y la esfera también. En este caso, el plano sólo tendrán collider, mientras que el cubo y la esfera deben tener Rigidbody.**
![Situacion2](img/2.gif)
Ahora vemos que la gravedad afecta a la esfera, que cae chocando con el cubo y el plano ya que tienen collider. El plano no se cae ya que no se le aplica la física.
3.**El plano no es un objeto físico. El cubo es un objeto físico y la esfera es cinemática. En este caso, el plano sólo tendrán collider, mientras que el cubo y la esfera deben tener Rigidbody esta última cinemático.**
![Situacion3](img/3.gif)
Observamos que pese a que la esfera tiene rigidbody al ser cinemática no se le aplica la física y por tanto se queda quieta sin sufrir gravedad.
4. **El plano es un objeto físico. El cubo es un objeto físico y la esfera es física. En este caso, todos los objetos deben tener Rigidbody.**
![Situacion4](img/4.gif)
Vemos que como todos los objetos son físicos sufren la gravedad, por lo que todos caen a la vez hacia el vacío.
5. **El plano es un objeto físico. El cubo es un objeto físico y la esfera es física con 10 veces más masa que el cubo. En este caso, todos los objetos deben tener Rigidbody.**
![Situacion5](img/5.gif)
Apreciamos que la esfera cae a la misma velocidad que el resto de objeto a pesar de tener más masa. Esto es debido a que los objetos están en el vacío/no sufren fricción.
6. **El plano es un objeto físico. El cubo es un objeto físico y la esfera es física con 100 veces más masa que el cubo. En este caso, todos los objetos deben tener Rigidbody.**
![Situacion6](img/6.gif)
Aumentar la masa de la esfera no cambia nada ya que sigue sin haber fricción.
7. **El plano es un objeto físico. El cubo es un objeto físico y la esfera es física con fricción. En este caso, todos los objetos deben tener Rigidbody.**
![Situacion7](img/7.gif)
Ahora, debido a que la esfera tiene fricción (que establecemos con el ajuste ```drag```), ejerce resistencia con el "aire" y cae a menor velocidad que el resto de objetos.
8. **El plano es un objeto físico. El cubo es un objeto físico y la esfera no es física y es Trigger. En este caso, todos los objetos deben tener Rigidbody.**
![Situacion9](img/8.gif)
Vemos que, al no ser física, la esfera no sufre la gravedad, por lo que se queda quieta. Que sea trigger no afecta a nada.
9. **El plano es un objeto físico. El cubo es un objeto físico y la esfera es física y es Trigger. En este caso, todos los objetos deben tener Rigidbody.**
![Situacion9](img/9.gif)
Vemos que, al ser físicca, la esfera sí sufre la gravedad, al igual que el resto de objetos de la escena. Por tanto, no se puede percibir la diferencia de que sea trigger respecto a cuando no lo es (Caso 4).
