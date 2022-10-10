# TowerDefence
 TowerDefence2.0
 ```mermaid
 graph TD
    A[Start Game] -->|10 Sec Timer| B(Spawn Wave)
    B --> C{kill enemy}
    C -->|Enemies dead| D[You win]
    C -->|Enemies alive| E[You dead]
    
