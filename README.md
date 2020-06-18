# 2020_06_15_EnnioToolboxDemo

Affichage quand l'utilisateur regarde son "poignet",

Il y a un prefab où l'écran sera affiché, et il suffit de link la tête de l'utilisateur dans le script (Je ne pouvais pas le faire dans le prefab directement).

/!\ Changer la 'Person Data' en fonction de la personne ayant créer la salle actuelle /!\
-----------------------------------------------------------------------------------------


Pour la théorie vite fait, l'affichage s'active quand l'axe FORWARD du gameObject Head regarde Wrist et que l'axe UP Wrist regarde Head ausi.
