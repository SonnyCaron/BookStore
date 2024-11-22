# Faire un Pull request

Installer Github CLI si ce n’est pas déjà fait :

<https://cli.github.com/> -> cliquer sur download for windows et faire l’installation

Une fois l’installation terminé, ouvrir l’invite de commande et faire : gh auth login

Suivre les étapes pour se connecter avec github.com

Pour faire un pull request :

Dans visual studio, cloner le dépôt (dans ce cas-ci c’est <https://github.com/Azariade/BookStore>)

Faire les modifications voulues

Dans l’endroit où les fichiers sont listés cliquer sur modifications git

S’il est écrit master juste en dessous du titre de l’onglet, suivre ces instructions :

Cliquer sur master

Cliquer sur nouvelle branche

Choisir un nom de branche pour représenter les changements

Cliquer sur create

Dans entrer un message &lt;obligatoire&gt;, mettre un message au choix (ce message ne sera visible par personne), puis cliquer sur Valider tout

Revenir dans l’invite de commande, puis écrire : gh pr create

Suivre les instructions (title est le message que l’on verra)

Vous pouvez vérifier dans l’onglet pull request du github dans votre navigateur web que votre pull request y est
