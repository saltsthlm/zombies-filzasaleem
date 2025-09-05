using System.Dynamic;
using Microsoft.VisualBasic;

namespace Zombies;

public class ZombieRoom
{
    public int capacity { get; private set; }

     private List<string> zombies;
    public ZombieRoom(int capacity = 5)
    {
        this.capacity = capacity;
        zombies = new List<string>();
    }


    public void addZombie(string name)
    {
        if (zombies.Count == this.capacity)
        {
            zombies.RemoveAt(0);
        }
        zombies.Add(name);
    }

    public int getZombiesNUmber()
    {
        return zombies.Count;
    }
}
