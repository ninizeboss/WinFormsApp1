/**Créer un nouveau projet Exercice61.

Le programme doit permettre de :

L’objet txtNom doit contenir votre prénom stocké dans une variable (ex. «Nicolas Garcia »).
Le contenu de txtAge est rempli automatiquement par calcul par rapport à la date de naissance : il faut donc faire en sorte que sont contenu ne soit pas accessible par l’utilisateur
Le contennu de txtDateNaiss doit être aligné à droite.
 */

using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string nom = "Nicolas Garcia";
            string dateNaissance = "05/06/1967";
            int currentYear = DateTime.Now.Year; //Récupération de l'année courante
            int anneeNaissance = 1967;
            //Dans l'objet txtNom on doit saisir "Entrer le nom dans l'attribut Text.
            txtNom.Text = nom;
            //En mettant l'attribut Enabled à false, il n'est pas possible de rentrer de valeur
            txtAge.Enabled = false;
            txtAge.Text = (currentYear - anneeNaissance).ToString() + " ans";//Calcul et conversion âge pour affichage.
            //Positionnement du curseur à droite de la boite de saisie.
            txtDateNaiss.TextAlign = HorizontalAlignment.Right;
            txtDateNaiss.Text = dateNaissance;
        }
    }
}