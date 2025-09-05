namespace Zombies.Tests;

public class ZombieTests
{
    [Fact]
    public void the_room_is_empty()
    {
        var room = new ZombieRoom();
        Assert.Equal(0, room.getZombiesNUmber());
    }
}
