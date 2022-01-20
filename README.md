# Practica2-FDV

Implementar una aplicación en Unity3D en la que habrá una serie de objetos dispuestos en la escena y que proporcionarán poderes al jugador (otro objeto).

Todos los objetos pueden ser formas básicas (cubos, esferas, cilindros).
Los objetos se distribuyen por la escena y se catalogan en dos tipos, en movimiento rectilíneo y estáticos.
Algunos objetos son estáticos, el jugador cuando colisiona, los desplaza una cantidad proporcional a su poder.
Otros objetos al colisionar se desplazan por la fuerza que ejerce el jugador sobre ellos y hacen que el jugador sume puntos.
Cuando el jugador suma puntos, las dimensiones del objeto disminuyen y se atenúa su color, cuando se llega a un umbral desaparece el objeto.

----------------------------------------------------

Como se puede observar hay tres tipos de objetos:
El jugador que es un asset, el cilindro que es objeto móvil y el cubo que es el estático 
Cuando colisiona con un objeto móvil se mueven una cantida igual a la fuerza que ejerce el jugador sobre ellos.
![Vídeo 1](assets/VIDEOS/Proyecto sin título-%05d.gif)
En cambio, con un objeto estático, se mueve de acuerdo una cantidad proporcional al poder del jugador.
![Vídeo 1](assets/VIDEOS/practica2_1-%05d.gif)
![Vídeo 1](assets/VIDEOS/practica2_3-%05d.gif)

Ambos objetos hacen sumar puntos al jugador y cuando colisionan sus dimesiones disminuyen hasta desaparecer.
