# Catalina Island

A 3rd-person exploration game made in Unity with only free and handmade assets. Giant mutant rabbits rule the island. The player takes the form of a lone white wolf who uncovers the truth of how the giant rabbit regime came into being. The story unfolds as the player directs the wolf towards food, health and knowledge, leading him to an ultimate choice…

<img width="863" alt="Screenshot 2023-08-29 at 17 34 44" src="https://github.com/elenabarry/Catalina_Island/assets/53048127/36f94281-3955-442c-a3d6-ce7066c66313">

## Look and Feel 

The first island is inspired by a real island, ‘Santa Catalina’, one of California’s Channel Islands, located southwest of Los Angeles. It is used by Apple as a Mac wallpaper.
The second island is inspired by another real island, ‘Ōkunoshima’, situated in the inland sea of Japan. In 1929 the army began manufacturing chemical weapons, rabbits were brought to the island and used to test the effectiveness of the poison gas in a secret test program. The island is now overrun by them. The game is based on the legend of giant mutant bunny rabbits from the test program.

![Screenshot 2023-10-04 at 19 19 15](https://github.com/elenabarry/Catalina_Island/assets/53048127/892a79e8-56c6-4a5a-96a1-947560bfaa19)

## Game Objective

The player has to move the wolf through the different habitats (levels) of the island to collect artefacts. These contain elements of a riddle, which when pieced together offer two possible outcomes. The choice made by the wolf will affect all the species on the island. Whilst discovering the artefacts the wolf must stay alive and find food for the other species to survive.

The wolf has to collect food scattered across the island which is accounted for in a food bank for the other species. The more food the player can collect, the longer the species will stay alive, giving the wolf more time to discover all the artefacts.

Hidden within the island are unique books that contain clues that are nonsensical alone. Once the player has collected all the artefacts s/he must piece together the information and make the final choice for the island.

<img width="764" alt="Screenshot 2023-10-05 at 14 56 32" src="https://github.com/elenabarry/Catalina_Island/assets/53048127/e0049dd4-10e1-4db8-9f37-8fedae8b30c1">


## Surviving a Rabbit Attack

The giant mutant bunny rabbits will chase and squash you if you are not careful...
Rampaging rabbits will chase and try to stomp on the wolf to prevent him reaching food and artefacts. This reduces the health of the wolf indicated by the health bar. If the health bar reaches zero, the wolf and all the other animals die on the island. The wolf can collect health hearts protected by other animals on the island to rejuvenate the wolf’s health. The wolf sometimes needs to use self-defence to knock out the rabbits (this is achieved by jumping on a weak spot between the rabbit’s ears), or to run away or use the escape portals to the next level.

<img width="863" alt="Screenshot 2023-08-29 at 17 36 59" src="https://github.com/elenabarry/Catalina_Island/assets/53048127/bb547e6f-c7b5-4182-a8fc-85cbe94da603">

<img width="863" alt="Screenshot 2023-08-29 at 17 38 10" src="https://github.com/elenabarry/Catalina_Island/assets/53048127/49daa14a-f466-4bdd-8d0e-1c072bf570f8">


## Finite State Machine

The rabbit AI will be on 'Idle' state if the player is not close enough for the rabbit to attack. If the rabbit sees the player, the rabbit will start to chase the player and jump attack until the player runs away or dies. However, if the player fights back and the rabbit is knocked out, it will go to the 'Dead' state from which it cannot return.

![Screenshot 2023-10-04 at 19 23 23](https://github.com/elenabarry/Catalina_Island/assets/53048127/738e41f2-884e-4abc-8d04-f5c7045c25d8)

<img width="764" alt="Screenshot 2023-10-05 at 14 55 23" src="https://github.com/elenabarry/Catalina_Island/assets/53048127/ca19b6a4-dc30-4b2c-ab58-81c044afaff2">


## User Interface

### Main Menu

The options screen will have the choices for ‘easy’, ‘medium’ or ‘hard’ game play, where the rabbits get faster and harder to knock out with each progression. The main menu appears at the beginning and at the end of the game. It uses 'On Click' events alongside a script to activate different buttons within the menu.

<img width="861" alt="Screenshot 2023-08-29 at 17 31 49" src="https://github.com/elenabarry/Catalina_Island/assets/53048127/b07e7186-fe20-433d-8af3-c90ba89bcd31">

### Pause Menu

If the player would like to pause the game whilst playing, they can press the ‘esc’ key on the keyboard and the pause menu will appear, allowing them to pause and resume the game. They player can also select ‘MENU’ to go back to the main menu and ‘QUIT’ to exit the game.

![Screenshot 2023-10-05 at 15 05 48](https://github.com/elenabarry/Catalina_Island/assets/53048127/d359d2d6-1486-427c-b0af-7225b9c80716)

## Navigation & Player Controls

The player controls the white wolf’s movements through various habitats by using the arrow keys for direction of travel, and the space bar to jump.
Each habitat is an enclosed world in which the player’s avatar, the wolf, is free to wander in all directions and discover the environment, food and artefacts, without time limits. However, a rapidly reproducing rabbit population threatens the wolf’s ability to survive in each habitat.

![Picture 14](https://github.com/elenabarry/Catalina_Island/assets/53048127/32e12adf-6ea0-4442-919f-adcd127666cd)

## Collectables
### Point System

The vegetable bank counter is located in the top right sky area. It increases as the wolf collects the food. The food counter will also reduce at a specific rate, illustrating the effects of the animals feeding on the collected food. The player must keep the vegetable bank counter in surplus. The food is animated and glows indicating to the player that it can be collected.

<img width="166" alt="Picture 6" src="https://github.com/elenabarry/Catalina_Island/assets/53048127/ec29d3cd-f37c-46fe-b596-1fe04a1b3f4c">

### Books/ artefact collection

Hidden around the island are unique books that contain clues that are nonsensical alone. Once the player has collected all the artefacts s/he must piece together the information and make the final choice for the island.

<img width="110" alt="Picture 8" src="https://github.com/elenabarry/Catalina_Island/assets/53048127/be8c4f35-9315-44e7-90f3-e2d6aa0de91d">


### Health System

The giant rabbits attack the wolf as he progresses through the game. The health bar is located in the top left sky area indicating the damaging effects of the rabbits’ attacks. The health hearts scattered around the island, protected by friendly creatures, increase the wolf’s health and is also indicated by the health bar.

![Picture 12](https://github.com/elenabarry/Catalina_Island/assets/53048127/cb3ae072-e33c-4ef6-b576-56e59f531154)


## End Game Sequence

The game is won when the wolf discovers the source of the rabbits’ power and makes his ultimate choice which will appear using a Head Up Display. The Head Up Display is in production. The wolf needs to discover all the artefacts and piece together the riddle, which has two answers, but the answer the player chooses will determine the fate of the island’s future. The player will choose their answers by clicking on one of the multiple-choice answers. In the meantime, the player should focus on staying alive.
If the wolf is overcome by the stomping rabbits and has no health left or the food bank counter reaches zero, the wolf will die and so will all the other species. A ‘Game Over’ screen will appear.

<img width="764" alt="Screenshot 2023-10-05 at 15 02 54" src="https://github.com/elenabarry/Catalina_Island/assets/53048127/1fb32a41-dc40-4d0a-925b-9c3a2daee049">
