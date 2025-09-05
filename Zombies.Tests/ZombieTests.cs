namespace Zombies.Tests;

public class ZombieTests
{
    [Fact]
    public void the_room_is_empty()
    {
        var room = new ZombieRoom();
        Assert.Equal(0, room.getZombiesNumber());
    }
    [Fact]
    public void the_room_has_one_zombie()
    {
        var room = new ZombieRoom();
        room.addZombie("first zombie");
        Assert.Equal(1, room.getZombiesNumber());
    }
}
