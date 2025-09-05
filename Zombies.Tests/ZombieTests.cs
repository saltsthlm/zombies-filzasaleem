namespace Zombies.Tests;

public class ZombieTests
{
    [Fact]
    public void the_room_is_empty()
    {
        var room = new ZombieRoom(3);
        Assert.Equal(0, room.getZombiesNumber());
    }
    [Fact]
    public void the_room_has_one_zombie()
    {
        var room = new ZombieRoom(3);
        room.addZombie("first zombie");
        Assert.Equal(1, room.getZombiesNumber());
    }
    [Fact]
    public void room_with_no_capacity_cannot_fit_any_zombie()
    {
        var room = new ZombieRoom(0);
        room.addZombie("zoombie A");
        Assert.Equal(0, room.getZombiesNumber());        
    }
}
