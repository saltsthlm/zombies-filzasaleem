using System.Dynamic;
using Microsoft.VisualBasic;

namespace Zombies;

public class ZombieRoom
{
    public int capacity { get; private set; }

    private List<string> zombies;
    public ZombieRoom(int capacity)
    {
        this.capacity = capacity;
        zombies = new List<string>();
    }


    public void addZombie(string name)
    {
        if (this.capacity > 0)
        {
            if (zombies.Count == this.capacity)
            {
                zombies.RemoveAt(0);
            }
            zombies.Add(name);
        }
    }

    public int getZombiesNumber()
    {
        return zombies.Count;
    }
    public List<string> getZombies()
    {
        return new List<string>(this.zombies);
    }
}
