# Sonido en Unity - FDV

## Tarea 1

### Enunciado

Configurar una escena simple en 3D con un objeto cubo que hará de player y varias esferas de color. Agregar un objeto AudioSource desde el menú *GameObject → Audio*. Seleccionar un clip de audio en algún paquete de la Asset Store de tu gusto y adjuntarlo a una esfera. El audio se debe reproducir en cuanto se carga la escena y en bucle.

### Resolución

Para esta actividad, he diseñado una escena que incluye un personaje en primera persona y una esfera roja (Figura 1). A la esfera le he asignado un componente `Audio Source`. Además, he creado un script que permite el movimiento en primera persona del personaje.

![Descripción de la imagen](images/1.0.png)

*Figura 1: Escena básica*

En el componente `Audio Source` le añado un audio y le activo las propiedades de *PlayOnAwake* y *Loop*.

![Descripción de la imagen](images/1.png)

*Figura 1: Escena básica*

## Tarea 2

### Enunciado

En la escena anterior crea un objeto con una fuente de audio a la que le configures el efecto Doppler elevado y que se mueva a al pulsar la tecla m a una velocidad alta. Explica los efectos que produce:

- Incrementar el valor del parámetro Spread
- Cambiar la configuración de Min Distance y Max Distance
- Cambiar la curva de Logarithmic Rollof a Linear Rollof

### Resolución

## Tarea 3

### Enunciado

Configurar un mezclador de sonidos, aplica a uno de los grupo un filtro de echo y el resto de filtros libre. Configura cada grupo y masteriza el efecto final de los sonidos que estás mezclando. Explica los cambios que has logrado con tu mezclador.

### Resolución

## Tarea 4  

### Enunciado

Implementar un script que al pulsar la tecla p accione el movimiento de una esfera en la escena y reproduzca un sonido en bucle hasta que se pulse la tecla s.

### Resolución

## Tarea 5 

### Enunciado

Implementar un script en el que el cubo-player al colisionar con las esferas active un sonido.

### Resolución

## Tarea 6

### Enunciado

Modificar el script anterior para que según la velocidad a la que se impacte, el cubo lance un sonido más fuerte o más débil.

### Resolución

## Tarea 7

### Enunciado

Agregar un sonido de fondo a la escena que se esté reproduciendo continuamente desde que esta se carga. Usar un mezclador para los sonidos.

### Resolución

## Tarea 8

### Enunciado

Crear un script para simular el sonido que hace el cubo-player cuando está movimiento en contacto con el suelo (mecánica para reproducir sonidos de pasos).

### Resolución

## Tarea 9

### Enunciado

En la escena de tus ejercicios 2D incorpora efectos de sonido ajustados a los siguientes requisitos:
Crea un grupo SFX en el AudioMixer para eventos:
- Movimiento del personaje: Crea sonidos específicos para saltos y aterrizajes.
- Interacción y recolección de objetos: Diseña sonido para la recolección de objetos.
-Indicadores de salud/vida: Diseña un sonido breve y distintivo para cada cambio en el estado de salud (por ejemplo, ganar o perder vida).
Crea un grupo Ambiente:
- Crea un sonido de fondo acorde con el ambiente
- Agrega una zona específica del juego en que el ambiente cambie de sonido
Crea un grupo para música: Crea un loop de música de fondo acorde al tono del juego

### Resolución