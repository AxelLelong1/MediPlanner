# **Projet de Gestion Médicale**

Ce projet combine une application **Django** (backend), une **API RESTful ASP.NET** (backend secondaire), et une interface utilisateur utilisant des technologies front-end comme **HTML/CSS/JavaScript**. Il vise à gérer les plannings de patients avec des fonctionnalités avancées.

# Sommaire

```plaintext
MediPlanner/
├── Prérequis/             
└── Installation/
    ├── Backend Django/
    └── RESTFUL API/
├── Structure du Projet
├── Changer les targets réseaux
└── Contribuer
```

## **Prérequis**

1. **Systèmes** :
   - Windows, macOS ou Linux avec accès administrateur.
2. **Logiciels nécessaires** :
   - Python 3.9+
   - .NET Core SDK (version compatible avec le projet)
3. **Outils recommandés** :
   - Visual Studio Code ou Visual Studio (pour l'édition de code C# et Python)

---

## **Installation**

### 1. **Backend Django**

#### Cloner le projet
```bash
git clone https://github.com/votre-repo/projet.git
cd projet
```

#### Créer un environnement virtuel Python
```bash
python -m venv env
source env/bin/activate # Sur Linux/Mac
env\Scripts\activate    # Sur Windows
```

#### Installer les dépendances Python
```bash
pip install -r requirements.txt
```

#### Migrer la base de données si des données si besoin
```bash
python manage.py makemigrations
python manage.py migrate
```

#### Lancer le serveur Django
```bash
python manage.py runserver
```

#### Tester le déploiements
```bash
python manage.py check --deploy
```

---

### 2. **API RESTful ASP.NET**

#### Ouvrir le projet
- Ouvrez le projet dans **Visual Studio** ou via une interface en ligne de commande.

#### Restaurer les dépendances NuGet
```bash
dotnet restore
```

#### Compiler et exécuter l'API
```bash
dotnet build
dotnet run
```

L'API sera accessible à une URL locale, par exemple : `https://localhost:5001`

---

## **Structure du Projet**

```plaintext
projet/
├── MediCore/                # Code source pour l'API RESTful (ASP.NET)
└── ClinicAPP/            # Application Django
    └── static/           # contient les pages html, css, et le js
├── README.md           # Documentation
├── requirements.txt    # Dépendances Python
└── .gitignore          # Fichiers ignorés par Git
```

---

## **Changer les targets réseaux**

### API RESTFUL

Chercher `appsettings.json` dans MediCore, vous y trouverez ceci
```json
"AllowedHosts": "*",
"Kestrel": {
  "Endpoints": {
    "Http": {
      "Url": "http://localhost:5001"  // Changez l'URL ici !
    }
  }
},
```

:warning: ATTENTION ! L'application Django doit pouvoir communiquer avec le serveur !
Il faut donc lui indiquer la bonne adresse également dans `patients\helper\fetch.py` !

### Django

Si vous voulez lancer le serveur **de développement** sur une adresse spécifique `python manage.py runserver 0.0.0.0:0000` avec l'ip que vous souhaitez
Si vous voulez changer l'adresse **de déploiement** à voir selon les méthodes employés que vous avez utilisé pour déployer l'application Django. 
---

## **Contribuer**

1. Forkez le dépôt.
2. Créez une branche pour votre fonctionnalité (`git checkout -b ma-fonctionnalité`).
3. Faites vos modifications et validez-les (`git commit -m 'Ajout d'une fonctionnalité'`).
4. Poussez la branche sur votre fork (`git push origin ma-fonctionnalité`).
5. Soumettez une Pull Request.

---

## **Contact**

Pour toute question ou suggestion, contactez moi à : **axel.lelong@outlook.com**!
