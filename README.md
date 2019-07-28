# Test_unity

Voici mon projet pour mon test technique en RA sur unity.
Le projet a été réalisé sur Unity 2019.1.12f1 (dernière version) et avec ARFoundation.
Utilisation de openweathermap

## Projet
Le projet detecte les surfaces planes. La zone qui est detectée est tactile, l'utilisateur peut créer de cubes mouvants en la touchant.

## Bonus
L'utilisateur à le choix entre deux options: "Create" ou "Shoot". Le "Create" permet de placer les cubes sur les surfaces planes detectées, comme expliqué ci-dessus. Une option "Shoot" fait apparaitre un viseur et un score, toucher l'écran dans ce mode permet de tirer un projectile vers le viseur, touche un cube avec un projectile lui fait perdre 1 point de vie et reduit sa taille, le rendant plus difficile à toucher. Les cubes possèdent 3 points de vie avant de disparaitre. Une fois détruit le score augmente de 1 point.
Le projectile tiré varie de couleur en fonction de la météo.

## Notes
La detection de la surface put prendre un peu de temps (10 seconde max en général).
