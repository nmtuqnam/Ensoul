namespace EnsoulSharp.Xerath
{
    using System;
    using EnsoulSharp.SDK;

    internal class Program
    {
        private static void Main(string[] args)
        {
            GameEvent.OnGameLoad += OnGameLoad;
        }

        private static void OnGameLoad()
        {
            if (ObjectManager.Player.CharacterName != "Xerath")
                return;
            Katarina.OnLoad();
            Chat.PrintChat("<font color = '#FFFFFF' > [ahihi -> Xerath]");
        }
    }
}
