using System;

namespace DeurClass
{
    public class Door
    {
        private bool isLocked;
        private bool isOpen;
        public string DoorName { get; }

        public Door(string doorName)
        {
            isLocked = true;
            isOpen = false;
            DoorName = doorName;
        }

        public string UseKey(string direction)
        {
            switch (direction)
            {
                case "links":
                    // ontgrendel
                    isLocked = false;
                    return "De deur is ontgrendeld";

                case "rechts":
                    // vergrendel
                    isLocked = true;
                    return "De deur is vergrendeld";

                default:
                    return "Rechts of links draaien";
            }
        }

        public string OpenDoor()
        {
            if (!isLocked)
            {
                // deur is ontgrendeld en kan open
                isOpen = true;
                return "De deur staat open";
            }
            else
            {
                // deur is vergrendeld en dicht
                isOpen = false;
                return "De deur is nog op slot";
            }
        }

        public string WalkThrough()
        {
            if (isOpen)
            {
                // deur is open, je kan binnen
                return "Je bent in de huiskamer";
            }
            else
            {
                // deur is dicht, je botst ertegenaan
                return "Je loopt tegen de deur aan";
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            Door voordeur = new Door("Voordeur");

            Console.WriteLine(voordeur.UseKey("links"));
            Console.WriteLine(voordeur.OpenDoor());
            Console.WriteLine(voordeur.WalkThrough());
        }
    }
}

