**FECHA DE ENTREGA 24/01/2021**


**Requisitos:**
- Unity 2020.x.
- Visual Studio.

**Objetivos:**
1. Crear los siguientes sistemas e implementar el principio de segregación de la interfaz:
* a.  Sistema de puntos.
* b.  Sistema de vida en la UI.
* c.  Sistema de recuperación de vida mediante un power up.
2. Estructurar y comentar el código correctamente.
3. Compilar el proyecto de Unity para Windows.


**Procedimientos:**
1. Crear un sistema de puntos que almacene y sume puntos al eliminar un enemigo. Y mostrar los puntos en el objeto “Score” de la interfaz.
2. Mostrar los puntos de vida del jugador en la barra de vida del objeto “Lifebar” de la interfaz. Crear el efecto especial de muerte “Explosion” cada vez que la vida del jugador llegue a 0.
3. Crear un sistema de generación de prefabs “PowerUpHeal” en la parte superior de la pantalla de manera esporádica. El objeto “PowerUpHeal” se moverá hacia el límite inferior de la pantalla continuamente y se destruirá al entrar en contacto con el objeto “Player” o con el collider de la parte inferior de la pantalla. Al entrar en contacto con el objeto “Player”, este recuperará una fracción de su vida y aparecerá el objeto “HealEffect” como efecto especial.
4. Estructurar y comentar el código utilizando las regiones adecuadas y comentarios.
5. El proyecto se debe compilar para ser ejecutado en Windows. La compilación del proyecto se debe guardar en una carpeta llamada "build" en la raíz del proyecto de Unity.
