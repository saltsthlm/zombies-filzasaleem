using System.IO.Compression;

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
        room.addZombie("zombie A");
        Assert.Equal(0, room.getZombiesNumber());
    }
    [Fact]
    public void one_roomer_becomes_full_when_a_zombie_is_added()
    {
        var room = new ZombieRoom(1);
        room.addZombie("zombie 1");
        Assert.Equal(room.capacity, room.getZombiesNumber());
    }
    [Fact]
    public void two_roomer_is_not_full_when_a_zombie_is_added()
    {
        // Arrange
        var room = new ZombieRoom(2);

        // Act
        room.addZombie("Zombie A");
        //Assert
        Assert.NotEqual(room.capacity, room.getZombiesNumber());
        Assert.True(room.getZombiesNumber() < room.capacity);
        Assert.Equal(1, room.getZombiesNumber());
        
    }

    [Fact]
    public void second_zombie_consumes_first_zombie_when_added_to_a_one_roomer()
    {
        var room = new ZombieRoom(1);
        room.addZombie("zombie A");
        room.addZombie("zombie B");
        var zombies = room.getZombies();
        Assert.DoesNotContain("zombie A", zombies);
        Assert.Contains("zombie B", zombies);
        Assert.Single(zombies);
    }
    [Fact]
    public void oldest_zombie_is_removed_when_room_capacity_is_exceeded()
    {
        // Arrange
        var room = new ZombieRoom(3);

        // Act
        room.addZombie("Zombie A");
        room.addZombie("Zombie B");
        room.addZombie("Zombie C");
        room.addZombie("Zombie D"); 

        var zombies = room.getZombies();

        // Assert
        Assert.DoesNotContain("Zombie A", zombies);  
        Assert.Contains("Zombie B", zombies);       
        Assert.Contains("Zombie C", zombies);        
        Assert.Contains("Zombie D", zombies);      
        Assert.Equal(3, zombies.Count);              
    }


}
