# Catalina Island

A 3rd-person exploration game made in Unity with only free and handmade assets. Giant mutant rabbits rule the island. The player takes the form of a lone white wolf who uncovers the truth of how the giant rabbit regime came into being. The story unfolds as the player directs the wolf towards food, health and knowledge, leading him to an ultimate choice…

<img width="863" alt="Screenshot 2023-08-29 at 17 34 44" src="https://github.com/elenabarry/Catalina_Island/assets/53048127/36f94281-3955-442c-a3d6-ce7066c66313">
## Look and Feel 

The first island is inspired by a real island, ‘Santa Catalina’, one of California’s Channel Islands, located southwest of Los Angeles. It is used by Apple as a Mac wallpaper.
The second island is inspired by another real island, ‘Ōkunoshima’, situated in the inland sea of Japan. In 1929 the army began manufacturing chemical weapons, rabbits were brought to the island and used to test the effectiveness of the poison gas in a secret test program. The island is now overrun by them. The game is based on the legend of giant mutant bunny rabbits from the test program.

## Game Objective

The player has to move the wolf through the different habitats (levels) of the island to collect artefacts. These contain elements of a riddle, which when pieced together offer two possible outcomes. The choice made by the wolf will affect all the species on the island. Whilst discovering the artefacts the wolf must stay alive and find food for the other species to survive.

The wolf has to collect food scattered across the island which is accounted for in a food bank for the other species. The more food the player can collect, the longer the species will stay alive, giving the wolf more time to discover all the artefacts.

Hidden within the island are unique books that contain clues that are nonsensical alone. Once the player has collected all the artefacts s/he must piece together the information and make the final choice for the island.


## Surviving a Rabbit Attack

The giant mutant bunny rabbits will chase and squash you if you are not careful...
Rampaging rabbits will chase and try to stomp on the wolf to prevent him reaching food and artefacts. This reduces the health of the wolf indicated by the health bar. If the health bar reaches zero, the wolf and all the other animals die on the island. The wolf can collect health hearts protected by other animals on the island to rejuvenate the wolf’s health. The wolf sometimes needs to use self-defence to knock out the rabbits (this is achieved by jumping on a weak spot between the rabbit’s ears), or to run away or use the escape portals to the next level.

## Finite State Machine

The rabbit AI will be on 'Idle' state if the player is not close enough for the rabbit to attack. If the rabbit sees the player, the rabbit will start to chase the player and jump attack until the player runs away or dies. However, if the player fights back and the rabbit is knocked out, it will go to the 'Dead' state from which it cannot return.



