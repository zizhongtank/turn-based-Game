**Game Technologies Lab**\
**Jiayu Yan**\
**turn-based-Game in Unity 3D**

**Proposal**

I am a loyal fan of RPG games, and turn-based combat is an important element in most RPG games, including before. So this project is to explore how to implement turn-based competition in unity.

**Reserach**

In fact, the logic of a simple turn-based game is very simple. We can divide the state of the battle into three states

1, Our character has a health value of 0, then the game ends and the character loses.

2, The enemy character's health value is 0, then the game is over and the character wins.

3, If both of the role health values are not 0, repeat the following procedure:\
When the current operating state is AI, the enemy moves according to the AI algorithm logic\
When the current operating state is the player, perform the action according to the player's operation

**Porcess**

1. Create a plane, and then create a red cube represent the enemy and create a blue cube to represent the player.

2. Create the player script and give it to the player cube, this script should inclues three parts:Shows and hides the player's user interface, player attack moves, and player health settings.

3. Create the enemy script and give it to enemy cube, this script should inclues two parts: enemy health settings and the enemy needs to perform an operation randomly after the player finishes.

4. Create a control script and give it to an empty gameobject in order to judge the statement of the game and perform different logic according to different states. 

**Project**

Both player and enemy in the game has 100HP. After press the start the button, you can press attack or defend button on screen to do tha action(sorry I don't do the anime, the result will display in console). Any one HP is 0 then the game is over.

**citation**

https://gamedevacademy.org/how-to-create-an-rpg-game-in-unity-comprehensive-guide/\
https://forum.unity.com/threads/turn-based-rpg-combat-system-style-game.237159/

