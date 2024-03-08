using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodinGame_WA
{
    public class ServerRoom
    {
        public int[] Solve(string direction, int x, int y, int width, int height)
        {
            {
                double newX = 0;
                double newY = 0;

                if (direction.Contains('U'))
                {
                    newX = x - ((height - x) / 2);
                };
                if (direction.Contains('D'))
                {
                    newX = x + ((height - x) / 2);

                };
                if (direction.Contains('R'))
                {
                    newY = y + ((width - y) / 2);
                };
                if (direction.Contains('L'))
                {
                    newY = y - ((width - y) / 2);

                };
                return [(int)(Math.Ceiling(newX)), (int)(Math.Ceiling(newY))];
            }

        }
     }
}


//Objectif

//Trouver le serveur infecté.
//Règles

//Vous êtes un ingénieur dans un datacenter, et l'un de vos serveurs est en train de se faire hacker.
//Vous ne savez pas lequel, mais vous pouvez examiner chaque serveur du datacenter pour savoir si c'est
//le bon.

//Le jeu se joue sur une grille de width serveurs de large et height serveurs de haut. Le serveur dans le
//coin en haut à gauche est en (0, 0). x représente la colonne et y représente la ligne.

//À chaque tour, vous recevez votre position courante x, y et la direction vers le serveur infecté :
//U(Up): le serveur cible est au-dessus de vous
//UR (Up Right): le serveur cible est au-dessus de vous et sur votre droite
//R (Right): le serveur cible est sur votre droite
//DR (Down Right): le serveur cible est en-dessous de vous et sur votre droite
//D (Down):le serveur cible est en-dessous de vous
//DL (Down Left): le serveur cible est en-dessous de vous et sur votre gauche
//L (Left): le serveur cible est sur votre gauche
//UL (Up Left): le
//serveur cible est au-dessus de vous et sur votre gauche
//Vous devez retourner la position du serveur que vous voulez examiner sous la forme d'un tableau de 2
//entiers.

//Pour réussir votre mission, vous devez trouver le serveur infecté le plus vite possible, avant que le
//hacker n'infiltre votre réseau, ce qui est représenté sous la forme d'un nombre maximum de tentatives.
//Vos coordonnées initiales ne sont pas toujours (0, 0) et la direction initiale n'est pas toujours "DR".
//Implémentation

//Implémentez la méthode Solve(direction, x, y, width, height) où les paramètres sont :
//direction: une chaîne de caractères parmi les 8 directions possibles x: votre x actuel y: votre y actuel
//width: la largeur de la grille height: la hauteur de la grille
//et qui doit retourner la prochaine position x, y où vous souhaitez aller, sous la forme d'un tableau de 2
//entiers.
