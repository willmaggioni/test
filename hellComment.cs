// Importa il namespace 'System', che contiene le classi base come 'Console'
using System;

// Definisce un contenitore (namespace) per organizzare il tuo codice e prevenire conflitti di nomi
namespace HelloWorldApp
{
    // Definisce una classe chiamata 'Program': in C#, tutto il codice deve stare dentro una classe
    class Program
    {
        // Questo è il 'punto di ingresso' (Main) del programma: è da qui che il computer inizia a leggere
        static void Main(string[] args)
        {
            // Usa il comando WriteLine della classe Console per stampare il testo a schermo
            Console.WriteLine("Hello, World!");
            
            // (Opzionale) Aspetta che l'utente prema un tasto prima di chiudere la finestra del terminale
            // Console.ReadKey();
        }
    }
}
